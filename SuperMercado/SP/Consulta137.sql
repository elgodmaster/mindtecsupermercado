-- Consulta que regresa la información de un producto.

DROP PROC dbo.Consulta137
GO

CREATE PROCEDURE dbo.Consulta137
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

Select Descripcion  
From SMercado..Cat_Unidades
Where Descripcion not like ''
Order by Descripcion

Select Descripcion 
From SMercado..Cat_Categorias 
Where Descripcion not like ''
Order by Descripcion

Select Descripcion 
From SMercado..Cat_Marcas
Where Descripcion not like ''
Order by Descripcion

Select Descripcion 
From SMercado..Cat_Departamentos
Where Descripcion not like ''
Order by Descripcion  
	
END