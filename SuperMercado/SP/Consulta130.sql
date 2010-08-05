-- Consulta regresa el estado de cuenta de un Proveedor

DROP PROC dbo.Consulta130
GO

CREATE PROCEDURE dbo.Consulta130
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @nomProveed	VARCHAR(8000)
DECLARE @idProveed  VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idProveed 	Output 

select	C1 = C.IdCuenta, 

		C2 = C.Descripcion, 
		
		C3 = '$ ' + CONVERT(char, CONVERT(decimal(18,2), (Select SUM( CD.PrecioUni * CD.cantidad )
				 From SMercado..Cuentas_Pagar_Detalles CD
				 Where IdCuenta = C.IdCuenta 
				 Group by IdCuenta ))),
				 
		C4 = '$ ' + CONVERT(char, C.adeudo),
				 
		C5 = '$ ' + CONVERT(char, isnull((Select SUM(CA.monto)
				  From SMercado..Cuentas_Pagar_Abonos CA
				  Where idCuenta = C.IdCuenta 
				  Group by CA.idCuenta), 0)),
		C6 = C.fecha 		  
				  
from SMercado..Cuentas_Pagar C
Where	C.idProveedor = @idProveed 
and C.Adeudo <> 0

Select @Resul = '2R=OK|'

END