drop proc dbo.Consulta125
go

CREATE  PROCEDURE [dbo].[Consulta125]
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
  --Cotizaciones
  ------------------------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)
  Declare @Valor2    VarChar(8000)
  Declare @Valor3    VarChar(8000)
  Declare @Valor4    VarChar(8000)
  Declare @Valor5    VarChar(8000)
  Declare @Valor6    VarChar(8000)
  Declare @Valor7    VarChar(8000)
  Declare @Valor8    VarChar(8000)
  Declare @Valor9    VarChar(8000)
  Declare @Valor10   VarChar(8000)
  Declare @Valor11   VarChar(8000)
  Declare @Valor12   VarChar(8000)
  Declare @Valor13   VarChar(8000)
  Declare @Valor14   VarChar(8000)
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Facturas
  
   --Validar Parametros
  If @Validar = 1 
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el número de cotización para continuar|'
       Return
     End
   End
 
  If @Validar = 4 
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el número de cotización para continuar|'
       Return
     End
   End
 

  If @Validar = 0               ----Catalogo de productos
   Begin
    Select Codigo       = IsNull(a.Codigo,''), 
           Descripción  = IsNull(a.Descripcion,''),
           Precio       = IsNull(a.PrecioVenta,0)
    From Smercado..Cat_Productos a (NoLock)
    Order by a.Codigo 
	 Select @Registro = @@RowCount	 
   End

  If @Validar = 1  ------Codigo Producto Enter
   Begin
    Select @Desc1  = IsNull(a.Descripcion,''),
           @Desc2  = IsNull(b.Descripcion,''),
           @Desc3  = ISNULL(a.PrecioVenta,0)
       From SMercado..Cat_Productos a (NoLock)
       Left Join SMercado..Cat_Unidades b (NoLock) On b.IdUnidad = a.IdUnidad
       Where a.Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End


 If @Validar = 2
   Begin
      
     Select C1 = IsNull(a.IdProducto,''),
            C2 = IsNull(a.Descripcion,''),
            C3 = ISNULL(a.cantidad,0),
            C4 = ISNULL(a.Unidad,''),
            C5 = ISNULL(a.CostoUnitario,0),
            C6 = ISNULL(a.CostoTotal,0)
     From SMercado..Entrada_detalles a (NoLock)
     Where a.idEntrada= @Valor1 
     
	 Select @Registro = @@RowCount	 
	 
   End

 If @Validar = 3               ----Catalogo de productos
   Begin
    Select Codigo       = IsNull(a.NoCotizacion ,0), 
           Cliente  = IsNull(b.NombreFiscal ,''),
           Fecha       = IsNull(a.Fecha ,'')
    From Smercado..Cotizaciones a (NoLock)
    Left Join SMercado..Cat_Clientes b (NoLock) On b.Codigo = a.IdCliente 
    Order by a.NoCotizacion  
	 Select @Registro = @@RowCount	 
   End


 If @Validar = 4
   Begin
      
     Select @Desc2 = IsNull(a.Fecha,''),
            @Desc3 = ISNULL(a.IVA,0.0),
            @Desc4 = IsNull(a.IdCliente,''),
            @Desc5 = IsNull(b.RFC,''),
            @Desc6 = IsNull(b.NombreFiscal,''),
            @Desc7 = IsNull(b.Direccion,''),
            @Desc8 = IsNull(b.colonia,''),
            @Desc9 = ISNULL(b.CP,''),
            @Desc10 = ISNULL(c.Descripcion,''),
            @Desc11 = ISNULL(d.Descripcion,'')
     From Smercado..Cotizaciones a (NoLock)
     Left Join SMercado..Cat_Clientes b (NoLock) On b.codigo = a.IdCliente
     Left Join SMercado..Cat_EstadosdelaRepublica c (NoLock) On c.IdEstado = b.IdEstado 
     Left Join SMercado..Cat_Ciudades d (NoLock) On d.idciudad = b.IdCiudad  
     Where a.Nocotizacion = @Valor1
     
	 Select @Registro = @@RowCount	 
	 
	 
	 Select C1 = IsNull(a.IdProducto,''),
            C2 = IsNull(a.Descripcion,''),
            C3 = ISNULL(a.cantidad,0),
            C4 = ISNULL(c.Descripcion,''),
            C5 = ISNULL(a.PrecioUni,0),
            C6 = IsNull(Sum(a.cantidad * a.precioUni * a.Descuento),0),
            C8 = ISNULL (a.descuento,0)
	 From SMercado..Cotizaciones_Detalles a (NoLock)
	 Left Join Smercado..Cat_Productos b (NoLock) On b.Codigo = a.idProducto
	 Left Join SMercado..Cat_Unidades c (NoLock) On b.IdUnidad = c.IdUnidad 
	 Where a.NoCotizacion = @Valor1
	 group by a.IdProducto,a.Descripcion,a.cantidad,c.Descripcion,a.PrecioUni,a.Descuento 
	 
   End

  If @Validar = 5
   Begin
     Select @Desc1 = IsNull(Min(Convert(Integer,Nocotizacion)),0) + 1 
     From SMercado..Cotizaciones (NoLock)
   End 
   
      If @Validar = 7
      Begin
        --Seleccionar el nuevo ID
       Select @Desc1 = Isnull(Min(IsNull(Nocotizacion,0)),0)
       From Smercado..Cotizaciones (NoLock)
       Where Len(RTrim(LTrim(iva))) = 100                   
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Cotizaciones(Iva) 
          Values(100)
        
       Select @Desc1 = Isnull(Min(IsNull(IdMarca,0)),0)
       From SMercado..Cat_Marcas(NoLock)
       Where Len(RTrim(LTrim(Descripcion))) = 0    
       
       Select @Registro = 1   
        End
    End
    
  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=El catálogo de productos esta vacio|'
      If @Validar = 1 
         Select @Resul = '2R=ERROR|2M=No esta registrado el codigo especificado|'
	  If @Validar = 2
		 Select @Resul = '2R=ERROR|2M=No existe una entrada con el codigo especificado. Clic en Nuevo para crear una nueva entrada'
	  If @Validar = 3
		 Select @Resul = '2R=ERROR|2M=El producto no esta registrado|'
	  If @Validar = 4 
         Select @Resul = '2R=OK|V2=' + @Desc2 + 
							  '|V3=' + '16' + 
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + 
							  '|V6=' + @Desc6 + 
							  '|V7=' + @Desc7 + 
							  '|V8=' + @Desc8 + 
							  '|V9=' + @Desc9 + 
							  '|V10=' + @Desc10 + 
							  '|V11=' + @Desc11 + 
							  '|V12=' + '1' + 
							  '|V13=' + @Desc13 + 
							  '|V14=' + @Desc14+ '|'
      
  End
   Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|'
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
							  '|V2=' + @Desc2 + '|'
	  If @Validar = 4 
         Select @Resul = '2R=OK|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + 
							  '|V4=' + @Desc4 + 
							  '|V5=' + @Desc5 + 
							  '|V6=' + @Desc6 + 
							  '|V7=' + @Desc7 + 
							  '|V8=' + @Desc8 + 
							  '|V9=' + @Desc9 + 
							  '|V10=' + @Desc10 + 
							  '|V11=' + @Desc11 + 
							  '|V12=' + @Desc12 + 
							  '|V13=' + @Desc13 + 
							  '|V14=' + @Desc14 + '|'
	  If @Validar = 7 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
    End
  Set NoCount OFF
END


