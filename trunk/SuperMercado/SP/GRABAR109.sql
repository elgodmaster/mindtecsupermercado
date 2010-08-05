drop proc dbo.GRABAR109
go

CREATE PROCEDURE [dbo].[GRABAR109]
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN
  Set NoCount On
  --------------------------
  --Entradas
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Valor3    VarChar(8000)
  Declare @Valor4    Varchar(8000)
  Declare @Valor5    Varchar(8000)
  Declare @Valor6    Varchar(8000)
  Declare @Valor7    Varchar(8000)
  Declare @Valor8    Varchar(8000)
  Declare @Valor9    Varchar(8000)
  Declare @Valor10   Varchar(8000)
  Declare @Valor11   Varchar(8000)
  Declare @Valor12   Varchar(8000)
  Declare @Valor13   Varchar(8000)
  Declare @Valor14   Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
  DECLARE @nomProvee VarChar(8000)
  DECLARE @error	 int 
  
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio de entrada
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Fecha
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Usuario
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --Folio de factura
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --Folio de proveedor
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --Total
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código de Entrada para continuar.|'
     Return    
   End
  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre una fecha para continuar.|'
     Return    
   End
 
  If Len(RTrim(LTrim(@Valor4)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre una factura para continuar.|'
     Return    
   End

 If Len(RTrim(LTrim(@Valor5)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre un proveedor para continuar.|'
     Return    
   End
   

------------------------------------------------------------------------
    --Caja de proveedores
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor5 + '|'
     Exec Consulta106 @Desc0,@Resul2 Output,'',1
     Exec Emulador_SepararCadena '2R', @Resul2, '|', @Desc0 Output
     If Upper (@Desc0) <> 'OK'
      Begin
        Select @Resul = @Resul2
        Return
      End

     --obtenemos el valor
     Exec Emulador_SepararCadena 'V1', @Resul2, '|', @Desc1 Output
     If LEN(LTrim(RTrim(@Desc1))) = 0 
      Begin
       Select @Resul= '2R=Error|2M=El código del proveedor no está registrado.|'
       Return
      End
     --------------------------------------------------------------------------
     --------------------------------------------------------------------------
     

Select @nomProvee = (Select P.Nombre 
					 From SMercado..Cat_Proveedores P
					 Where P.Codigo = @valor5)
   
-- Se hace pago con efectivo.	 
If @Validar = 2
BEGIN
	DECLARE @totalDineroCaja	DECIMAL(12,2)
	DECLARE @totalPago			DECIMAL(12,2)
	Select @totalDineroCaja = (Select CC.dineroActual  
							   From SMercado..Caja_Corte CC
							   Where CC.usuario  = @Valor3 and
							   CC.fecha = CONVERT(date, GETDATE()) )
	Select @totalPago = CONVERT(decimal(12,2), @valor6)

	IF  @totalPago <= @totalDineroCaja 
	BEGIN
		Insert SMercado..Caja_Salida 
		Values (1, @Valor3, @Valor6, 'Pago a proveedor: ' + @nomProvee, GETDATE())
		
		Update SMercado..Caja_Corte 
		Set dineroActual -= @totalPago
		Where usuario = @Valor3 and
		fecha = CONVERT(date, getdate())
	END
	ELSE
	BEGIN
		Select @Resul = '2R=ERROR02|2M=No hay suficiente dinero en la caja para efectuar el pago. Por favor deposite dinero en la caja para poder realizar el pago. Dinero en caja: $ ' + CONVERT(char,@totalDineroCaja )
		Return
	END 	
END 

 
	Select e.idEntrada  
	From SMercado..entradas e 
	Inner join SMercado..entrada_detalles ed on e.identrada=ed.identrada
	Inner join SMercado..cat_proveedores p on  e.idproveedor=p.Codigo  and p.codigo=@Valor5 and e.folioFactura=@Valor4
  If @@RowCount > 0
    Begin
	  Select @Resul='2R=ERROR|2M=El código de la factura ya fué dado de alta con ese mismo proveedor|'
      Return 
	End   
	
	Select @Desc0 = idEntrada 
	From SMercado..Entradas 
	Where idEntrada = @Valor1 And foliofactura = 0
	Select  @Registro = @@ROWCOUNT 
	
-- Inicia la TRANSACCIÓN --
Begin Tran Grabar109
	
	If @Registro = 0
	Begin
	Insert SMercado..Entradas(fecha,idUsuario,folioFactura,IdProveedor)
	Values (@Valor2,@Valor3,@Valor4,@Valor5)
	End
	 Else
	  Begin
	  Update SMercado..Entradas 
       Set Fecha = @Valor2,
           IdUsuario = @Valor3,
           folioFactura = @Valor4,
           IdProveedor = @Valor5 
        Where idEntrada=@Valor1 
	  End
	 
SET @Error = @@ERROR
--Si ocurre un error almacenamos su código en @Error
--y saltamos al trozo de código que deshara la transacción. Si, eso de ahí es un 
--GOTO, el demonio de los programadores, pero no pasa nada por usarlo
--cuando es necesario
IF (@Error<>0) GOTO TratarError

-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C7  = @Valor1,    --FoliEntrada                 
        C1  = C1,    --IdProducto
        C2  = C2,    --Descripcion producto                       
        C3  = C3,     --Cantidad 
        C4  = C4,      --Unidad
        C5  = C5,     --CostoUnitario
        C6  = C6     --Costototal      
        Into #TmpGrabar109     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C7  Int,
              C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C4  Varchar (250),
              C5  Decimal(18,2),
              C6  Decimal (18,2))    
        EXEC sp_xml_removedocument @idoc
        
SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError  
-----------------------------------------------     -- Fin de XML     -----------------------------------------------
	
	--Insert de la tabla temporal..
	Insert SMercado..Entrada_detalles(idEntrada,IdProducto,Descripcion,cantidad,Unidad,costoUnitario,CostoTotal)
    Select C7,C1,C2,C3,C4,C5,C6
    From #TmpGrabar109
	 
SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError
	 
	 Update a
	    Set a.cantidad = a.cantidad + b.C3
	    From SMercado..Existencias a 
	    Left join #TmpGrabar109 b on b.C1 = a.codigo
	    Where b.C7 = @Valor1
	   
SET @error = @@ERROR 
IF (@error<>0) GOTO TratarError
	 
-- Termina la TRANSACCIÓN --
Commit Tran Grabar109

  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se grabó correctamente.|' 
  
  TratarError:
--Si ha ocurrido algún error llegamos hasta aquí
If @@Error<>0
	BEGIN
	PRINT 'Ha ecorrido un error. Abortamos la transacción'
	--Se lo comunicamos al usuario y deshacemos la transacción
	--todo volverá a estar como si nada hubiera ocurrido
	ROLLBACK TRAN
	END
  

  Set NoCount OFF
END



