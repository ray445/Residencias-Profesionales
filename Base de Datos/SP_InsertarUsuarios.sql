
use Residencias


create procedure sp_InsertarUsuario
@NombreUser varchar(30),
@Contraseņa varchar(60),
@Cargo varchar(30),
@cveAsesor varchar(10)
as
begin
	begin try
		begin tran t
			insert into Usuarios values(@NombreUser,@Contraseņa,@Cargo,@cveAsesor)
		commit tran t
	end try
	begin catch	
		rollback tran t
	end catch	
end

select*from Usuarios

--exec sp_InsertarUsuario 'Pedro','Royers','Asesor','1234567890'