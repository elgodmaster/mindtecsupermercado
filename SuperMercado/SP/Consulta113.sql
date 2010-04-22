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
            C2 = IsNull(b.Descripcion,''),
            C3 = ISNULL(a.cantidad,0),
            C4 = ISNULL(c.Descripcion,'')
     From SMercado..Salida_detalles a (NoLock)
     Left Join Smercado..Cat_Productos b (NoLock) On b.IdProducto = a.IdProducto
     Left Join SMercado..Cat_Unidades c (NoLock) on c.IdUnidad = b.IdUnidad 
     Where a.idSalida = @Valor1 
     
     
	 Select @Registro = @@RowCount	 
	 
   End
   
  If @Validar = 3
     Begin    
       Select @Desc1 = Isnull(Min(IsNull(IdSalida,0)),0)
       From SMercado..Salidas (NoLock)
       Where LEN(LTRIM(RTrim(Motivo))) = 0                   
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Salidas(Motivo,fecha) 
          Values('','')
        
       Select @Desc1 = Isnull(Min(IsNull(IdSalida,0)),0)
       From SMercado..Salidas(NoLock)
       Where LEN(RTrim(LTrim(Motivo))) = 0    
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
      If @Validar = 6
         Select @Resul= '2R=ERROR|2M=El producto no esta registrado'
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
    End
  Set NoCount OFF
END


