drop proc dbo.Consulta115
go

CREATE  PROCEDURE [dbo].[Consulta115]
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
  --Modulo de Ventas
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Ventas
  
  -- Validar Parametros
  --If @Validar = 1 or @Validar = 2
  -- Begin 
  --  If Len(RTrim(LTrim(@Valor1))) = 0 
  --   Begin
  --     Select @Resul = '2R=ERROR|2M=Registre el codigo de la entrada para continuar|'
  --     Return
  --   End
  -- End
  
  --If @Validar = 3 or @Validar = 6 
  -- Begin 
  --  If Len(RTrim(LTrim(@Valor1))) = 0 
  --   Begin
  --     Select @Resul = '2R=ERROR|2M=Registre el codigo del producto para continuar|'
  --     Return
  --   End
  -- End

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


 
  If @Validar = 5
     Begin    
       Select @Desc1 = Isnull(Min(IsNull(IdVenta,0)),0)
       From SMercado..Ventas (NoLock)
       Where IdTipoCambio = 10000 And IdUsuario = @Valor1              
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Ventas(Factura,Fecha,IdCliente,IdUsuario,idTipoCambio) 
          Values(0,'',0,@Valor1,10000)
        
       Select @Desc1 = Isnull(Min(IsNull(IdVenta,0)),0)
       From SMercado..Ventas(NoLock)
       Where idTipoCambio = 10000 And IdUsuario = @Valor1
       End
       
       Select @Registro = 1                  
     End 

    If @Validar = 6
     Begin
       
	 Select @Registro = @@RowCount	 
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
         Select @Resul = '2R=OK|'
      If @Validar = 6
         Select @Resul= '2R=ERROR|2M=El producto no esta registrado'
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
         Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + '|'
      If @Validar = 5
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 6 
         Select @Resul = '2R=OK|V1=' + @Desc1 + 
							  '|V2=' + @Desc2 + 
							  '|V3=' + @Desc3 + '|'
    End
  Set NoCount OFF
END


