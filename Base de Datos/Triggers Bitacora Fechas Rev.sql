create trigger tg_insertar_Bitacora_FechasRev
on FechasRev
after insert
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1,Fecha2,Fecha3,Fecha4,Fecha5,operacion)
		select folioProyecto,Fecha1,Fecha2,Fecha3,Fecha4,Fecha5,'Insertar' from inserted
end


create trigger tg_eliminar_Bitacora_FechasRev
on FechasRev
after delete
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1_viejo,Fecha2_viejo,Fecha3_viejo,Fecha4_viejo,Fecha5_viejo,operacion)
		select folioProyecto,Fecha1,Fecha2,Fecha3,Fecha4,Fecha5,'Eliminar' from deleted
end


create trigger tg_actualizar_Bitacora_FechasRev
on FechasRev
after update
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1_nuevo,Fecha1_viejo,Fecha2_nuevo,Fecha2_viejo,Fecha3_nuevo,Fecha3_viejo,Fecha4_nuevo,Fecha4_viejo,Fecha5_nuevo,Fecha5_viejo,operacion)
		select inserted.folioProyecto,inserted.Fecha1,deleted.Fecha1,inserted.Fecha2,deleted.Fecha2,inserted.Fecha3,deleted.Fecha3,inserted.Fecha4,deleted.Fecha4,inserted.Fecha5,deleted.Fecha5,'Actualizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end


insert into Proyectos(matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin)
	values('131000111','A','B','A-001','A-001','A-001','Agosto-Diciembre','31/08/2016','15/12/2016')

insert into FechasRev values(1,'10/09/2016','30/09/2016','10/10/2016','30/10/2016','15/11/2016')

update FechasRev set Fecha3='17/10/2016' where folioProyecto=1

delete from FechasRev where folioProyecto=1


select* from FechasRev
select* from bitacora_FechasRev