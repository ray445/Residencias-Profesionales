

--use Residencias

--Script para la creacion de las tablas de la bitacora

create table bitacora_Alumnos ( 
matricula varchar(10) primary key,
nombre varchar(30) not null,
nombre_nuevo varchar(30) not null,
nombre_viejo varchar(30) not null,
apPaterno varchar(30) not null,
apPaterno_nuevo varchar(30) not null,
apPaterno_viejo varchar(30) not null,
apMaterno varchar(30) not null,
apMaterno_nuevo varchar(30) not null,
apMaterno_viejo varchar(30) not null,
telefono varchar(13) null,
telefono_nuevo varchar(13) null,
telefono_viejo varchar(13) null,
correo varchar(100) not null,
correo_nuevo varchar(100) not null,
correo_viejo varchar(100) not null,
cve_carrera varchar(50) not null,
cve_carrera_nuevo varchar(50) not null,
cve_carrera_viejo varchar(50) not null,
sexo char(1) not null,
sexo_nuevo char(1) not null,
sexo_viejo char(1) not null,
)