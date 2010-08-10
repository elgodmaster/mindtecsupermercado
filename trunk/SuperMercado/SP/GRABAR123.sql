-- Graba un abono, y actualiza el adeudo en la tabla Cuentas Cobrar.

drop proc dbo.GRABAR123
go

CREATE PROCEDURE dbo.GRABAR123
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

DECLARE @impresora		varchar(8000)
DECLARE @linea1			varchar(8000)
DECLARE @linea2			varchar(8000)
DECLARE @linea3			varchar(8000)
DECLARE @linea4			varchar(8000)
DECLARE @linea5			varchar(8000)
DECLARE @linea6			varchar(8000)
DECLARE @linea7			varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @impresora	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @linea1		Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @linea2		Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @linea3		Output 
Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @linea4		Output 
Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @linea5		Output 
Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @linea6		Output 
Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @linea7		Output 

Update SMercado..Config_Ticket 
Set impresora = @impresora,
    lineaCabezero1 = @linea1,
    lineaCabezero2 = @linea2,
    lineaCabezero3 = @linea3,
    lineaCabezero4 = @linea4,
    lineaPie1 = @linea5,
    lineaPie2 = @linea6,
    lineaPie3 = @linea7
Where idConfig = 1

Select @Resul = '2R=OK|2M=Se guardaron los cambios correctamente.'

END