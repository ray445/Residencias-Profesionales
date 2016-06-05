
create proc sp_modificarAlumnos 
@matricula varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@telefono varchar ( 13 ),@correo varchar ( 100 ),
@cve_carrera varchar ( 15 ),@sexo char(1),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		
		update Alumnos set matricula=@matricula, nombre= @nombre , apPaterno= @apPaterno,apMaterno=  @apMaterno,telefono=@telefono,correo=@correo,cve_carrera=@cve_carrera,sexo=@sexo
		where matricula=@matricula
		commit tran t
		set @msj='Datos Agregados'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Agregar los Datos'
		end catch
end




create table Alumnos ( 
matricula varchar(10) primary key,
nombre varchar(30) not null,
apPaterno varchar(30) not null,
apMaterno varchar(30) not null,
telefono varchar(13) null,
correo varchar(100) not null,
cve_carrera varchar(15) not null,
sexo char(1) not null,
)