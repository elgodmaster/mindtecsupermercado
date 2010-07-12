-- Devolución: Elimina un artículo de la tabla
-- VentaDetalles e inserta un registro en la tabla
-- devoluciones.

drop proc dbo.GRABAR126
go

CREATE PROCEDURE dbo.GRABAR126
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

DECLARE @numArt 				varchar(8000)
DECLARE @totArt					varchar(8000)
DECLARE @idVentaDetalle		 	varchar(8000)
DECLARE @idProducto				varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @numArt			Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @totArt			Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @idVentaDetalle	Output 

Set noCount ON

Select @idProducto = (Select VD.IdProducto  
					  From SMercado..Venta_detalles VD
					  Where VD.IdDetalleVentas = @idVentaDetalle )

IF CONVERT(decimal(12,2), @numArt) < CONVERT(decimal(12,2), @totArt)
	BEGIN	
		Update SMercado..Venta_detalles 
		Set cantidad = cantidad - @numArt
		Where IdDetalleVentas = @idVentaDetalle 
	END
IF CONVERT(decimal(12,2), @numArt) = CONVERT(decimal(12,2), @totArt)
	BEGIN
		Delete SMercado..Venta_detalles
		Where IdDetalleVentas = @idVentaDetalle 
	END

Insert SMercado..Devoluciones 
Values ( @idProducto, @numArt, GETDATE() )

Set noCount OFF

END
