-- Consulta llamada por el bot�n "Hacer Corte" de la ventana Caja.
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
DECLARE @usuario   varchar(8000)
DECLARE @idUsuario varchar(8000)
DECLARE @registro int
DECLARE @entradas decimal(18,2)
DECLARE @salidas decimal(18,2)
DECLARE @dineroInicialCaja decimal(18,2)
DECLARE @venta decimal(18,2)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idUsuario Output

Select C1 = concepto, 
       C2 = '$ ' + CONVERT(char, monto), 
       C3 = fecha 
From SMercado..Caja_Entrada 
where convert( date, fecha ) = convert( date, GETDATE() ) and
      usuario = @idUsuario 
Order by fecha DESC

Select C1 = concepto, 
       C2 = '$ ' + CONVERT(char, monto), 
       C3 = fecha 
From SMercado..Caja_Salida  
where convert( date, fecha ) = convert( date, GETDATE() ) and
      usuario = @idUsuario 
Order by fecha DESC

Select C1 = d.Descripcion, 
	   C2 = '$ ' + CONVERT(char, CONVERT(decimal(12,2),SUM(vd.cantidad * vd.PrecioUni * vd.Descuento)))
From SMercado..Venta_detalles vd
inner join SMercado..Ventas v ON vd.IdVenta = v.IdVenta
inner join SMercado..Cat_Productos p ON vd.IdProducto = p.Codigo 
inner join SMercado..Cat_Departamentos d ON p.IDDepartamento = d.IdDepartamento 
Where CONVERT(date, v.Fecha) = CONVERT(date, GETDATE()) and
      v.IdUsuario = @idUsuario
Group by d.Descripcion

Select @dineroInicialCaja = dineroInicialCaja,
	   @entradas = (select SUM(monto) from SMercado..Caja_Entrada 
				    where CONVERT(date, fecha) = CONVERT(date, GETDATE()) and
				    usuario = @idUsuario 
				    group by CONVERT(date, fecha)),
				    
	   @salidas =  (select SUM(monto) from SMercado..Caja_Salida 
				    where CONVERT(date, fecha) = CONVERT(date, GETDATE()) and
				    usuario = @idUsuario 
				    group by CONVERT(date, fecha)),
				    
	   @venta =    (Select SUM( vd.cantidad * vd.PrecioUni * vd.Descuento )
					From SMercado..Venta_detalles vd
					inner join SMercado..Ventas v ON vd.IdVenta = v.IdVenta 
					where CONVERT(date, v.Fecha) = CONVERT(date, GETDATE()) and
					v.IdUsuario = @idUsuario 
					Group by CONVERT(date, v.Fecha)
)				
From SMercado..Caja_Corte
Where CONVERT(date, fecha) = CONVERT(date, GETDATE()) and
usuario = @idUsuario 



Select @entradas = ISNULL(@entradas, 0)
Select @salidas =  ISNULL(@salidas, 0)
Select @venta =    ISNULL(@venta, 0)

select dineroCaja = @dineroInicialCaja, 
	   entradas = @entradas, 
	   salidas = @salidas,
	   venta = @venta 

END