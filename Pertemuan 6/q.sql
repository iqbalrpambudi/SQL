/*----nomer 1-------*/
update Customers set name='Bagus Aliando' where customer_id='CUS-000001'

select * from Customers

begin transaction 
update Customers set name='Paidjo' where customer_id='CUS-000009'
rollback transaction


-- deklarasi variabel
declare @insert_err int
declare @delete_err int
begin transaction
-- tambah customer baru
insert into Customers (customer_id, name, address)
values ('CUS-000016', 'Jhono', 'Yogyakarta')
-- simpan err number hasil dari perintah insert
set @insert_err = @@error
-- hapus customer
delete from customers where customer_id = 'CUS-000005'
-- simpan err number hasil dari perintah delete
set @delete_err = @@error
if @insert_err = 0 and @delete_err = 0 -- tidak ada error
begin
print 'transaksi berhasil'
commit transaction
end
else
begin
print 'transaksi gagal'
rollback transaction
end

begin transaction
update Customers set name='Aulia Garo' where customer_id='CUS-000007'
--COMMIT TRANSACTION

select * from Customers where customer_id='CUS-000007'

create table ConsistencyTest(
	data SMALLINT
	CONSTRAINT uq_Data1 unique)

insert into ConsistencyTest (data) Values(1)
insert into ConsistencyTest (data) Values(4)
select * from ConsistencyTest
