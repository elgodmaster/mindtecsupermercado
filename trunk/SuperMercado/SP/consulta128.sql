-- Consulta el detalle de una venta.

DROP PROC dbo.Consulta128
GO

CREATE PROCEDURE dbo.Consulta128
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE	@keyWord	VARCHAR(8000)

SET noCount ON

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @keyWord 	Output 

Select C1 = C.IdCliente, 
	   C2 = C.NombreFiscal, 
	   C3 = C.Colonia, 
	   C4 = C.Direccion, 
	   C5 = C.Telefono1, 
	   C6 = C.Email  
From SMercado..Cat_Clientes C
Where C.IdCliente like '%' + @keyword + '%' OR
	  C.NombreFiscal like '%' + @keyWord + '%' 
Order by C.NombreFiscal

Set noCount OFF

END
