-- Crea una nueva cuenta por pagar asociada a un
-- proveedor.

drop proc dbo.GRABAR130
go

CREATE PROCEDURE dbo.GRABAR130
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN

DECLARE @idUsuario			 	varchar(8000)
DECLARE @codProve				varchar(8000)
DECLARE @idProvee				varchar(8000)
DECLARE @idCuenta				varchar(8000)
DECLARE @total					varchar(8000)
DECLARE @factura                varchar(8000)
DECLARE @error					integer


Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @codProve   	Output
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @idUsuario  	Output
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @factura  	Output
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @total   	Output

Set noCount ON

Select @idProvee = (Select P.IdProveedor 
					From SMercado..Cat_Proveedores P
					Where P.Codigo = @codProve )
					
If @idProvee is null
BEGIN
	Select @Resul = '2R=ERROR|2M=No existe un proveedor con ese código.'
	Return 
END

-- Inicia la TRANSACCIÓN
BEGIN TRAN
 
 
 
Insert SMercado..Cuentas_Pagar
Values ( GETDATE(), @factura , @idUsuario, @idProvee, 1, 'ENTRADA PROVEEDOR', CONVERT(decimal(12,2),@total) ) 

SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError


Select @idCuenta = (Select top 1 idCuenta  
					From SMercado..Cuentas_Pagar 
					Where idUsuario = @idUsuario and
					      idProveedor = @idProvee
					Order by fecha DESC )

SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError


-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C8  = @idCuenta,  
		C1  = C1,    -- codProducto
        C2  = C2,    -- Descripcion producto                       
        C3  = C3,    -- Cantidad 
        C5  = C5     -- CostoUnitario    
        Into #TmpGrabar110     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C0  integer,
			  C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C5  Decimal(18,2))
 EXEC sp_xml_removedocument @idoc  

SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError
-----------------------------------------------------     -- Fin de XML     -----------------------------------------------
-- Insertamos en la tabla Cuentas_Pagar_Detalles

	--Insert de la tabla temporal..
	Insert SMercado..Cuentas_Pagar_Detalles( idCuenta, codProducto, cantidad, precioUni, descripcion )
    Select C8,C1,C3,C5,C2
    From #TmpGrabar110
    
SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError


Update E 
Set E.Cantidad += CPD.cantidad 
From SMercado..Existencias E
Inner join SMercado..Cuentas_Pagar_Detalles CPD ON E.Codigo = CPD.codProducto 
Where CPD.idCuenta = @idCuenta 

SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError


Update SMercado..Cat_Proveedores
Set Deuda = Deuda + CONVERT(decimal(12,2),@total)
Where IdProveedor = @idProvee 

SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError

-- Termina la TRANSACCIÓN
COMMIT TRAN

Select @Resul = '2R=OK|2M=Se asignó una cuenta por pagar al proveedor correspondiente.'





  TratarError:
--Si ha ocurrido algún error llegamos hasta aquí
If @@Error<>0
	BEGIN
	PRINT 'Ha ecorrido un error. Abortamos la transacción'
	--Se lo comunicamos al usuario y deshacemos la transacción
	--todo volverá a estar como si nada hubiera ocurrido
	ROLLBACK TRAN
	END

Set noCount OFF

END