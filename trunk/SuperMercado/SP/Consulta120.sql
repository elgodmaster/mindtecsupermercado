-- Consulta regresa OK si un nombre la contraseņa de un
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
DECLARE @nomCompleto	VARCHAR(8000)
DECLARE @idUsuario		VARCHAR(8000)

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
	  
SELECT @nomCompleto = (Select U.nombreCompleto    
					   From SMercado_Seguridad..Usuarios U
	                   Where U.nombreUsuario = @nomUsuario )
	                   
SELECT @idUsuario = (SELECT U.idUsuario 
					 FROM SMercado_Seguridad.. Usuarios U
					 WHERE U.nombreUsuario = @nomUsuario)
	  	  
If @@ROWCOUNT > 0
	BEGIN
		Select @Resul = '2R=OK|3R=' + @nomCompleto + '|4R=' + @idUsuario + '|'
	END
ELSE
	BEGIN
		Select @Resul = '2R=ERROR2|'
	END
	
	Select resul = @Resul 
	
END