

use Residencias

create procedure sp_InsertarProyecto
@matriculaAlumno varchar(10),
@nombreProyecto varchar(50),
@nombreEmpresa varchar(50),
@calificacion int,
@cveAsesor varchar(10),
@cveRevisor1 varchar(10),
@cveRevisor2 varchar(10), 
@periodo varchar(45),
@inicio date, 
@fin date
as	
	begin	
				insert into Proyectos(matriculaAlumno, nombreEmpresa, nombreProyecto, calificacion, cveAsesor,
				 cveRevisor1, cveRevisor2, periodo, inicio, fin)
				values(@matriculaAlumno,@nombreEmpresa,@nombreProyecto,@calificacion,
				@cveAsesor,@cveRevisor1,@cveRevisor2,@periodo,@inicio,@fin)			
	end


	