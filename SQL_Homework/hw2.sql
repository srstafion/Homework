CREATE TABLE Departments (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Financing MONEY NOT NULL CHECK (Financing >= 0) DEFAULT 0,
    Name NVARCHAR(100) NOT NULL UNIQUE CHECK (Name <> '')
);

CREATE TABLE Faculties (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Dean NVARCHAR(MAX) NOT NULL CHECK (Dean <> ''),
    Name NVARCHAR(100) NOT NULL UNIQUE CHECK (Name <> '')
);

CREATE TABLE Groups (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(10) NOT NULL UNIQUE CHECK (Name <> ''),
    Rating INT NOT NULL CHECK (Rating BETWEEN 0 AND 5),
    Year INT NOT NULL CHECK (Year BETWEEN 1 AND 5)
);

CREATE TABLE Teachers (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    EmploymentDate DATE NOT NULL CHECK (EmploymentDate >= '1990-01-01'),
    IsAssistant BIT NOT NULL DEFAULT 0,
    IsProfessor BIT NOT NULL DEFAULT 0,
    Name NVARCHAR(MAX) NOT NULL CHECK (Name <> ''),
    Position NVARCHAR(MAX) NOT NULL CHECK (Position <> ''),
    Premium MONEY NOT NULL CHECK (Premium >= 0) DEFAULT 0,
    Salary MONEY NOT NULL CHECK (Salary > 0),
    Surname NVARCHAR(MAX) NOT NULL CHECK (Surname <> '')
);

INSERT INTO Departments (Financing, Name) 
VALUES (12000, 'Computer Science'), (8000, 'Mathematics'), (30000, 'Physics'), (25000, 'Software Development');

INSERT INTO Faculties (Dean, Name) 
VALUES ('John Doe', 'Engineering'), ('Jane Smith', 'Humanities'), ('Robert Brown', 'Science'), ('Alice Green', 'Computer Science');

INSERT INTO Groups (Name, Rating, Year) 
VALUES ('CS101', 3, 5), ('MATH202', 4, 3), ('PHY303', 2, 4), ('CS404', 5, 5);

INSERT INTO Teachers (EmploymentDate, IsAssistant, IsProfessor, Name, Position, Premium, Salary, Surname) 
VALUES ('2005-09-01', 0, 1, 'Alice', 'Professor', 300, 1200, 'Johnson'), ('2010-03-15', 1, 0, 'Bob', 'Assistant', 200, 1000, 'Smith'), 
('1995-07-20', 0, 1, 'Charlie', 'Professor', 500, 1500, 'Williams'), ('2018-11-11', 1, 0, 'David', 'Assistant', 150, 800, 'Brown'),
('2000-01-01', 0, 0, 'Eva', 'Lecturer', 100, 950, 'Davis');

SELECT Name, Financing, Id FROM Departments;

SELECT Name AS [Group Name], Rating AS [Group Rating] FROM Groups;

SELECT Surname, (Salary / Premium) * 100 AS [Salary to Premium %], (Salary / (Salary + Premium)) * 100 AS [Salary to Total %] FROM Teachers;

SELECT 'The dean of faculty ' + Name + ' is ' + Dean + '.' AS FacultyInfo FROM Faculties;

SELECT Surname FROM Teachers WHERE IsProfessor = 1 AND Salary > 1050;

SELECT Name FROM Departments WHERE Financing < 11000 OR Financing > 25000;

SELECT Name FROM Faculties WHERE Name <> 'Computer Science';

SELECT Surname, Position FROM Teachers WHERE IsProfessor = 0;

SELECT Surname, Position, Salary, Premium FROM Teachers WHERE IsAssistant = 1 AND Premium BETWEEN 160 AND 550;

SELECT Surname, Salary FROM Teachers WHERE IsAssistant = 1;

SELECT Surname, Position FROM Teachers WHERE EmploymentDate < '2000-01-01';

SELECT Name AS [Name of Department] FROM Departments WHERE Name < 'Software Development' ORDER BY Name;

SELECT Surname FROM Teachers WHERE IsAssistant = 1 AND (Salary + Premium) <= 1200;

SELECT Name FROM Groups WHERE Year = 5 AND Rating BETWEEN 2 AND 4;

SELECT Surname FROM Teachers WHERE IsAssistant = 1 AND (Salary < 550 OR Premium < 200);