/* Delete the functions if they already exist */
DROP FUNCTION IF EXISTS display_name;

/* Create the schema for our functions */
DELIMITER $$

CREATE FUNCTION display_name(old_name varchar(100))
RETURNS varchar(100)
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

DELIMITER ;