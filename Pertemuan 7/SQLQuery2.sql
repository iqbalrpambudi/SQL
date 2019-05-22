/*------nomer 1------*/
declare @nama varchar(25)
declare @gaji int

set @nama = 'Paijo'
set @gaji = 100000

print 'Nama =' + @nama + ', Gaji =' +cast(@gaji as varchar)

/*------nomer 2------*/
declare @bil int
declare @gg varchar(6)

set @bil = 1

while @bil<=10
begin
	if @bil%2=0
	begin
		set @gg ='Genap'
	end
	else
	begin
		set @gg = 'Ganjil'
	end
	print 'Bilangan ' +cast(@bil as varchar)+ ' adalah bilangan '+@gg
	set @bil = @bil+1
end

/*------nomer 3------*/
declare @bil int

set @bil = 1

while @bil<=10
begin
	if @bil= 5 or @bil = 8 or @bil = 9
	begin
		set @bil = @bil+1
		if @bil= 5 or @bil = 8 or @bil = 9
		begin
			set @bil = @bil +1
		end
	end
	print 'Bilangan ' +cast(@bil as varchar)
	set @bil = @bil+1
end

/*------nomer 4------*/

/*------nomer 5------*/
declare @hoodie_nike int
declare @hoodie_zipper int
declare @result int

set @hoodie_nike = (select selling_price from Products where product_id='CG-002-IT000015')
set @hoodie_zipper = (select selling_price from Products where product_id='CG-002-IT000016')

set @result = @hoodie_nike-@hoodie_zipper

print 'Hoodie 1 Rp.'+cast(@hoodie_nike as varchar)
print 'Hoodie 2 Rp.'+cast(@hoodie_zipper as varchar)
print 'Selisih Harga jual Hoodie 1 dan 2= '+cast(@result as varchar)

/*------nomer 6------*/
