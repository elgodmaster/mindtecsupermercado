-- Consulta que regresa la lista de permisos.
DROP PROC dbo.Consulta123
GO

CREATE PROCEDURE dbo.Consulta123
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select P.nomPermiso, P.idPermiso 
From SMercado_Seguridad..Permisos P

Select @Resul = '2R=OK|PERMISOS=Catálogo de permisos|VALCOL=87*400|'

Select resultado = @resul
		
END