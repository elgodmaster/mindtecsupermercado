-- Consulta llamada por el botón "Hacer Corte" de la ventana Caja.
-- Regresa las tablas ENTRADAS y SALIDAS con la fecha actual.
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

Select C1 = concepto, 
       C2 = monto, 
       C3 = fecha 
From SMercado..Caja_Salida  
where convert( date, fecha ) = convert( date, GETDATE() )

Select dineroInicialCaja,
	   entradas = (select SUM(monto) from SMercado..Caja_Entrada 
				  where CONVERT(date, fecha) = CONVERT(date, GETDATE())
				  group by idCaja, usuario ),
	   salidas = (select SUM(monto) from SMercado..Caja_Salida 
				  where CONVERT(date, fecha) = CONVERT(date, GETDATE())
				  group by idCaja, usuario )
From SMercado..Caja_Corte
Where CONVERT(date, fecha) = CONVERT(date, GETDATE())

END