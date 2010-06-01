-- Consulta regresa OK si un nombre la contraseña de un
-- usuario especificado es correcta.

DROP PROC dbo.Consulta120
GO

CREATE PROCEDURE dbo.Consulta120
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @nomUsuario		VARCHAR(8000)
DECLARE @pass			VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nomUsuario 	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @pass		Output

Set NoCount On

Select U.idUsuario 
From SMercado_Seguridad.. Usuarios U
Where U.nombreUsuario = @nomUsuario 
If @@ROWCOUNT = 0
	BEGIN
		Select @Resul = '2R=ERROR1|'
		Select resul = @Resul 
		RETURN
	END

Select U.idUsuario 
From SMercado_Seguridad.. Usuarios U
Where U.nombreUsuario = @nomUsuario and
	  U.Pass = @pass 
	  
If @@ROWCOUNT > 0
	BEGIN
		Select @Resul = '2R=OK|3R=' + (Select U.nombreCompleto 
									   From SMercado_Seguridad..Usuarios U
									   Where U.nombreUsuario = @nomUsuario) + '|'
	END
ELSE
	BEGIN
		Select @Resul = '2R=ERROR2|'
	END
	
	Select resul = @Resul 
	
END