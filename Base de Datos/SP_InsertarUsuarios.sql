

create procedure sp_InsertarUsuarios
@NombreUser varchar (30),
@Contraseņa varchar (60),
@Cargo varchar (30),
@cveAsesor varchar (10)
as
begin
	select NombreUser, Contraseņa, Cargo, cveAsesor from Usuarios
	where NombreUser = @NombreUser and Contraseņa = @Contraseņa and Cargo = @Cargo and cveAsesor = @cveAsesor
end


