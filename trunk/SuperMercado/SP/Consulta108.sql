drop proc dbo.CONSULTA108
go

CREATE PROCEDURE dbo.CONSULTA108
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
  --Catalogo de ciudades
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    Varchar(8000)

  
  --Asignar Valores
  Select @Desc0  = ''
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2  = ''


  --Obtener los Parametros

  Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @Valor1 Output --Codigo del estado
  Exec Emulador_SepararCadena 'V2', @Cabezero, '|', @Valor2 Output --Codigo de la Ciudad

  -- Validar Parametros

  If Len(LTrim(RTrim(@Valor1))) = 0
   Begin
     Select @Resul = '2R=ERROR|2M=Registre el campo estado para continuar|'
	 Return
   End
  If @Validar = 1 or @Validar = 2
   Begin
     If Len(LTrim(RTrim(@Valor2))) = 0
      Begin
        Select @Resul = '2R=ERROR|2M=Registre el campo ciudad para continuar|'
        Return
      End
   End

  -- Logica de Negocio
  
  If @Validar = 0 --Mostrar todas las ciudades
   Begin
     Select Código      = IsNull(IdCiudad,0),
            Descripción = IsNull(Descripcion,'')
	 From SMercado..Cat_Ciudades (NoLock)
     Where IdEstado = @Valor1
     Order by IdCiudad

	 Select @Registro = @@RowCount	 
   End

  If @Validar = 1 or @Validar = 2 
   Begin                           
     Select 
            @Desc1 = IsNull(Descripcion,'')
     From SMercado..Cat_Ciudades (NoLock)
     Where IDEstado = @Valor1 and IDCiudad = @Valor2

     Select @Registro = @@RowCount
   End

	-- Enviar Resultado
  If @Registro = 0
   Begin
     If @Validar = 0
        Select @Resul = '2R=ERROR|2M=No hay datos en el catálogo de ciudades|'
     If @Validar = 1
        Select @Resul = '2R=ERROR|2M=La ciudad no existe' 
     If @Validar = 2
        Select @Resul = '2R=OK|'
         
   End
  Else
    Begin
	  If @Validar = 0
	     Select @Resul='2R=OK|CATALOGO=Catálogo de ciudades|VALCOL=50*437|'
      If @Validar = 1 
         Select @Resul='2R=OK|V1=' + @Desc1 + '|'
      If @Validar = 2
         Select @Resul='2R=OK|V1=' + @Desc1 + '|'
    End

  Set NoCount OFF
END

