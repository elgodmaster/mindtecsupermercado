drop proc dbo.GRABAR115
go

CREATE PROCEDURE [dbo].[GRABAR115]
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
  --Ventas
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
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio Venta
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Vacio
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Factura 1/0
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --IdUsuario
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --IdCliente
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --IdTipoCambio
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registrar el numero de venta para continuar|'
     Return    
   End
  
 
 Begin Tran Grabar115
 
	Select fecha 
	From SMercado..Ventas a 
	Inner join SMercado..Venta_detalles b on b.IdVenta = b.IdVenta 
	Where a.IdUsuario = @Valor3 And a.IdVenta = @Valor1 
	
	Select @Registro = @@ROWCOUNT
	 
  If @Registro <> 0
    Begin
	  Select @Resul='2R=ERROR|2M=El folio de venta ya fue utilizado|'
      Return 
	End   
	
	Select * 
	From SMercado..Ventas
	Where YEAR(Fecha) = 1900 And IdVenta = @Valor1 And IdUsuario = @Valor4
	Select @Registro = @@Rowcount
	
	If @Registro = 0
	Begin
	Select @Resul='2R=ERROR|2M=No Funciono'
	End
	 Else
	  Begin
	  Update SMercado..Ventas
       Set Fecha = GetDate(),
           Factura  = @Valor3,
           IdUsuario = @Valor4,
           IdCliente = @Valor5,
           idTipoCambio = @Valor6 
        Where IdVenta = @Valor1 
	  End
	 
	 If @@ERROR <> 0
	 Begin
	  Rollback Tran Grabar115
	  Return
	 End
-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C7  = C7,    --FolioVenta                
        C1  = C1,    --CodigoProducto
        C2  = C2,    --Descripcion producto                       
        C3  = C3,     --Cantidad 
        C5  = C5,     --PrecioUnitario
        C8  = C8     --Descuento      
        Into #TmpGrabar115     
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
	
	--Insert de la tabla temporal..
	Insert SMercado..Venta_detalles(idVenta,IdProducto,cantidad,PrecioUni,Descripcion,Descuento)
    Select C7,C1,C3,C5,C2,C8
    From #TmpGrabar115
	 
	 If @@ERROR <> 0
	 Begin
	  RollBack Tran Grabar115
	  Return
	 End
	 
	 Update a
	    Set a.cantidad = a.cantidad - b.C3
	    From SMercado..Existencias a 
	    Left join #TmpGrabar115 b on b.C1 = a.codigo
	    Where b.C7 = @Valor1
	   
	If @@ERROR <> 0
	 Begin
	  RollBack Tran Grabar115
	  Return
	 End
	 
	 Commit Tran Grabar115
	 
  -- Enviar Resultado
  Select @Resul='2R=OK|'   

  Set NoCount OFF
END



