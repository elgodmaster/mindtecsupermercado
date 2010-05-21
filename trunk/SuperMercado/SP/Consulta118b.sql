-- Consulta regresa el detalle de una cuenta por cobrar

DROP PROC dbo.Consulta118b
GO

CREATE PROCEDURE dbo.Consulta118b
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @idCuenta	VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @idCuenta	Output 

Select	C1 = A.idAbono, 
		C2 = '$ ' + CONVERT(char, A.monto), 
		C3 = CONVERT(varchar,DATEADD(d,0,A.fecha), 103), 
		C4 = A.idUsuario   
From SMercado..Cuentas_Abonos A
Inner join SMercado..Cuentas_Cobrar CC ON A.idCuenta = CC.IdCuenta 
Where CC.IdCuenta = @idCuenta 
Order by A.fecha DESC
				
END