drop proc dbo.Consulta105
go

CREATE PROCEDURE dbo.Consulta105
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
  --Catalogo de clientes
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
  Declare @Desc18	 Varchar(8000)
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
  Select @Desc18  = ''
  Select @Resul   = ''
  Select @Resul2  = ''

  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo Cliente

  -- Validar Parametros
  If @Validar = 1 or @Validar = 2
   Begin 
    If Len(RTrim(LTrim(@Valor1))) = 0 
     Begin
       Select @Resul = '2R=ERROR|2M=Registre el codigo del cliente para continuar|'
       Return
     End
   End
 
  If @Validar = 0               
   Begin
     Select Codigo = IsNull(Codigo,''),
            Descripción = IsNull(NombreFiscal,'')
     From SMercado..Cat_Clientes (NoLock)
     Order By Codigo

	 Select @Registro = @@RowCount	 
   End
   
  If @Validar = 1
   Begin
     Select @Desc1 = IsNull(NombreFiscal,'')
     From SMercado..Cat_Clientes (NoLock)
     Where Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 2
   Begin
     Select @Desc1  = IsNull(a.NombreFiscal,''),
            @Desc2  = IsNull(a.RFC,''),
            @Desc3  = IsNull(a.Colonia,''),
            @Desc4  = IsNull(a.Direccion,''),
            @Desc5  = IsNull(a.Cp,''),
            @Desc6  = IsNull(b.Descripcion,''),
            @Desc7  = IsNull(c.Descripcion,''),
            @Desc8  = IsNull(a.Telefono1,''),
            @Desc9  = IsNull(a.Extencion1,''),
            @Desc10 = IsNull(a.Telefono2,''),
            @Desc11 = IsNull(a.Extencion2,''),
            @Desc12 = IsNull(a.Cel1,''),
            @Desc13 = IsNull(a.Cel2,''),
            @Desc14 = IsNull(a.Fax,''),
            @Desc15 = IsNull(a.Email,''),
            @Desc16 = IsNull(a.LimiteCredito, '0'),
            @Desc17 = IsNull(a.Adeudo, '0')
                  
     From SMercado..Cat_Clientes a (NoLock)
     Left Join SMercado..Cat_EstadosdelaRepublica b (NoLock) On b.IdEstado = a.IdEstado
     Left Join SMercado..Cat_Ciudades c (NoLock) On c.IdCiudad = a.IdCiudad And c.IdEstado = a.IdEstado 
     Where Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End
   If @Validar = 3
   Begin
     Select @Desc1  = IsNull(a.NombreFiscal,''),
            @Desc2  = IsNull(a.RFC,''),
            @Desc3  = IsNull(a.Colonia,''),
            @Desc4  = IsNull(a.Direccion,''),
            @Desc5  = IsNull(a.Cp,''),
            @Desc6  = IsNull(b.Descripcion,''),
            @Desc7  = IsNull(c.Descripcion,''),
            @Desc8 = IsNull(a.Telefono1,''),
            @Desc9 = IsNull(a.Extencion1,''),
            @Desc10 = IsNull(a.Telefono2,''),
            @Desc11 = IsNull(a.Extencion2,''),
            @Desc12 = IsNull(a.Cel1,''),
            @Desc13 = IsNull(a.Cel2,''),
            @Desc14 = IsNull(a.Fax,''),
			@Desc15 = IsNull(a.Email,''),
            @Desc16 = IsNull(a.LimiteCredito, '0'),
            @Desc17 = IsNull(a.Adeudo, '0')
     From SMercado..Cat_Clientes a (NoLock)
     Left Join SMercado..Cat_EstadosdelaRepublica b (NoLock) On b.IdEstado = a.IdEstado
     Left Join SMercado..Cat_Ciudades c (NoLock) On c.IdCiudad = a.IdCiudad And c.IdEstado = a.IdEstado 
     Where Codigo = @Valor1

	 Select @Registro = @@RowCount	 
   End
  -- Enviar Resultado 

  If @Registro = 0
   Begin
      If @Validar = 0 
         Select @Resul = '2R=ERROR|2M=No hay datos en el catálogo de clientes|'
      If @Validar = 1 
         Select @Resul = '2R=OK|'
      If @Validar = 2 
         Select @Resul = '2R=OK|'
	  If @Validar = 3
         Select @Resul = '2R=ERROR|2M=No exite el codigo del cliente|'
   End
  Else
    Begin
	  If @Validar = 0 
	     Select @Resul = '2R=OK|CATALOGO=Catálogo de clientes|VALCOL=87*400|'
      If @Validar = 1 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 2
        Begin 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|V2=' + @Desc2 + '|V3=' + @Desc3 + '|V4=' + @Desc4 + '|V5=' + @Desc5 + '|V6=' + @Desc6 +
                         '|V7=' + @Desc7 + '|V8=' + @Desc8 + '|V9=' + @Desc9 + '|V10=' + @Desc10 + 
                         '|V11=' + @Desc11 + '|V12=' + @Desc12 + '|V13=' + @Desc13 + '|V14=' + @Desc14 + '|V15=' + @Desc15 + '|V16=' + @Desc16 + 
                         '|V17=' + @Desc17 
                         
        End
	  If @Validar = 3
        Begin 
         Select @Resul = '2R=OK|V1=' + @Desc1 + '|V2=' + @Desc2 + '|V3=' + @Desc3 + '|V4=' + @Desc4 + '|V5=' + @Desc5 + '|V6=' + @Desc6 +
                         '|V7=' + @Desc7 + '|V8=' + @Desc8 + '|V9=' + @Desc9 + '|V10=' + @Desc10 + 
                         '|V11=' + @Desc11 + '|V12=' + @Desc12 + '|V13=' + @Desc13 + '|V14=' + @Desc14 + '|V15=' + @Desc15 + '|V16=' + @Desc16 + 
                         '|V17=' + @Desc17 
        End
    End
  Set NoCount OFF
  Select resultado = @Resul 
 
  
END