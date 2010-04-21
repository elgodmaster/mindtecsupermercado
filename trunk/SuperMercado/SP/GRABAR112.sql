-- Ingresa las salidas en la tabla Caja_Salidas

drop proc dbo.GRABAR112
go

CREATE PROCEDURE dbo.GRABAR112
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @registros		int  -- Para las validaciones.
DECLARE @dineroEnCaja	decimal(18,2)
DECLARE @idCaja		varchar(8000)
DECLARE @idUsuario	varchar(8000)
DECLARE @Monto		varchar(8000)
DECLARE @Concepto	varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCaja    Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @idUsuario Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Monto     Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Concepto  Output 

IF LEN(RTRIM(LTRIM(@concepto))) = 0
BEGIN
	Select @resul = '2R=ERROR1|2M=No se ha especificado el concepto.|'
	Select error = @resul
	return
END

Select @dineroEnCaja = dineroActual from SMercado..Caja_Corte 
where CONVERT( date, getdate() ) = fecha

IF CONVERT(decimal(18,2), @monto) > @dineroEnCaja
BEGIN
	Select @resul = '2R=ERROR2|2M=La suma a retirar es mayor que el monto actual en la caja|'
	Select error = @resul
	return
END

Insert into SMercado..caja_salida values ( @idCaja, @idUsuario, convert( decimal(18,2), @monto), @Concepto, GETDATE() )
-- Se actualiza el Caja_Corte
Update SMercado..Caja_Corte set dineroActual = dineroActual - convert( decimal(18,2), @monto)
where CONVERT(date, fecha) = CONVERT(date, GETDATE() ) 

Select @Resul = '2R=OK|2M=El monto ha sido retirado con éxito.'



END