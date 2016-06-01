


create proc sp_updateproyecto
 @calificacion int,
 @folioProyecto int,
 @msj varchar(100) output
as
begin
	begin try
		begin tran t
		UPDATE Proyectos
		SET calificacion = @calificacion
		WHERE folioProyecto = @folioProyecto
		commit tran t
		set @msj='Datos Agregados'
	end try
	begin catch	
		rollback tran t
		set @msj='Error al cargar los datos'
	end catch	
end
