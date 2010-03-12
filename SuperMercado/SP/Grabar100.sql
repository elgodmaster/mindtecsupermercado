
drop proc dbo.GRABAR100
go

CREATE PROCEDURE dbo.GRABAR100
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN
  Set NoCount On
  --------------------------
  --Catalogo de Departamentos
  --------------------------
--set quoted_identifier off
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
  Select @Desc0  = "" 
  Select @Desc1  = ""
  Select @Resul  = ""
  Select @Resul2 = ""
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Codigo Categoria
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Descripcion
 
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código del departamento para continuar|'
     Return    
   End

  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la descripción para continuar|'
     Return    
   End

        
  -- Logica de Negocio      
  Select @Desc1 = IdDepartamento 
  From SMercado..Cat_Departamentos(NoLock)
  Where IdDepartamento = @Valor1
  
  If @@RowCount = 0
   Begin
     Insert SMercado..Cat_Departamentos(Descripcion)
            Values(@Valor2)
   End
  Else
   Begin
     Update SMercado..Cat_Departamentos 
            Set Descripcion = @Valor2
     Where IdDepartamento = @Valor1
   End  

  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se Grabó Correctamente|'   

  Set NoCount OFF
END



