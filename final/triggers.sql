DROP TRIGGER  IF EXISTS user_trig;

DELIMITER $$
CREATE TRIGGER user_trig BEFORE INSERT ON users
    FOR EACH ROW
    BEGIN
        IF ((SELECT count(*) FROM users GROUP BY account_id HAVING account_id = NEW.account_id) >= 5) THEN
            SIGNAL SQLSTATE '45000';
        END IF;
    END;
$$
DELIMITER ;