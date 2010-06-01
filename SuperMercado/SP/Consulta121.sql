-- Consulta que regresa los nombres de los usuarios
-- del sistema.

DROP PROC dbo.Consulta121
GO

CREATE PROCEDURE dbo.Consulta121
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select U.nombreUsuario, U.nombreCompleto 
From SMercado_Seguridad..Usuarios U
Where U.activo = 1

Select @Resul = '2R=OK|PERMISOS=Catálogo de usuarios|VALCOL=87*400|'

Select resultado = @resul
	
END