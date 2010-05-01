-- Consulta que regresa los ciudades.

DROP PROC dbo.Consulta114b
GO

CREATE PROCEDURE dbo.Consulta114b
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @estado		VARCHAR(8000)
DECLARE @Idestado	int

Exec Emulador_SepararCadena 'V1', @Cabezero, '|', @estado Output

SELECT @Idestado = ISNULL(E.IdEstado , 0) 
FROM SMercado..Cat_EstadosdelaRepublica  E
WHERE ltrim(rtrim(E.Descripcion)) = rtrim(ltrim(@estado ))

SELECT c.Descripcion 
FROM SMercado..Cat_Ciudades C
WHERE C.IdEstado = @Idestado 

Select @Resul = '2R=OK|'

END