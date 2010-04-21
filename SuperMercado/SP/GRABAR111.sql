-- Inserciones en la tabla Caja_Entrada

drop proc dbo.GRABAR111
go

CREATE PROCEDURE dbo.GRABAR111
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @idCaja		varchar(8000)
DECLARE @idUsuario	varchar(8000)
DECLARE @Monto	varchar(8000)
DECLARE @Concepto	varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCaja    Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @idUsuario Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Monto     Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Concepto  Output 

Insert into SMercado..Caja_Entrada values ( @idCaja, @idUsuario, convert( decimal(18,2), @monto), @Concepto, GETDATE() )
-- Se actualiza la Caja_Corte
Update SMercado..Caja_Corte set dineroActual = dineroActual + convert( decimal(18,2), @monto)
where CONVERT(date, fecha) = CONVERT(date, GETDATE() )

Select @Resul = '2R=OK|2M=El monto ha sido ingresado con éxito.'

END