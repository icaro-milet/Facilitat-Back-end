CREATE TABLE IF NOT EXISTS templates (
    id SERIAL PRIMARY KEY,
    username VARCHAR(255),
    email VARCHAR(255)
);

INSERT INTO templates (username, email) VALUES
    ('milet', 'milet@example.com'),
    ('joao', 'joao@example.com');

CREATE TABLE IF NOT EXISTS service_orders (
    id SERIAL PRIMARY KEY,
    template_id INT,
    code INT,
    description VARCHAR(255),
    FOREIGN KEY (template_id) REFERENCES templates(id),
    UNIQUE(code)
);

INSERT INTO service_orders (template_id, code, description) VALUES
    (1, 5435, 'Conserto de equipamento');

CREATE TABLE IF NOT EXISTS answers (
    id SERIAL PRIMARY KEY,
    template_id INT,
    service_order_code INT,
    username VARCHAR(255),
    email VARCHAR(255),
    FOREIGN KEY (template_id) REFERENCES templates(id),
    FOREIGN KEY (service_order_code) REFERENCES service_orders(code)
);

INSERT INTO answers (template_id, username, email) VALUES
    (1,'milet', 'milet@example.com'),
    (1,'joao', 'joao@example.com');




