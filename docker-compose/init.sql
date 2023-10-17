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

---

CREATE TABLE IF NOT EXISTS Users (
    Id SERIAL PRIMARY KEY,
    ServiceOrderId INT,
    Name Varchar(255),
    Email Varchar(255),
    Password Varchar(255),
    FOREIGN KEY (ServiceOrderId) REFERENCES ServiceOrders(Id)
)

------------------------------------------------------------------

-- SQL Server --

CREATE TABLE Templates (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    Description Varchar(255)
);
GO
---

CREATE TABLE Questions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TemplateId INT,
    QuestionText Varchar(255),
    FOREIGN KEY (TemplateId) REFERENCES Templates(Id)
);
GO
---

CREATE TABLE ServiceOrders (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ServiceOrderCode VARCHAR(255),
    DateCreated DATE,
    Status VARCHAR(255)
);
GO
---


CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName Varchar(255),
    LastName Varchar(255),
    Email Varchar(255),
    Document Varchar(255)
)

GO
CREATE TABLE Answers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionId INT,
    ServiceOrderId INT,
    UserId INT,
    AnswerText Varchar(255),
    FOREIGN KEY (QuestionId) REFERENCES Questions(Id),
    FOREIGN KEY (ServiceOrderId) REFERENCES ServiceOrders(Id),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);
GO
---

CREATE TABLE Appointments (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(255),
	DateStart DATE,
	DateEnd DATE,
	UserId INT,
	FOREIGN KEY (UserId) REFERENCES Users(Id)
);




