CREATE DATABASE CalculatorDb

USE CalculatorDb

CREATE TABLE Calculations(id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
							num_one VARCHAR(100) NOT NULL, 
							operator VARCHAR(1) NOT NULL,
							num_two VARCHAR(100) NOT NULL,
							equals VARCHAR(1) NOT NULL,
							result VARCHAR(200) NOT NULL,
							datetime DATETIME NOT NULL)


SELECT * FROM Calculations