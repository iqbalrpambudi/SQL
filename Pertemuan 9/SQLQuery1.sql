/*Nomer satu=======================================*/
/*procedure*/
CREATE PROCEDURE sp_cetak_nama
(@nama varchar(20))
as
BEGIN
	print 'Nama anda adalah '+ @nama
END

DECLARE @namaanda varchar(20)
set @namaanda = 'Otong'

exec sp_cetak_nama 'Paidjo'
exec sp_cetak_nama @nama ='Asasdad'
exec sp_cetak_nama @namaanda


/*Nomer dua==========================================*/
/*procedure*/
CREATE PROCEDURE sp_gan_gen
(@awal int, @akhir int)
as
DECLARE @keterangan as varchar(20)

BEGIN
	while (@awal <=@akhir)
	BEGIN
		IF (@awal %2 = 0)
			set @keterangan = 'Genap'
		ELSE
			set @keterangan = 'Ganjil'
		print 'Bilangan '+cast(@awal as varchar)+' adalah bilangan '+@keterangan
		set @awal=@awal +1
	END
END

exec sp_gan_gen 70,100

/*Nomer tiga======================================*/
/*procedure*/
CREATE PROCEDURE sp_add_supplier
(@code varchar(20), @nama varchar(20), @alamat varchar(20))
as
BEGIN
	insert into Suppliers VALUES (@code, @nama, @alamat)
END

exec sp_add_supplier 'SUP-000035', 'PixelComp','Yogyakarta'
select * from Suppliers where name='PixelComp'

/*Nomer empat====================================*/
/*procedure 1---------------------------------*/
CREATE PROCEDURE sp_XY1
(@x int, @y int)
as
BEGIN
	set @x = @x +2
	set @y = @y +2 
END
/*procedure 2-----------------------------------*/
CREATE PROCEDURE sp_XY2
(@x int OUTPUT, @y int OUTPUT)
as
BEGIN
	set @x = @x +2
	set @y = @y +2 
END

DECLARE @nilaiX int
DECLARE @nilaiY int

SET @nilaiX = 2
SET @nilaiY = 3

PRINT 'OUTPUT #1 = '+ cast(@nilaiX as varchar) + ', ' +cast(@nilaiY as varchar)
EXEC sp_XY1 @nilaiX , @nilaiY
PRINT 'OUTPUT #2 = '+ cast(@nilaiX as varchar) + ', ' +cast(@nilaiY as varchar)