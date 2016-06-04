alter proc sp_BuscarAsesor
@cve varchar(10), @nombre varchar(60)
as
begin
	if(@cve='')
		select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera from Asesores A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.nombre like  @nombre+'%' or A.apPaterno like  @nombre+'%' or A.apMaterno like  @nombre+'%'
	if(@nombre='')
	select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera from Asesores A inner join Carreras C
	on A.cve_carrera=C.cve_carrera
		where A.cveAsesor like @cve+'%'
end

select * from asesores
exec sp_BuscarAsesor '','mar'