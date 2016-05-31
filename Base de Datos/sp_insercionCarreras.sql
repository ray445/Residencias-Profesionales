--Procedimiento almacenado para la insercion de Carreras al sistema de Residencias
alter proc sp_insertarCarreras
@cve varchar(15),@nombre varchar(50),@msj varchar(100) output
as
begin

	begin try
		begin tran t
		insert into Carreras values(@cve,@nombre)
		set @msj='Datos Agregados'
		commit tran t
	end try
	begin catch	
		rollback tran t
		set @msj='Error'		
	end catch	
	select @msj
end



exec sp_insertarCarreras 'JLCA131000111NC','DE 100 METROS'
