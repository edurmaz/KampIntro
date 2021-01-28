--select
select ContactName Adi,CompanyName sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'


select * from Products where CategoryID=1 or CategoryId=3

select * from Products where CategoryID=1 and UnitPrice>=10 

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Customers c left join Orders o on C.CustomerID = o.CustomerID where o.CustomerID is null