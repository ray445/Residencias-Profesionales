Create trigger tg_insertar_bitacora_Documentos
on Documentos
after insert 
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,operacion)
		select folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,'Insertar' from inserted
end


Create trigger tg_eliminar_bitacora_Documentos
on Documentos
after delete
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia_viejo,AnteProyecto_viejo,CartaPresentacion_viejo,Dictamen_viejo,AsignacionExterno_viejo,AsignacionInterno_viejo,Seguimiento_viejo,RegistrosAsesoria_viejo,CartaTerminacion_viejo,SolicitudRevisor_viejo,AsignacionRevisor1_viejo,AsignacionRevisor2_viejo,FormatoEvaluacion_viejo,CartaAgadecimiento_viejo,ResumenEjecutivo_viejo,Informe_viejo,CartaAceptacion_viejo,operacion)
		select folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,'Eliminar' from deleted
end


Create trigger tg_actualizar_bitacora_Documentos
on Documentos
after update
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia_viejo,SolicitudResidencia_nuevo,AnteProyecto_viejo,AnteProyecto_nuevo,CartaPresentacion_viejo,CartaPresentacion_nuevo,Dictamen_viejo,Dictamen_nuevo,AsignacionExterno_viejo,AsignacionExterno_nuevo,AsignacionInterno_viejo,AsignacionInterno_nuevo,Seguimiento_viejo,Seguimiento_nuevo,RegistrosAsesoria_viejo,RegistrosAsesoria_nuevo,CartaTerminacion_viejo,CartaTerminacion_nuevo,SolicitudRevisor_viejo,SolicitudRevisor_nuevo,AsignacionRevisor1_viejo,AsignacionRevisor1_nuevo,AsignacionRevisor2_viejo,AsignacionRevisor2_nuevo,FormatoEvaluacion_viejo,FormatoEvaluacion_nuevo,CartaAgadecimiento_viejo,CartaAgadecimiento_nuevo,ResumenEjecutivo_viejo,ResumenEjecutivo_nuevo,Informe_viejo,Informe_nuevo,CartaAceptacion_viejo,CartaAceptacion_nuevo,operacion)
		select inserted.folioProyecto,deleted.SolicitudResidencia,inserted.SolicitudResidencia,deleted.AnteProyecto,inserted.AnteProyecto,deleted.CartaPresentacion,inserted.CartaPresentacion,deleted.Dictamen,inserted.Dictamen,deleted.AsignacionExterno,inserted.AsignacionExterno,deleted.AsignacionInterno,inserted.AsignacionInterno,deleted.Seguimiento,inserted.Seguimiento,deleted.RegistrosAsesoria,inserted.RegistrosAsesoria,deleted.CartaTerminacion,inserted.CartaTerminacion,deleted.SolicitudRevisor,inserted.SolicitudRevisor,deleted.AsignacionRevisor1,inserted.AsignacionRevisor1,deleted.AsignacionRevisor2,inserted.AsignacionRevisor2,deleted.FormatoEvaluacion,inserted.FormatoEvaluacion,deleted.CartaAgadecimiento,inserted.CartaAgadecimiento,deleted.ResumenEjecutivo,inserted.ResumenEjecutivo,deleted.Informe,inserted.Informe,deleted.CartaAceptacion,inserted.CartaAceptacion,'Actualizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end

select* from Documentos
select* from bitacora_Documentos

insert into Documentos(folioProyecto) values(1)
update Documentos set SolicitudResidencia='true', SolicitudRevisor='true' where folioProyecto=1
delete from Documentos where folioProyecto=1