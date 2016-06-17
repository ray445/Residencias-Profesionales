create database Residencias
go
use Residencias
go
--Raymundo Hernandez Fernandez
--Crea una tabla llamada alumnos en la cual se guardara la informacion personal del alumno
create table Alumnos ( 
matricula varchar(10) primary key,
nombre varchar(30) not null,
apPaterno varchar(30) not null,
apMaterno varchar(30) not null,
telefono varchar(13) null,
correo varchar(100) not null,
cve_carrera varchar(15) not null,
sexo char(1) not null,
)
go

--Raymundo Hernandez Fernandez
--Crea una tabla llamada Carreras en la cual se guardaran las carreras existentes
create table Carreras(
cve_carrera varchar(15) primary key,
nombre varchar(50) not null unique,
jefe varchar(100)
)
go

--Saul Rocha Gomez
--Crea una tabla llamada usuario en la cual se guardara la informacion de los usuarios que puede acceder al sistema
create table Usuarios(
NombreUser varchar(30) not null,
Contraseña varchar(60) not null,
Cargo varchar(30) not null,
cveAsesor varchar(10) not null
)
go

--Saul Rocha Gomez
--Crea una tabla llamada FechasRev en la cual se guardan las fechas de revision del proyecto asignado
create table FechasRev(
folioProyecto int not null,
Fecha1 date,
Fecha2 date,
Fecha3 date,
Fecha4 date,
Fecha5 date
)
go
--Consuelo Mena Vasquez
--Crea una tabla llamada Asesores en la cual se guarda la informacion de los docentes que forman parte del 
--programa de residencias profesionales.
create table Asesores(
cveAsesor varchar(10) primary key,
nombre varchar(30) not null,
apPaterno varchar(30) not null,
apMaterno varchar(30) not null,
correo varchar(60) not null,
telefono varchar(13),
cve_carrera varchar(15) not null,
titulo varchar(10)
)
go

--Raymundo Hernandez Fernandez
--Crea una tabla llamada Proyectos en la cual se guarda la informacion general del proyecto asignado a un alumno 
create table Proyectos(
folioProyecto int identity primary key,
matriculaAlumno varchar(10) not null,
nombreProyecto varchar(50) not null,
nombreEmpresa varchar(50) not null,
calificacion int null,
cveAsesor varchar(10),
cveRevisor1 varchar(10),
cveRevisor2 varchar(10), 
periodo varchar(45) not null,
inicio date not null, 
fin date
)
go
--Saul Rocha Gomez
--Crea una tabla llamada Documentos en la cual se guardara el registro de documentos entregados por parte 
--del residente.
create table Documentos(
folioProyecto int not null,
SolicitudResidencia bit,
AnteProyecto bit,
CartaPresentacion bit,
Dictamen bit,
AsignacionExterno bit,
AsignacionInterno bit,
Seguimiento bit,
RegistrosAsesoria bit,
CartaTerminacion bit,
SolicitudRevisor bit,
AsignacionRevisor1 bit,
AsignacionRevisor2 bit,
FormatoEvaluacion bit,
CartaAgadecimiento bit,
ResumenEjecutivo bit,
Informe bit,
CartaAceptacion bit
)
go


------------------Relaciones-------------------
alter table Alumnos add foreign key(cve_carrera) references Carreras(cve_carrera)
go
alter table Asesores add foreign key(cve_carrera) references Carreras(cve_carrera)
go
alter table FechasRev add foreign key(folioProyecto) references Proyectos(folioProyecto)
go
alter table Proyectos add foreign key(matriculaAlumno) references Alumnos(matricula)
go
alter table Proyectos add foreign key(cveAsesor) references Asesores(cveAsesor)
go
alter table Usuarios add foreign key(cveAsesor) references Asesores(cveAsesor)
go
alter table Documentos add foreign key(folioProyecto) references Proyectos(folioProyecto)


--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Alunnos en la cual se va a registrar las operaciones que se realizan en la
--tabla Alumnos
create table bitacora_Alumnos (
id_bitacora int identity, 
matricula varchar(10),
nombre varchar(30),
nombre_nuevo varchar(30),
nombre_viejo varchar(30),
apPaterno varchar(30),
apPaterno_nuevo varchar(30),
apPaterno_viejo varchar(30),
apMaterno varchar(30),
apMaterno_nuevo varchar(30),
apMaterno_viejo varchar(30),
telefono varchar(13),
telefono_nuevo varchar(13),
telefono_viejo varchar(13),
correo varchar(100),
correo_nuevo varchar(100),
correo_viejo varchar(100),
cve_carrera varchar(50),
cve_carrera_nuevo varchar(50),
cve_carrera_viejo varchar(50),
sexo char(1),
sexo_nuevo char(1),
sexo_viejo char(1),
operacion  varchar(15) not null,
cveAsesor varchar(10)
)
go

--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Asesores en la cual se va a registrar las operaciones que se realizan en la
--tabla Asesores
create table bitacora_Asesores(
id_bitacoraAs int identity primary key,
cveAsesor varchar(10),
nombre varchar(30),
nombre_nuevo varchar(30),
nombre_vieho varchar(30),
apPaterno varchar(30),
apPaterno_nuevo varchar(30),
apPaterno_viejo varchar(30),
apMaterno varchar(30),
apMaterno_nuevo varchar(30),
apMaterno_viejo varchar(30),
correo varchar(60),
correo_nuevo varchar(60),
correo_viejo varchar(60),
telefono varchar(13),
telefono_nuevo varchar(13),
telefono_viejo varchar(13),
cve_carrera varchar(15),
cve_carrera_nuevo varchar(15),
cve_carrera_viejo varchar(15),
titulo varchar(10),
titulo_nuevo varchar(10),
titulo_viejo varchar(10),
operacion varchar(15),
usuario varchar(10))
go

--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Carreras en la cual se va a registrar las operaciones que se realizan en la
--tabla Carreras
create table bitacoras_Carreras(
id_bitacoraC int identity,
cve_carrera varchar(15),
nombre varchar(50),
nombre_nuevo varchar(50),
nombre_viejo varchar(50),
operacion varchar(15) not null,
cveAsesor varchar(10),
jefe varchar(100),
jefe_nuevo varchar(100),
jefe_viejo varchar(100))
go


--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Documentos en la cual se va a registrar las operaciones que se realizan en la
--tabla Docuemtos
create table bitacora_Documentos(
id_bitacoraDoc int identity primary key,
folioProyecto int,
SolicitudResidencia bit,
SolicitudResidencia_nuevo bit,
SolicitudResidencia_viejo bit,
AnteProyecto bit,
AnteProyecto_nuevo bit,
AnteProyecto_viejo bit,
CartaPresentacion bit,
CartaPresentacion_nuevo bit,
CartaPresentacion_viejo bit,
Dictamen bit,
Dictamen_nuevo bit,
Dictamen_viejo bit,
AsignacionExterno bit,
AsignacionExterno_nuevo bit,
AsignacionExterno_viejo bit,
AsignacionInterno bit,
AsignacionInterno_nuevo bit,
AsignacionInterno_viejo bit,
Seguimiento bit,
Seguimiento_nuevo bit,
Seguimiento_viejo bit,
RegistrosAsesoria bit,
RegistrosAsesoria_nuevo bit,
RegistrosAsesoria_viejo bit,
CartaTerminacion bit,
CartaTerminacion_nuevo bit,
CartaTerminacion_viejo bit,
SolicitudRevisor bit,
SolicitudRevisor_nuevo bit,
SolicitudRevisor_viejo bit,
AsignacionRevisor1 bit,
AsignacionRevisor1_nuevo bit,
AsignacionRevisor1_viejo bit,
AsignacionRevisor2 bit,
AsignacionRevisor2_nuevo bit,
AsignacionRevisor2_viejo bit,
FormatoEvaluacion bit,
FormatoEvaluacion_nuevo bit,
FormatoEvaluacion_viejo bit,
CartaAgadecimiento bit,
CartaAgadecimiento_nuevo bit,
CartaAgadecimiento_viejo bit,
ResumenEjecutivo bit,
ResumenEjecutivo_nuevo bit,
ResumenEjecutivo_viejo bit,
Informe bit,
Informe_nuevo bit,
Informe_viejo bit,
CartaAceptacion bit,
CartaAceptacion_nuevo bit,
CartaAceptacion_viejo bit,
operacion varchar(15),
usuario varchar(10)
)
go

--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_FechasRev en la cual se va a registrar las operaciones que se realizan en la
--tabla FechasRev
create table bitacora_FechasRev(
folioProyecto int not null,
Fecha1 date,
Fecha1_nuevo date,
Fecha1_viejo date,
Fecha2 date,
Fecha2_nuevo date,
Fecha2_viejo date,
Fecha3 date,
Fecha3_nuevo date,
Fecha3_viejo date,
operacion varchar(15),
usuario varchar(10))
go

--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Proyectos en la cual se va a registrar las operaciones que se realizan en la
--tabla Proyectos
create table bitacora_Proyectos(
id_bitacoraPr int identity primary key,
folioProyecto int,
matriculaAlumno varchar(10),
nombreProyecto varchar(50),
nombreProyecto_nuevo varchar(50),
nombreProyecto_viejo varchar(50),
nombreEmpresa varchar(50),
nombreEmpresa_nuevo varchar(50),
nombreEmpresa_viejo varchar(50),
calificacion int,
calificacion_nuevo int,
calificacion_viejo int,
cveAsesor varchar(10),
cveAsesor_nuevo varchar(10),
cveAsesor_viejo varchar(10),
cveRevisor1 varchar(10),
cveRevisor1_nuevo varchar(10),
cveRevisor1_viejo varchar(10),
cveRevisor2 varchar(10), 
cveRevisor2_nuevo varchar(10),
cveRevisor2_viejo varchar(10),  
periodo varchar(45),
periodo_nuevo varchar(45),
periodo_viejo varchar(45),
inicio date, 
inicio_nuevo date,
inicio_viejo date,  
fin date,
fin_nuevo date,
fin_viejo date,
operacion varchar(15),
usuario varchar(10)
)
go

--Juan Luis Castillo Arriaga
--Crea una tabla llamda bitacora_Usuarios en la cual se va a registrar las operaciones que se realizan en la
--tabla Usuarios
create table bitacora_Usuarios(
	id_bitacora_U int identity,
	NombreUser varchar(30),
	NombreUser_nuevo varchar(30),
	NombreUser_viejo varchar(30),
	Contraseña varchar(60),	
	Contraseña_nuevo varchar(60),
	Contraseña_viejo varchar(60),
	Cargo varchar(30),
	Cargo_nuevo varchar(30),
	Cargo_viejo varchar(30),
	cveAsesor varchar(10),
	cveAsesor_nuevo varchar(10),
	cveAsesor_viejo varchar(10),
	operacion varchar(15),
	usuario varchar(10))
	go

--Raymundo Hernandez Fernandez
--Crea una consulta en la que selecciona el usuario y la contraseña primmordialmente para poder compararlas y 
--asi permitir o no el acceso al software
create procedure sp_Acceso
@nombre varchar(30), @contraseña varchar(60)
as
begin 
	select Usuarios.NombreUser as Nombre,Usuarios.Contraseña,Usuarios.Cargo,Asesores.cve_carrera as Carrera from Usuarios inner join Asesores on Usuarios.cveAsesor=Asesores.cveAsesor
	where NombreUser=@nombre and @contraseña=Contraseña
end
go

--Saul Rocha Gomez
--Inserta un nuevo registro en la tabla Alumnos
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
go

--Consuelo Mena Vasquez
--Inserta un nuevo registro en la tabla carreras
create proc sp_insertarCarreras
@cve varchar(15),@nombre varchar(50),@jefe varchar(100),@msj varchar(100) output
as
begin
	begin try
		begin tran t
		insert into Carreras values(@cve,@nombre,@jefe)
		commit tran t
	    set @msj='Carrera agregada con exito'
	end try
	begin catch	
	    set @msj='Datos no agregados'
		rollback tran t
	end catch	
end
go

--Consuelo Mena Vasquez
--Inserta un nuevo registro en la tabla Asesores
create proc sp_insertarAsesores
@cveAsesor varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@correo varchar ( 60 ),
@telefono varchar ( 13 ),@cve_carrera varchar ( 15 ), @titulo varchar(10),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		insert  into Asesores values (@cveAsesor, @nombre , @apPaterno, @apMaterno , @correo, @telefono, @cve_carrera,@titulo)
		commit tran t
		set @msj='Datos Agregados'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Agregar los Datos'
		end catch
end
go

--Saul Rocha Gomez
--Inserta un nuevo registro en la tabla usuario
create procedure sp_InsertarUsuario
@NombreUser varchar(30),
@Contraseña varchar(60),
@Cargo varchar(30),
@cveAsesor varchar(10),
@msj varchar(100) output
as
begin
	begin try
		begin tran t
		if exists(select * from Usuarios where cveAsesor=@cveAsesor)
			set @msj='Ya se ha agregado un usuario con esta clave'
		else
		begin
			insert into Usuarios values(@NombreUser,@Contraseña,@Cargo,@cveAsesor)
			set @msj='Datos Agregados'
		end
		commit tran t
	end try
	begin catch	
		rollback tran t
		set @msj='Error al Agregar los Datos'
	end catch	
end
go

--Saul Rocha Gomez
--Inserta un nuevo registro en la tabla Proyectos y ejecuta el sp sp_InsertarFechasREv
create procedure sp_InsertarProyecto
@matriculaAlumno varchar(10),
@nombreProyecto varchar(50),
@nombreEmpresa varchar(50),
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
		
		if not exists ((select* from Proyectos where matriculaAlumno=@matriculaAlumno))
				insert into Proyectos(matriculaAlumno, nombreEmpresa,nombreProyecto, cveAsesor,
				 cveRevisor1, cveRevisor2, periodo, inicio, fin)
				values(@matriculaAlumno,@nombreEmpresa,@nombreProyecto,
				@cveAsesor,@cveRevisor1,@cveRevisor2,@periodo,@inicio,@fin)
				declare @folio int	
				set @folio= (select top 1 folioProyecto from Proyectos order by folioProyecto desc)
			if not exists(select* from FechasRev where folioProyecto=@folio)
				exec sp_InsertarFechasRev @folio,@fecha1,@fecha2,@fecha3
	end
	go

--Saul Rocha Gomez
--Selecciona el nombre, apellido paterno y apellido materno del asesor asi como la clave de la tabla Asesores
--pertenecientes a la carrera qu contiene el parametro
create proc comboAsesores2
@carrera varchar(15)
as
begin
	select UPPER(nombre+' '+apPaterno+' '+apMaterno) as nom,cveAsesor as cve from Asesores 
	where cve_carrera=@carrera
	order by nom
end
go


--Saul Rocha Gomez
--Selecciona el nombre completo, la matricula de los alumnos que aun no tiene un proyecto asigando.
create proc comboAlumnos
@carrera varchar(15)
as
begin
	select upper(nombre+' '+apPaterno+' '+apMaterno) as nom,matricula from Alumnos A left join  Proyectos P
	on A.matricula=P.matriculaAlumno
	where p.matriculaAlumno is null	and A.cve_carrera=@carrera
	order by nom
end
go

--Saul Rocha Gomez
--Selecciona los campos de la tabla Documentos y la matricula del alumno de la tabla Alumnos
--Selecciona todos los campos que tengan una coincidencia con el parametro recibido
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
go


--Saul Rocha Gomez
--Selecciona todo los campos de la tabla Documentos y el campo matricula de la tabla Alumnos
create proc sp_Documentos
@carera varchar(10)
as
begin
select a.matricula as Matricula, upper(a.nombre+' '+apPaterno+' '+apMaterno) as Alumno,SolicitudResidencia [Solicitud de Residencia],AnteProyecto [Anteproyecto],CartaPresentacion[Carta Presentacion],Dictamen as Dictamen,AsignacionExterno[Asignacion Asesor Externo],
AsignacionInterno [Asignacion Asesor Interno],Seguimiento as Seguimiento,RegistrosAsesoria [Registro Asesoria],CartaTerminacion [Carta de Terminacion],SolicitudRevisor [Solicitud de Revisor],AsignacionRevisor1[Asignacion Revisor(1)],
AsignacionRevisor2 [Asignacion Revisor(2)],FormatoEvaluacion[Formato de Evaluacion],CartaAgadecimiento[Carta de Agradecimiento],ResumenEjecutivo[Resumen Ejecutivo], Informe as Informe,CartaAceptacion[Carta de Aceptacion] from Documentos D inner join Proyectos P
on D.folioProyecto= P.folioProyecto
inner join Alumnos A
on A.matricula=P.matriculaAlumno
where a.cve_carrera=@carera
end
go


--Saul Rocha Gomez
--Actualiza la informacion de la tabla Documentos de la tupla en la que su identificador coincide con el paramatro identificador recibido
create procedure sp_ActualizarDocumentos
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
	go

--Consuelo Mena Vasquez
--Actualiza la calificacion en la tabla Proyectos del proyecto que en su campo matricula sea coincidente con 
--el parametro @matricula
create proc sp_updateCalifproyecto
 @calificacion int,
 @matricula varchar(10),
 @msj varchar(100) output
as
begin
	begin try
		begin tran t
		UPDATE Proyectos
		SET calificacion = @calificacion
		WHERE matriculaAlumno=@matricula
		commit tran t
		set @msj='Datos Agregados'
	end try
	begin catch	
		rollback tran t
		set @msj='Error al cargar los datos'
	end catch	
end
go

--Raymundo Hernandez Fernandez
--
create proc datosmail
@folio int
as
declare  @fecha date
declare @correo1 varchar(100)
declare @correo2 varchar(100)
set @fecha=null
if convert(varchar(13),(select fecha1 from FechasRev where folioProyecto=@folio),102)=convert(varchar(13),dateadd(day,1,getdate()),102)
	select @fecha=fecha1 from FechasRev where folioProyecto=@folio
if convert(varchar(13),(select fecha1 from FechasRev where folioProyecto=@folio),102)=convert(varchar(13),dateadd(day,1,getdate()),102)
	select @fecha=fecha2 from FechasRev where folioProyecto=@folio
if convert(varchar(13),(select fecha1 from FechasRev where folioProyecto=@folio),102)=convert(varchar(13),dateadd(day,1,getdate()),102)
	select @fecha=fecha3 from FechasRev where folioProyecto=@folio	
select @correo1= a.correo from proyectos p inner join asesores a on a.cveAsesor=p.cveRevisor1 where folioProyecto=@folio
select @correo2= a.correo from proyectos p inner join asesores a on a.cveAsesor=p.cveRevisor2 where folioProyecto=@folio
if @fecha is not null	
select a.nombre+' '+a.apPaterno+' '+a.apMaterno as Nombre,@fecha as Fecha,@correo1 as correoR1,@correo2 as correor2 from Proyectos p inner join Alumnos a
on p.matriculaAlumno=a.matricula
where p.folioProyecto=@folio
go


--Raymundo Hernandez Fernandez
--
create proc infoCorreo
as
select p.folioProyecto [Folio Proyecto], nombreProyecto as Proyecto, a.nombre+' '+a.apPaterno+' '+a.apMaterno as Alumno,f.Fecha1,Fecha2,Fecha3 from FechasRev f inner join Proyectos p
on p.folioProyecto=f.folioProyecto
inner join Alumnos a
on a.matricula=p.matriculaAlumno
where convert(varchar(13),f.Fecha1,102)=convert(varchar(13),dateadd(day,1,getdate()),102)
or convert(varchar(13),f.Fecha2,102)=convert(varchar(13),dateadd(day,1,getdate()),102)
or convert(varchar(13),f.Fecha3,102)=convert(varchar(13),dateadd(day,1,getdate()),102)
go


--Raymundo Hernandez Fernandez
--Selecciona los campos necesarios que deben de insertarse en el documento a generar, seleccionando 
--los campos de la tupla correspondiente a la matricula de un Alumno
create proc Doc
@matricula varchar(9)
as
set language 'spanish'
select upper(c.jefe) as jefe,upper(c.nombre) as Carrera,UPPER( p.nombreProyecto) as Proyecto,UPPER(a.nombre+' '+a.apPaterno+' '+a.apMaterno) as Alumno, matricula,UPPER(ase.titulo+' '+ase.nombre+' '+ase.apPaterno+' '+ase.apMaterno)as Asesor,day(GETDATE()) as dia, datename( MONTH,GETDATE()) as mes,YEAR(GETDATE())as año from Proyectos p inner join Alumnos a
on p.matriculaAlumno=a.matricula
inner join Carreras c
on c.cve_carrera=a.cve_carrera
inner join asesores ase
on ase.cveAsesor=p.cveAsesor
where matriculaAlumno=@matricula
go


--Raymundo Hernandez Fernandez
--Selecciona los campos necesarios que deben de insertarse en el documento a generar, seleccionando 
--los campos de la tupla correspondiente a la matricula de un Alumno
create proc docAsesores
@matricula varchar(9)
as
select UPPER(asr.titulo+' '+asr.nombre+' '+asr.apPaterno+' '+asr.apMaterno) as Asesor, UPPER(a.nombre+' '+a.apPaterno+' '+a.apMaterno) as Alumno,
	   upper(c.nombre) as Carrera, upper(p.nombreProyecto) as Proyecto,upper(p.periodo) as Periodo,upper(p.nombreEmpresa) as Empresa, 
	   getdate() as fecha,UPPER( c.jefe) as jefe from proyectos p inner join Alumnos a
on p.matriculaAlumno=a.matricula
inner join Asesores asr
on p.cveAsesor=asr.cveAsesor 
inner join Carreras c
on a.cve_carrera=c.cve_carrera
where a.matricula=@matricula
go


--Raymundo Hernandez Fernandez
--Selecciona la fecha requerida asi como todos los demas campos necesarios para poder hacer el llenado del 
--documento esto mediante la coincidencia en las matriculas.
create proc DocRevisor
@matricula varchar(9),@numfecha int
as
declare @fecha date
if @numfecha=1
	select @fecha= Fecha1 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
if @numfecha=2
	select @fecha= Fecha2 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
if @numfecha=3
	select @fecha= Fecha3 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
set language 'spanish'
select upper(ase.titulo+' '+ase.nombre+' '+ase.apPaterno+' '+ase.apMaterno) as Revisor,day(@fecha) as dia, datename( MONTH,@fecha) as mes,
	   upper(a.nombre+' '+a.apPaterno+' '+a.apMaterno) as Alumno, UPPER(c.nombre) as Carrera, upper(p.nombreProyecto) as Proyecto,
	   getdate() as fecha, upper(c.jefe) as jefe from proyectos p inner join alumnos a
on p.matriculaAlumno=a.matricula
inner join Asesores ase
on p.cveRevisor1=ase.cveAsesor
inner join Carreras c
on a.cve_carrera=c.cve_carrera
where p.matriculaAlumno=@matricula
go


--Raymundo Hernandez Fernandez
--Selecciona la fecha requerida asi como todos los demas campos necesarios para poder hacer el llenado del 
--documento esto mediante la coincidencia en las matriculas.
create proc DocRevisor2
@matricula varchar(9), @numfecha int
as
declare @fecha date
if @numfecha=1
	select @fecha= Fecha1 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
if @numfecha=2
	select @fecha= Fecha2 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
if @numfecha=3
	select @fecha= Fecha3 from FechasRev inner join proyectos p on p.folioProyecto=FechasRev.folioProyecto where p.matriculaAlumno= @matricula
set language 'spanish'
select upper(ase.titulo+' '+ase.nombre+' '+ase.apPaterno+' '+ase.apMaterno) as Revisor,day(@fecha) as dia, datename( MONTH,@fecha) as mes,
	   upper(a.nombre+' '+a.apPaterno+' '+a.apMaterno) as Alumno, UPPER(c.nombre) as Carrera, upper(p.nombreProyecto) as Proyecto,
	   getdate() as fecha, upper(c.jefe) as jefe from proyectos p inner join alumnos a
on p.matriculaAlumno=a.matricula
inner join Asesores ase
on p.cveRevisor2=ase.cveAsesor
inner join Carreras c
on a.cve_carrera=c.cve_carrera
where p.matriculaAlumno=@matricula 
go


--Raymundo Hernandez Fernandez
--Selecciona el nombre completo y la clave de los asesores que aun no cuentan con un usuario y contraseña
--para poder accesar al sistema
create proc comboAsesores
as
begin
	select UPPER(nombre+' '+apPaterno+' '+apMaterno) as nom,A.cveAsesor as cve from Asesores A left join Usuarios U
	on A.cveAsesor=U.cveAsesor
	where u.cveAsesor is null
	order by nom
end
go

--Raymundo Hernanes Fernandez
--Selecciona la clave y el nombre de la tabla Carreras
create proc comboCarrera
as
begin
	select cve_carrera as cve,nombre from carreras
	order by nombre
end
go

--Raymundo Hernandez Fernandez
--Realiza un conteo sobre cuantos proyectos tiene un asesor asignado 
create proc conteo
@cve varchar(10)
as
begin
declare @cont1 int
declare @cont2 int
	
	select @cont1=count(*) from 
Proyectos p
where p.cveAsesor=@cve and p.calificacion is null 

select @cont2=COUNT(*) from proyectos where (cveRevisor1=@cve or cveRevisor2=@cve)  and calificacion is null

select @cont1 as c1,@cont2 as c2
end
go

--Juan Luis Castillo Arriaga
--Actualiza una tupla en la que el campo cveAsesor y el parametro @cveAsesor coinciden
create proc sp_ActualizarAsesor
@cveAsesor varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@correo varchar ( 60 ),
@telefono varchar ( 13 ),@cve_carrera varchar ( 15 ), @titulo varchar(10),
@msj varchar(100) output
as
begin
	begin try
		begin tran
		update Asesores set nombre=@nombre,apPaterno=@apPaterno,apMaterno=@apMaterno,
		correo=@correo,telefono=@telefono,cve_carrera=@cve_carrera, titulo=@titulo where cveAsesor=@cveAsesor
		commit tran 
		set @msj='Datos Actualizados'
	end try
		begin catch 
		rollback tran
		set @msj='Error al actualizar'
		end catch
end
go

----Juan Luis Castillo Arriaga
--Actualiza una tupla en la que el campo cve_carrera y el parametro @clave coinciden de la tabla Carreras
create proc sp_ActualizarCarrera
@clave varchar(15), @nombre varchar(50), @jefe varchar(100), @msj varchar(100) output
as
begin
	begin try
		begin tran
		update Carreras set nombre=@nombre, jefe=@jefe where cve_carrera=@clave
		commit tran 
		set @msj='Datos Actualizados'
	end try
		begin catch 
		rollback tran
		set @msj='Error al actualizar'
		end catch
end
go

--Juan Luis Castillo Arriaga
--Actualiza la tupla de la tabla FechasRev en la que el campo folioProyecto y el parametro @folio coinciden
create proc sp_ActualizarFechasRev
@folio int,
@fecha1 date,
@fecha2 date,
@fecha3 date
as
begin
	update FechasRev set Fecha1=@fecha1, Fecha2=@fecha2,Fecha3=@fecha3 where folioProyecto=@folio
end
go

--Juan Luis Castillo Arriaga
--Actualiza la tupla de la tabla Proyectos en la que el campo matriculaAlumno y el parametro @matriculaAlumno coinciden
--y ejecuta el sp sp_ActualizarFechasRev
create procedure sp_ActualizarProyecto
@matriculaAlumno varchar(10),
@nombreProyecto varchar(50),
@nombreEmpresa varchar(50),
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
		update Proyectos set nombreEmpresa=@nombreEmpresa, nombreProyecto=@nombreProyecto, cveAsesor=@cveAsesor,
				 cveRevisor1=@cveRevisor1, cveRevisor2=@cveRevisor2, periodo=@periodo, inicio=@inicio, fin=@fin
				 where matriculaAlumno=@matriculaAlumno
		set @folio=(select folioProyecto from Proyectos where matriculaAlumno=@matriculaAlumno)
		exec sp_ActualizarFechasRev @folio, @fecha1, @fecha2, @fecha3
	end
	go

--Raymundo Hernandez Fernandez
--Selecciona los campos de la tabla Asesores que coincidan con los campos cveAsesor o con el nombre completo del asesor
create proc sp_BuscarAsesor
@cve varchar(10), @nombre varchar(60),@carrera varchar(10),@cargo varchar(1)
as
begin
	if(@cargo='c')
	begin
		if(@cve='')
			select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera, UPPER(A.titulo) as Titulo from Asesores A inner join Carreras C
			on A.cve_carrera=C.cve_carrera
			where (A.nombre like  @nombre+'%' or A.apPaterno like  @nombre+'%' or A.apMaterno like  @nombre+'%') and c.cve_carrera=@carrera
		if(@nombre='')
		select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera,UPPER(A.titulo) as Titulo from Asesores A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
			where A.cveAsesor like @cve+'%'and c.cve_carrera=@carrera
	end
	if(@cargo='a')
	begin
		if(@cve='')
			select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera, UPPER(A.titulo) as Titulo from Asesores A inner join Carreras C
			on A.cve_carrera=C.cve_carrera
			where (A.nombre like  @nombre+'%' or A.apPaterno like  @nombre+'%' or A.apMaterno like  @nombre+'%')
		if(@nombre='')
		select cveAsesor as [Clave de Asesor],upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno],correo as Correo,telefono as Telefono,UPPER( C.nombre) as Carrera,UPPER(A.titulo) as Titulo from Asesores A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
			where A.cveAsesor like @cve+'%'
	end
end
go

--Raymundo Hernandez Fernandez
--Selecciona los campos requeridos de las tuplas que coincidan con los parametros @matricula y @nombre
create proc sp_BuscarAlumno
@matricula varchar(9), @nombre varchar(60),@carrera varchar(10),@cargo varchar(1)
as
begin
	if(@cargo='c')
	begin
	if(@matricula='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.nombre like @nombre+'%' and a.cve_carrera=@carrera
	if(@nombre='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.matricula like @matricula+'%' and a.cve_carrera=@carrera
	end
	if(@cargo='a')
	begin
		if(@matricula='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.nombre like @nombre+'%' 
		if(@nombre='')
		select matricula as Matricula,upper(A.nombre) as Nombre, upper(apPaterno) as [Apellido Paterno], upper(apMaterno) as [Apellido Materno], telefono as Telefono, correo as Correo,UPPER( C.nombre) as Carrera,sexo as Sexo  from Alumnos A inner join Carreras C
		on A.cve_carrera=C.cve_carrera
		where A.matricula like @matricula+'%'
	end
end
go

--Raymundo Hernandez Fernandez
--Selecciona las tuplas con los campos clave de la carrera, nombre y el jefe de la tabla carreras que coincidan
--el campo cve_carrera y el parametro @clave
create proc sp_BuscarCarrera
@nombre varchar(50), @clave varchar(15)
as
begin
	if(@nombre='')
	begin
		select cve_carrera as Clave, nombre as Nombre, jefe as Encargado from Carreras
		where cve_carrera like @clave+'%'
	end
	if(@clave='')
	begin
		select cve_carrera as Clave, nombre as Nombre, jefe as Encargado from Carreras
		where nombre like @nombre+'%'
	end
end
go

--Raymundo Hernandez Fernandez
--Selecciona las tuplas con los campos necesarios de la tabla proyectos que coincidan con los parametros 
--recibidos @nombreA con el campo de nombre del alumno y @nombrep con el campo de nombre del proyecto
create proc sp_Busqueda_Proyecto
@nombreA varchar(60), @nombreP varchar(60), @carrera varchar(10)
as
begin
	if(@nombreA='')
		select Proyectos.matriculaAlumno as Matricula, Alumnos.nombre+' '+Alumnos.apPaterno as [Nombre Alumno], Proyectos.nombreProyecto as Proyecto, Proyectos.nombreEmpresa as Empresa, Proyectos.calificacion as Calificacion, Proyectos.cveAsesor as Asesor, Proyectos.cveRevisor1 [Revisor 1], Proyectos.cveRevisor2 as [Revisor 2], Proyectos.periodo as Periodo, Proyectos.inicio as Inicio, Proyectos.fin Fin, FechasRev.Fecha1 as [Revision 1], FechasRev.Fecha2 as [Revision 2], FechasRev.Fecha3 as [Revsion 3] from Proyectos inner join Alumnos 
		on Proyectos.matriculaAlumno=Alumnos.matricula 
		inner join Asesores
		on Proyectos.cveAsesor=Asesores.cveAsesor 
		inner join FechasRev
		on Proyectos.folioProyecto=FechasRev.folioProyecto
		where (Proyectos.nombreProyecto like @nombreP+'%') and Alumnos.cve_carrera= @carrera
	if(@nombreP='')
		select Proyectos.matriculaAlumno as Matricula, Alumnos.nombre+' '+Alumnos.apPaterno as [Nombre Alumno], Proyectos.nombreProyecto as Proyecto, Proyectos.nombreEmpresa as Empresa, Proyectos.calificacion as Calificacion, Proyectos.cveAsesor as Asesor, Proyectos.cveRevisor1 [Revisor 1], Proyectos.cveRevisor2 as [Revisor 2], Proyectos.periodo as Periodo, Proyectos.inicio as Inicio, Proyectos.fin Fin, FechasRev.Fecha1 as [Revision 1], FechasRev.Fecha2 as [Revision 2], FechasRev.Fecha3 as [Revsion 3] from Proyectos inner join Alumnos on Proyectos.matriculaAlumno=Alumnos.matricula inner join Asesores on Proyectos.cveAsesor=Asesores.cveAsesor inner join FechasRev on Proyectos.folioProyecto=FechasRev.folioProyecto
		where (Alumnos.nombre like @nombreA+'%' or Alumnos.apPaterno like @nombreA+'%') and Alumnos.cve_carrera= @carrera
end
go

--Juan Luis Castillo Arriaga
--Elimina una tupla de la tabla Alumnos que coincida el campo matricula con el parametro @matricula
create procedure sp_EliminarAlumno
@matricula varchar(10), @msj varchar(100) output
as
begin 
	begin tran
	if not exists(select* from Proyectos where matriculaAlumno=@matricula)
	begin
		delete from Alumnos where matricula=@matricula
		set @msj='Alumno eliminado con exito'
	end
	else
	begin
		set @msj='Primero debe de eliminar el proyecto del alumno'
	end
	commit tran
end 
go

--Juan Luis Castillo Arriaga
--Elimina una tupla de la tabla Asesores que coincida el campo cveAsesor con el parametro @clave
create proc sp_EliminarAsesor
@clave varchar(10), @msj varchar(100) output
as
begin
	begin tran
	if not exists(select* from Proyectos where cveAsesor=@clave or cveRevisor1=@clave or cveRevisor2=@clave)
	begin
		delete from Asesores where cveAsesor=@clave
		set @msj='Asesor eliminado con exito'
	end
	else
	begin
		set @msj='Primero debe de eliminar el(los) proyecto(s) asignado(s) al asesor'
	end
	commit tran
end
go

--Juan Luis Castillo Arriaga
--Elimina una tupla de la tabla Proyectos, Documentos y de la tabla Fechas Rev
create proc sp_EliminarProyecto
@matricula varchar(10)
as
begin
	declare @folio int
	set @folio=(select folioProyecto from Proyectos where matriculaAlumno=@matricula)
	delete from Documentos where folioProyecto=@folio
	delete from FechasRev where folioProyecto=@folio
	delete from Proyectos where matriculaAlumno=@matricula
end
go

--Saul Rocha Gomez
--Inserta un nuevo registro en la tabla FechassRev
create proc sp_InsertarFechasRev
@folio int,@fecha1 date, @fecha2 date, @fecha3 date
as
	begin
		insert into FechasRev(folioProyecto,Fecha1,Fecha2,Fecha3) values(@folio,@fecha1,@fecha2,@fecha3)
	end
	go

--Juan Luis Castillo Arriaga
--Actualiza una tupla de la tabla Alumnos 
create proc sp_modificarAlumnos
@matricula varchar ( 10 ),@nombre varchar ( 30 ),@apPaterno varchar ( 30 ),
@apMaterno varchar ( 30 ),@telefono varchar ( 13 ),@correo varchar ( 100 ),
@cve_carrera varchar ( 15 ),@sexo char(1),
@msj varchar(100) output
as
begin
	begin try
		begin tran t	
		
		update Alumnos set matricula=@matricula, nombre= @nombre , apPaterno= @apPaterno,apMaterno=  @apMaterno,telefono=@telefono,correo=@correo,cve_carrera=@cve_carrera,sexo=@sexo
		where matricula=@matricula
		commit tran t
		set @msj='Datos Agregados'
	End try
		begin catch
		rollback tran t
		set @msj='Error al Agregar los Datos'
		end catch
end
go

--Juan Castillo	
--Se ejecuta cuando en la tabla de Alumno se realiza una actualizacion, despues de que se realiza la actualizacion
--se inserta la operacion en la tabla bitacora_Alumnos
create trigger tg_actualizar_Bitacora_Alumnos
	on Alumnos
	after update
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre_nuevo,nombre_viejo,apPaterno_nuevo,apPaterno_viejo,apMaterno_nuevo,apMaterno_viejo,telefono_nuevo,telefono_viejo,correo_nuevo,correo_viejo,cve_carrera_nuevo,cve_carrera_viejo,sexo_nuevo,sexo_viejo,operacion)
			select deleted.matricula,inserted.nombre,deleted.nombre,inserted.apPaterno,deleted.apPaterno,inserted.apMaterno,deleted.apMaterno,inserted.telefono,deleted.telefono,inserted.correo,deleted.correo,inserted.cve_carrera,deleted.cve_carrera,inserted.sexo,deleted.sexo,'Actualizacion' from deleted inner join inserted on deleted.matricula=inserted.matricula
	end
	go

--Juan Castillo	
--Se ejecuta cuando en la tabla de Alumno se elimina un registro, despues de que se realiza el delete
--se inserta la operacion en la tabla bitacora_Alumnos
create trigger tg_eliminar_Bitacora_Alumnos
	on Alumnos
	after delete
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre_viejo,apPaterno_viejo,apMaterno_viejo,telefono_viejo,correo_viejo,cve_carrera_viejo,sexo_viejo,operacion)
			select matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,'Eliminar' from deleted
	end
	go
--Juan Castillo	
--Se ejecuta cuando en la tabla de Alumno se inserta un nuevo registro, despues de que se realiza el inset
--se inserta la operacion en la tabla bitacora_Alumnos
create trigger tg_Inseratr_Bitacora_Alumnos
	on Alumnos
	after insert
	as
	begin
		insert into bitacora_Alumnos(matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,operacion,cveAsesor)
			select matricula,nombre,apPaterno,apMaterno,telefono,correo,cve_carrera,sexo,'Insertar','nolose' from inserted
	end
	go

--Juan Castillo	
--Se ejecuta cuando en la tabla de Asesores se actualiza un registro, despues de que se realiza el update
--se inserta la operacion en la tabla bitacora_Asesores
create trigger tg_actualizar_bitacora_Asesor
on Asesores
after update
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre_vieho,nombre_nuevo,apPaterno_viejo,apPaterno_nuevo,apMaterno_viejo,apMaterno_nuevo,correo_viejo,correo_nuevo,telefono_viejo,telefono_nuevo,cve_carrera_viejo,cve_carrera_nuevo,titulo_viejo,titulo_nuevo,operacion)
		select deleted.cveAsesor,deleted.nombre,inserted.nombre,deleted.apPaterno,inserted.apPaterno,deleted.apMaterno,inserted.apMaterno,deleted.correo,inserted.correo,deleted.telefono,inserted.telefono,deleted.cve_carrera,inserted.cve_carrera,deleted.titulo,inserted.titulo,'Actualizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
end
go

--Juan Castillo	
--Se ejecuta cuando en la tabla de Asesores se elimina un registro, despues de que se realiza el delete
--se inserta la operacion en la tabla bitacora_Asesores
create trigger tg_eliminar_bitacora_Asesor
on Asesores
after delete
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre_vieho,apPaterno_viejo,apMaterno_viejo,correo_viejo,telefono_viejo,cve_carrera_viejo,titulo_viejo,operacion)
		select deleted.cveAsesor,deleted.nombre,deleted.apPaterno,deleted.apMaterno,deleted.correo,deleted.telefono,deleted.cve_carrera,deleted.titulo,'Eliminar' from deleted
end
go

--Juan Castillo	
--Se ejecuta cuando en la tabla de Asesores se inserta un nuevo registro, despues de que se realiza el insert
--se inserta la operacion en la tabla bitacora_Asesores
create trigger tg_insertar_bitacora_Asesor
on Asesores
after insert
as
begin
	insert into bitacora_Asesores(cveAsesor,nombre,apPaterno,apMaterno,correo,telefono,cve_carrera,operacion,titulo)
		select inserted.cveAsesor,nombre,apPaterno,apMaterno,correo,telefono,cve_carrera,titulo,'Insertar' from inserted
end
go

--A partir de aqui los triggers hacen la misma funcion que en los pasados, insertan despues de eliminar, actualizar e insertar.

create trigger tg_actualizar_Bitacora_Carrera
	on Carreras
	after update
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre_nuevo,nombre_viejo,jefe_nuevo,jefe_viejo,operacion)
			select deleted.cve_carrera,inserted.nombre,deleted.nombre,inserted.jefe,deleted.jefe,'Actualizacion'  
			from deleted inner join inserted on deleted.cve_carrera=inserted.cve_carrera
	end
	go

create trigger tg_eliminar_Bitacora_Carrera
	on Carreras
	after delete
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre_viejo,jefe_viejo,operacion)
			select cve_carrera,nombre,jefe,'Insertar' from deleted
	end
	go

create trigger tg_Insertar_Bitacora_Carrera
	on Carreras
	after insert
	as
	begin
		insert into bitacoras_Carreras(cve_carrera,nombre,jefe,operacion)
			select cve_carrera,nombre,jefe,'Insertar' from inserted
	end
	go

create trigger tg_actualizar_bitacora_Documentos
on Documentos
after update
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia_viejo,SolicitudResidencia_nuevo,AnteProyecto_viejo,AnteProyecto_nuevo,CartaPresentacion_viejo,CartaPresentacion_nuevo,Dictamen_viejo,Dictamen_nuevo,AsignacionExterno_viejo,AsignacionExterno_nuevo,AsignacionInterno_viejo,AsignacionInterno_nuevo,Seguimiento_viejo,Seguimiento_nuevo,RegistrosAsesoria_viejo,RegistrosAsesoria_nuevo,CartaTerminacion_viejo,CartaTerminacion_nuevo,SolicitudRevisor_viejo,SolicitudRevisor_nuevo,AsignacionRevisor1_viejo,AsignacionRevisor1_nuevo,AsignacionRevisor2_viejo,AsignacionRevisor2_nuevo,FormatoEvaluacion_viejo,FormatoEvaluacion_nuevo,CartaAgadecimiento_viejo,CartaAgadecimiento_nuevo,ResumenEjecutivo_viejo,ResumenEjecutivo_nuevo,Informe_viejo,Informe_nuevo,CartaAceptacion_viejo,CartaAceptacion_nuevo,operacion)
		select inserted.folioProyecto,deleted.SolicitudResidencia,inserted.SolicitudResidencia,deleted.AnteProyecto,inserted.AnteProyecto,deleted.CartaPresentacion,inserted.CartaPresentacion,deleted.Dictamen,inserted.Dictamen,deleted.AsignacionExterno,inserted.AsignacionExterno,deleted.AsignacionInterno,inserted.AsignacionInterno,deleted.Seguimiento,inserted.Seguimiento,deleted.RegistrosAsesoria,inserted.RegistrosAsesoria,deleted.CartaTerminacion,inserted.CartaTerminacion,deleted.SolicitudRevisor,inserted.SolicitudRevisor,deleted.AsignacionRevisor1,inserted.AsignacionRevisor1,deleted.AsignacionRevisor2,inserted.AsignacionRevisor2,deleted.FormatoEvaluacion,inserted.FormatoEvaluacion,deleted.CartaAgadecimiento,inserted.CartaAgadecimiento,deleted.ResumenEjecutivo,inserted.ResumenEjecutivo,deleted.Informe,inserted.Informe,deleted.CartaAceptacion,inserted.CartaAceptacion,'Actualizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end
go

create trigger tg_eliminar_bitacora_Documentos
on Documentos
after delete
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia_viejo,AnteProyecto_viejo,CartaPresentacion_viejo,Dictamen_viejo,AsignacionExterno_viejo,AsignacionInterno_viejo,Seguimiento_viejo,RegistrosAsesoria_viejo,CartaTerminacion_viejo,SolicitudRevisor_viejo,AsignacionRevisor1_viejo,AsignacionRevisor2_viejo,FormatoEvaluacion_viejo,CartaAgadecimiento_viejo,ResumenEjecutivo_viejo,Informe_viejo,CartaAceptacion_viejo,operacion)
		select folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,'Eliminar' from deleted
end
go


create trigger tg_insertar_bitacora_Documentos
on Documentos
after insert 
as
begin 
	insert into bitacora_Documentos(folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,operacion)
		select folioProyecto,SolicitudResidencia,AnteProyecto,CartaPresentacion,Dictamen,AsignacionExterno,AsignacionInterno,Seguimiento,RegistrosAsesoria,CartaTerminacion,SolicitudRevisor,AsignacionRevisor1,AsignacionRevisor2,FormatoEvaluacion,CartaAgadecimiento,ResumenEjecutivo,Informe,CartaAceptacion,'Insertar' from inserted
end
go

create trigger tg_actualizar_Bitacora_FechasRev
on FechasRev
after update
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1_nuevo,Fecha1_viejo,Fecha2_nuevo,Fecha2_viejo,Fecha3_nuevo,Fecha3_viejo,operacion)
		select inserted.folioProyecto,inserted.Fecha1,deleted.Fecha1,inserted.Fecha2,deleted.Fecha2,inserted.Fecha3,deleted.Fecha3,'Actualizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end
go

create trigger tg_eliminar_Bitacora_FechasRev
on FechasRev
after delete
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1_viejo,Fecha2_viejo,Fecha3_viejo,operacion)
		select folioProyecto,Fecha1,Fecha2,Fecha3,'Eliminar' from deleted
end
go

create trigger tg_insertar_Bitacora_FechasRev
on FechasRev
after insert
as
begin
	insert into bitacora_FechasRev(folioProyecto,Fecha1,Fecha2,Fecha3,operacion)
		select folioProyecto,Fecha1,Fecha2,Fecha3,'Insertar' from inserted
end
go

create trigger tg_actualizar_bitacora_Proyectos
on Proyectos
after update
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto_viejo,nombreProyecto_nuevo,nombreEmpresa_viejo,nombreEmpresa_nuevo,cveAsesor_viejo,cveAsesor_nuevo,cveRevisor1_viejo,cveRevisor1_nuevo,cveRevisor2_viejo,cveRevisor2_nuevo,periodo_viejo,periodo_nuevo,inicio_viejo,inicio_nuevo,fin_viejo,fin_nuevo,operacion)
		select deleted.folioProyecto,deleted.matriculaAlumno,deleted.nombreProyecto,inserted.nombreProyecto,deleted.nombreEmpresa,inserted.nombreEmpresa,deleted.cveAsesor,inserted.cveAsesor,deleted.cveRevisor1,inserted.cveRevisor1,deleted.cveRevisor2,inserted.cveRevisor2,deleted.periodo,inserted.periodo,deleted.inicio,inserted.inicio,deleted.fin,inserted.fin,'Actalizacion' from deleted inner join inserted on deleted.folioProyecto=inserted.folioProyecto
end
go

create trigger tg_eliminar_bitacora_Proyectos
on Proyectos
after delete
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto_viejo,nombreEmpresa_viejo,cveAsesor_viejo,cveRevisor1_viejo,cveRevisor2_viejo,periodo_viejo,inicio_viejo,fin_viejo,operacion)
		select folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,'Eliminar' from deleted
end
go

create trigger tg_insertar_bitacora_Proyectos
on Proyectos
after insert
as 
begin
	insert into bitacora_Proyectos(folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,operacion)
		select folioProyecto,matriculaAlumno,nombreProyecto,nombreEmpresa,cveAsesor,cveRevisor1,cveRevisor2,periodo,inicio,fin,'Insert' from inserted
end
go

create trigger tg_Documentos
on Proyectos
after insert
as
begin
	insert into Documentos values((select folioProyecto from inserted),0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)
end
go

create trigger tg_actualizar_Bitacora_Usuarios
	on Usuarios
	after update
	as
	begin
		insert into bitacora_Usuarios(NombreUser_nuevo,NombreUser_viejo,Contraseña_nuevo,Contraseña_viejo,Cargo_nuevo,Cargo_viejo,cveAsesor_nuevo,cveAsesor_viejo,operacion)
			select inserted.NombreUser,deleted.NombreUser,inserted.Contraseña,deleted.Contraseña,inserted.Cargo,deleted.Cargo,inserted.cveAsesor,deleted.cveAsesor,'Actalizacion' from deleted inner join inserted on deleted.cveAsesor=inserted.cveAsesor
	end
	go

create trigger tg_eliminar_Bitacora_Usuarios
	on Usuarios
	after delete
	as
	begin
		insert into bitacora_Usuarios(NombreUser_viejo,Contraseña_viejo,Cargo_viejo,cveAsesor,operacion)
			select NombreUser,Contraseña,Cargo,cveAsesor,'Eliminar' from deleted
	end
	go

create trigger tg_insertar_Bitacora_Usuarios
	on Usuarios
	after insert
	as
	begin
		insert into bitacora_Usuarios(NombreUser,Contraseña,Cargo,cveAsesor,operacion)
			select NombreUser,Contraseña,Cargo,cveAsesor,'Insertar' from inserted
	end
	go
	
insert into Carreras VALUES('ISIC','SISTEMAS COMPUTACIONALES','ING JOSE LUIS MOTA ESPELETA')
go
INSERT INTO Asesores values('A001','JOSE LUIS','MOTA','ESPELETA','jlca668@gmail.com','8722954480','ISIC','ING')
go
insert into Usuarios(NombreUser,Contraseña,Cargo,cveAsesor) values('adm','MQAyADMANAA=','Administrador','A001')
go --usuario: adm  contraseña:1234