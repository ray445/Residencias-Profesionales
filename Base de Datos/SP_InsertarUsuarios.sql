
use Residencias


alter procedure sp_InsertarUsuario
@NombreUser varchar(30),
@Contraseña varchar(60),
@Cargo varchar(30),
@cveAsesor varchar(10),
@msj varchar(100) output
as
begin
	begin try
		begin tran t
		if exists(select * from Usuarios where cveAsesor=@cveAsesor)
			set @msj='Ya se ha agregado un usuario con esta clave'
		else
		begin
			insert into Usuarios values(@NombreUser,@Contraseña,@Cargo,@cveAsesor)
			set @msj='Datos Agregados'
		end
		commit tran t
	end try
	begin catch	
		rollback tran t
		set @msj='Error al Agregar los Datos'
	end catch	
end


--exec sp_InsertarUsuario 'Pedro','Royers','Asesor','1234567890'