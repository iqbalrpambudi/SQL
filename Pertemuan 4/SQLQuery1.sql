/*No. 1*/
select c.description as category, p.name as product, stok, p.selling_price 
from Categories c join Products p on p.category_id=c.category_id

/*No. 2*/
select c.description as category, count(p.product_id) as amount 
from Products p join Categories c on p.category_id=c.category_id group by description

/*No. 3*/
select c.description as category, count(p.product_id) as amount 
from Products p join Categories c on p.category_id=c.category_id group by description having count(*)>5

/*No. 4*/
select s.name ,s.address, sum(p.stok)
from Products p join Suppliers s on p.supplier_id=s.supplier_id group by s.name,s.address

/*No. 5*/
select s.name ,s.address, sum(p.purchasing_price*p.stok) as total_harga
from Products p join Suppliers s on p.supplier_id=s.supplier_id group by s.name,s.address

/*No. 6*/
/*No. 7*/
select c.name, o.order_id, o.date, oi.product_id as products_id, oi.amount, oi.selling_price, sum(oi.amount*oi.selling_price) as sub_total
from Customers c join Orders o on c.customer_id=o.customer_id join OrderItems oi on o.order_id=oi.order_id
group by c.name, o.order_id, o.date, oi.product_id, oi.amount, oi.selling_price

/*No. 8*/
select c.name, o.order_id, o.date, p.name as products, oi.amount, oi.selling_price, sum(oi.amount*oi.selling_price) as sub_total
from Customers c join Orders o on c.customer_id=o.customer_id join OrderItems oi on o.order_id=oi.order_id join Products p on oi.product_id=p.product_id 
group by c.name, o.order_id, o.date, p.name, oi.amount, oi.selling_price

/*No. 9*/
select c.name, o.order_id, o.date ,ct.description, p.name as products, oi.amount, oi.selling_price, sum(oi.amount*oi.selling_price) as sub_total
from Customers c join Orders o on c.customer_id=o.customer_id join OrderItems oi on o.order_id=oi.order_id join Products p on oi.product_id=p.product_id join Categories ct on p.category_id=ct.category_id
group by c.name, o.order_id,o.date , ct.description, p.name, oi.amount, oi.selling_price

/*No. 10*/
select c.name, sum(oi.selling_price*oi.amount)
from Customers c join Orders o on c.customer_id=o.customer_id join OrderItems oi on o.order_id=oi.order_id
group by c.name






