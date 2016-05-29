create proc sp_insertarAsesores 
@cveAsesor varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@correo varchar ( 60 ),
@telefono varchar ( 13 ),@cve_carrera varchar ( 15 )

as
begin
	begin try
		begin tran t
		insert  into Asesores values (@cveAsesor, @nombre , @apPaterno, @apMaterno , @correo, @telefono, @cve_carrera)
		commit tran t
	End try
		begin catch
		rollback tran t
		end catch
end

