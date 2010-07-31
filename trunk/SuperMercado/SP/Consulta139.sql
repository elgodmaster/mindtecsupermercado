-- Consulta que regresa la información de un producto.

DROP PROC dbo.Consulta139
GO

CREATE PROCEDURE dbo.Consulta139
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @keyWord	varchar(8000)

exec Emulador_SepararCadena 'V1', @cabezero, '|', @keyWord output 

	Select C1 = C.NombreFiscal,
		   C2 = C.Colonia,
		   C3 = C.Direccion,
		   C4 = '$ ' + CONVERT(char,Adeudo),
		   C5 = CONVERT(varchar, UltimoPago, 103),
		   C6 = C.IdCliente,
		   C7 = C.Codigo 
	From SMercado..Cat_Clientes C
	Where C.NombreFiscal like '%' + @keyWord + '%'
	Order by C.NombreFiscal 
	
	Select @Resul = '2R=OK|'
END 

				

	
