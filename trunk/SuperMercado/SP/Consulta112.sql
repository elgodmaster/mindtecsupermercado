-- Consulta que regresa la configuraci�n de la caja.

DROP PROC dbo.Consulta112
GO

CREATE PROCEDURE dbo.Consulta112
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

Select * from SMercado..Caja_Configuracion
Select @Resul = '2R=OK|'

END