drop proc dbo.GRABAR116
go

CREATE PROCEDURE [dbo].[GRABAR116]
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
  --Credito
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
  Declare @limCred   decimal(16,2)
  Declare @adeuAct   decimal(16,2)
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --IdCuenta_Cobrar
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Vacio
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Factura 1/0
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --IdUsuario
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --IdCliente
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --IdTipoCambio
  Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @Valor7 Output --Descripcion
  Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @Valor8 Output --Total
  	 
  -- Se valida el crédito del cliente
  	 
  Select @limCred =	(Select C.LimiteCredito From SMercado..Cat_Clientes C
					 Where C.Codigo = @Valor5)
  Select @adeuAct = (Select C.Adeudo From SMercado..Cat_Clientes C
					 Where C.Codigo = @Valor5)
  Select @adeuAct = @adeuAct + @Valor8
					  
  If @adeuAct > @limCred 
	BEGIN
		Select @Resul = '2R=ERROR|2M=No tiene crédito suficiente.' + CHAR(13) + CHAR(13) +						    
		'    Crédito: $' + CONVERT(char, @limCred) + CHAR(13) +
		'    Adeudo: $' + CONVERT(char, @adeuAct) + '|'
		Return
	END
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registrar el numero cuenta para continuar|'
     Return    
   End
  
 --Begin Tran Grabar116
	Select b.IdCuenta 
	From SMercado..Cuentas_Cobrar a 
	Inner join SMercado..Cuentas_Cobrar_detalles b on b.IdCuenta = a.IdCuenta 
	Where a.IdCuenta  = @Valor1
	
	Select @Registro = @@ROWCOUNT
	 
  If @Registro <> 0
    Begin
	  Select @Resul='2R=ERROR|2M=El folio de cuenta ya fue utilizado|'
      Return 
	End   
	
	Select * 
	From SMercado..Cuentas_Cobrar 
	Where YEAR(Fecha) = 1900 And IdCuenta = @Valor1 And IdUsuario = @Valor4
	Select @Registro = @@Rowcount
	
	If @Registro = 0
	Begin
	Select @Resul='2R=ERROR|2M=No se registro un numero de cuenta.'
	End
	 Else
	  Begin
	  Update SMercado..Cuentas_Cobrar
       Set Fecha = GetDate(),
           Factura  = @Valor3,
           IdUsuario = @Valor4,
           CodigoCliente = @Valor5,
           idTipoCambio = @Valor6,
           Descripcion  = @Valor7,
           Adeudo      = @Valor8 
        Where IdCuenta = @Valor1 
	  End
	 
	 -- Se actualiza el saldoActual que debe el cliente.
	 Update SMercado..Cat_Clientes 
	 Set Adeudo = Adeudo + @Valor8
	 Where Codigo = @Valor5
	 
	  
	 If @@ERROR <> 0
	 Begin
	  RollBack Tran Grabar116
	  Return
	 End
	
-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C7  = @Valor1,    --FolioCuenta                
        C1  = C1,    --CodigoProducto
        C2  = C2,    --Descripcion producto                       
        C3  = C3,     --Cantidad 
        C5  = C5,     --PrecioUnitario
        C8  = C8     --Descuento      
        Into #TmpGrabar116     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C7  Int,
              C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C5  Decimal(18,2),
              C6  Decimal (18,2),
              C8  Decimal(18,2))    
        EXEC sp_xml_removedocument @idoc     
        -----------------------------------------------     -- Fin de XML     -----------------------------------------------
	--Se eliminan los productos en blanco.
	Delete from #TmpGrabar116
	Where C2 = ''
	
	--Insert de la tabla temporal..
	Insert SMercado..Cuentas_Cobrar_Detalles(idCuenta,IdProducto,cantidad,PrecioUni,Descripcion,Descuento)
    Select C7,C1,C3,C5,C2,C8
    From #TmpGrabar116
	 
	If @@ERROR <> 0
	 Begin
	  RollBack Tran Grabar116
	  Return
	 End
	 
	 Update a
	    Set a.cantidad = a.cantidad - b.C3
	    From SMercado..Existencias a 
	    Left join #TmpGrabar116 b on b.C1 = a.codigo
	    Where b.C7 = @Valor1
	If @@ERROR <> 0
	 Begin
	  RollBack Tran Grabar116
	  Return
	 End
	 
	 --Commit Tran Grabar116
	 
	
		 
  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se realizo el cargo correctamente '   

  Set NoCount OFF
END



