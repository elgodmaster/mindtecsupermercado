drop proc Emulador_SepararCadena
go

Set quoted_identifier off
go
CREATE PROC Emulador_SepararCadena
(
    @NombreCampo VARCHAR(50),
    @Cadena VARCHAR(8000),
    @CaracterSeparador Varchar(2),
    @RegresaValorCampo Varchar(8000) output
) WITH ENCRYPTION
AS
BEGIN
    Set NoCount On

    --Declarar Variable de Trabajo
    Declare @Tamano        Int
    Declare @pos_campo     Int
    Declare @pos_separador Int

    --Asignar Datos
    SELECT @NombreCampo = UPPER(@NombreCampo)

    --Proceso para Extraer el Valor de la Cadena
    SELECT @Tamano = Len(@NombreCampo) + 1
    SELECT @Pos_Campo = CharIndex(@NombreCampo + "=",UPPER(@Cadena))

    If @Pos_Campo <= 0
      Begin
        SELECT @RegresaValorCampo = ""
      End
    Else
      Begin -- "|"
        Select @pos_separador = charindex(@CaracterSeparador,@Cadena,@pos_campo + 1)
        Select @RegresaValorCampo = substring(@Cadena, @pos_campo + @tamano, @pos_separador - (@pos_campo + @tamano))
      End

    Set NoCount Off
END

Go
Grant all on Emulador_SepararCadena to public 