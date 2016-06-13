create proc sp_busquedaDocumentos
@matricula varchar(9), @nombre varchar(60),@cve_carrera varchar(15)
as
begin

	if(@matricula='')
		select a.matricula as Matricula, upper(a.nombre+' '+apPaterno+' '+apMaterno) as Alumno,SolicitudResidencia [Solicitud de Residencia],AnteProyecto [Anteproyecto],CartaPresentacion[Carta Presentacion],Dictamen as Dictamen,AsignacionExterno[Asignacion Asesor Externo],
AsignacionInterno [Asignacion Asesor Interno],Seguimiento as Seguimiento,RegistrosAsesoria [Registro Asesoria],CartaTerminacion [Carta de Terminacion],SolicitudRevisor [Solicitud de Revisor],AsignacionRevisor1[Asignacion Revisor(1)],
AsignacionRevisor2 [Asignacion Revisor(2)],FormatoEvaluacion[Formato de Evaluacion],CartaAgadecimiento[Carta de Agradecimiento],ResumenEjecutivo[Resumen Ejecutivo], Informe as Informe,CartaAceptacion[Carta de Aceptacion] from Documentos D inner join Proyectos P
on D.folioProyecto= P.folioProyecto
inner join Alumnos A
on A.matricula=P.matriculaAlumno
		where A.nombre like @nombre+'%'
		and A.cve_carrera=@cve_carrera
		
	if(@nombre='')
	select a.matricula as Matricula, upper(a.nombre+' '+apPaterno+' '+apMaterno) as Alumno,SolicitudResidencia [Solicitud de Residencia],AnteProyecto [Anteproyecto],CartaPresentacion[Carta Presentacion],Dictamen as Dictamen,AsignacionExterno[Asignacion Asesor Externo],
AsignacionInterno [Asignacion Asesor Interno],Seguimiento as Seguimiento,RegistrosAsesoria [Registro Asesoria],CartaTerminacion [Carta de Terminacion],SolicitudRevisor [Solicitud de Revisor],AsignacionRevisor1[Asignacion Revisor(1)],
AsignacionRevisor2 [Asignacion Revisor(2)],FormatoEvaluacion[Formato de Evaluacion],CartaAgadecimiento[Carta de Agradecimiento],ResumenEjecutivo[Resumen Ejecutivo], Informe as Informe,CartaAceptacion[Carta de Aceptacion] from Documentos D inner join Proyectos P
on D.folioProyecto= P.folioProyecto
inner join Alumnos A
on A.matricula=P.matriculaAlumno
		where A.matricula like @matricula+'%'
		and A.cve_carrera = @cve_carrera	
end

--en este SP donde buscaremos  mediante matricula ,nombre y cve_carrera en este caso utilisaremos tres tablas
--que son las tablas "documentos","proyecto"y"alumnos" se utilisan los if por si no entra en matricula entra en la otra opcion nombre 
