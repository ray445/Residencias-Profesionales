create trigger tg_insertar_Bitacora_Usuarios
	on Usuarios
	after insert
	as
	begin
		insert into bitacora_Usuarios(NombreUser,Contrase�a,Cargo,cveAsesor,operacion)
			select NombreUser,Contrase�a,Cargo,cveAsesor,'Insertar' from inserted
	end


create trigger tg_eliminar_Bitacora_Usuarios
	on Usuarios
	after delete
	as
	begin
		insert into bitacora_Usuarios(NombreUser_viejo,Contrase�a_viejo,Cargo_viejo,cveAsesor,operacion)
			select NombreUser,Contrase�a,Cargo,cveAsesor,'Eliminar' from deleted
	end

create trigger tg_actualizar_Bitacora_Usuarios
	on Usuarios
	after update
	as
	begin
		insert into bitacora_Usuarios(NombreUser_nuevo,NombreUser_viejo,Contrase�a_nuevo,Contrase�a_viejo,Cargo_nuevo,Cargo_viejo,cveAsesor_nuevo,cveAsesor_viejo,operacion)
			select inserted.NombreUser,deleted.NombreUser,inserted.Contrase�a,deleted.Contrase�a,inserted.Cargo,deleted.Cargo,inserted.cveAsesor,deleted.cveAsesor,'Actalizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
	end
	