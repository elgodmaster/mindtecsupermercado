-- Consulta llamada por el bot�n "Hacer Corte" de la ventana Caja.
drop proc dbo.Consulta111
go

CREATE PROCEDURE dbo.Consulta111
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS 
BEGIN

Select C1 = concepto, 
       C2 = monto, 
       C3 = fecha 
From SMercado..Caja_Entrada 
where convert( date, fecha ) = convert( date, GETDATE() )

END