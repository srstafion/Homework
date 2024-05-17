DROP TABLE Groups
CREATE TABLE Groups (
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name NVARCHAR(10)  NOT NULL,
	Rating INT CHECK(Rating >= 0 AND Rating <= 5) NOT NULL,
	Year INT CHECK(Year >= 1 AND Year <= 5)  NOT NULL
);

INSERT INTO Groups (Name, Rating, Year) 
VALUES ('GP1', 1, 2), ('GP2', 3, 4)
 
SELECT * FROM Groups



DROP TABLE Departments
CREATE TABLE Departments (
  Id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
  Financing  MONEY CHECK(Financing >= 0) NOT NULL DEFAULT 0,
  Name NVARCHAR(100) NOT NULL
);
 
INSERT INTO Departments (Name, Financing) 
VALUES ('Music', 1000), ('Art', 6000);
 
SELECT * FROM Departments;



DROP TABLE Faculties
CREATE TABLE Faculties (
	Id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Name NVARCHAR(100) NOT NULL
);

INSERT INTO Faculties (Name) 
VALUES ('History of Music'), ('History of Art');
 
SELECT * FROM Faculties;



DROP TABLE Teachers
CREATE TABLE Teachers (
  Id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
  EmploymentDate DATE CHECK(EmploymentDate > '1990-01-01') NOT NULL,
  Name NVARCHAR(max) NOT NULL,
  Premium MONEY CHECK(Premium >= 0) NOT NULL DEFAULT 0,
  Salary MONEY CHECK(Salary > 0) NOT NULL,
  Surname NVARCHAR(100) NOT NULL,
);
 
INSERT INTO Teachers (EmploymentDate, Name, Salary, Surname) 
VALUES ('2000-11-07', 'Taylor', 3600, 'Swift');
 
SELECT * FROM Teachers;