

alter proc comboCarrera
as
begin
	select cve_carrera as cve,nombre from carreras
	order by nombre
end

--sp para combo de alumnos que aun no tiene un proyecto de residencias registrado
create proc comboAlumnos
as
begin
	select upper(nombre+' '+apPaterno+' '+apMaterno) as nom,matricula from Alumnos A left join  Proyectos P
	on A.matricula=P.matriculaAlumno
	where p.matriculaAlumno is null	
end


--insert into Proyectos values(131000123,'Residencias','Google',null,'123','1234','321','Febrero-agosto','2016-05-31','2016-09-15')

alter proc comboAsesores
as
begin
	/*declare @numP float
	declare @numA float
	declare @prom float
	declare @numP_A float

	select @numP= count(*) from proyectos
	select @numA=count(*) from Asesores
	set @prom= CEILING(@numP/@numA)	
	--select @numP as NumP,@numA as NumA,@prom as limite 
	select @numP_A= COUNT(*) from Proyectos
	group by cveAsesor*/

	select UPPER(nombre+' '+apPaterno+' '+apMaterno) as nom,cveAsesor from Asesores
	order by nom
end

select cast(4 as float)/cast(5 as float)

exec comboAsesores
