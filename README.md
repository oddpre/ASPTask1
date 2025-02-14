# WindowsFormAPPTask1
Change the datasource in line 47 of Form1.cs to whatever works for you. (both device, and sql server connection/database name etc.)


SQL Queries








CREATE DATABASE Students_Oddi;

CREATE TABLE Studlogin (
    StudID INT,
    FullName VARCHAR(50),
    IsActive BIT
);




--The Data.
INSERT INTO Studlogin (StudID, FullName, IsActive)
VALUES ( 1, 'Arvid', 1),
(2, 'Diana', 1),
(3, 'Maina', 1),
(4, 'Even', 0),
(5, 'Stian F', 0),
(6, 'Stian K', 1),
(7, 'Stian S', 1),
(8, 'Ingvild', 1),
(9, 'Viktoriia', 1),
(10, 'Ean', 1),
(11, 'Odd', 1),
(12, 'Harisha', 1),
(13, 'Håkon', 1),
(14, 'Karl', 0), 
(15, 'Joe', 1);

