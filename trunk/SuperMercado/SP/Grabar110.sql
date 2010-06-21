drop proc dbo.GRABAR110
go

CREATE PROCEDURE dbo.GRABAR110
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @monto		varchar(8000)
DECLARE @idUsuario  varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @monto		 Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @idUsuario    Output 

Insert into SMercado..Caja_Corte values (1, 
										 @idUsuario, 
										 CONVERT(decimal, @monto), 
										 CONVERT(decimal, @monto),
										 CONVERT(date, GETDATE()))
		
Select @Resul = '2R=OK'

END