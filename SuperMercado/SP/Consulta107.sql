drop proc dbo.CONSULTA107
go

CREATE PROCEDURE dbo.CONSULTA107
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
  --Estados de la Republica
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)
  Declare @Desc1     VarChar(8000)
  
  --Asignar Valores
  Select @Desc1  = ""
  Select @Resul  = ""

  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo del Estado

  -- Validar Parametros
  If @Validar = 1 Or @Validar = 2
   Begin
	 If Len(LTrim(RTrim(@Valor1))) = 0
	  Begin
		Select @Resul = '2R=ERROR|2M=Registre el campo estado para poder continuar|'
		Return
      End
   End


  -- Logica de Negocio
  If @Validar = 0 --Mostrar todos los Estados
   Begin
     Select Código      = IdEstado, 
			Descripción = Descripcion
	 From SMercado..Cat_EstadosdelaRepublica (NoLock)
	 Order by IdEstado

	 Select @Registro = @@RowCount	 
   End
  If @Validar = 1 Or @Validar = 2
   Begin
	 Select @Desc1= Descripcion
	 From SMercado..Cat_EstadosdelaRepublica (NoLock)
	 Where IdEstado = @Valor1

	 Select @Registro =@@RowCount
   End

	-- Enviar Resultado
  If @Registro = 0
   Begin
      If @Validar = 0
         Select @Resul = '2R=ERROR|2M=No hay datos en el catálogo de estados de la república|'
      If @Validar = 1
         Select @Resul = '2R=ERROR|2M=El código del estado no existe|'
	  If @Validar = 2
		 Select @Resul = '2R=OK|'
   End
  Else
    Begin
	  If @Validar = 0
	     Select @Resul='2R=OK|CATALOGO=Catálogo de estados de la república|VALCOL=60*425|'
	 If @Validar = 1 Or @Validar = 2
		Select @Resul='2R=OK|V1=' + @Desc1 + '|'
    End

  Set NoCount OFF
END



