-- Liquida una cuenta dado el nombre de un cliente.

drop proc dbo.eliminar104
go

CREATE PROCEDURE dbo.eliminar104
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

DECLARE @idCuenta	varchar(8000)
DECLARE @adeudo     varchar(8000)
DECLARE @nomCliente varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCuenta	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @adeudo		Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @nomCliente	Output 

Delete from SMercado..Cuentas_Cobrar
Where IdCuenta = @idCuenta

Delete from SMercado..Cuentas_Cobrar_Detalles
Where IdCuenta = @idCuenta

Update SMercado..Cat_Clientes
Set Adeudo = Adeudo - CONVERT(decimal(12,2),@adeudo)
Where NombreFiscal = @nomCliente 

END