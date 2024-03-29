drop proc dbo.GRABAR119
go

CREATE PROCEDURE [dbo].[GRABAR119]
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
  --Facturas
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
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio Factura
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Fecha
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Cliente
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --IVA
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --Cotizacion
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --Venta
  Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @Valor7 Output --IdUsuario
  Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @Valor8 Output --TipoCambio
  Exec Emulador_SepararCadena 'V9',  @Cabezero, '|', @Valor9 Output --GenerarSalida
  
  
  --Select @Resul = '2R=ERROR|2M=Valores 1.-' + @Valor1 + '__2.-' + @Valor2 + '__3.-' + @Valor3 + '__4.-' + @Valor4 + '__5.-' + @Valor5 + '__6.-' + @Valor6 + '__7.-' + @Valor7 + '__8.-' + @Valor8 + '__9.-' + @Valor9 
  --Return
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registrar el numero de factura para continuar|'
     Return    
   End

  If Len(RTrim(LTrim(@Valor3)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el cliente para continuar|'
     Return    
   End
  
   ------------------------------------------------------------------------
    --Caja de clientes
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor3 + '|'
     Exec Consulta105 @Desc0,@Resul2 Output,'',1
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
       Select @Resul= '2R=Error|2M=El codigo del cliente no esta registrado|'
       Return
      End
     --------------------------------------------------------------------------
     --------------------------------------------------------------------------  
     
 
	--Validar que la venta no este facturada	
	If Len(LTrim(RTrim(@Valor6))) > 0
	 Begin
	 --Checar que el numero de venta no este facturado 
	 Select @Desc0 = Factura 
	 From SMercado..Ventas 
	  If @Desc0 = 0
	   Begin 
	    Update SMercado..Ventas
	     Set   Factura = 1
	     Where IdVenta = @Valor6
	   End
	    If @Desc0 = 1 
	     Begin
	      Select @Resul='2R=ERROR|2M=La venta ya fue facturada'
	     End
	 End
	
	--Validar que la cotizacion no este facturada
	--If Len(LTrim(RTrim(@Valor7))) <> 0
	-- Begin
	-- 
	-- Select @Desc0 = Factura 
	-- From SMercado..cotizaciones 
	--  If @Desc0 = 0
	--   Begin 
	--    Update SMercado..Ventas
	--     Set   Factura = 1
	--     Where IdVenta = @Valor6
	--   End
	--    If @Desc0 = 1 
	--     Begin
	--      Select @Resul='2R=ERROR|2M=La venta ya fue facturada'
	--     End
	-- End
	
	
	
 --Validar que no este utilizado el numero de la factura	
	Select NoFactura  
	From SMercado..Facturas 
	Where NoFactura = @Valor1 
	
	Select @Registro = @@ROWCOUNT
	 
  If @Registro = 0
    Begin
     Insert SMercado..Facturas (NoFactura,Fecha,IdCliente,IVA,Cotizacion,Venta,IdUsuario,IdTipoCambio,GenerarSalida)
     Values (@Valor1,@Valor2,@Valor3,@Valor4,@Valor5,@Valor6,@Valor7,@Valor8,@Valor9)
    End
     Else
    Begin
	  Select @Resul='2R=ERROR|2M=El folio de la factura ya fue utilizado|'
      Return 
	End   

-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C7  = @Valor1,
        C1  = C1,    --CodigoProducto
        C2  = C2,    --Descripcion producto                       
        C3  = C3,     --Cantidad 
        C5  = C5,     --PrecioUnitario
        C6  = C6,     
        C8  = C8      --Descuento
        Into #TmpGrabar119     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C7  Varchar(50),
              C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C5  Decimal(18,2),
              C6  Decimal(18,2),
              C8  Decimal (18,2))    
        EXEC sp_xml_removedocument @idoc    
        
        
         
        -----------------------------------------------     -- Fin de XML     -----------------------------------------------
	
	
	Delete From #TmpGrabar119 Where C1 = ''
	
	
	--Insert de la tabla temporal..
	Insert SMercado..Factura_detalles(NoFactura,IdProducto,cantidad,PrecioUni,Descripcion,Descuento)
    Select C7,C1,C3,C5,C2,C8
    From #TmpGrabar119
	 
	 
	 If @Valor9 = 'True'
	  Begin
	 Update a
	    Set a.cantidad = a.cantidad - b.C3
	    From SMercado..Existencias a 
	    Left join #TmpGrabar119 b on b.C1 = a.codigo
	    Where b.C7 = @Valor1
	   End 
	 
	 
	Update C
	    Set C.dineroActual = C.dineroInicialCaja + (Select SUM(C3 * C5 * C6 ) From #TmpGrabar119)
	    From SMercado..Caja_Corte  C 
	    Where CONVERT(date, C.fecha) = CONVERT(Date, getdate()) 
	    
	 	 
  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se guardo la factura correctamente'   

  Set NoCount OFF
END



