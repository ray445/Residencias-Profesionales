alter trigger tg_Insertar_Bitacora_Carrera
	on Carreras
	after insert
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre,operacion)
			select cve_carrera,nombre,'Insertar' from inserted
	end


create trigger tg_eliminar_Bitacora_Carrera
	on Carreras
	after delete
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre_viejo,operacion)
			select cve_carrera,nombre,'Insertar' from deleted
	end


alter trigger tg_actualizar_Bitacora_Carrera
	on Carreras
	after update
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre_nuevo,nombre_viejo,operacion)
			select deleted.cve_carrera,inserted.nombre,deleted.nombre,'Actualizacion'  from deleted inner join inserted on deleted.cve_carrera=inserted.cve_carrera
	end

	insert into Carreras values('C-003','Industrial')
	delete from Carreras where cve_carrera='C-003'
	select* from bitacoras_Carreras
	select* from Carreras

	update Carreras set nombre='Industrial' where cve_carrera='C-003'