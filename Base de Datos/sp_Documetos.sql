select * from Documentos

alter proc sp_Documentos
as
begin
select a.matricula as Matricula, upper(a.nombre+' '+apPaterno+' '+apMaterno) as Alumno,SolicitudResidencia [Solicitud de Residencia],AnteProyecto [Anteproyecto],CartaPresentacion[Carta Presentacion],Dictamen as Dictamen,AsignacionExterno[Asignacion Asesor Externo],
AsignacionInterno [Asignacion Asesor Interno],Seguimiento as Seguimiento,RegistrosAsesoria [Registro Asesoria],CartaTerminacion [Carta de Terminacion],SolicitudRevisor [Solicitud de Revisor],AsignacionRevisor1[Asignacion Revisor(1)],
AsignacionRevisor2 [Asignacion Revisor(2)],FormatoEvaluacion[Formato de Evaluacion],CartaAgadecimiento[Carta de Agradecimiento],ResumenEjecutivo[Resumen Ejecutivo], Informe as Informe,CartaAceptacion[Carta de Aceptacion] from Documentos D inner join Proyectos P
on D.folioProyecto= P.folioProyecto
inner join Alumnos A
on A.matricula=P.matriculaAlumno
end

--select * from Alumnos
--exec sp_Documentos '1234'
