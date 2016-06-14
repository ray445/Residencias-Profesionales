create proc sp_insertarAsesores 
@cveAsesor varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@correo varchar ( 60 ),
@telefono varchar ( 13 ),@cve_carrera varchar ( 15 ),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		insert  into Asesores values (@cveAsesor, @nombre , @apPaterno, @apMaterno , @correo, @telefono, @cve_carrera)
		commit tran t
		set @msj='Datos Agregados'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Agregar los Datos'
		end catch
end

select * from asesores

----este SP vamos a insertar las datos siguentes para para la tabla asesores tambien mostramos
----un mensaje donde los datos ya an sido agregados en la tabla
---CREADO POR CONSUELO MENA VASQUEZ
