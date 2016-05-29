

create procedure sp_InsertarUsuarios
@NombreUser varchar (30),
@Contraseña varchar (60),
@Cargo varchar (30),
@cveAsesor varchar (10)
as
begin
	select NombreUser, Contraseña, Cargo, cveAsesor from Usuarios
	where NombreUser = @NombreUser and Contraseña = @Contraseña and Cargo = @Cargo and cveAsesor = @cveAsesor
end


