create trigger tg_insertar_Bitacora_Usuarios
	on Usuarios
	after insert
	as
	begin
		insert into bitacora_Usuarios(NombreUser,Contraseņa,Cargo,cveAsesor,operacion)
			select NombreUser,Contraseņa,Cargo,cveAsesor,'Insertar' from inserted
	end


create trigger tg_eliminar_Bitacora_Usuarios
	on Usuarios
	after delete
	as
	begin
		insert into bitacora_Usuarios(NombreUser_viejo,Contraseņa_viejo,Cargo_viejo,cveAsesor,operacion)
			select NombreUser,Contraseņa,Cargo,cveAsesor,'Eliminar' from deleted
	end

create trigger tg_actualizar_Bitacora_Usuarios
	on Usuarios
	after update
	as
	begin
		insert into bitacora_Usuarios(NombreUser_nuevo,NombreUser_viejo,Contraseņa_nuevo,Contraseņa_viejo,Cargo_nuevo,Cargo_viejo,cveAsesor_nuevo,cveAsesor_viejo,operacion)
			select inserted.NombreUser,deleted.NombreUser,inserted.Contraseņa,deleted.Contraseņa,inserted.Cargo,deleted.Cargo,inserted.cveAsesor,deleted.cveAsesor,'Actalizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
	end
	