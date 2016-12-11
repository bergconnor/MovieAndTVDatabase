/* Delete the functions if they already exist */
DROP FUNCTION IF EXISTS subscription_length;
DROP FUNCTION IF EXISTS display_name;

/* Create the schema for our functions */
DELIMITER $$

CREATE FUNCTION display_name(old_name varchar(100)) RETURNS varchar(100)
    DETERMINISTIC
BEGIN
    RETURN 
    CASE 
        WHEN ((position('(T' IN old_name) = 0) AND (position('(A' IN old_name) = 0)) THEN
            old_name
        ELSE
            trim(concat(trim(')' FROM substr(old_name, position('(' IN old_name) + 1)), ' ',
                                  trim(substr(old_name, 1, position('(' IN old_name) - 1))))
    END;
END;
$$

CREATE FUNCTION subscription_length(start date) RETURNS varchar(20)
    DETERMINISTIC
BEGIN
    DECLARE days_in_a_year  int DEFAULT 365;
    DECLARE total_days      int DEFAULT 0;
    DECLARE flt             float DEFAULT 0.0;
    DECLARE years           varchar(4) DEFAULT "0000";
    DECLARE days            varchar(3) DEFAULT "000";
    DECLARE sub_length      varchar(20) DEFAULT "0 years, 0 days";

    SET total_days  = datediff(curdate(), start);
    SET years       = cast(floor(total_days/days_in_a_year) AS char(4));
    SET flt         = mod((total_days/days_in_a_year), 1);
    SET days        = cast((flt*days_in_a_year) AS char(3));
    SET sub_length  = concat(years, ' years, ', days, ' days');

    RETURN sub_length;
END;
$$

DELIMITER ;