USE TestJC;

CREATE TABLE Department (
Id INT(11) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name VARCHAR(100) NOT NULL,
Location VARCHAR(100) NOT NULL
);

INSERT INTO Department VALUES (1, 'Executive', 'Sydney');
INSERT INTO Department VALUES (2, 'Production', 'Sydnay');
INSERT INTO Department VALUES (3, 'Resources', 'Cape Town');
INSERT INTO Department VALUES (4, 'Thecnical', 'Texas');
INSERT INTO Department VALUES (5, 'Managment', 'Paris');
