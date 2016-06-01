


use Residencias
create proc sp_updateproyecto
 @calificacion int,
 @folioProyecto int
as
begin
	begin try
		begin tran t
		UPDATE Proyectos
		SET calificacion = [@calificacion]
		WHERE folioProyecto = [@folioProyecto]
		commit tran t
	end try
	begin catch	
		rollback tran t
	end catch	
end
