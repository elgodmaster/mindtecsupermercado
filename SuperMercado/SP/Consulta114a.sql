-- Consulta que regresa los estados de la república.

DROP PROC dbo.Consulta114a
GO

CREATE PROCEDURE dbo.Consulta114a
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select e.Descripcion from SMercado..Cat_EstadosdelaRepublica e
Select @Resul = '2R=OK|'

END