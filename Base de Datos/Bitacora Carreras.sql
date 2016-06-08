create table bitacoras_Carreras(
id_bitacoraC int identity,
cve_carrera varchar(15),
nombre varchar(50),
nombre_nuevo varchar(50),
nombre_viejo varchar(50),
operacion varchar(15) not null,
cveAsesor varchar(10))