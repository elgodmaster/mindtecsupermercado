-- Graba una nueva contrase�a para un usuario.

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

DECLARE @nuevaContrase�a	VARCHAR(8000)
DECLARE @usuario			VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nuevaContrase�a 	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @usuario			 	Output 

Update SMercado_Seguridad..Usuarios
Set Pass = @nuevaContrase�a 
Where nombreUsuario  = @usuario
	
END