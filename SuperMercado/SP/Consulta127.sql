-- Consulta el detalle de una venta.

DROP PROC dbo.Consulta127
GO

CREATE PROCEDURE dbo.Consulta127
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE	@idVenta	VARCHAR(8000)
DECLARE	@cajero 	VARCHAR(8000)
DECLARE	@fecha  	VARCHAR(8000)
DECLARE	@total  	VARCHAR(8000)

SET noCount ON

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idVenta 	Output 

Select C1 = VD.cantidad,
       C2 = VD.Descripcion,
       C3 = CONVERT(decimal(12,2),(VD.cantidad * VD.PrecioUni * VD.Descuento)),
       C4 = VD.IdDetalleVentas 
From SMercado..Venta_detalles VD
Where VD.IdVenta = @idVenta

IF @@ROWCOUNT = 0
	BEGIN
		Select @Resul = '2R=ERROR|'
		Return
	END
	
Select @cajero	= (Select U.nombreCompleto From SMercado..Ventas V 
				   Inner join SMercado_Seguridad..Usuarios U ON V.IdUsuario = U.idUsuario
				   Where IdVenta = @idVenta)
				  
Select @fecha	= (Select V.Fecha from SMercado..Ventas V
			       Where IdVenta = @idVenta)
			     
Select @total	= (Select SUM(VD.PrecioUni * VD.Descuento * VD.cantidad) from SMercado..Venta_detalles VD
                   Where VD.IdVenta = @idVenta 
                   Group by VD.IdVenta ) 
                   
Select @Resul = 'V0=OK|V1=' + @idVenta + '|V2=' + @cajero + '|V3=' + @fecha + '|V4=' + RTRIM(CONVERT(char, CONVERT(decimal(12,2),@total))) + '|'

Select resul = @Resul 

END