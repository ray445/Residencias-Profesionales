
--Procedimiento almacenado para la insercion de Alumnos al sistema de Residencias
create proc sp_insertarAlumnos
@matricula varchar(10),@nombre varchar(30),@apP varchar(30),@apM varchar(30),@telefono varchar(13),@correo varchar(100),@cve_carrera varchar(15),@sexo char(1)
as
begin
	begin try
		begin tran t
		insert into Alumnos values(@matricula,@nombre,@apP,@apM,@telefono,@correo,@cve_carrera,@sexo)
		commit tran t
	end try
	begin catch	
		rollback tran t
	end catch	
end

--Insercion de prueba--
--exec sp_insertarAlumnos '131000154','Raymundo','Hdz','Fdz','872 104 22 42','raymundo.hernandezfernandez@sistemas.tecsanpedro.edu.mx','C-001','M'