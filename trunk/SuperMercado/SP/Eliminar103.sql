drop proc dbo.ELIMINAR103
go

CREATE PROCEDURE dbo.ELIMINAR103
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
  --@UsuarioSistema VarChar(8000)
)

AS
BEGIN
  Set NoCount On
  --------------------------
  --Catalogo Productos
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Valor3    Varchar(8000)
  Declare @Valor4    Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Resul2    VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = "" 
  Select @Resul  = ""
  Select @Resul2 = ""
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --IdProducto
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output
  If @Validar = 0
   Begin
      --Update SMercado..Cat_Productos
      --      Set IDDepartamento = "",
      --          IdCategoria   = "",
      --          IdMarca      = "",
      --          Descripcion  = "",
      --          CostoCompra  = "",
      --          Flete        = "",
      --          Margen       = "",
      --          IdUnidad     = "",
      --          StockMinimo  = "",
      --          PrecioVenta  = "",
      --          InventarioInicial = ""
      
     Delete from smercado..cat_productos Where Codigo = @Valor1 --and IDDepartamento = @Valor2 And IdCategoria = @Valor3 And IdMarca = @Valor4 
      Select @Registro = @@ROWCOUNT 
   End

 
  If @Validar = 0
   Begin
     Select @Resul='2R=OK|2M=Se eliminaron los datos correctamente Registro= ' + @Valor1 + '|'
    End
   

  Set NoCount OFF
END



