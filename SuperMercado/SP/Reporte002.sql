drop proc dbo.Reporte002
go

CREATE  PROCEDURE [dbo].[Reporte002]
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
  --Clientes
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --codigocliente
  Exec Emulador_SepararCadena 'V2', @Cabezero, '|', @Valor2 Output --Estado
  Exec Emulador_SepararCadena 'V3', @Cabezero, '|', @Valor3 Output --Ciudad
  
   
   --Validar Parametros
  If @Validar = 1
   Begin 
	 
	   --Armar Query
    Select @Sql = " Select C0 = LTrim(RTrim(IsNull(a.Codigo,''))), " +
                          "C1 = LTrim(RTrim(IsNull(a.NombreFiscal,''))), " +
                          "C2 = Ltrim(RTrim(IsNull(a.RFC,''))), " +
                          "C3 = LTrim(RTrim(IsNull(a.Direccion,''))), " +
                          "C4 = Ltrim(RTrim(IsNull(a.Colonia,''))), " +
                          "C5 = LTrim(RTrim(IsNull(a.Cp,''))), " +
                          "C6 = Ltrim(RTrim(IsNull(b.descripcion,''))), " +
                          "C7 = LTrim(RTrim(IsNull(c.descripcion,''))), " +
                          "C8 = Ltrim(RTrim(IsNull(a.Telefono1,''))), " + 
                          "C9 = LTrim(RTrim(IsNull(a.Extencion1,''))), " +
                          "C12 = Ltrim(RTrim(IsNull(a.Cel1,''))), " +
                          "C14 = LTrim(RTrim(IsNull(a.Fax,''))), " +
                          "C15 = Ltrim(RTrim(IsNull(a.Email,''))) " +
                  " From Smercado..Cat_Clientes a (NoLock) " +
                  "LEFT Join Smercado..Cat_Estadosdelarepublica b On b.idestado = a.idestado " + 
                  "LEFT Join  Smercado..Cat_Ciudades c On c.idestado = b.idestado And c.idciudad = a.idciudad " + 
                  " Where 1 = 1 " 
 
             If Len(@Valor1) > 0
              Begin
               Select @Sql = @Sql + " And a.codigo = '" + @Valor1 + "'"
              End
              
             If Len(@Valor2) > 0
              Begin
               Select @Sql = @Sql + " And a.idestado = '" + @Valor2 + "'"
              End
              
             If Len(@Valor3) > 0
              Begin
               Select @Sql = @Sql + " And a.idciudad = '" + @Valor3 + "'"
              End
 
  Select @Sql = @Sql + " Order By a.codigo"

  
  Exec(@Sql)

	 Select @Registro = @@RowCount
   End
 

  -- Enviar Resultado 

  If @Registro = 0
   Begin
	  If @Validar = 1 
         Select @Resul = '2R=ERROR|No hay información de clientes para realizar un reporte'
  End
   Else
    Begin
	  If @Validar = 1
        Select @Resul = '2R=OK|'
    End
  Set NoCount OFF
END


