﻿--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where  City = 'Berlin'

--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products where categoryId = 1 order by UnitPrice desc --ascending = artan descending = azalan

Select count(*) Adet from Products where CategoryID = 2
 
Select categoryId,count(*) from products where UnitPrice>20 group by CategoryID having count(*) <10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

Select * 
from Products p inner join [Order Details] od
on p.ProductID =od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null