-- Consulta que regresa la configuración del Ticket.

DROP PROC dbo.Consulta126
GO

CREATE PROCEDURE dbo.Consulta126
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @idVenta as varchar(8000)

Select  C.impresora, 
		C.lineaCabezero1, C.lineaCabezero2, C.lineaCabezero3, C.lineaCabezero4,
		C.lineaPie1, C.lineaPie2, C.lineaPie3 
From SMercado..Config_Ticket C

Select @idVenta = (Select top 1 V.IdVenta from SMercado..Ventas V
				   Inner join SMercado..Venta_detalles VD ON V.IdVenta = VD.IdVenta 
				   Order by V.Fecha desc)

Select @Resul = '2R=' + @idVenta + '|'
 
END