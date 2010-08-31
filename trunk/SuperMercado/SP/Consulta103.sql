drop proc dbo.Consulta103
go

CREATE PROCEDURE dbo.Consulta103
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
  --Catalogo de productos
  ------------------------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)
  Declare @Valor2    VarChar(8000)
  Declare @Valor3    Varchar(8000)
  Declare @Valor4    Varchar(8000)
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

  --Obtener los Parametros                                                                --- Validar 3
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --DEPARTAMENTO          --- CostoCompra
  Exec Emulador_SepararCadena 'V2', @Cabezero, '|', @Valor2 Output --CATEGORIA             --- Flete
  Exec Emulador_SepararCadena 'V3', @Cabezero, '|', @Valor3 Output --MARCA                 --- Margen
  Exec Emulador_SepararCadena 'V4', @Cabezero, '|', @Valor4 Output --PRODUCTO

   --Validar Parametros
   If @Validar = 2 
     Begin
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el departamento para continuar|'
       Return
     End
     If dbo.Fnc_EsNumero(@Valor1) <> 1
     Begin
       Select @Resul = '2R=ERROR|2M=El codigo del departamento debe ser numérico|'
       Return
     End
    ------------------------------------------------------------------------
    --Caja de departamentos
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor1 + '|'
     Exec Consulta100 @Desc0,@Resul2 Output,'',1
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
       Select @Resul= '2R=Error|2M=El codigo del departamento no esta registrado|'
       Return
      End
     --------------------------------------------------------------------------
     --------------------------------------------------------------------------  

  If Len(RTrim(LTrim(@Valor2))) = 0 
       Begin
        Select @Resul = '2R=ERROR|2M=Registre la categoría para continuar|'
        Return
       End
  If dbo.Fnc_EsNumero(@Valor2) <> 1
     Begin
       Select @Resul = '2R=ERROR|2M=El codigo de la categoría debe ser numérico|'
       Return
     End
    ------------------------------------------------------------------------
    --Caja de categorías
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor2 + '|'
     Exec Consulta101 @Desc0,@Resul2 Output,'',1
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
       Select @Resul= '2R=Error|2M=El codigo de la categoría no esta registrado|'
       Return
      End
     --------------------------------------------------------------------------
     --------------------------------------------------------------------------  

  If Len(RTrim(LTrim(@Valor3))) = 0 
       Begin
        Select @Resul = '2R=ERROR|2M=Registre la marca para continuar|'
        Return
       End
  If dbo.Fnc_EsNumero(@Valor3) <> 1
     Begin
       Select @Resul = '2R=ERROR|2M=El codigo de la marca debe ser numérico|'
       Return
     End
    ------------------------------------------------------------------------
    --Caja de marcas
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor3 + '|'
     Exec Consulta102 @Desc0,@Resul2 Output,'',1
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
       Select @Resul= '2R=Error|2M=El codigo de la marca no esta registrado|'
       Return
      End
     --------------------------------------------------------------------------
     --------------------------------------------------------------------------  
       
  If Len(RTrim(LTrim(@Valor4))) = 0 
       Begin
        Select @Resul = '2R=ERROR|2M=Registre el codigo del producto para continuar|'
        Return
       End
     End

  If @Validar = 0               
   Begin
    Select @Sql = "Select Codigo       = IsNull(a.Codigo,''), " +
            "Descripción  = IsNull(a.Descripcion,''), " +
            "Marca        = IsNull(b.Descripcion,''), " +
            "Categoria    = IsNull(c.Descripcion,''), " +
            "Departamento = IsNull(d.Descripcion,'')  " +  
     "From SMercado..Cat_Productos a(NoLock) " +
     "LEFT Join SMercado..Cat_Marcas b On b.IdMarca = a.IdMarca " +
     "Left Join SMercado..Cat_Categorias c On c.IdCategoria = a.IdCategoria " +
     "Left Join SMercado..Cat_Departamentos d On d.IdDepartamento=a.IDDepartamento " + 
     "Where 1 = 1 " 
     If LEN(LTrim(RTrim(@Valor1))) > 0
      Begin
       Select @Sql = @Sql + " And a.IdDepartamento = " + @Valor1
      End
     If LEN(LTrim(RTrim(@Valor2))) > 0
      Begin
       Select @Sql = @Sql + " And a.idcategoria = " + @Valor2
      End 
      If LEN(LTRIM(RTrim(@Valor3))) > 0
       Begin
        Select @Sql = @Sql + " And a.idmarca = " + @Valor3
       End
      
     Select @Sql = @Sql + " Order By d.Descripcion,c.Descripcion,b.Descripcion,a.Codigo "
     
     Exec(@Sql)
 
	 Select @Registro = @@RowCount	 
   End

  If @Validar = 1
   Begin
    Select @Desc1 = IsNull(a.Descripcion,''),
           @Desc2 = IsNull(d.IdDepartamento,0),
           @Desc3 = ISNULL(d.Descripcion,''),
           @Desc4 = IsNull(c.IdCategoria,0),
           @Desc5 = IsNull(c.Descripcion,0),
           @Desc6 = IsNull(b.IdMarca,0),                      
           @Desc7 = IsNull(b.Descripcion,'')
    From SMercado..Cat_Productos a(NoLock)
    Left Join SMercado..Cat_Departamentos d (NoLock)on d.IdDepartamento = a.IDDepartamento 
    Left Join SMercado..Cat_Marcas b (NoLock) On b.IdMarca = a.IdMarca
    Left Join SMercado..Cat_Categorias c (NoLock) On c.IdCategoria = a.IdCategoria
    Where a.Codigo = @Valor4

	 Select @Registro = @@RowCount	 
   End

  If @Validar = 2
   Begin
    Select @Desc1  = IsNull(a.Descripcion,''),
           @Desc2  = IsNull(a.IdUnidad,''),
           @Desc3  = IsNull(b.Descripcion,''),
           @Desc4  = IsNull(a.StockMinimo,''),
           @Desc5  = IsNull(a.CostoCompra,0),
           @Desc6  = IsNull(a.Flete,0),
           @Desc7  = IsNull(a.Margen,0),
           @Desc8  = IsNull(a.PrecioVenta,0),
           @Desc9  = ISNULL(c.IdDepartamento,0),
           @Desc10 = ISNULL(c.Descripcion,''),
           @Desc11 = IsNull(d.IdMarca,0),                      
           @Desc12 = IsNull(d.Descripcion,''),
           @Desc13 = IsNull(e.IdCategoria,0),
           @Desc14 = IsNull(e.Descripcion,''),
           @Desc15 = ISNULL(a.inventarioInicial,0)
    From SMercado..Cat_Productos a (NoLock)
    Left Join SMercado..Cat_Unidades b (NoLock) On b.IdUnidad = a.IdUnidad
    Left Join SMercado..Cat_Departamentos c (NoLock) on c.IdDepartamento = a.IDDepartamento 
    Left Join SMercado..Cat_Marcas d (NoLock) On d.IdMarca = a.IdMarca
    Left Join SMercado..Cat_Categorias e (NoLock) On e.IdCategoria = a.IdCategoria
    Where a.IdDepartamento = @Valor1 And a.IdCategoria = @Valor2 And a.IdMarca = @Valor3 And a.Codigo = @Valor4

	 Select @Registro = @@RowCount	 
   End

 If @Validar = 3
   Begin
    Select @Desc1 = IsNull(a.Descripcion,'')
    From SMercado..Cat_Productos a(NoLock)
    Where a.Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=No Existe ningun producto|'
      If @Validar = 1 
         Select @Resul = '2R=OK|'
      If @Validar = 2
         Select @Resul = '2R=OK|'
      If @Validar = 3
         Select @Resul = '2R=ERROR|2M=No esta registrado el codigo del producto'
   End
  Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Catálogo de categorías|VALCOL=87*400|'
      If @Validar = 1 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|V2=' + @Desc2 + '|V3=' + @Desc3 + '|V4=' + @Desc4 + '|V5=' + @Desc5 + '|V6=' + @Desc6 + '|V7=' + @Desc7 + '|'
      If @Validar = 2 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|V2=' + @Desc2 + '|V3=' + @Desc3 + '|V4=' + @Desc4 + '|V5=' + @Desc5 + '|V6=' + @Desc6 +
                         '|V7=' + @Desc7 + '|V8=' + @Desc8 + '|V9=' + @Desc9 + '|V10=' + @Desc10 + '|V11=' + @Desc11 + '|V12=' + @Desc12 + 
                         '|V13=' + @Desc13 + '|V14=' + @Desc14 + '|V15=' + @Desc15 + '|'  
      If @Validar = 3
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
    End

  Set NoCount OFF
END