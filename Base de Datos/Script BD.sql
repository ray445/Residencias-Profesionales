create database Residencias

--nombre, apellido, matricula, telefono, correo, carrera, sexo
create table Alumnos ( 
matricula varchar(10) primary key,
nombre varchar(30) not null,
apPaterno varchar(30) not null,
apMaterno varchar(30) not null,
telefono varchar(13) null,
correo varchar(100) not null,
cve_carrera varchar(50) not null,
sexo char(1) not null,
)

create table Carreras(
cve_carrera varchar(15) primary key,
nombre varchar(50) not null unique
)

create table Usuarios(
NombreUser varchar(30) not null,
Contraseña varchar(30) not null,
Cargo varchar(30) not null
)

create table FechasRev(
Fecha1 date,
Fecha2 date,
Fecha3 date,
Fecha4 date,
Fecha5 date
)

create table Asesores(
nombre varchar(30) not null,
correo varchar(60) not null,
telefono varchar(13)
)
