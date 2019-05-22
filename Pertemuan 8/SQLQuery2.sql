/*------nomer 1------*/
declare @kota varchar(25)
declare @jumlah int

declare cursor_kota cursor for
select address, count(*) from Suppliers group by address

open cursor_kota
fetch next from cursor_kota into @kota, @jumlah
while (@@FETCH_STATUS = 0)
begin
	print 'Kota= ' + @kota + ', Jumlah = ' + cast(@jumlah as varchar)
	fetch next from cursor_kota into @kota, @jumlah
end
close cursor_kota
deallocate cursor_kota

/*------nomer 2------*/
declare @product varchar(50)
declare @hargajual int
declare @total int

declare cursor_ cursor for
select name, selling_price from Products where selling_price > 1000000 group by name, selling_price

fetch next from cursor_ into @product, @hargajual
while (@@FETCH_STATUS = 0)
begin
	print 'Product= ' + @product + ', Harga Jual = ' + cast(@hargajual as varchar)
	fetch next from cursor_ into @product, @hargajual
end
close cursor_
deallocate cursor_

/*------nomer 3------*/
declare @product varchar(50)
declare @hargajual int
declare @total int

declare cursor_ cursor for
select name, selling_price from Products where selling_price > 1000000 group by name, selling_price

set @total = (select sum(selling_price) from Products where selling_price > 1000000)

open cursor_
fetch next from cursor_ into @product, @hargajual
while (@@FETCH_STATUS = 0)
begin
	print 'Product= ' + @product + ', Harga Jual = ' + cast(@hargajual as varchar)
	fetch next from cursor_ into @product, @hargajual
end
close cursor_
deallocate cursor_
print'============================================================='
print 'Total harga jual = '+ cast(@total as varchar)

/*------nomer 4------*/


declare @product varchar(50)
declare @jumlah int
declare @i int

declare cursor_ cursor for
select c.description, count(p.category_id) from Categories c join Products p on c.category_id=p.category_id group by c.description

set @i=1

open cursor_
fetch next from cursor_ into @product, @jumlah
while (@@FETCH_STATUS = 0)
begin
	print cast(@i as varchar)+'. ' + @product
	print '---> Jumlah Product : '+cast(@jumlah as varchar)
	set @i+=1
	fetch next from cursor_ into @product, @jumlah
end
close cursor_
deallocate cursor_

/*nomer 5*/
declare @nama
declare @trx
declare @i int

declare cursor_ cursor for
select c.name, count(o.customer_id) from Customers c join Orders o  on c.customer_id=o.customer_id group by c.name
set @i=1

open cursor_
fetch next from cursor_ into @name, @trx
while (@@FETCH_STATUS = 0)
begin
	print cast(@i as varchar)+'. ' + @name
	print '---> Jumlah transaksi : '+cast(@jumlah as varchar)
	set @i+=1
	fetch next from cursor_ into @product, @jumlah
end
close cursor_
deallocate cursor_

