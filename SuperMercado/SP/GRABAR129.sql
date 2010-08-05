-- Graba un producto.

drop proc dbo.GRABAR129
go

CREATE PROCEDURE dbo.GRABAR129
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
 --@UsuarioSistema VarChar(8000)
)

AS
BEGIN

DECLARE @keyCodigo	varchar(8000)
DECLARE @valor1     varchar(8000)
DECLARE @valor2     varchar(8000)
DECLARE @valor3     varchar(8000)
DECLARE @valor4     varchar(8000)
DECLARE @valor5     varchar(8000)
DECLARE @valor6     varchar(8000)
DECLARE @valor7     varchar(8000)
DECLARE @valor8     varchar(8000)
DECLARE @valor9     varchar(8000)
DECLARE @valor10     varchar(8000)

DECLARE @idUnidad	 varchar(8000)
DECLARE @idCategoria varchar(8000)
DECLARE @idMarca	 varchar(8000)
DECLARE @idDepartam	 varchar(8000)

Exec Emulador_SepararCadena 'V0',  @Cabezero, '|', @keyCodigo	Output 

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @valor1		Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @valor2		Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @valor3		Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @valor4		Output 
Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @valor5		Output 
Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @valor6		Output 
Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @valor7		Output 
Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @valor8		Output 
Exec Emulador_SepararCadena 'V9',  @Cabezero, '|', @valor9		Output 
Exec Emulador_SepararCadena 'V10',  @Cabezero, '|', @valor10	Output 

Set noCount ON

Select @idUnidad	= (	Select U.IdUnidad From SMercado..Cat_Unidades U
						Where U.Descripcion = @valor3 )
					
Select @idCategoria = (	Select C.IDCategoria From SMercado..Cat_Categorias C
						Where C.Descripcion = @valor4 )
					
Select @idMarca 	= (	Select M.IdMarca From SMercado..Cat_Marcas M
						Where M.Descripcion = @valor5 )
					
Select @idDepartam 	= (	Select D.IdDepartamento From SMercado..Cat_Departamentos D
						Where D.Descripcion = @valor6 )

Select P.Codigo From SMercado..Cat_Productos P
Where P.Codigo = @keyCodigo

IF @@ROWCOUNT = 1
BEGIN
	Update SMercado..Cat_Productos
	Set Descripcion		= @valor1,
	    Codigo			= @valor2,
	    IdUnidad		= @idUnidad,
	    IdCategoria		= @idCategoria,
	    IdMarca			= @idMarca,
	    IDDepartamento	= @idDepartam,
	    CostoCompra		= @valor7,
	    PrecioVenta		= @valor8,
	    StockMinimo		= @valor9
	Where Codigo = @keyCodigo
	
	Update SMercado..Existencias  	    
	Set Codigo = @valor2
	Where Codigo = @keyCodigo  
END
ELSE
BEGIN
	Insert SMercado..Cat_Productos
	values (@valor2 , @idDepartam, @idCategoria, @idMarca, @valor1, @valor7, 0, 0, @idUnidad, @valor9, @valor8, @valor10 )
	
	--Se actualiza el inventario.
	Insert SMercado..Existencias 
	values (@valor2, @valor10)
END

Select @Resul = '2R=OK|'

END