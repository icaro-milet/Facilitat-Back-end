CREATE TABLE IF NOT EXISTS templates (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255)
);

-- INSERT INTO templates (name) VALUES
--     ('Cadastro de serviço');

---

CREATE TABLE IF NOT EXISTS questions (
    id SERIAL PRIMARY KEY,
    template_id INT,
    question_one_id SERIAL UNIQUE,
    question_one VARCHAR(255),
    question_two_id SERIAL UNIQUE,
    question_two VARCHAR(255),
    FOREIGN KEY (template_id) REFERENCES templates(id)
);

-- INSERT INTO questions 
-- (
--     template_id, 
--     question_one_id, 
--     question_one, 
--     question_two_id, 
--     question_two
-- ) 
-- VALUES
-- (
--     1, 
--     1, 
--     'Qual o seu nome?',
--     1,
--     'Qual o seu e-mail?'
-- );

---

CREATE TABLE IF NOT EXISTS service_orders (
    id SERIAL PRIMARY KEY,
    template_id INT,
    code INT UNIQUE,
    description VARCHAR(255),
    FOREIGN KEY (template_id) REFERENCES templates(id)
);

INSERT INTO service_orders (template_id, code, description) VALUES
    (1, 5435, 'Conserto de equipamento');

---

CREATE TABLE IF NOT EXISTS answers (
    id SERIAL PRIMARY KEY,
    template_id INT,
    service_order_id INT,
    question_one_id INT,
    answer_one VARCHAR(255),
    question_two_id INT,
    answer_two VARCHAR(255),
    FOREIGN KEY (template_id) REFERENCES templates(id),
    FOREIGN KEY (service_order_id) REFERENCES service_orders(id),
    FOREIGN KEY (question_one_id) REFERENCES questions(question_one_id),
    FOREIGN KEY (question_two_id) REFERENCES questions(question_two_id)
);

-- INSERT INTO answers 
-- (
--     template_id, 
--     service_order_id,
--     question_one_id,
--     answer_one,
--     question_two_id,
--     answer_two
-- ) 
-- VALUES
-- (
--     1,
--     1, 
--     1,
--     'Icaro',
--     1,
--     'icaro@example.com'
-- )

---


