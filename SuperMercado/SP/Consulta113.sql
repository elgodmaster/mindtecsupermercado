drop proc dbo.Consulta113
go

CREATE  PROCEDURE [dbo].[Consulta113]
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
  --Salidas Inventario
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Salidas

  -- Validar Parametros
  If @Validar = 1 or @Validar = 2
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo de salida para continuar|'
       Return
     End
   End
  
  If  @Validar = 6 
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo del producto para continuar|'
       Return
     End
   End

  If @Validar = 0               
   Begin
     Select Codigo = str(IsNull(a.IdSalida,0)),
            Fecha = IsNull(a.Fecha,''),
            Usuario = b.NombreUsuario,
            Motivo = IsNull(a.Motivo,'')
     From SMercado..Salidas a(NoLock)
     Left join Smercado_Seguridad..Usuarios b (NoLock) On b.IdUsuario = a.IdUsuario
    
     Order By a.IdSalida 

	 Select @Registro = @@RowCount	 
   End

  If @Validar = 1
   Begin
     Select @Desc1 = IsNull(Fecha,GETDATE()),
			@Desc3 = IsNull(Motivo,'')
     From SMercado..Salidas (NoLock)
     Where IdSalida = @Valor1

	 Select @Registro = @@RowCount	 
   End

 If @Validar = 2
   Begin
      Select @Desc1 = IsNull(Fecha,GETDATE()),
			 @Desc2 = IsNull(Motivo,'')
     From SMercado..Salidas (NoLock)
     Where IdSalida = @Valor1
     
     Select C1 = IsNull(a.IdProducto,''),
            C2 = IsNull(a.Descripcion,''),
            C3 = ISNULL(a.cantidad,0),
            C4 = ISNULL(a.Unidad,'')
     From SMercado..Salida_detalles a (NoLock)
     Where a.idSalida = @Valor1 
     
     
	 Select @Registro = @@RowCount	 
	 
   End
   
  If @Validar = 3
     Begin    
       Select @Desc1 = Isnull(Min(IsNull(IdSalida,0)),0)
       From SMercado..Salidas (NoLock)
       Where LEN(LTRIM(RTrim(Motivo))) = '0'                   
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Salidas(Motivo,fecha) 
          Values('','')
        
       Select @Desc1 = Isnull(Min(IsNull(IdSalida,0)),0)
       From SMercado..Salidas(NoLock)
       Where LEN(RTrim(LTrim(Motivo))) = '0'    
       End
       
       Select @Registro = 1                  
     End 

    If @Validar = 4
     Begin
       Select @Desc1  = IsNull(a.Descripcion,''),
              @Desc2  = IsNull(b.Descripcion,''),
              @Desc3  = ISNULL(a.CostoCompra,0)
       From SMercado..Cat_Productos a (NoLock)
       Left Join SMercado..Cat_Unidades b (NoLock) On b.IdUnidad = a.IdUnidad
       Where a.Codigo = @Valor1
	 Select @Registro = @@RowCount	 
     End

    If @Validar = 5
     Begin
      Select Año           = IsNull(str(year(a.fecha)),''),
	  	     Mes           = IsNull(str(month(a.fecha)),''),
			 Dia           = IsNull(str(day(a.fecha)),''),
			 Salida        = IsNull(str(a.idSalida),''),
			 Usuario       = 'usuario nombre',
			 Departamento  = ISNULL(e.descripcion,''),
			 Categoria     = IsNull(f.descripcion,''),
			 Marca         = IsNull(g.descripcion,''),
			 CodProducto   = IsNull(c.codigo,''),
			 Producto      = IsNull(c.descripcion,''),
			 Cantidad      = IsNull(str(b.cantidad),''),
			 Unidad        = IsNull(h.descripcion,''),
			 Costo         = ISNULL(c.CostoCompra,0),
			 CostoTotal    = Convert(Decimal(18,2),IsNull(SUM(c.costocompra * b.cantidad),0)),
			 Motivo        = IsNull(a.Motivo,'') 
      From SMercado..Salidas a (NoLock)
      Left Join Smercado..Salida_Detalles b (NoLock) On b.Idsalida = a.IdSalida  
      Left join Smercado..cat_productos c (NoLock) On c.codigo = b.idproducto
      Left join SMercado..Cat_Departamentos e (NoLock) On e.IdDepartamento = c.IDDepartamento 
      Left join SMercado..cat_categorias f (NoLock) On f.idcategoria = c.idcategoria
	  Left join SMercado..cat_marcas g (NoLock) On g.idmarca = c.idmarca
      Left join SMercado..Cat_Unidades h (NoLock) On h.IdUnidad = c.IdUnidad 
      Group By a.fecha,a.IdSalida,c.Codigo,c.Descripcion,e.Descripcion,f.Descripcion,g.Descripcion,b.cantidad,h.Descripcion,c.CostoCompra,a.motivo 
 End

  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=El catálogo de entradas esta vacio|'
      If @Validar = 1 
         Select @Resul = '2R=ERROR|2M=No existe una entrada con el codigo especificado|'
	  If @Validar = 2
		 Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 +
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + '|'
	  If @Validar = 3
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 5
         Select @Resul= '2R=ERROR|2M=No existen salidas'
  End
   Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Catálogo de categorías|'
      If @Validar = 1 
         Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + '|'
	  If @Validar = 2 
	     Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 +
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + '|'
	  If @Validar = 3
		 Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
	  If @Validar = 4 
         Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + '|'
	  If @Validar = 5
	     Select @Resul = '2R=OK|'
    End
  Set NoCount OFF
END


