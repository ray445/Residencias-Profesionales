

use residencias

create procedure sp_ActualizarDocumentos
@folioProyecto int,
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
@CartaAceptacion bit
as
	begin
		begin try 
			begin tran t
				update Documentos
				set SolicitudResidencia = @SolicitudResidencia, AnteProyecto = @AnteProyecto, CartaPresentacion = @CartaPresentacion,
				Dictamen = @Dictamen, AsignacionExterno = @AsignacionExterno, AsignacionInterno = @AsignacionInterno, Seguimiento = @Seguimiento,
				RegistrosAsesoria = @RegistrosAsesoria, CartaTerminacion = @CartaTerminacion, SolicitudRevisor = @SolicitudRevisor, AsignacionRevisor1 = @AsignacionRevisor1,
				AsignacionRevisor2 = @AsignacionRevisor2, FormatoEvaluacion = @FormatoEvaluacion, CartaAgadecimiento = @CartaAgadecimiento, ResumenEjecutivo = @ResumenEjecutivo,
				Informe = @Informe, CartaAceptacion = @CartaAceptacion
				where folioProyecto = @folioProyecto
			commit tran t
		end try
		begin catch
			rollback tran t
		end catch
	end



