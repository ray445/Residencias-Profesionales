

create procedure sp_Acceso 
@nombre varchar(30), @contraseÃ±a varchar(60)
as
begin 
	select NombreUser as Nombre, Contraseña,Cargo  from Usuarios
	where NombreUser=@nombre and @contraseña=Contraseña
end


--exec sp_Acceso 'Raymundo','patoganzo'

/*
insert into Usuarios values('Raymundo','patoganzo','Asesor','A-001')

insert into Asesores values('A-001','Raul','Hdz','Fdz','asdsad','123123123','C-001')

insert into Carreras values('C-001','Sistemas Computacionales')*/

--select * from Usuarios
