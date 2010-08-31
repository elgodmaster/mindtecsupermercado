drop proc dbo.Reporte005
go

CREATE  PROCEDURE [dbo].[Reporte005]
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
  --Facturas
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
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Nofactura
  Exec Emulador_SepararCadena 'V2', @Cabezero, '|', @Valor2 Output --codigoCliente
  Exec Emulador_SepararCadena 'V3', @Cabezero, '|', @Valor3 Output --Fecha1
  Exec Emulador_SepararCadena 'V4', @Cabezero, '|', @Valor4 Output --Fecha2
  
   
   --Validar Parametros
  If @Validar = 1
   Begin 
	 
	   --Armar Query
     Select @Sql = " Select C0 = LTrim(RTrim(IsNull(a.nofactura,''))), " +
       "C1 = LTrim(RTrim(IsNull(c.NombreFiscal,''))), " +
       "C2 = Convert(VarChar, DateAdd(d,0,IsNull(a.Fecha,'')), 110), " + 
       "C3 = (Select LTrim(RTrim(IsNull(SUM(convert(Decimal(18,2),b.cantidad * b.PrecioUni * b.Descuento)),0)))), " + 
       "C4 = (Select LTrim(RTrim(IsNull(SUM(convert(Decimal(18,2),b.cantidad * b.PrecioUni * b.Descuento * (a.IVA / 100 ))),0)))), " +
       "C5 = (Select LTrim(RTrim(IsNull(SUM(convert(Decimal(18,2),b.cantidad * b.PrecioUni * b.Descuento * ((a.IVA / 100) + 1))),0)))) " +
       "From SMercado..Facturas a " +  
       "Left Join SMercado..Factura_Detalles b On b.NoFactura = a.NoFactura " + 
       "Left Join SMercado..Cat_Clientes c On c.Codigo = a.IdCliente " + 
       " Where 1 = 1 " 

 Select @Sql = @Sql + "And a.Fecha Between '" + @Valor3 + "' And '" + @Valor4 + "' "

             If Len(@Valor1) > 0
              Begin
               Select @Sql = @Sql + " And a.NoFactura = '" + @Valor1 + "' "
              End
              
              If Len(@Valor2) > 0
              Begin
               Select @Sql = @Sql + " And a.idcliente = '" + @Valor2 + "' "
              End

 
  Select @Sql = @Sql + " group by a.NoFactura,c.NombreFiscal, a.Fecha  order by a.fecha,c.NombreFiscal"

  
  Exec(@Sql)

	 Select @Registro = @@RowCount
   End
 

  -- Enviar Resultado 

  If @Registro = 0
   Begin
	  If @Validar = 1 
         Select @Resul = '2R=ERROR|2M=No hay información de productos para realizar un reporte'
  End
   Else
    Begin
	  If @Validar = 1
        Select @Resul = '2R=OK|'
    End
  Set NoCount OFF
END


