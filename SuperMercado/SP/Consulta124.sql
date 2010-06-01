-- Consulta que regresa los campos de un usuario.

DROP PROC dbo.Consulta124
GO

CREATE PROCEDURE dbo.Consulta124
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Set noCount ON

DECLARE	@nombreUsuario	VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nombreUsuario 	Output 

Select U.nombreUsuario, U.Pass, U.nombreCompleto, P.nomPermiso  
From SMercado_Seguridad..Usuarios U
Inner join SMercado_Seguridad..Permisos P ON U.idPermiso = P.idPermiso 
Where U.nombreUsuario = @nombreUsuario

IF @@ROWCOUNT = 0
	BEGIN
		Select @Resul = '2R=ERROR|'
	END
ELSE
	BEGIN
		Select @Resul = '2R=OK|'
	END
END