drop proc dbo.Consulta138
go

CREATE PROCEDURE dbo.Consulta138
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN
  Set NoCount On
  ------------------------------------------
  --Consulta Existencias
  ------------------------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)
  Declare @Valor2    VarChar(8000)
  Declare @Desc0     VarChar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Desc2     VarChar(8000)
  Declare @Desc3     VarChar(8000)
  Declare @Desc4     VarChar(8000)
  Declare @Desc5     VarChar(8000)
  Declare @Desc6     VarChar(8000)
  Declare @Desc7     VarChar(8000)
  Declare @Desc8     VarChar(8000)
  Declare @Desc9     VarChar(8000)
  Declare @Desc10    VarChar(8000)
  Declare @Desc11    VarChar(8000)
  Declare @Desc12    VarChar(8000)
  Declare @Desc13    VarChar(8000)
  Declare @Desc14    VarChar(8000)
  Declare @Desc15    VarChar(8000)
  Declare @Sql       VarChar(8000)
  Declare @Resul2    Varchar(8000)
  
  --Asignar Valores
  Select @Desc0   = ''
  Select @Desc1   = ''
  Select @Desc2   = '' 
  Select @Desc3   = ''
  Select @Desc4   = ''
  Select @Desc5   = ''
  Select @Desc6   = ''
  Select @Desc7   = '' 
  Select @Desc8   = ''
  Select @Desc9   = ''
  Select @Desc10  = ''
  Select @Desc11  = ''
  Select @Desc12  = '' 
  Select @Desc13  = ''
  Select @Desc14  = ''
  Select @Desc15  = '' 
  Select @Resul   = ''
  Select @Resul2  = ''

  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo Departamento

  -- Validar Parametros
 
  If @Validar = 0               
   Begin
     Select Departamento = IsNull(C.Descripcion,''),
       Categoria    = IsNull(d.Descripcion,''),
       Marca        = IsNull(e.Descripcion,''),
       Codigo       = IsNull(a.Codigo,''), 
       Producto     = IsNull(b.Descripcion,''), 
       Existencia   = Isnull(a.cantidad,0),
       Unidad       = IsNull(f.descripcion,''),
       PrecioU      = ISNULL(b.PrecioVenta,0),
       Total        = Convert(Decimal(18,2),ISNULL(Sum(b.precioVenta * a.cantidad),0))
     From SMercado..Existencias a 
     Left Join Smercado..Cat_Productos b On b.Codigo = a.Codigo 
     Left join SMercado..Cat_Departamentos c (NoLock) On c.IdDepartamento = b.IDDepartamento 
     Left join SMercado..cat_categorias d (NoLock) On d.idcategoria = b.idcategoria
     Left join SMercado..cat_marcas e (NoLock) On e.idmarca = b.idmarca
     Left join SMercado..Cat_Unidades f (NoLock) On f.IdUnidad = b.IdUnidad 
     Group By c.Descripcion,d.Descripcion,e.Descripcion,a.Codigo,b.Descripcion,a.Cantidad,f.Descripcion,b.PrecioVenta 
	  Select @Registro = @@RowCount	 
   End
  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|No existen datos para mostrar'
   End
  Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|'
    End

  Set NoCount OFF
END