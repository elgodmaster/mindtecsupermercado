drop proc dbo.Consulta106
go

CREATE PROCEDURE dbo.Consulta106
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
  --Catalogo de proveedores
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
  Declare @Desc16    VarChar(8000)
  Declare @Desc17    VarChar(8000)
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
  Select @Desc16  = '' 
  Select @Desc17  = '' 
  Select @Resul   = ''
  Select @Resul2  = ''

  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo proveedor

  -- Validar Parametros
  If @Validar = 1 or @Validar = 2
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo del proveedor para continuar|'
       Return
     End
   End
 
  If @Validar = 0               
   Begin
     Select Codigo = IsNull(Codigo,0),
            Descripción = IsNull(Nombre,'')
     From SMercado..Cat_Proveedores (NoLock)
     Order By Codigo

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 1
   Begin
     Select @Desc1 = IsNull(Nombre,'')
     From SMercado..Cat_Proveedores (NoLock)
     Where Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 2
   Begin
     Select @Desc1  = IsNull(a.Nombre,''),
            @Desc2  = IsNull(a.RFC,''),
            @Desc3  = IsNull(a.Colonia,''),
            @Desc4  = IsNull(a.Direccion,''),
            @Desc5  = IsNull(a.Cp,''),
            @Desc6  = IsNull(a.IdEstado,''),
            @Desc7  = IsNull(b.Descripcion,''),
            @Desc8  = IsNull(a.IdCiudad,''),
            @Desc9  = IsNull(c.Descripcion,''),
            @Desc10  = IsNull(a.Telefono1,''),
            @Desc11  = IsNull(a.Extencion1,''),
            @Desc12  = IsNull(a.Telefono2,''),
            @Desc13 = IsNull(a.Extencion2,''),
            @Desc14 = IsNull(a.Celular1,''),
            @Desc15 = IsNull(a.Celular2,''),
            @Desc16 = IsNull(a.Email,''),
            @Desc17 = IsNull(a.Fax,'')      
     From SMercado..Cat_Proveedores a (NoLock)  
     Left Join SMercado..Cat_EstadosdelaRepublica b (NoLock) On b.IdEstado = a.IdEstado
     Left Join SMercado..Cat_Ciudades c (NoLock) On c.IdCiudad = a.IdCiudad And c.IdEstado = a.IdEstado
     Where Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End
  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=No hay datos en el catálogo de proveedores|'
      If @Validar = 1 
         Select @Resul = '2R=OK|'
      If @Validar = 2 
         Select @Resul = '2R=OK|'
   End
  Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Catálogo de proveedores|VALCOL=87*400|'
      If @Validar = 1 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 2
        Begin 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|V2=' + @Desc2 + '|V3=' + @Desc3 + '|V4=' + @Desc4 + '|V5=' + @Desc5 + '|V6=' + @Desc6 +
                         '|V7=' + @Desc7 + '|V8=' + @Desc8 + '|V9=' + @Desc9 + '|V10=' + @Desc10 + '|V11=' + @Desc11 + '|V12=' + @Desc12 + 
                         '|V13=' + @Desc13 + '|V14=' + @Desc14 + '|V15=' + @Desc15 + '|V16=' + @Desc16 + '|V17=' + @Desc17 + '|' 
        End
    End

  Set NoCount OFF
END