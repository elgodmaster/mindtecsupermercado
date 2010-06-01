-- Graba una nueva contraseña para un usuario.

DROP PROC dbo.GRABAR120
GO

CREATE PROCEDURE dbo.GRABAR120
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @nuevaContraseña	VARCHAR(8000)
DECLARE @usuario			VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nuevaContraseña 	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @usuario			 	Output 

Update SMercado_Seguridad..Usuarios
Set Pass = @nuevaContraseña 
Where nombreUsuario  = @usuario
	
END