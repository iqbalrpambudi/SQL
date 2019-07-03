
/*Nomer 1================================================================*/
create function fn_volume_balox (@panjang int, @lebar int,@tinggi int)
returns int
as
begin
return @panjang * @lebar *@tinggi
end	

declare @panjang int
declare @tinggi int
declare @lebar int
declare @volume int

set @panjang =2
set @tinggi =3;
set @lebar =4;
set @volume = dbo.fn_volume_balox(@panjang,@lebar,@tinggi)

print 'Volume Balok adalah ' + cast(@volume as varchar)

/*Nomer 2================================================================*/
create function fn_hitung_selisih (@bil1 int, @bil2 int)
returns int
as
begin
return @bil1 - @bil2
end	

declare @selisih int
set @selisih = dbo.fn_hitung_selisih(1000,452)
print 'Selisih angka adalah ' + cast(@selisih as varchar)

/*Nomer 3================================================================*/
create function fn_get_nama_hari (@tanggal datetime)
returns varchar(7)
as
begin
	declare @hari varchar(7)
	declare @nomor_hari int

	set @nomor_hari= datepart(weekday,@tanggal)
			set @hari = case @nomor_hari
			when 1 then 'Minggu'
			when 2 then 'Senin'
			when 3 then 'Selasa'
			when 4 then 'Rabu'
			when 5 then 'Kamis'
			when 6 then 'Jumat'
			else 'Sabtu'
			end;

		return @hari
end

declare @tanggal datetime
declare @hari varchar(7)

set @tanggal = '2018-06-10'
set @hari = dbo.fn_get_nama_hari(@tanggal)

print 'hari : '+@hari