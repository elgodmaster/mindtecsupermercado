-- Consulta que regresa las marcas.

DROP PROC dbo.Consulta133
GO

CREATE PROCEDURE dbo.Consulta133
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select M.IdMarca, M.Descripcion 
From SMercado..Cat_Marcas M

Select @Resul = '2R=OK|PERMISOS=Catálogo de marcas|VALCOL=87*400|'

Select resultado = @resul
	
END