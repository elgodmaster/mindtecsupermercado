DROP PROC dbo.Consulta122b
GO

CREATE PROCEDURE dbo.Consulta122b
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE	@nombreUsuario	VARCHAR(8000)
DECLARE @nombrePermiso  VARCHAR(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @nombreUsuario  	Output 

Select @nombrePermiso = P.nomPermiso 
From SMercado_Seguridad..Usuarios U
Inner join SMercado_Seguridad..Permisos P ON U.idPermiso = P.idPermiso 
Where U.nombreUsuario = @nombreUsuario 

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