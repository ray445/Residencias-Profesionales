create proc sp_BuscarAlumno
@matricula varchar(9), @nombre varchar(60)
as
begin
	if(@matricula='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.nombre like @nombre+'%'
	if(@nombre='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.matricula like @matricula+'%'
end

--select * from Alumnos
--exec sp_BuscarAlumno '',''