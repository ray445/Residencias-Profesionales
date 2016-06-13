--cambio el nombre del sp
--cambio folio por matricula


create proc sp_updateCalifproyecto
 @calificacion int,
 @matricula varchar(10),
 @msj varchar(100) output
as
begin
	begin try
		begin tran t
		UPDATE Proyectos
		SET calificacion = @calificacion
		WHERE matriculaAlumno=@matricula
		commit tran t
		set @msj='Datos Agregados'
	end try
	begin catch	
		rollback tran t
		set @msj='Error al cargar los datos'
	end catch	
end

este SP acualizaremos los datos de la tabla proyectos los datos que se actualizarab son calificacion,matricula
