-- Consulta que regresa la información de un producto.

DROP PROC dbo.Consulta136
GO

CREATE PROCEDURE dbo.Consulta136
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @keyCodigo	VARCHAR(8000)
DECLARE @desc1		VARCHAR(8000)     
DECLARE @desc2		VARCHAR(8000)
DECLARE @desc3		VARCHAR(8000)
DECLARE @desc4		VARCHAR(8000)
DECLARE @desc5		VARCHAR(8000)
DECLARE @desc6		VARCHAR(8000)
DECLARE @desc7		VARCHAR(8000)
DECLARE @desc8		VARCHAR(8000)
DECLARE @desc9		VARCHAR(8000)
DECLARE @desc10		VARCHAR(8000)

DECLARE @unidad		VARCHAR(8000)
DECLARE @categoria	VARCHAR(8000)
DECLARE @marca		VARCHAR(8000)
DECLARE @departame  VARCHAR(8000)

exec Emulador_SepararCadena 'V1', @cabezero, '|', @keyCodigo Output

set noCount ON

Select @unidad		= (Select U.Descripcion  
					   From SMercado..Cat_Productos P
					   inner join SMercado..Cat_Unidades U ON P.IdUnidad = U.IdUnidad 
					   Where P.Codigo = @keyCodigo ) 
				  
Select @categoria	= (Select C.Descripcion 
					   From SMercado..Cat_Productos P
					   inner join SMercado..Cat_Categorias C ON P.IdCategoria = C.IDCategoria 
					   Where P.Codigo = @keyCodigo )
					   
Select @marca		= (Select M.Descripcion  
					   From SMercado..Cat_Productos P
					   inner join SMercado..Cat_Marcas M ON P.IdMarca = M.IdMarca 
					   Where P.Codigo = @keyCodigo )
					   
Select @departame 	= (Select D.Descripcion 
					   From SMercado..Cat_Productos P
					   inner join SMercado..Cat_Departamentos D ON P.IDDepartamento = D.IdDepartamento 
					   Where P.Codigo = @keyCodigo )

Select @desc1 = P.Descripcion,
	   @desc2 = P.Codigo,
	   @desc3 = @unidad,
	   @desc4 = @categoria,
	   @desc5 = @marca,
	   @desc6 = @departame,
	   @desc7 = P.CostoCompra,
	   @desc8 = P.PrecioVenta,
	   @desc9 = P.StockMinimo
From SMercado..Cat_Productos P
Where P.Codigo = @keyCodigo  
	
IF @@rowcount = 1
BEGIN
	Select @Resul = '2R=OK' + 
					'|V1=' + @desc1 + '|V2=' + @desc2 + '|V3=' + @desc3 + '|V4=' + @desc4 + 
					'|V5=' + @desc5 + '|V6=' + @desc6 + '|V7=' + @desc7 + '|V8=' + @desc8 +
					'|V9=' + @desc9 + '|' 
END
ELSE
BEGIN
	Select @Resul = '2R=ERROR|'
END 

				
Select resul = @Resul  
	
END