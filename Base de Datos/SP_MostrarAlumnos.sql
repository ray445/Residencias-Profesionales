

use Residencias

create procedure sp_MostrarAlumnos
@matricula varchar(10),
@nombre varchar(30),
@apPaterno varchar(30),
@apMaterno varchar(30),
@telefono varchar(13),
@correo varchar(100),
@cveCarrera varchar(15),
@sexo char(1)
as
	begin
		select @nombre = nombre,
				@apPaterno = apPaterno,
				@apMaterno = apMaterno,
				@telefono = telefono,
				@correo = correo,
				@cveCarrera = cveCarrera,
				@sexo = sexo
		from Residencias
		where matriculo = @matricula
	end

exec 