-- Consulta regresa el detalle de una cuenta por cobrar

DROP PROC dbo.Consulta118a
GO

CREATE PROCEDURE dbo.Consulta118a
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
				C3		= D.PrecioUni,
				C4		= '% ' + CONVERT(char, (100 - D.Descuento * 100)),
				C5		= CONVERT(decimal(12,2),D.PrecioUni * D.cantidad * D.Descuento)
		From SMercado..Cuentas_Cobrar_Detalles D
		Where D.IdCuenta = @idCuenta 
		
END