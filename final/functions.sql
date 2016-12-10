DELIMITER $$
CREATE FUNCTION get_subscription_remainder(date start, date end)
RETURNS int
declare restdays interval
begin
	restdays := enddate - startdate;
	return restdays; 

end;
$$ Language plpgsql;