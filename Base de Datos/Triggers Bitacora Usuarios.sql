create trigger tg_insertar_Bitacora_Usuarios
	on Usuarios
	after insert
	as
	begin
		insert into bitacora_Usuarios(NombreUser,Contraseña,Cargo,cveAsesor,operacion)
			select NombreUser,Contraseña,Cargo,cveAsesor,'Insertar' from inserted
	end


create trigger tg_eliminar_Bitacora_Usuarios
	on Usuarios
	after delete
	as
	begin
		insert into bitacora_Usuarios(NombreUser_viejo,Contraseña_viejo,Cargo_viejo,cveAsesor,operacion)
			select NombreUser,Contraseña,Cargo,cveAsesor,'Eliminar' from deleted
	end

create trigger tg_actualizar_Bitacora_Usuarios
	on Usuarios
	after update
	as
	begin
		insert into bitacora_Usuarios(NombreUser_nuevo,NombreUser_viejo,Contraseña_nuevo,Contraseña_viejo,Cargo_nuevo,Cargo_viejo,cveAsesor_nuevo,cveAsesor_viejo,operacion)
			select inserted.NombreUser,deleted.NombreUser,inserted.Contraseña,deleted.Contraseña,inserted.Cargo,deleted.Cargo,inserted.cveAsesor,deleted.cveAsesor,'Actalizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
	end
	