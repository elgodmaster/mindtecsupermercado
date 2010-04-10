
drop proc dbo.GRABAR103
go

CREATE PROCEDURE dbo.GRABAR103
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
  --Producto
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
  Declare @Valor15   Varchar(8000)
  Declare @Valor16   Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = "" 
  Select @Desc1  = ""
  Select @Resul  = ""
  Select @Resul2 = ""
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --CodigoProducto
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --CodigoCategoria
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --CodigoMarca
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --Descripcion
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --Costocompra
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --Flete
  Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @Valor7 Output --Margen
  Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @Valor8 Output --CodigoUnidad
  Exec Emulador_SepararCadena 'V9',  @Cabezero, '|', @Valor9 Output --CodigoTC
  Exec Emulador_SepararCadena 'V10',  @Cabezero, '|', @Valor10 Output --StockMinimo
  Exec Emulador_SepararCadena 'V11',  @Cabezero, '|', @Valor11 Output --CostoVenta
  Exec Emulador_SepararCadena 'V12',  @Cabezero, '|', @Valor12 Output --Cambio
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código del producto para continuar|'
     Return    
   End

  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el departamento para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor3)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la categoría para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor4)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la marca para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor5)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la descripcion del producto para continuar|'
     Return    
   End
If Len(RTrim(LTrim(@Valor6)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el costo para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor7)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el flete para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor8)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el margen para continuar|'
     Return    
   End
If Len(RTrim(LTrim(@Valor9)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la unidad para continuar|'
     Return    
   End
        
  -- Logica de Negocio      
  Select @Desc1 = Descripcion
  From SMercado..Cat_Productos(NoLock)
  Where Codigo = @Valor1 And IDDepartamento = @Valor2 And IdCategoria  = @Valor3 And IdMarca = @Valor4
  
  If @@RowCount = 0
   Begin
     Insert SMercado..Cat_Productos(Codigo,IDDepartamento,IdCategoria,IdMarca,Descripcion,CostoCompra,Flete,Margen,IdUnidad,StockMinimo,PrecioVenta,InventarioInicial)
            Values(@Valor1,@Valor2,@Valor3,@Valor4,@Valor5,@Valor6,@Valor7,@Valor8,@Valor9,@Valor10,@Valor11,@Valor12)
   End
  Else
   Begin
     Update SMercado..Cat_Productos
            Set Descripcion  = @Valor5,
                CostoCompra  = @Valor6,
                Flete        = @Valor7,
                Margen       = @Valor8,
                IdUnidad     = @Valor9,
                StockMinimo  = @Valor10,
                PrecioVenta  = @Valor11,
                InventarioInicial = @Valor12
     Where Codigo = @Valor1 And IdDepartamento = @Valor2 And IdCategoria = @Valor3 And IdMarca = @Valor4
   End  

  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se Grabó Correctamente|'   

  Set NoCount OFF
END



