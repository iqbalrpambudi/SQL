/*no 1*/
select description as category, name as product, purchasing_price, selling_price from Products join Categories on Products.category_id=Categories.category_id

/*no 2*/
select s.supplier_id, s.name as supplier, p.product_id, p.name from Products p join Suppliers s on p.supplier_id=p.supplier_id 

/*no 3*/
select distinct s.supplier_id, s.name, s.address from Suppliers s join Products p on s.supplier_id=p.supplier_id

/*no 4---------sub query*/
select c.category_id, c.description from Categories c where category_id not in(select Products.category_id from Products)

/*no 5---------join + sub query*/
select s.supplier_id,s.name,p.product_id,p.name from Products p join Suppliers s on p.supplier_id=s.supplier_id where p.product_id not in (select product_id from OrderItems)

/*no 6---------join + sub query*/
select c.customer_id, c.name, c.address, c.region_id , c.year_of_birth from Customers c where c.customer_id in (select customer_id from Orders where date ='2016-03-01')

/*no 7*/
select s.supplier_id, s.name, p.product_id, p.name 
from Products p join Suppliers s on p.supplier_id=s.supplier_id 
where product_id not in 
	(select p.product_id 
	from Products p join OrderItems oi on p.product_id=oi.product_id join Orders o on oi.order_id=o.order_id 
	where o.date='2016-03-07')

/*no 8*/
select * from Customers where customer_id=
(
select top 1 customer_id, count(*) as jml
from Orders group by customer_id
order by count(*) desc)