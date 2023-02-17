-- All scenarios are based on Database NORTHWND.

-- 1.      List all cities that have both Employees and Customers.

SELECT Distinct  City
From Employees
INTERSECT
SELECT Distinct City
From Customers

-- 2.      List all cities that have Customers but no Employee.

-- a.      Use sub-query

SELECT Distinct City
FROM Customers
where City NOT IN (SELECT Distinct  City
From Employees)

-- b.      Do not use sub-query

SELECT Distinct  City
From Customers
EXCEPT
SELECT Distinct City
From Employees


-- 3.      List all products and their total order quantities throughout all orders.

SELECT p.ProductName,SUM(od.Quantity) AS TolQuan
From Products AS p JOIN [Order Details] AS od on p.ProductID = od.ProductID JOIN Orders AS ord ON ord.OrderID = od.OrderID
GROUP BY p.ProductName
ORDER by SUM(od.Quantity) DESC

-- 4.      List all Customer Cities and total products ordered by that city.

SELECT cus.City,COUNT(od.Quantity) AS TotalProduct
From Customers AS cus JOIN Orders on cus.CustomerID = Orders.CustomerID JOIN [Order Details] AS od ON Orders.OrderID = od.OrderID
GROUP BY cus.City

-- 5.      List all Customer Cities that have at least two customers.

SELECT City, COUNT(*)
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

-- a.      Use union


-- b.      Use sub-query and no union

select City
from (SELECT City, COUNT(*) AS NumCustomer
FROM Customers
GROUP BY City) AS dt
where dt.NumCustomer >= 2

-- 6.      List all Customer Cities that have ordered at least two different kinds of products.

SELECT cus.City,COUNT(*) AS TotalProduct
From Customers AS cus JOIN Orders on cus.CustomerID = Orders.CustomerID JOIN [Order Details] AS od ON Orders.OrderID = od.OrderID
GROUP BY cus.City
HAVING COUNT(*) >= 2

-- 7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.

SELECT cus.ContactName,cus.City,Orders.ShipCity
FROM Customers AS cus JOIN Orders ON cus.CustomerID = orders.CustomerID
WHERE cus.City != Orders.ShipCity

-- 8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

-- I have 2 Confusions. 
-- 1. What is most popular product? By quantity or times of order? 
-- 2. Are we gone to figure out average price for 5 products in a separate output or each product(Make No Sense since each product unit price is the same)

-- 9.      List all cities that have never ordered something but we have employees there.


-- a.      Use sub-query
SELECT Distinct City
FROM Employees
WHERE City NOT IN (SELECT Distinct Customers.City
FROM Customers JOIN Orders ON Orders.CustomerID = Orders.CustomerID)

-- b.      Do not use sub-query

SELECT Distinct City
FROM Employees
EXCEPT
SELECT Distinct Customers.City
FROM Customers JOIN Orders ON Orders.CustomerID = Orders.CustomerID

-- 10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

SELECT DT1.City
FROM
(SELECT TOP 1 Employees.City
from Orders JOIN Employees ON orders.EmployeeID = Employees.EmployeeID
GROUP BY Employees.City
ORDER by COUNT(*) DESC) dt1 JOIN

(SELECT  TOP 1 Employees.City
from Orders JOIN Employees ON orders.EmployeeID = Employees.EmployeeID JOIN [Order Details] AS od ON od.OrderID = Orders.OrderID
GROUP BY Employees.City
ORDER by SUM(od.Quantity) DESC)  dt2 ON dt1.City = dt2.City



-- 11. How do you remove the duplicates record of a table?

-- Find duplicate rows using GROUP BY clause or ROW_NUMBER() function.
-- Use DELETE statement to remove the duplicate rows.