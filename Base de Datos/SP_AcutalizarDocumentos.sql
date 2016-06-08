

use residencias

alter procedure sp_ActualizarDocumentos
@matricula varchar(10),
@SolicitudResidencia bit,
@AnteProyecto bit,
@CartaPresentacion bit,
@Dictamen bit,
@AsignacionExterno bit,
@AsignacionInterno bit,
@Seguimiento bit,
@RegistrosAsesoria bit,
@CartaTerminacion bit,
@SolicitudRevisor bit,
@AsignacionRevisor1 bit,
@AsignacionRevisor2 bit,
@FormatoEvaluacion bit,
@CartaAgadecimiento bit,
@ResumenEjecutivo bit,
@Informe bit,
@CartaAceptacion bit,
@msj varchar(100) output
as
	begin
	declare @folio int
	select @folio= folioProyecto from proyectos where @matricula = matriculaAlumno
		begin try 
			begin tran t
				update Documentos
				set SolicitudResidencia = @SolicitudResidencia, AnteProyecto = @AnteProyecto, CartaPresentacion = @CartaPresentacion,
				Dictamen = @Dictamen, AsignacionExterno = @AsignacionExterno, AsignacionInterno = @AsignacionInterno, Seguimiento = @Seguimiento,
				RegistrosAsesoria = @RegistrosAsesoria, CartaTerminacion = @CartaTerminacion, SolicitudRevisor = @SolicitudRevisor, AsignacionRevisor1 = @AsignacionRevisor1,
				AsignacionRevisor2 = @AsignacionRevisor2, FormatoEvaluacion = @FormatoEvaluacion, CartaAgadecimiento = @CartaAgadecimiento, ResumenEjecutivo = @ResumenEjecutivo,
				Informe = @Informe, CartaAceptacion = @CartaAceptacion
				where folioProyecto = @folio
			commit tran t
			set @msj='Se han actualizado los datos'
		end try
		begin catch
			rollback tran t
			set @msj='Error al actualizar los datos'
		end catch
	end


