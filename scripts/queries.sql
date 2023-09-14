SELECT 
	ans.template_id AS "Template Id",
	ans.service_order_code AS "Service Order Code", 
	ans.username AS "Username", 
	ans.email AS "E-mail"
FROM answers AS ans
INNER JOIN templates AS tem
ON tem.username = ans.username 
INNER JOIN service_orders AS so
ON so.code = ans.service_order_code