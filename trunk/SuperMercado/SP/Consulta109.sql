drop proc dbo.Consulta109
go

CREATE  PROCEDURE [dbo].[Consulta109]
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
  --Entradas
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Entradas

  -- Validar Parametros
  If @Validar = 1 or @Validar = 2
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo de la entrada para continuar|'
       Return
     End
   End
  
  If @Validar = 3
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo del producto para continuar|'
       Return
     End
   End

  If @Validar = 0               
   Begin
     Select Codigo = str(IsNull(a.IdEntrada,0)),
            Fecha = IsNull(a.Fecha,''),
            Proveedor = ISNULL(b.Nombre,''),
			Factura = IsNull(a.folioFactura,'')

     From SMercado..Entradas a(NoLock)
     Left join Smercado..Cat_Proveedores b (NoLock) On b.IdProveedor = a.IdProveedor 
    
     Order By a.IdEntrada

	 Select @Registro = @@RowCount	 
   End

  If @Validar = 1
   Begin
     Select @Desc1 = IsNull(Fecha,''),
			@Desc2 = str(IsNull(idUsuario,0)),
			@Desc3 = IsNull(folioFactura,'')
     From SMercado..Entradas (NoLock)
     Where IdEntrada = @Valor1

	 Select @Registro = @@RowCount	 
   End

 If @Validar = 2
   Begin
     Select @Desc1 = IsNull(a.Fecha,GETDATE()),
            @Desc2 = ISNULL(a.idproveedor,''),
            @Desc3 = ISNULL(b.Nombre,''),
            @Desc4 = IsNull(a.FolioFactura,'')
     From SMercado..Entradas a (NoLock) 
     Left Join SMercado..Cat_Proveedores b (NoLock) On b.IdProveedor = a.idproveedor
     Where a.idEntrada = @Valor1 
     
     Select C1 = IsNull(a.IdProducto,''),
            C2 = IsNull(b.Descripcion,''),
            C3 = ISNULL(a.cantidad,0),
            C4 = ISNULL(c.Descripcion,'')
     From SMercado..Entrada_detalles a (NoLock)
     Left Join Smercado..Cat_Productos b (NoLock) On b.IdProducto = a.IdProducto
     Left Join SMercado..Cat_Unidades c (NoLock) on c.IdUnidad = b.IdUnidad 
     Where a.idEntrada= @Valor1 
     
     
	 Select @Registro = @@RowCount	 
	 
   End


  if @Validar = 3
   Begin
    select @Desc1 = IsNull(p.codigo,''),
            @Desc2 = ISNULL(dp.Descripcion,''),
			@Desc3 = IsNull(c.descripcion,''),
			@Desc4 = IsNull(p.descripcion,''),
			@Desc5 = IsNull(m.descripcion,'')
			
	from SMercado..Cat_Productos p 
	inner join SMercado..Cat_Departamentos Dp on Dp.IdDepartamento = p.IDDepartamento 
	inner join SMercado..Cat_Categorias c on c.IdCategoria=p.IdCategoria and p.codigo=@Valor1
	inner join SMercado..Cat_Marcas m on  m.IdMarca=p.IdMarca

	 Select @Registro = @@RowCount	 
   End

 If @Validar = 4
   Begin
     Select @Desc1 = IsNull(Fecha,''),
			@Desc2 = str(IsNull(idUsuario,0)),
			@Desc3 = IsNull(folioFactura,'')
     From SMercado..Entradas (NoLock)
     Where IdEntrada = @Valor1


	 select Codigo = IsNull(p.codigo,''),
			Categoria = IsNull(c.descripcion,''),
			Producto = IsNull(p.descripcion,''),
			Marca = IsNull(m.descripcion,''), 
			Cantidad = IsNull(str(ed.cantidad),'0.0'),
			Unidad = IsNull(u.descripcion,'')
			--Proveedor = IsNull(ed.idProveedor,'')
	from SMercado..Entrada_Detalles ed 
	inner join SMercado..Cat_Productos p on ed.IdProducto=p.IdProducto and ed.IdEntrada=@valor1
	inner join SMercado..Cat_Categorias c on c.IdCategoria=p.IdCategoria
	inner join SMercado..Cat_Marcas m on  m.IdMarca=p.IdMarca
	inner join SMercado..Cat_Unidades u on u.IdUnidad=p.IdUnidad

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 5
     Begin    
       Select @Desc1 = Isnull(Min(IsNull(IdEntrada,0)),0)
       From SMercado..Entradas (NoLock)
       Where FolioFactura = 0                   
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Entradas(folioFactura,fecha,IdProveedor) 
          Values(0,'',0)
        
       Select @Desc1 = Isnull(Min(IsNull(IdEntrada,0)),0)
       From SMercado..Entradas(NoLock)
       Where folioFactura = 0    
       End
       
       Select @Registro = 1                  
     End 

  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=El cat�logo de entradas esta vacio|'
      If @Validar = 1 
         Select @Resul = '2R=ERROR|2M=No existe una entrada con el codigo especificado|'
	  If @Validar = 2
		 Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 +
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + '|'
	  If @Validar = 3
		 Select @Resul = '2R=ERROR|2M=El producto no existe|'
	  If @Validar = 4 
         Select @Resul = '2R=OK|'
  End
   Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Cat�logo de categor�as|'
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
		 Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 +
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + '|'
	  If @Validar = 4 
         Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + '|'
      If @Validar = 5
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
    End
  Set NoCount OFF
END

