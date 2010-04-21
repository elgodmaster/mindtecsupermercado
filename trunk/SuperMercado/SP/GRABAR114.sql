drop proc dbo.GRABAR114
go

CREATE PROCEDURE dbo.GRABAR114
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @dinIniAct	varchar(8000)
DECLARE @monDinIni	varchar(8000)
DECLARE @monMaxAct	varchar(8000)
DECLARE @monMax 	varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @dinIniAct    Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @monDinIni	 Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @monMaxAct    Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @monMax		 Output 

UPDATE SMercado..Caja_Configuracion SET 
	    dinIniAct = CONVERT(bit, @dinIniAct),
		monDinIni = CONVERT(decimal, @monDinIni),
		monMaxAct = CONVERT(bit, @monMaxAct),
		monMax = CONVERT(decimal, @monMax)
		where idCajaConfig = 1
		
Select @Resul = '2R=OK'

END