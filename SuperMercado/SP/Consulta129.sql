DROP PROC dbo.Consulta129
GO

CREATE PROCEDURE dbo.Consulta129
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

Select C1 = P.IdProveedor,
	   C2 = P.Nombre,
	   C3 = P.Colonia,
	   C4 = P.Direccion,
	   C5 = P.Telefono1,
	   C6 = P.Email
From SMercado..Cat_Proveedores P
Where P.IdProveedor like '%' + @keyWord + '%' OR
      P.Nombre like '%'+ @keyWord + '%'
Order by P.Nombre

Set noCount OFF
		
END