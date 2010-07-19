-- Graba un abono, y actualiza el adeudo en la tabla Cuentas 
-- por PAGAR.

drop proc dbo.GRABAR128
go

CREATE PROCEDURE dbo.GRABAR128
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @idCuenta	varchar(8000)
DECLARE @monto		varchar(8000)
DECLARE @idUsuario	varchar(8000)
DECLARE @nomProvee	varchar(8000)
DECLARE @idProvee   varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCuenta	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @monto		Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @idUsuario	Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @nomProvee	Output 

Select @idProvee = (Select C.IdProveedor from SMercado..Cat_Proveedores C
					 Where C.Nombre = @nomProvee)

-- Se registra el Abono correspondiente. 
Insert into SMercado..Cuentas_Pagar_Abonos 
values (@idCuenta, CONVERT(decimal(12,2), @monto), GETDATE(), @idProvee, @idUsuario)

-- Se actualiza el adeudo de la cuenta.
Update SMercado..Cuentas_Pagar  
Set adeudo = adeudo - CONVERT(decimal(12,2), @monto)
Where IdCuenta = @idCuenta 

-- Se actualiza el adeudo total del cliente.
Update SMercado..Cat_Proveedores 
Set Deuda = Deuda - CONVERT(decimal(12,2), @monto)
Where IdProveedor = @idProvee 

END