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
	Select @Resul = '2R=ERROR|'
	Return 
END
 
Insert SMercado..Cuentas_Pagar
Values ( GETDATE(), @factura , @idUsuario, @idProvee, 1, 'ENTRADA PROVEEDOR', CONVERT(decimal(12,2),@total) ) 

Select @idCuenta = (Select top 1 idCuenta  
					From SMercado..Cuentas_Pagar 
					Where idUsuario = @idUsuario and
					      idProveedor = @idProvee
					Order by fecha DESC )

-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C1  = C1,    -- codProducto
        C2  = C2,    -- Descripcion producto                       
        C3  = C3,    -- Cantidad 
        C5  = C5     -- CostoUnitario    
        Into #TmpGrabar110     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C5  Decimal(18,2))
 EXEC sp_xml_removedocument @idoc  

-----------------------------------------------------     -- Fin de XML     -----------------------------------------------
-- Insertamos en la tabla Cuentas_Pagar_Detalles

	--Insert de la tabla temporal..
	Insert SMercado..Cuentas_Pagar_Detalles( codProducto, cantidad, precioUni, descripcion )
    Select C1,C3,C5,C2
    From #TmpGrabar110
    
Update SMercado..Cuentas_Pagar_Detalles 
Set idCuenta = @idCuenta 
Where idCuenta is null

Update E 
Set E.Cantidad += CPD.cantidad 
From SMercado..Existencias E
Inner join SMercado..Cuentas_Pagar_Detalles CPD ON E.Codigo = CPD.codProducto 
Where CPD.idCuenta = @idCuenta 

Update SMercado..Cat_Proveedores
Set Deuda = Deuda + CONVERT(decimal(12,2),@total)
Where IdProveedor = @idProvee 

Select @Resul = '2R=OK|'

Set noCount OFF

END