use bdsonicdoc
go

CREATE PROCEDURE sp_Insert_Usuario
	 @dni varchar(8),
	 @clave varchar(20),	 
	 @nombres varchar(100), 
	 @apellidos varchar(30),
	 @sexo int,
	 @ID int output
AS
	set nocount on
	begin try
		set @ID = (select top(1) ID from Usuario order by ID desc)
		if @ID is not null
		begin
			set @ID = @ID + 1
		end
		else
		begin
			set @ID = 1
		end		

		insert into Usuario values(@ID,@dni,@clave,@nombres,@apellidos,20,@sexo,'cell','direc','correo',1)

		return @ID
	end try
	begin catch
		set @ID = 0
		return -1
	end catch
GO

CREATE PROCEDURE sp_Insert_Especialidad
	 @iduser int,
	 @idesp int,
	 @ID int output
AS
	set nocount on
	begin try
		set @ID = (select top(1) ID from Doctor order by ID desc)
		if @ID is not null
		begin
			set @ID = @ID + 1
		end
		else
		begin
			set @ID = 1
		end

		insert into Doctor values(@ID,@iduser,@idesp,1)

		return @ID
	end try
	begin catch
		set @ID = 0
		return -1
	end catch
GO

CREATE PROCEDURE sp_Insert_Doctor
	 @idesp int,
	 @dni varchar(8),
	 @clave varchar(20),	 
	 @nombres varchar(100), 
	 @apellidos varchar(30),
	 @sexo int,
	 @ID int output
AS
	set nocount on
	begin try
		set @ID = (select top(1) ID from Usuario order by ID desc)
		if @ID is not null
		begin
			set @ID = @ID + 1
		end
		else
		begin
			set @ID = 1
		end		

		declare @iduser int

		set @iduser = @ID
		insert into Usuario values(@iduser,@dni,@clave,@nombres,@apellidos,20,@sexo,'cell','direc','correo',2)

		set @ID = (select top(1) ID from Doctor order by ID desc)
		if @ID is not null
		begin
			set @ID = @ID + 1
		end
		else
		begin
			set @ID = 1
		end		

		insert into Doctor values(@ID,@iduser,@idesp,1)

		return @ID
	end try
	begin catch
		set @ID = 0
		return -1
	end catch
GO


CREATE PROCEDURE sp_Insert_Reserva
	 @iduser int,
	 @iddoc int,	 
	 @fecha date, 
	 @idturno int,
	 @idestado int,
	 @ID int output
AS
	set nocount on
	begin try
		set @ID = (select top(1) ID from Reserva order by ID desc)
		if @ID is not null
		begin
			set @ID = @ID + 1
		end
		else
		begin
			set @ID = 1
		end		

		insert into Reserva values(@ID,@iduser,@iddoc,@fecha,@idturno,@idestado,GETDATE())

		return @ID
	end try
	begin catch
		set @ID = 0
		return -1
	end catch
GO

