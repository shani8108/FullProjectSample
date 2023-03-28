--1.Calculate Total Sales by Product Category
SELECT c.CategoryName, SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM Categories c
INNER JOIN Products p ON c.CategoryID = p.CategoryID
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY c.CategoryName;

--2. Calculate Average Order Value by Country
SELECT o.ShipCountry, AVG(od.UnitPrice * od.Quantity) AS AvgOrderValue
FROM Orders o
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.ShipCountry;

--3. Find the Most Frequent Order Quantity
SELECT od.Quantity, COUNT(*) AS Frequency
FROM [Order Details] od
GROUP BY od.Quantity
ORDER BY Frequency DESC
 

--4.Find the Most Profitable Products
--Write a query that finds the top 10 mos
SELECT p.ProductName, SUM(od.Quantity * (od.UnitPrice - od.UnitPrice * od.Discount)) AS Revenue
FROM Products p
INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY Revenue DESC

--5.Find the Average Time Between Orders
SELECT c.CustomerID, AVG(DATEDIFF(day, o1.OrderDate, o2.OrderDate)) AS AvgTimeBetweenOrders
FROM Customers c
INNER JOIN Orders o1 ON c.CustomerID = o1.CustomerID
INNER JOIN Orders o2 ON c.CustomerID = o2.CustomerID
WHERE o2.OrderDate > o1.OrderDate
GROUP BY c.CustomerID;

--6.Find the Most Common Shipping Country for Each Employee
SELECT e.EmployeeID, o.ShipCountry, COUNT(*) AS Frequency
FROM Employees e
INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID, o.ShipCountry
HAVING COUNT(*) = (
    SELECT MAX(Frequency)
    FROM (
        SELECT COUNT(*) AS Frequency
        FROM Orders
        where EmployeeID=e.EmployeeID
        GROUP BY ShipCountry
    ) AS ShippingFrequencies
)
ORDER BY e.EmployeeID;

--7 Find Customers with More Than 10 Orders
SELECT c.CustomerID, COUNT(*) AS OrderCount
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID
HAVING COUNT(*) > 10;

--8.Find Categories with Average Product Prices Greater Than $50
SELECT c.CategoryName, AVG(p.UnitPrice) AS AvgProductPrice
FROM Categories c
INNER JOIN Products p ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
HAVING AVG(p.UnitPrice) > 50;

--9.Find Employees with More Than 50 Orders and More Than 10 Customers
SELECT e.EmployeeID, COUNT(DISTINCT o.CustomerID) AS CustomerCount, COUNT(*) AS OrderCount
FROM Employees e
INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID
HAVING COUNT(*) > 50 AND COUNT(DISTINCT o.CustomerID) > 10;

