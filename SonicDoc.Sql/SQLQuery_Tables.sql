use ydRSoftWeb
go

--- SELECT CAST(table_name as varchar)  FROM INFORMATION_SCHEMA.TABLES


create table Paciente(
	DNI varchar(8) primary key not null,
	Nombres varchar(50),
	Apellidos varchar(50),
	Edad int not null,
	Sexo int not null

)