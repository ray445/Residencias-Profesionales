--Procedimiento almacenado para la insercion de Carreras al sistema de Residencias
create proc sp_insertarCarreras
@matricula varchar(15),@nombre varchar(50)
as
begin
	begin try
		begin tran t
		insert into Carreras values(@matricula,@nombre)
		commit tran t
	end try
	begin catch	
		rollback tran t
	end catch	
end


exec sp_insertarCarreras 'JLCA131000111NC','DE 100 METROS'
