/* Delete the functions if they already exist */
DROP FUNCTION IF EXISTS subscription_length;
DROP FUNCTION IF EXISTS sanitize_search;
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

CREATE FUNCTION sanitize_search(old_search varchar(100)) RETURNS varchar(100)
    DETERMINISTIC
BEGIN
    IF (strcmp(substring_index(old_search, ' ', 1), 'the') = 0) OR
       (strcmp(substring_index(old_search, ' ', 1), 'a') = 0) THEN
            SET old_search = substring(old_search, LOCATE(' ' ,old_search)+1);
    END IF;
    RETURN concat('%', old_search, '%');
END;
$$

CREATE FUNCTION subscription_length(start date) RETURNS varchar(24)
    DETERMINISTIC
BEGIN
    DECLARE days_in_a_year  int DEFAULT 365;
    DECLARE total_days      int DEFAULT 0;
    DECLARE flt             float DEFAULT 0.0;
    DECLARE years           varchar(4) DEFAULT "0000";
    DECLARE days            varchar(3) DEFAULT "000";
    DECLARE sub_length      varchar(24) DEFAULT "0 years, 0 days";

    SET total_days  = datediff(curdate(), start);
    SET years       = cast(floor(total_days/days_in_a_year) AS char(4));
    SET flt         = mod((total_days/days_in_a_year), 1);
    SET total_days  = (flt*days_in_a_year);
    SET days        = cast(total_days AS char(3));
    SET sub_length  = concat(years, ' year(s), ', days, ' day(s)');

    RETURN sub_length;
END;
$$

DELIMITER ;