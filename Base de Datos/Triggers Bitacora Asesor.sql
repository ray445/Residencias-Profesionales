create trigger tg_insertar_bitacora_Asesor
on Asesores
after insert
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre,apPaterno,apMaterno,correo,telefono,cve_carrera,operacion)
		select cveAsesor,nombre,apPaterno,apMaterno,correo,telefono,cve_carrera,'Insertar' from inserted
end


create trigger tg_eliminar_bitacora_Asesor
on Asesores
after delete
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre_vieho,apPaterno_viejo,apMaterno_viejo,correo_viejo,telefono_viejo,cve_carrera_viejo,operacion)
		select deleted.cveAsesor,deleted.nombre,deleted.apPaterno,deleted.apMaterno,deleted.correo,deleted.telefono,deleted.cve_carrera,'Eliminar' from deleted
end


create trigger tg_actualizar_bitacora_Asesor
on Asesores
after update
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre_vieho,nombre_nuevo,apPaterno_viejo,apPaterno_nuevo,apMaterno_viejo,apMaterno_nuevo,correo_viejo,correo_nuevo,telefono_viejo,telefono_nuevo,cve_carrera_viejo,cve_carrera_nuevo,operacion)
		select deleted.cveAsesor,deleted.nombre,inserted.nombre,deleted.apPaterno,inserted.apPaterno,deleted.apMaterno,inserted.apMaterno,deleted.correo,inserted.correo,deleted.telefono,inserted.telefono,deleted.cve_carrera,inserted.cve_carrera,'Actualizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
end



select* from bitacora_Asesores
select* from Asesores

insert into Asesores values('A-004','El dificil','Se hace','El profe','asdes','8722954480','C-002')
delete from Asesores where cveAsesor='A-00'
update Asesores set nombre='prueba',apPaterno='martinez',apMaterno='rodriguez' where cveAsesor='A-004'