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

---

INSERT INTO service_orders (template_id, code, description) VALUES
    (1, 5432, 'Garantia de máquina'),
    (1, 5433, 'Garantia de eletrônico'),
	(1, 5434, 'Garantia de celular');
----

SELECT so.*
FROM service_orders so
INNER JOIN templates tem
ON so.template_id = tem.id
WHERE so.template_id = 3

----

SELECT * 
FROM answers ans
INNER JOIN templates tem
ON ans.template_id = tem.id
INNER JOIN service_orders so
ON ans.service_order_code = so.code

----