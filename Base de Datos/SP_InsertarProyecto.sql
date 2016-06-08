

use Residencias

alter procedure sp_InsertarProyecto
@matriculaAlumno varchar(10),
@nombreProyecto varchar(50),
@nombreEmpresa varchar(50),
@calificacion int,
@cveAsesor varchar(10),
@cveRevisor1 varchar(10),
@cveRevisor2 varchar(10), 
@periodo varchar(45),
@inicio date, 
@fin date,
@fecha1 date,
@fecha2 date,
@fecha3 date
as	
	begin	
	declare @folio int
	insert into Proyectos(matriculaAlumno, nombreEmpresa, nombreProyecto, calificacion, cveAsesor,cveRevisor1, cveRevisor2, periodo, inicio, fin)
	values(@matriculaAlumno,@nombreEmpresa,@nombreProyecto,@calificacion,@cveAsesor,@cveRevisor1,@cveRevisor2,@periodo,@inicio,@fin)							

	select top 1 folioProyecto =@folio from Proyectos order by folioProyecto desc

	if exists(select * from Proyectos where folioProyecto=@folio)
			insert into FechasRev values(@folio, @fecha1,@fecha2,@fecha3)			
	end
	

---trigger necesario para crear el registro en la tabla Documentos
create trigger tg_Documentos
on proyectos 
for insert
as
begin
	insert into Documentos values((select folioProyecto from inserted),null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null)
end
	
				


	