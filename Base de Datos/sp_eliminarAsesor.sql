alter proc sp_eliminarAsesor 
@cveAsesor varchar ( 10 ),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		delete from Usuarios
		where cveAsesor=@cveAsesor
		delete from Asesores				
		where cveAsesor=@cveAsesor
		commit tran t
		set @msj='Se ha eliminado el registro'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Eliminar los Datos'
		end catch
end
