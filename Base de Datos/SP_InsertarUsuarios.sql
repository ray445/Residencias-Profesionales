

create procedure sp_InsertarUsuarios
@NombreUser varchar (30),
@Contrase�a varchar (60),
@Cargo varchar (30),
@cveAsesor varchar (10)
as
begin
	select NombreUser, Contrase�a, Cargo, cveAsesor from Usuarios
	where NombreUser = @NombreUser and Contrase�a = @Contrase�a and Cargo = @Cargo and cveAsesor = @cveAsesor
end


