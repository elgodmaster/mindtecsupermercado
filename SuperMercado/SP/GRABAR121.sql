-- Graba un nuevo grupo de permisos.

DROP PROC dbo.GRABAR121
GO

CREATE PROCEDURE dbo.GRABAR121
(
  @cabezero VARCHAR(8000),
  @Resul    VARCHAR(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)
AS
BEGIN

DECLARE @nombrePermiso	VARCHAR(50)

--Reportes
DECLARE @repProductos		CHAR(5)
DECLARE @repEntProd			CHAR(5)
DECLARE @repSalProd			CHAR(5)
DECLARE @repClientes		CHAR(5)

DECLARE @repProveedores		CHAR(5)
DECLARE @repFacturas		CHAR(5)
DECLARE @repVentas			CHAR(5)
DECLARE @repRetEfect		CHAR(5)

DECLARE @repDepEfect		CHAR(5)

--Catálogos
DECLARE @catDepartamentos	CHAR(5)
DECLARE @catCategorias		CHAR(5)
DECLARE @catMarcas			CHAR(5)
DECLARE @catProductos		CHAR(5)

DECLARE @catClientes		CHAR(5)
DECLARE @catProveedores		CHAR(5)
DECLARE @catUnidades		CHAR(5)

--Facturas
DECLARE @facFactura			CHAR(5)
DECLARE @facCotizacion		CHAR(5)

--Inventarios
DECLARE @invMovimientos		CHAR(5)
DECLARE @invConsultas		CHAR(5)

--Caja
DECLARE @cajaCorte			CHAR(5)
DECLARE @cajaEntradas		CHAR(5)
DECLARE @cajaSalidas		CHAR(5)

--Seguridad
DECLARE @segUsuarios		CHAR(5)
DECLARE @segGrupPerm		CHAR(5)

--Configuración
DECLARE @confCaja			CHAR(5)
DECLARE @confFac			CHAR(5)
DECLARE @confTick			CHAR(5)

Set noCount ON

Exec Emulador_SepararCadena 'V1',   @Cabezero, '|', @nombrePermiso 		Output 

--Reportes
Exec Emulador_SepararCadena 'V2',   @Cabezero, '|', @repProductos		Output 
Exec Emulador_SepararCadena 'V3',   @Cabezero, '|', @repEntProd			Output 
Exec Emulador_SepararCadena 'V4',   @Cabezero, '|', @repSalProd			Output 
Exec Emulador_SepararCadena 'V5',   @Cabezero, '|', @repClientes		Output 

Exec Emulador_SepararCadena 'V6',   @Cabezero, '|', @repProveedores 	Output 
Exec Emulador_SepararCadena 'V7',   @Cabezero, '|', @repFacturas 		Output 
Exec Emulador_SepararCadena 'V8',   @Cabezero, '|', @repVentas 			Output 
Exec Emulador_SepararCadena 'V9',   @Cabezero, '|', @repRetEfect 		Output 

Exec Emulador_SepararCadena 'V10',  @Cabezero, '|', @repDepEfect 		Output 

--Catálogos
Exec Emulador_SepararCadena 'V11',  @Cabezero, '|', @catDepartamentos 	Output 
Exec Emulador_SepararCadena 'V12',  @Cabezero, '|', @catCategorias 		Output 
Exec Emulador_SepararCadena 'V13',  @Cabezero, '|', @catMarcas 			Output 
Exec Emulador_SepararCadena 'V14',  @Cabezero, '|', @catProductos	 	Output 

Exec Emulador_SepararCadena 'V15',  @Cabezero, '|', @catClientes 		Output 
Exec Emulador_SepararCadena 'V16',  @Cabezero, '|', @catProveedores 	Output 
Exec Emulador_SepararCadena 'V17',  @Cabezero, '|', @catUnidades		Output 

--Facturas
Exec Emulador_SepararCadena 'V18',  @Cabezero, '|', @facFactura 		Output 
Exec Emulador_SepararCadena 'V19',  @Cabezero, '|', @facCotizacion 		Output 

--Inventarios
Exec Emulador_SepararCadena 'V20',  @Cabezero, '|', @invMovimientos 	Output 
Exec Emulador_SepararCadena 'V21',  @Cabezero, '|', @invConsultas 		Output 

--Caja
Exec Emulador_SepararCadena 'V22',  @Cabezero, '|', @cajaCorte 			Output 
Exec Emulador_SepararCadena 'V23',  @Cabezero, '|', @cajaEntradas 		Output 
Exec Emulador_SepararCadena 'V24',  @Cabezero, '|', @cajaSalidas 		Output 

--Seguridad
Exec Emulador_SepararCadena 'V25',  @Cabezero, '|', @segUsuarios		Output 
Exec Emulador_SepararCadena 'V26',  @Cabezero, '|', @segGrupPerm		Output 

--Configuración
Exec Emulador_SepararCadena 'V27',  @Cabezero, '|', @confCaja			Output 
Exec Emulador_SepararCadena 'V28',  @Cabezero, '|', @confFac 			Output 
Exec Emulador_SepararCadena 'V29',  @Cabezero, '|', @confTick			Output 

Select P.idPermiso 
From SMercado_Seguridad..Permisos P
Where P.nomPermiso = @nombrePermiso 

IF @@ROWCOUNT = 0
	BEGIN
		Insert SMercado_Seguridad..Permisos
		Values( @nombrePermiso,
				--Reportes
				@repProductos,
				@repEntProd,
				@repSalProd,
				@repClientes,
				
				@repProveedores,
				@repFacturas,
				@repVentas,
				@repRetEfect,
				
				@repDepEfect,
				
				--Catálogos
				@catDepartamentos,
				@catCategorias,
				@catMarcas,
				@catProductos,
				
				@catClientes,
				@catProveedores,
				@catUnidades,
				
				--Facturas
				@facFactura,
				@facCotizacion,
				
				--Inventarios
				@invMovimientos,
				@invConsultas,
				
				--Caja
				@cajaCorte,
				@cajaEntradas,
				@cajaSalidas,
				
				--Seguridad
				@segUsuarios,
				@segGrupPerm,
				
				--Configuración
				@confCaja,
				@confFac,
				@confTick)				
	END
ELSE
	BEGIN
		Update SMercado_Seguridad..Permisos
		    --Reportes
		Set RepProductos = @repProductos,
			RepEntProd = @repEntProd,
			RepSalProd = @repSalProd,
			RepClientes = @repClientes,
			
			RepProveedores = @repProveedores,
			RepFacturas = @repFacturas,
			RepVentas = @repVentas,
			RepRetEfect = @repRetEfect,
			
			RepDepEfect = @repDepEfect,
			
			--Catálogos
			CatDepartamentos = @catDepartamentos,
			CatCategorias = @catCategorias,
			CatMarcas = @catMarcas,
			CatProductos = @catProductos,
			
			CatClientes = @catClientes,
			CatProveedores = @catProveedores,
			CatUnidades = @catUnidades,
			
			--Facturas
			FacFactura = @facFactura,
			FacCotizacion = @facCotizacion,
			
			--Inventarios
			InvMovimientos = @invMovimientos,
			InvConsultas = @invConsultas,
			
			--Caja
			CajaCorte = @cajaCorte,
			CajaEntradas = @cajaEntradas,
			CajaSalidas = @cajaSalidas,
			
			--Seguridad
			SegUsuarios = @segUsuarios,
			SegGrupPerm = @segGrupPerm,
			
			--Configuración
			ConfCaja = @confCaja,
			ConfFact = @confFac,
			ConfTick = @confTick 
			
		Where nomPermiso = @nombrePermiso 
	END
END