	-- Elimina un artículo de la tabla Cuentas_Cobrar_Detalles
-- y actualiza el adeudo de la cuenta así como del cliente.

drop proc dbo.GRABAR124
go

CREATE PROCEDURE dbo.GRABAR124
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int

)

AS
BEGIN

DECLARE @idCuentaDetalle 	varchar(8000)
DECLARE @idCuenta		 	varchar(8000)
DECLARE @codigo		 	    varchar(8000)
DECLARE @numArt				varchar(8000)
DECLARE @totArt				varchar(8000)
DECLARE @precio				decimal(12,2)
DECLARE @adeudoCuenta		decimal(12,2)
DECLARE @adeudoCliente		decimal(12,2)
DECLARE @idProducto			int

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @numArt			Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @totArt			Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @idCuentaDetalle	Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @idCuenta		Output
Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @codigo	     	Output

Set noCount ON

Select @idProducto = (Select IdProducto 
					  From SMercado..Cuentas_Cobrar_Detalles 
					  Where IdCuentaDetalle  = @idCuentaDetalle )

Select @precio = (Select (CC.PrecioUni * CC.Descuento) 
				  From SMercado..Cuentas_Cobrar_Detalles CC
 				  Where CC.IdCuentaDetalle = @idCuentaDetalle )
	
Update SMercado..Cuentas_Cobrar 
Set Adeudo = Adeudo - @numArt * @precio 
Where IdCuenta = @idCuenta 


Select @adeudoCuenta = (Select CC.Adeudo From SMercado..Cuentas_Cobrar CC Where CC.IdCuenta = @idCuenta )

IF @adeudoCuenta < 0
BEGIN
	DECLARE @adeudoChar varchar(8000)
	Select @adeudoChar = RTRIM((CONVERT(char, ABS(@adeudoCuenta))))
	Select @Resul = '2R=' + @adeudoChar + '|'

	Update SMercado..Cuentas_Cobrar 
	Set Adeudo = 0
	Where IdCuenta = @idCuenta
END

Update SMercado..Cat_Clientes
Set Adeudo = Adeudo - @numArt * @precio
Where Codigo = @codigo

Select @adeudoCliente = (Select C.Adeudo 
						 From SMercado..Cat_Clientes C
						 Where Codigo = @codigo ) 
						 
IF @adeudoCliente < 0
BEGIN
	Update SMercado..Cat_Clientes 
	Set Adeudo = 0
	Where Codigo = @codigo
END

IF @numArt < @totArt
BEGIN
	Update SMercado..Cuentas_Cobrar_Detalles
	Set cantidad = cantidad - @numArt
	Where IdCuentaDetalle = @idCuentaDetalle 
END
IF @numArt = @totArt 
BEGIN
	Delete SMercado..Cuentas_Cobrar_Detalles 
	Where IdCuentaDetalle = @idCuentaDetalle 
END

Insert SMercado..devoluciones values ( @idProducto, @numArt, GETDATE())

select precio = @precio, resul = @Resul  

Set noCount OFF

END
