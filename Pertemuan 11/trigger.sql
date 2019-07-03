/*No 2==============================*/
create trigger tg_add_product 
on Products 
for Insert
as declare @namabarang varchar(20)
begin
	select @namabarang = name from inserted
	print 'Product '+@namabarang+' berhasil ditambahkan' 
end

insert into products (product_id, name, stok, purchasing_price,
selling_price, category_id, supplier_id)
values ('CG-006-IT000040', 'Sport Bottle 900ml', 15, 75000, 780000, 'CG-006',
'SUP-000017')/*No 2==============================*/create trigger tg_delete_product 
on Products 
for Delete
as declare @namabarang varchar(20)
begin
	select @namabarang = name from deleted
	print 'Product '+@namabarang+' berhasil dihapus' 
enddelete from products where product_id = 'CG-006-IT000040'/*No 3==============================*/create trigger tg_kurangi_stok
on Orderitems 
for insert
as 
declare @amount int
begin
	select @amount = amount from inserted
	update Products set stok = stok - @amount
end

select * from Products
select * from OrderItems

insert into orderitems (order_id, product_id, amount, purchasing_price,
selling_price)
values ('20160305-00001', 'CG-001-IT000002', 9, 160000, 165000)

delete from OrderItems where order_id = '20160305-00001'

/*No 3==============================*/
create trigger tg_update_stok
on Orderitems 
for update
as 
declare @amount int
declare @newamount int
declare @id varchar(20)
begin
	select @newamount = amount from inserted
	select @id = order_id from inserted
	select @amount = amount from OrderItems where order_id=@id
	update Products set stok = stok + @amount
	update Products set stok = stok - @newamount
end

select * from Products
select * from OrderItems

update orderitems set amount = 15
where order_id = '20160305-00001' AND product_id = 'CG-001-IT000002'