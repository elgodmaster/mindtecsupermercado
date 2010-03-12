drop proc dbo.ELIMINAR102
go

CREATE PROCEDURE dbo.ELIMINAR102
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
  --Catalogo Marcas
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Resul2    VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = "" 
  Select @Resul  = ""
  Select @Resul2 = ""
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --IdMarca
  
  If @Validar = 0
   Begin
      Update SMercado..Cat_Marcas  
            Set Descripcion = ''
     Where IdMarca = @Valor1
      
   End

 
  If @Validar = 0
   Begin
     Select @Resul='2R=OK|2M=Se eliminaron los datos correctamente|'
   End
   

  Set NoCount OFF
END



