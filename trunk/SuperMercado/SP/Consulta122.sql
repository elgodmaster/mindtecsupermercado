-- Consulta que regresa el estado de un permiso dado un nombre.

DROP PROC dbo.Consulta122
GO

CREATE PROCEDURE dbo.Consulta122
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE	@nombrePermiso	VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nombrePermiso 	Output 

Select	P.RepProductos, P.RepEntProd, P.RepSalProd, P.RepClientes, 
		P.RepProveedores, P.RepFacturas, P.RepVentas, P.RepRetEfect,
		P.RepDepEfect, 
		
		P.CatDepartamentos, P.CatCategorias, P.CatMarcas, P.CatProductos,
		P.CatClientes, P.CatProveedores, P.CatUnidades, 
		
		P.FacFactura, P.FacCotizacion,
		
		P.InvMovimientos, P.InvConsultas,
		
		P.CajaCorte, P.CajaEntradas, P.CajaSalidas,
		
		P.SegUsuarios, P.SegGrupPerm,
		
		P.ConfCaja, P.ConfFact, P.ConfTick 

From SMercado_Seguridad..Permisos P
Where nomPermiso = @nombrePermiso

IF @@ROWCOUNT > 0
	BEGIN
		Select @Resul = '2R=OK|'
	END  
ELSE
	BEGIN
		Select @Resul = '2R=ERROR|'
	END
		
END