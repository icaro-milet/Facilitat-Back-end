CREATE TABLE IF NOT EXISTS Templates (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255),
    Description Varchar(255)
);

---

CREATE TABLE IF NOT EXISTS Questions (
    Id SERIAL PRIMARY KEY,
    TemplateId INT,
    QuestionText Varchar(255),
    FOREIGN KEY (TemplateId) REFERENCES Templates(Id)
);

---

CREATE TABLE IF NOT EXISTS ServiceOrders (
    Id SERIAL PRIMARY KEY,
    ServiceOrderCode VARCHAR(255),
    DateCreated DATE,
    Status VARCHAR(255)
);

---

CREATE TABLE IF NOT EXISTS Answers (
    Id SERIAL PRIMARY KEY,
    QuestionId INT,
    ServiceOrderId INT,
    AnswerText Varchar(255),
    FOREIGN KEY (QuestionId) REFERENCES Questions(Id),
    FOREIGN KEY (ServiceOrderId) REFERENCES ServiceOrders(Id)
);


