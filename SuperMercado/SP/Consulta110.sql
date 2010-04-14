-- Consulta la fecha más reciente de los registros en Caja_Corte

drop proc dbo.Consulta110
go

CREATE PROCEDURE dbo.Consulta110 (
 @fecha		varchar(20) output,
 @resul		varchar(20) output 
 )
 
 AS
 BEGIN
	Set NoCount ON
	-------------------------
	-- Tabla SM_Caja_Corte
	-------------------------
	
	Declare @registro	int	

	Select top 1 @fecha =  ISNULL(fecha, '') from SMercado..Caja_Corte
	Order by fecha DESC
	
	Select @registro = @@ROWCOUNT 
	
	IF @registro = 0
		BEGIN
			Select @resul = 'ERROR'
		END
	ELSE
		BEGIN
			Select @resul = 'OK'
		END
	
	set NoCount OFF	
END
