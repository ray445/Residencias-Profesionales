
alter proc sp_modificarAsesor 
@cveAsesor varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@correo varchar ( 60 ),
@telefono varchar ( 13 ),@cve_carrera varchar ( 15 ),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		
		update Asesores set nombre= @nombre , apPaterno= @apPaterno,apMaterno=  @apMaterno,correo=@correo,telefono=@telefono,cve_carrera=@cve_carrera
		where cveAsesor=@cveAsesor
		commit tran t
		set @msj='Datos Agregados'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Agregar los Datos'
		end catch
end
