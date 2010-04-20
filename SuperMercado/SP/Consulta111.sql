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
Set noCount ON

-- Variables de trabajo
DECLARE @registro int
DECLARE @entradas decimal(18,2)
DECLARE @salidas decimal(18,2)
DECLARE @dineroInicialCaja decimal(18,2)

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

Select @dineroInicialCaja = dineroInicialCaja,
	   @entradas = (select SUM(monto) from SMercado..Caja_Entrada 
				  where CONVERT(date, fecha) = CONVERT(date, GETDATE())
				  group by CONVERT(date, fecha)),
	   @salidas = (select SUM(monto) from SMercado..Caja_Salida 
				  where CONVERT(date, fecha) = CONVERT(date, GETDATE())
				  group by CONVERT(date, fecha))
From SMercado..Caja_Corte
Where CONVERT(date, fecha) = CONVERT(date, GETDATE())

Select @entradas = ISNULL(@entradas, 0)
Select @salidas = ISNULL(@salidas, 0)

select dineroCaja = @dineroInicialCaja, entradas = @entradas, salidas = @salidas

END