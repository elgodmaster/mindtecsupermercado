-- Consulta que regresa el catálogo de productos.

DROP PROC dbo.Consulta135
GO

CREATE PROCEDURE dbo.Consulta135
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select P.Codigo, P.Descripcion, P.CostoCompra, P.PrecioVenta  
From SMercado..Cat_Productos P

Select @Resul = '2R=OK|PERMISOS=Catálogo de productos|VALCOL=87*400|'
	
END