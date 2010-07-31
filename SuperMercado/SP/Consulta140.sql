-- Consulta que regresa la información de un producto.

DROP PROC dbo.Consulta140
GO

CREATE PROCEDURE dbo.Consulta140
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

	Select C1 = C.Nombre,
		   C2 = C.Colonia,
		   C3 = C.Direccion,
		   C4 = '$ ' + CONVERT(char,C.Deuda ),
		   C5 = CONVERT(varchar, UltimoPago, 103),
		   C6 = C.IdProveedor 
	From SMercado..Cat_Proveedores C
	Where C.Nombre like '%' + @keyWord + '%' 
	Order by C.Nombre 
	Select @Resul = '2R=OK|'
END 

				

	
