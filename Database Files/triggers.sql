/* Delete the triggers if they already exist */
DROP TRIGGER IF EXISTS user_trig;
DROP TRIGGER IF EXISTS title_trig;

/* Create the schema for our triggers */
DELIMITER $$

CREATE TRIGGER user_trig BEFORE INSERT ON users
    FOR EACH ROW
    BEGIN
        IF ((SELECT count(*) FROM users GROUP BY account_id HAVING account_id = NEW.account_id) >= 5) THEN
            SIGNAL SQLSTATE '45000';
        END IF;
    END;
$$

CREATE TRIGGER display_name BEFORE INSERT ON shows
    FOR EACH ROW
    BEGIN
        IF (strcmp(substring_index(NEW.name, ' ', 1), 'The') = 0) THEN
            SET NEW.name = trim(concat(substring(NEW.name, locate(' ', NEW.name)), ' (The)'));
        ELSEIF (strcmp(substring_index(NEW.name, ' ', 1), 'A') = 0) THEN
            SET NEW.name = trim(concat(substring(NEW.name, locate(' ', NEW.name)), ' (A)'));
        END IF;
    END;
$$

DELIMITER ;