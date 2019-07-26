CREATE DATABASE StudentMS

USE StudentMS

CREATE TABLE Students(
Sl int identity(1,1),
ID int,
Name varchar(50),
Roll varchar(50),
Contact int,
Email varchar(30),
)


INSERT INTO Students VALUES(10000256, 'Jahid','1001',01720346187,'ja@gmail.com')


SELECT * FROM Students

SELECT * FROM Students WHERE Roll='12345678'

DELETE FROM Students WHERE Sl=3

UPDATE Students SET Name='Tarif' 
WHERE ID =254254




--DROP TABLE Students