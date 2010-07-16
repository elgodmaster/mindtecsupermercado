-- Graba un abono, y actualiza el adeudo en la tabla Cuentas Cobrar.

drop proc dbo.GRABAR117
go

CREATE PROCEDURE dbo.GRABAR117
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
DECLARE @Usuario	varchar(8000)
DECLARE @idUsuario	varchar(8000)
DECLARE @nomClien	varchar(8000)
DECLARE @idCliente  varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCuenta	Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @monto		Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Usuario		Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @nomClien	Output 

Select @idCliente = (Select C.IdCliente  from SMercado..Cat_Clientes C
					 Where C.NombreFiscal = @nomClien)
Select @idUsuario = (Select U.idUsuario From SMercado_Seguridad..Usuarios U
					 Where U.nombreUsuario = @Usuario)

-- Se registra el Abono correspondiente. 
Insert into SMercado..Cuentas_Abonos 
values (@idCuenta, CONVERT(decimal(12,2), @monto), GETDATE(), @idCliente, @idUsuario)

-- Se actualiza el adeudo de la cuenta.
Update SMercado..Cuentas_Cobrar 
Set Adeudo = Adeudo - CONVERT(decimal(12,2), @monto)
Where IdCuenta = @idCuenta 

-- Se actualiza el adeudo total del cliente.
Update SMercado..Cat_Clientes 
Set Adeudo = Adeudo - CONVERT(decimal(12,2), @monto)
Where IdCliente = @IdCliente 

-- Se registra una ENTRADA con el siguiente formato:
-- Abono de [nombreDelCliente]
Insert into SMercado..Caja_Entrada 
Values ( 1, @idUsuario, CONVERT(decimal(12,2), @monto),
	     'Abono de ' + (Select C.NombreFiscal from SMercado..Cat_Clientes C 
						Where IdCliente = @idCliente),
	     GETDATE()
	     )
	     
-- Se actualiza el dinero actual en la caja.
Update SMercado..Caja_Corte
Set dineroActual = dineroActual + CONVERT(decimal(12,2), @monto)
Where CONVERT(date, fecha) = CONVERT(date, getdate())
and usuario = @idUsuario

END