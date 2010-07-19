-- Consulta regresa el detalle de una cuenta por pagar
-- a un proveedor.

DROP PROC dbo.Consulta131
GO

CREATE PROCEDURE dbo.Consulta131
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @idCuenta	VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCuenta	Output 

		Select	C1		= D.Descripcion,
				C2		= D.cantidad,
				C3		= '$ ' + CONVERT(char, D.PrecioUni),
				C4		= '$ ' + CONVERT(char, (CONVERT(decimal(12,2),D.PrecioUni * D.cantidad ))),
				C5      = D.IdCuentaDetalle
		From SMercado..Cuentas_Pagar_Detalles D
		Where D.IdCuenta = @idCuenta 
		
END