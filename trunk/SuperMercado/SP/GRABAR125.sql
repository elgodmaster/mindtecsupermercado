drop proc dbo.GRABAR125
go

CREATE PROCEDURE [dbo].[GRABAR125]
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
  --Cotizaciones
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
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio Cotizacion
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Fecha
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Cliente
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --IVA
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --IdUsuario
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --TipoCambio
  Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @Valor7 Output --
  Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @Valor8 Output --
  Exec Emulador_SepararCadena 'V9',  @Cabezero, '|', @Valor9 Output --
  
  
  --Select @Resul = '2R=ERROR|2M=Valores 1.-' + @Valor1 + '__2.-' + @Valor2 + '__3.-' + @Valor3 + '__4.-' + @Valor4 + '__5.-' + @Valor5 + '__6.-' + @Valor6 + '__7.-' + @Valor7 + '__8.-' + @Valor8 + '__9.-' + @Valor9 
  --Return
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registrar el numero de cotizacion para continuar|'
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
	
	
 --Validar que no este utilizado el numero de la cotizacion
	Select NoCotizacion 
	From SMercado..Cotizaciones  
	Where NoCotizacion  = @Valor1 
	
	Select @Registro = @@ROWCOUNT
	 
  If @Registro = 0
    Begin
     Update  SMercado..Cotizaciones Set
     NoCotizacion = @Valor1,
     IdCliente    = @Valor3,
     Fecha        = @Valor2,
     IVA          = @Valor4,
     IdUsuario    = @Valor5,
     IdTipoCambio = @Valor6
     Where id = @Valor1
    End
     Else
    Begin
	  Select @Resul='2R=ERROR|2M=El folio de la cotización ya fue utilizado|'
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
        C8  = C8      --Descuento
        Into #TmpGrabar125    
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C7  Varchar(50),
              C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C5  Decimal(18,2),
              C8  Decimal (18,2))    
        EXEC sp_xml_removedocument @idoc    
           
        -----------------------------------------------     -- Fin de XML     -----------------------------------------------
	
	
	Delete From #TmpGrabar125 Where C1 = ''
	
	
	--Insert de la tabla temporal..
	Insert SMercado..cotizaciones_detalles(NoCotizacion,IdProducto,cantidad,PrecioUni,Descripcion,Descuento)
    Select C7,C1,C3,C5,C2,C8
    From #TmpGrabar125
	 	 	 
  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se guardo la cotización correctamente'   

  Set NoCount OFF
END



