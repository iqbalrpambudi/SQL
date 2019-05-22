/*-----------no.1----------*/
select name as product, stok from Products where stok >=100

/*-----------no.2----------*/
select name as product, stok from Products where category_id=(select category_id from Categories where description='Health')

/*-----------no.3----------*/
select product_id,name as product,purchasing_price from Products where purchasing_price BETWEEN 200000 AND 500000

/*-----------no.4----------*/
select customer_id, name from Customers where name in (select name from  Customers where name like '%B%' or name like '%K%')

/*-----------no.5----------*/
select category_id, description from Categories where category_id not in (select product_id from OrderItems)

/*-----------no.6----------*/
select product_id, name as product from Products where Products.product_id not in (select product_id from OrderItems)

/*-----------no.7----------*/
select product_id, name as product,stok from Products where Products.stok<25 and Products.product_id in (select product_id from OrderItems)

/*-----------no.8----------*/
select name, amount from Products join OrderItems on Products.product_id=OrderItems.product_id order by amount desc

/*-----------no.9----------*/