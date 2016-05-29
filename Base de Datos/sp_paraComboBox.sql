

alter proc comboCarrera
as
begin
	select cve_carrera as cve,nombre from carreras
	order by nombre
end

