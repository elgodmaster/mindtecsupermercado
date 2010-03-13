drop proc dbo.GRABAR109
go

CREATE PROCEDURE [dbo].[GRABAR109]
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN
  Set NoCount On
  --------------------------
  --Marcas
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Valor3    VarChar(8000)
  Declare @Valor4    Varchar(8000)
  Declare @Valor5    Varchar(8000)
  Declare @Valor6    Varchar(8000)
  Declare @Valor7    Varchar(8000)
  Declare @Valor8    Varchar(8000)
  Declare @Valor9    Varchar(8000)
  Declare @Valor10   Varchar(8000)
  Declare @Valor11   Varchar(8000)
  Declare @Valor12   Varchar(8000)
  Declare @Valor13   Varchar(8000)
  Declare @Valor14   Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio de entrada
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Fecha
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Usuario
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --Folio de factura
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --Folio de proveedor
 
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código de Entrada para continuar|'
     Return    
   End
  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre una fecha para continuar|'
     Return    
   End
 
  If Len(RTrim(LTrim(@Valor4)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre una factura para continuar|'
     Return    
   End

 If Len(RTrim(LTrim(@Valor5)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre un proveedor para continuar|'
     Return    
   End 

------------------------------------------------------------------------
    --Caja de proveedores
    ------------------------------------------------------------------------
     Select @Desc0 = 'V1=' + @Valor5 + '|'
     Exec Consulta106 @Desc0,@Resul2 Output,'',1
     Exec Emulador_SepararCadena '2R', @Resul2, '|', @Desc0 Output
     If Upper (@Desc0) <> 'OK'
      Begin
        Select @Resul = @Resul2
        Return
      End

     --obtenemos el valor
     Exec Emulador_SepararCadena 'V1', @Resul2, '|', @Desc1 Output
     If LEN(LTrim(RTrim(@Desc1))) = 0 
      Begin
       Select @Resul= '2R=Error|2M=El codigo del proveedor no esta registrado|'
       Return
      End
     --------------------------------------------------------------------------
     -------------------------------------------------------------------------- 


	select * from SMercado..entradas e 
	inner join SMercado..entrada_detalles ed on e.identrada=ed.identrada
	inner join SMercado..cat_proveedores p on  e.idproveedor=p.idproveedor and p.codigo=@Valor5 and e.folioFactura=@Valor4
  If @@RowCount > 0
    Begin
	  Select @Resul='2R=ERROR|2M=Factura ya existente|'
      Return 
	End   
	
	
  -- Logica de Negocio      
  
  If @@RowCount = 0
   Begin
     Update SMercado..Entradas 
     Set Fecha = @Valor2,
         IdUsuario = @Valor3,
         folioFactura = @Valor4,
         IdProveedor = @Valor5 
 Where idEntrada=@Valor1 
 
   End
   
   
   
   
  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se Grabó Correctamente|'   

  Set NoCount OFF
END



