USE TestJC;

CREATE TABLE Employee (
Id INT(11) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name VARCHAR(100) NOT NULL,
Salary INT(11) NOT NULL,
DepartmentId INT(11) NOT NULL
);

INSERT INTO Employee VALUES (1, 'Candice', 4685, 1);
INSERT INTO Employee VALUES (2, 'Julia', 2559, 2);
INSERT INTO Employee VALUES (3, 'Bob', 4405, 4);
INSERT INTO Employee VALUES (4, 'Scarlet', 2350, 1);
INSERT INTO Employee VALUES (5, 'Ilena', 1150, 4);