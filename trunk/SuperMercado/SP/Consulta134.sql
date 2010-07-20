-- Consulta que regresa las unidades

DROP PROC dbo.Consulta134
GO

CREATE PROCEDURE dbo.Consulta134
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select U.IdUnidad, U.Descripcion 
From SMercado..Cat_Unidades U

Select @Resul = '2R=OK|PERMISOS=Catálogo de unidades|VALCOL=87*400|'

Select resultado = @resul
	
END