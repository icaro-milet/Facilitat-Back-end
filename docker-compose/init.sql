CREATE TABLE IF NOT EXISTS templates (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255)
);

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

---

CREATE TABLE IF NOT EXISTS service_orders (
    id SERIAL PRIMARY KEY,
    service_order_name VARCHAR(255),
    description VARCHAR(255)
);

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

---


