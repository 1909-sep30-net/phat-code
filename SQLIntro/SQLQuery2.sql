--Basic of SQL
--DML 
SELECT 1; --give me number 1
SELECT 1;

SELECT 2+3; -- 5
SELECT  'str1' + ' '+ CONVERT(varchar,2 +3);
--single quotes fro string literal
--the semicolons are not required 
SELECT * FROM employee; --* means every columns
--fetching only some of the columns
--exp the name of all employees
SELECT FirstName, LastName FROM Employee;
--fetching only some of the rows
SELECT * FROM Employee
WHERE LEN(FirstName) <= 5;

SELECT * FROM  Employee
WHERE FirstName = 'Steve' AND LastName = 'johnson';

--in SQL, often, string comparison is case-insensitive. This is based on "collation"
--the collation is a per-database setting determining the rules for string comparision,
-- standard date/time format, number format, currencry format, VACHAR (non-Unicode) string encoding

--get full name of each employee
--with column aliases, if they have spaces, surround with [] or "" ("" is for identified)
SELECT FirstName+ ' ' +LastName AS [Full Name], LEN(FirstName+ ' ' +LastName) AS [Length]
FROM Employee;

--Exercises--
--1
SELECT FirstName +' ' + LastName AS "Full Name",
CustomerId, Country
FROM Customer
WHERE Country <> 'USA'
--2.
SELECT * FROM Customer
WHERE Country = 'Brazil';
--3. 
SELECT * FROM Employee
WHERE Title = 'Sales Support Agent';
--4.
SELECT DISTINCT BillingCountry FROM Invoice;
--5
SELECT COUNT(*) AS [Number Invoices], SUM(Total) AS [Total] FROM Invoice
WHERE YEAR(InvoiceDate) = 2009;
--6
SELECT COUNT (*) AS [Number Items] FROM InvoiceLine
WHERE InvoiceId = 37;
--7
SELECT DISTINCT BillingCountry, COUNT(*) [Number Invoices] FROM Invoice
GROUP BY BillingCountry;
--8
SELECT DISTINCT BillingCountry, SUM(Total) AS [Total] FROM Invoice
GROUP BY BillingCountry
ORDER BY [Total] DESC;