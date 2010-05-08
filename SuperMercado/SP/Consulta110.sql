-- Consulta la fecha más reciente de los registros en Caja_Corte

drop proc dbo.Consulta110
go

CREATE PROCEDURE dbo.Consulta110
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
 
 AS
 BEGIN
	Set NoCount ON
	-------------------------
	-- Tabla SM_Caja_Corte
	-------------------------
	
	Declare @registro	int	
	Declare @fecha      date
	Declare @existe     bit
	
	Select top 1 @fecha =  ISNULL(fecha, '') from SMercado..Caja_Corte
	Order by fecha DESC
	
	Select @registro = @@ROWCOUNT 
	
	IF @registro = 0
		BEGIN
			Select @resul = '2R=ERROR'
		END
	ELSE
		BEGIN
			Select @resul = '2R=OK|2M=' + CONVERT( varchar(8000), @fecha) +'|' 
		END
	
	Select C.idCorte  
	From SMercado..Caja_Corte C
	Where fecha = Convert(date, GETDATE())
	
	Select @registro = @@rowcount 
	
	IF @registro > 0
		BEGIN
			Select @existe = 1
		END
	ElSE
		BEGIN
			Select @existe = 0
		END
	Select fecha = @fecha, Existe = @existe 
	 
	set NoCount OFF	
END
