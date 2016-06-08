create trigger tg_insertar_bitacora_Proyectos
on Proyectos
after insert
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,operacion)
		select folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,'Insert' from inserted
end


create trigger tg_eliminar_bitacora_Proyectos
on Proyectos
after delete
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto_viejo,nombreEmpresa_viejo,cveAsesor_viejo,cveRevisor1_viejo,cveRevisor2_viejo,periodo_viejo,inicio_viejo,fin_viejo,operacion)
		select folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,'Eliminar' from deleted
end


create trigger tg_actualizar_bitacora_Proyectos
on Proyectos
after update
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto_viejo,nombreProyecto_nuevo,nombreEmpresa_viejo,nombreEmpresa_nuevo,cveAsesor_viejo,cveAsesor_nuevo,cveRevisor1_viejo,cveRevisor1_nuevo,cveRevisor2_viejo,cveRevisor2_nuevo,periodo_viejo,periodo_nuevo,inicio_viejo,inicio_nuevo,fin_viejo,fin_nuevo,operacion)
		select deleted.folioProyecto,deleted.matriculaAlumno,deleted.nombreProyecto,inserted.nombreProyecto,deleted.nombreEmpresa,inserted.nombreEmpresa,deleted.cveAsesor,inserted.cveAsesor,deleted.cveRevisor1,inserted.cveRevisor1,deleted.cveRevisor2,inserted.cveRevisor2,deleted.periodo,inserted.periodo,deleted.inicio,inserted.inicio,deleted.fin,inserted.fin,'Actalizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end

insert into Proyectos (matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin)
	values('131000111','ABCD','Oracle','A-001','A-001','A-001','AGO-DIC','20/08/2016','20/12/2106')

update Proyectos set nombreProyecto='Uno serio' where folioProyecto=2

delete from Proyectos where folioProyecto=2


select* from bitacora_Proyectos
select* from Proyectos
select* from Alumnos
select* from Asesores