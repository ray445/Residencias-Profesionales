alter trigger tg_Inseratr_Bitacora_Alumnos
	on Alumnos
	after insert
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,operacion)
			select matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,'Insertar','nolose' from inserted
	end


create trigger tg_eliminar_Bitacora_Alumnos
	on Alumnos
	after delete
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre_viejo,apPaterno_viejo,apMaterno_viejo,telefono_viejo,correo_viejo,cve_carrera_viejo,sexo_viejo,operacion)
			select matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,'Eliminar' from deleted
	end


create trigger tg_actualizar_Bitacora_Alumnos
	on Alumnos
	after update
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre_nuevo,nombre_viejo,apPaterno_nuevo,apPaterno_viejo,apMaterno_nuevo,apMaterno_viejo,telefono_nuevo,telefono_viejo,correo_nuevo,correo_viejo,cve_carrera_nuevo,cve_carrera_viejo,sexo_nuevo,sexo_viejo,operacion)
			select deleted.matricula,inserted.nombre,deleted.nombre,inserted.apPaterno,deleted.apPaterno,inserted.apMaterno,deleted.apMaterno,inserted.telefono,deleted.telefono,inserted.correo,deleted.correo,inserted.cve_carrera,deleted.cve_carrera,inserted.sexo,deleted.sexo,'Actualizacion' from deleted inner join inserted on deleted.matricula=inserted.matricula
	end

update Alumnos set nombre='kiere pelea prro' where matricula='111111111'


select* from Alumnos

delete from Alumnos where matricula='111111111'



insert into Alumnos(matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo) values('111111111','Leo','C','A','3333333333','AOC','C-002','M')