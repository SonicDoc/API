create database bdsonicdoc
COLLATE Latin1_General_100_CS_AS
Go
--- SELECT CAST(table_name as varchar)  FROM INFORMATION_SCHEMA.TABLES

Use bdsonicdoc
go


create table Especialidad(
	ID int primary key not null,
	Nombre varchar(60) not null,	
)
GO

insert into Especialidad values(0,'-')
insert into Especialidad values(1,'Cardiologia')
insert into Especialidad values(2,'Dermatologia')
insert into Especialidad values(3,'Ecografia')
insert into Especialidad values(4,'Endocrino')
insert into Especialidad values(5,'Gastroenterologia')
insert into Especialidad values(6,'Geriatria')
insert into Especialidad values(7,'Hematologia')
insert into Especialidad values(8,'Neurologia')
insert into Especialidad values(9,'Nutricion')
insert into Especialidad values(10,'Odontologia')
insert into Especialidad values(11,'Oftanmologia')
insert into Especialidad values(12,'Pediatria')
insert into Especialidad values(13,'Psicologia')
insert into Especialidad values(14,'Traumatologia')
insert into Especialidad values(15,'Urologia')
GO

create table Usuario_Estado(
	ID int primary key  not null,
	Nombre varchar(20)
)
GO

insert into Usuario_Estado values(1,'USUARIO')
insert into Usuario_Estado values(2,'DOCTOR')
GO

create table Usuario(
	ID int primary key  not null,
	DNI varchar(8) unique not null,
	Clave varchar(20) not null,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	Edad int not null,
	Sexo int not null,
	Celular varchar(15),
	Direccion varchar(100),
	Correo varchar(50),
	ID_Estado int not null
)
GO

ALTER TABLE Usuario
WITH CHECK ADD  CONSTRAINT FK_Usuario_Estado FOREIGN KEY(ID_Estado)
REFERENCES Usuario_Estado (ID)
GO

insert into Usuario values(1,'43114343','1234','YADER PHOOL','COÑAS HOSPINO',20,1,'cel','direc','correo',2)
insert into Usuario values(2,'12345678','1234','KARLA ARIANA','COÑAS OSIS',20,2,'cel','direc','correo',2)
insert into Usuario values(3,'12349875','1234','JUAN PEREZ','MALDONADO LLANOS',20,1,'cel','direc','correo',1)

create table Doctor(
	ID int primary key  not null,
	ID_Usuario int not null,
	ID_Espec int not null,
	Estado int not null
)
GO

insert into Doctor values(1,1,4,1)
insert into Doctor values(2,2,8,1)
GO

ALTER TABLE Doctor
WITH CHECK ADD  CONSTRAINT FK_Doc_Usuario FOREIGN KEY(ID_Usuario)
REFERENCES Usuario (ID)
GO

ALTER TABLE Doctor
WITH CHECK ADD  CONSTRAINT FK_Doc_Espe FOREIGN KEY(ID_Espec)
REFERENCES Especialidad (ID)
GO

create table Turno(
	ID int primary key not null,
	Nombre varchar(40),	
)
GO

insert into Turno values(1,'08:00 - 08:30')
insert into Turno values(2,'08:30 - 09:00')
insert into Turno values(3,'09:00 - 09:30')
insert into Turno values(4,'09:30 - 10:00')
insert into Turno values(5,'10:00 - 10:30')
insert into Turno values(6,'10:30 - 11:00')
insert into Turno values(7,'11:00 - 11:30')
insert into Turno values(8,'11:30 - 12:00')
insert into Turno values(9,'12:00 - 12:30')
insert into Turno values(10,'12:30 - 13:00')
insert into Turno values(11,'13:00 - 13:30')
insert into Turno values(12,'13:30 - 14:00')
insert into Turno values(13,'14:00 - 14:30')
insert into Turno values(14,'14:30 - 15:00')
insert into Turno values(15,'15:00 - 15:30')
insert into Turno values(16,'15:30 - 16:00')
insert into Turno values(17,'16:00 - 16:30')
insert into Turno values(18,'16:30 - 17:00')
insert into Turno values(19,'17:00 - 17:30')
insert into Turno values(20,'17:30 - 18:00')
GO

create table Reserva_Estado(
	ID int primary key not null,
	Nombre varchar(30) not null,	
)
GO

insert into Reserva_Estado values(1,'RESERVADO')
insert into Reserva_Estado values(2,'ACEPTADO')
insert into Reserva_Estado values(3,'CANCELADO')
insert into Reserva_Estado values(4,'POSTERGADO')
insert into Reserva_Estado values(5,'ELIMINADO')
Go

create table Reserva(
	ID int primary key not null,
	ID_Usuario int not null,
	ID_Doc int not null,
	Fecha date not null,
	ID_Turno int not null,
	ID_Estado int not null,
	Fecha_Reg datetime
)

insert into Reserva values(1,3,1,GETDATE(),3,1,GETDATE())
insert into Reserva values(2,3,2,GETDATE(),7,1,GETDATE())

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Usuario FOREIGN KEY(ID_Usuario)
REFERENCES Usuario (ID)
GO

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Doctor FOREIGN KEY(ID_Doc)
REFERENCES Doctor (ID)
GO

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Turno FOREIGN KEY(ID_Turno)
REFERENCES Turno (ID)
GO

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Estado FOREIGN KEY(ID_Estado)
REFERENCES Reserva_Estado (ID)
GO