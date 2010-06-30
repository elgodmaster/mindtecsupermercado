-- Consulta regresa el estado de cuenta de un cliente.

DROP PROC dbo.Consulta117
GO

CREATE PROCEDURE dbo.Consulta117
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @idCliente	VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCliente	Output 

select	C1 = C.IdCuenta, 

		C2 = C.Descripcion, 
		
		C3 = '$ ' + CONVERT(char, CONVERT(decimal(18,2), (Select SUM( CD.PrecioUni * CD.cantidad * CD.Descuento )
				 From SMercado..Cuentas_Cobrar_Detalles CD
				 Where IdCuenta = C.IdCuenta 
				 Group by IdCuenta ))),
				 
		C4 = '$ ' + CONVERT(char, C.adeudo),
				 
		C5 = '$ ' + CONVERT(char, isnull((Select SUM(CA.monto)
				  From SMercado..Cuentas_Abonos CA
				  Where idCuenta = C.IdCuenta 
				  Group by CA.idCuenta), 0))
				  
from SMercado..Cuentas_Cobrar C
Where	C.CodigoCliente = @idCliente
and C.Adeudo <> 0

Select @Resul = '2R=OK|'

END