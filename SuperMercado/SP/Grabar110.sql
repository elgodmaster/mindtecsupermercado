-- Insertar dinero inicial en la CAJA.

DROP PROC dbo.GRABAR110
GO

CREATE PROCEDURE dbo.GRABAR110 (
@dinInicial	decimal(18,2)
)

AS
BEGIN
	Set noCount ON
	Insert into SMercado..Caja_Corte values ( 1, 1, @dinInicial, @dinInicial, CONVERT( date, getdate() ) )
	
END