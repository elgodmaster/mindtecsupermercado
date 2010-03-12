drop proc dbo.Consulta101
go

CREATE PROCEDURE dbo.Consulta101
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
  --Catalogo de categorias
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo Categorias

  -- Validar Parametros
  If @Validar = 1 or @Validar = 2
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo de la categoría para continuar|'
       Return
     End

  If dbo.Fnc_ESNumero(@Valor1) <> 1
     Begin
       Select @Resul = '2R=ERROR|2M=El codigo de la categoría debe ser numérico|'
       Return
     End

   End
 
  If @Validar = 0               
   Begin
     Select Codigo = Str(IsNull(IDCategoria,0)),
            Descripción = IsNull(Descripcion,'')
     From SMercado..Cat_Categorias (NoLock)
     Order By IDCategoria  

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 1
   Begin
     Select @Desc1 = IsNull(Descripcion,'')
     From Smercado..Cat_Categorias (NoLock)
     Where IdCategoria = @Valor1

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 2
   Begin
     Select @Desc1  = IsNull(Descripcion,'')       
     From SMercado..Cat_Categorias (NoLock) 
     Where IdCategoria = @Valor1

	 Select @Registro = @@RowCount	 
   End

   If @Validar = 3
      Begin
        --Seleccionar el nuevo ID
       Select @Desc1 = Isnull(Min(IsNull(IdCategoria,0)),0)
       From Smercado..Cat_Categorias (NoLock)
       Where Len(RTrim(LTrim(Descripcion))) = 0                   
  
       If @Desc1 = 0
        Begin
          Insert SMercado..Cat_Categorias(Descripcion) 
          Values('')
        
       Select @Desc1 = Isnull(Min(IsNull(IdCategoria,0)),0)
       From SMercado..Cat_Categorias(NoLock)
       Where Len(RTrim(LTrim(Descripcion))) = 0    
       
       Select @Registro = 1   
        End
    End


  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=No hay datos en el catálogo de categorias|'
      If @Validar = 1 
         Select @Resul = '2R=OK|'
      If @Validar = 2 
         Select @Resul = '2R=OK|'
   End
  Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Catálogo de categorias|'
      If @Validar = 1 or @Validar = 3
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 2
        Begin 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|' 
        End
    End

  Set NoCount OFF
END