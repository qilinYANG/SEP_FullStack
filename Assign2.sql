-- 1.      How many products can you find in the Production.Product table?
SELECT COUNT(ProductID)
FROM Production.Product
-- 2.      Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(*)
FROM Production.Product
where ProductSubcategoryID is not NULL
-- 3.      How many Products reside in each SubCategory? Write a query to display the results with the following titles.

SELECT ProductSubcategoryID, count(*) as CountedProducts
from Production.Product
WHERE ProductSubcategoryID is not NULL
GROUP BY ProductSubcategoryID
-- ProductSubcategoryID CountedProducts

-- -------------------- ---------------

-- 4.      How many products that do not have a product subcategory.

SELECT COUNT(*)
FROM Production.Product
where ProductSubcategoryID is NULL
-- 5.      Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity)
from Production.ProductInventory
-- 6.    Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

--               ProductID    TheSum

--               -----------        ----------
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP by ProductID
HAVING SUM(Quantity) < 100

-- 7.    Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

--     Shelf      ProductID    TheSum

--     ----------   -----------        -----------

SELECT Shelf,ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP by Shelf,ProductID
HAVING SUM(Quantity) < 100

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.

SELECT AVG(Quantity)
FROM Production.ProductInventory
WHERE LocationID = 10
-- 9.    Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

--     ProductID   Shelf      TheAvg

--     ----------- ---------- -----------


SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP by ProductID,Shelf

-- 10.  Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

--     ProductID   Shelf      TheAvg

--     ----------- ---------- -----------

SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP by ProductID,Shelf
-- 11.  List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

--     Color                        Class              TheCount          AvgPrice

--     -------------- - -----    -----------            ---------------------

SELECT Color, Class, SUM(1) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color is not NULL AND Class is not NULL
GROUP BY Color, Class



-- Joins:

-- 12.   Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

--     Country                        Province

--     ---------                          ----------------------

SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion AS cr JOIN Person.StateProvince AS sp ON cr.CountryRegionCode = sp.CountryRegionCode

-- 13.  Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

 

SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion AS cr JOIN Person.StateProvince AS sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name in ('Germany','Canada')

--     Country                        Province

--     ---------                          ----------------------
USE Northwind
GO
--  Using Northwnd Database: (Use aliases for all the Joins)

-- 14.  List all Products that has been sold at least once in last 25 years.

SELECT pro.ProductName,orders.OrderDate
FROM Products AS pro Join [Order Details] AS od on pro.ProductID = od.ProductID JOIN Orders ON od.OrderID = Orders.OrderID
WHERE Orders.OrderDate > DATEADD(YEAR,-25,GETDATE())

-- 15.  List top 5 locations (Zip Code) where the products sold most.

SELECT TOP 5 Orders.ShipPostalCode AS ZipCode,SUM(od.Quantity) AS SoldQuantity
FROM Products AS pro Join [Order Details] AS od on pro.ProductID = od.ProductID JOIN Orders ON od.OrderID = Orders.OrderID
GROUP BY Orders.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

-- 16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.

SELECT TOP 5 Orders.ShipPostalCode AS ZipCode,SUM(od.Quantity) AS SoldQuantity
FROM Products AS pro Join [Order Details] AS od on pro.ProductID = od.ProductID JOIN Orders ON od.OrderID = Orders.OrderID
WHERE Orders.OrderDate > DATEADD(YEAR,-25,GETDATE())
GROUP BY Orders.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

-- 17.   List all city names and number of customers in that city.     
SELECT City,COUNT(CustomerID)
From Customers
GROUP by City



-- 18.  List city names which have more than 2 customers, and number of customers in that city

SELECT City,COUNT(CustomerID) AS numCus
From Customers
GROUP by City
HAVING COUNT(CustomerID) >= 2
-- 19.  List the names of customers who placed orders after 1/1/98 with order date.

SELECT cus.ContactName, Orders.OrderDate
from Orders JOIN Customers AS cus ON orders.CustomerID = cus.CustomerID
WHERE Orders.OrderDate > '1998-1-1'

-- 20.  List the names of all customers with most recent order dates
SELECT dt.ContactName,dt.OrderDate
from (SELECT cus.ContactName, Orders.OrderDate,RANK() OVER (PARTITION BY cus.ContactName ORDER BY  Orders.OrderDate DESC) RNK
from Orders JOIN Customers AS cus ON orders.CustomerID = cus.CustomerID) AS dt
WHERE RNK = 1

-- 21.  Display the names of all customers  along with the  count of products they bought

SELECT cus.ContactName, SUM(od.Quantity) AS Count
from Orders JOIN Customers AS cus ON orders.CustomerID = cus.CustomerID JOIN [Order Details] AS od on od.OrderID = Orders.OrderID
GROUP BY cus.ContactName
-- 22.  Display the customer ids who bought more than 100 Products with count of products.
SELECT Orders.CustomerID
from Orders JOIN Customers AS cus ON orders.CustomerID = cus.CustomerID JOIN [Order Details] AS od on od.OrderID = Orders.OrderID
GROUP BY Orders.CustomerID
HAVING SUM(od.Quantity) > 100
-- 23.  List all of the possible ways that suppliers can ship their products. Display the results as below

--     Supplier Company Name                Shipping Company Name

--     ---------------------------------            ----------------------------------

SELECT Suppliers.CompanyName, Shippers.CompanyName
FROM 
(SELECT Products.SupplierID, Orders.ShipVia AS ShipperID
FROM [Order Details] AS od JOIN Products ON od.ProductID = Products.ProductID JOIN Orders ON Orders.OrderID = od.OrderID) AS dt
JOIN Suppliers on dt.SupplierID = Suppliers.SupplierID JOIN Shippers ON Shippers.ShipperID = dt.ShipperID
-- 24.  Display the products order each day. Show Order date and Product Name.


SELECT Orders.OrderDate,Products.ProductName
FROM [Order Details] AS od JOIN Products ON od.ProductID = Products.ProductID JOIN Orders ON Orders.OrderID = od.OrderID
ORDER BY Orders.OrderDate

-- 25.  Displays pairs of employees who have the same job title.

SELECT Title,COUNT(*) AS Pairs
FROM Employees
GROUP BY Title


-- 26.  Display all the Managers who have more than 2 employees reporting to them.

-- 27.  Display the customers and suppliers by city. The results should have the following columns

-- City

-- Name

-- Contact Name,

-- Type (Customer or Supplier)