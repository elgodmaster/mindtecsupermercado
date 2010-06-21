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
	Declare @fecha      varchar(8000)
	Declare @existe     bit
	Declare @usuario    varchar(8000)
	Declare @idUsuario  varchar(8000)
	
	Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @usuario	 Output 
	
	Select @idUsuario = (Select U.idUsuario 
						 From SMercado_Seguridad..Usuarios U 
				         Where U.nombreUsuario = @usuario)
	
	Select @fecha = (Select C.fecha 
	                 From SMercado..Caja_Corte C
	                 Where C.fecha = CONVERT(date, GETDATE()) and
	                 C.usuario = @idUsuario)
	      
	Select @fecha = ISNULL(@fecha, '')
	
	Select fecha = @fecha, idUsuario = @idUsuario, usuario = @usuario
	
	set NoCount OFF	
END
