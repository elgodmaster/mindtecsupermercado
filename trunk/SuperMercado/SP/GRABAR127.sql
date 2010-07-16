-- Crea una nueva cuenta por pagar asociada a un
-- proveedor.

drop proc dbo.GRABAR127
go

CREATE PROCEDURE dbo.GRABAR127
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

DECLARE @producto 				varchar(8000)
DECLARE @cantidad				varchar(8000)
DECLARE @costo				 	varchar(8000)
DECLARE @idUsuario			 	varchar(8000)
DECLARE @nomProvee			 	varchar(8000)
DECLARE @idProvee				varchar(8000)
DECLARE @idCuenta				varchar(8000)
DECLARE @idProducto				varchar(8000)
DECLARE @total					decimal(12,2)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @producto	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @cantidad	Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @costo		Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @nomProvee 	Output
Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @idUsuario  	Output

Set noCount ON

Select @idProvee = (Select IdProveedor 
					From SMercado..Cat_Proveedores 
					Where Nombre = @nomProvee )
					
Select @total = CONVERT(decimal(12,2), @cantidad) * CONVERT(decimal(12,2), @costo) 
 
Insert SMercado..Cuentas_Pagar
Values ( GETDATE(), 1, @idUsuario, @idProvee, 1, @producto, @total ) 

Select @idCuenta = (Select top 1 idCuenta  
					From SMercado..Cuentas_Pagar 
					Where idUsuario = @idUsuario and
					      idProveedor = @idProvee and
					      descripcion = @producto
					Order by fecha DESC )

Insert SMercado..Cuentas_Pagar_Detalles
Values ( @idCuenta, 0, CONVERT(decimal(12,2),@cantidad), CONVERT(decimal(12,2),@costo), @producto )

Update SMercado..Cat_Proveedores
Set Deuda = Deuda + @total
Where Nombre = @nomProvee 

Set noCount OFF

END