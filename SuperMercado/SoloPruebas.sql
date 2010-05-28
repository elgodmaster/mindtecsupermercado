use SMercado 

-- <TABLAS NECESARIAS PARA CAJA> --

CREATE TABLE Caja_Entrada(
idEntrada int identity not null,
idCaja int not null,
usuario int not null,
monto decimal(18,2),
concepto varchar(250),
fecha datetime
)

CREATE TABLE Caja_Configuracion(
idCajaConfig int not null,
dinIniAct bit not null,
monDinIni decimal(18,2) not null,
monMaxAct bit not null,
monMax decimal(18,2) not null
)
Select * from SMercado..Caja_Configuracion 
-- Configurando inicial por defecto.
Insert into SMercado..Caja_Configuracion values (1, 1, 777.00, 0, 0.00)
select * from SMercado..Caja_Configuracion 

CREATE TABLE Caja_Salida(
idSalida int identity not null,
idCaja int not null,
usuario int not null,
monto decimal(18,2),
concepto varchar(250) not null,
fecha datetime,
)

CREATE TABLE Caja_Corte(
idCorte int identity not null,
idCaja int not null,
usuario int not null,
dineroInicialCaja decimal(18,2),
dineroActual decimal(18,2),
fecha date not null
)


-- TABLAS PARA CUENTAS POR COBRAR --

CREATE TABLE Cuentas_Abonos(
idAbono int identity not null,
idCuenta int not null,
monto decimal(16,2) not null,
fecha datetime not null,
idCliente int not null,
idUsuario int not null
)

CREATE TABLE CC_VentasCredito(
idVenta int not null identity,
idCliente int not null,
idUsuario int not null,
fecha date not null
)

CREATE TABLE CC_VentasCreditoDetalle(
idVenta int not null,
idProducto int not null,
cantidad decimal(12,2) not null,
precioUnitario int not null
)

DROP TABLE SMercado..Caja_Corte
DROP TABLE SMercado..Caja_Entrada
DROP TABLE SMercado..Caja_Salida

Select top 1 fecha from SMercado..Caja_Corte
order by fecha desc


-- Inserciones en las tablas.
drop table caja_corte
select * from caja_corte
-- Caja_Corte
Insert into Caja_Corte values (1, 1, 500, 600, '08/04/2010')
Insert into Caja_Corte values (1, 1, 500, 600, '09/04/2010')
Insert into Caja_Corte values (1, 1, 777, 777, '11/04/2010')


Update SMercado..Caja_Configuracion  set dinIniPred = 's'
Update SMercado..Caja_Configuracion  set monDinIni  = 100.00
where fecha = CONVERT(Date, getdate())

select idCorte, dineroINicialCaja, dineroActual, fecha, fechaActual = convert(date, getdate()) from Caja_Corte 

-- Caja_Entrada

Insert into Caja_Entrada values (1, 1, 100.10, '2010-04-08 17:09:05', 1)
Insert into Caja_Entrada values (1, 1, 100.5, '2010-04-09 17:09:05', 1)

-- Caja_Salida
Insert into Caja_Salida values (1, 1, 100.50, 'Pago a proveedor.',  '2010-04-08 17:10:12')

exec CONSULTA_FECHA_CAJA '', ''
exec INSERTAR_DINERO_INICIAL 500.50

delete from pvf..Caja_Corte where fecha = '2010-04-11'
delete from SMercado..Caja_Salida where CONVERT( date, fecha ) = CONVERT ( date, getdate() )
select * from SMercado..Caja_Salida 

select * from SMercado..Caja_corte
--drop table Smercado..caja_entrada


insert into SMercado..Caja_Salida values ( 1, 1, 150.00, 'Ninguno', '14/04/2010 16:21:00')
insert into SMercado..Caja_Salida values ( 1, 1, 151.00, 'Ninguno', '30-04-2010 16:53:00')

Select * from SMercado..Caja_corte
Select * from SMercado..Caja_salida
Select * from SMercado_Seguridad..Usuarios 
exec grabar110 'V1=100|','','',''
exec grabar111 'V1=1|V2=1|V3=150.50|V4=ninguno|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=1.5|V4=|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=150.5|V4=asalté un banco, tío|', '', '', ''
exec grabar120 'V1=123|V2=ADMIN|','','',''
exec consulta105 '','','',''
exec Consulta110 '','','',''
exec consulta111 '','','',''
exec consulta114a '','','',''
exec consulta114b 'V1=Baja California|','','',''
exec consulta105 'V1=CLIENTE2|','','','2'
exec consulta117 'V1=CLIENTE2|','','',''
exec consulta118a 'V1=9|','','',''
exec consulta118b 'V1=9|','','',''
exec consulta120 'V1=ADMIN|V2=12345|','','',''
exec consulta121 '','','',''
exec consulta122 'V1=cajero|','','',''
Select * 
From SMercado_Seguridad..Permisos 

Select C.Codigo, C.NombreFiscal, C.Adeudo 
From SMercado..Cat_Clientes C
Select * from SMercado..Caja_Entrada 
exec GRABAR117 'V1=9|V2=100|V3=1|V4=CLIENTE2|','','',''

select * 
From SMercado..Cuentas_Cobrar C
inner join SMercado..Cuentas_Cobrar_Detalles CD ON C.IdCuenta = CD.IdCuenta 

update SMercado..Cat_Clientes 
set Adeudo = 11200.5
where Codigo = 'CLIENTE2'

select	Cuenta = C.IdCuenta, 

		Artículo = C.Descripcion, 
		
		Monto = (Select SUM( CD.PrecioUni )
				 From SMercado..Cuentas_Cobrar_Detalles CD
				 Where IdCuenta = C.IdCuenta 
				 Group by IdCuenta ),
				 
		Adeudo = C.adeudo,
				 
		Abonado =  isnull((Select SUM(CA.monto)
				  From SMercado..Cuentas_Abonos CA
				  Where idCuenta = C.IdCuenta 
				  Group by CA.idCuenta), 0),
				  
	    C.CodigoCliente 
				  


select * 
from SMercado..Cuentas_Cobrar C
inner join SMercado..Cuentas_Cobrar_Detalles D ON C.IdCuenta = D.IdCuenta
Where D.IdCuenta = 9 

select * from SMercado..Cuentas_Cobrar_Detalles where IdCuenta = 9
select * from SMercado..Cuentas_Abonos

insert SMercado..Cuentas_Cobrar values ( GETDATE(), 1, 1, 1, 1, 'XBOX 360', 4500, 1)

insert SMercado..Cuentas_Cobrar_Detalles 
values (9, 777, 1, 4500, 'XBOX 360', NULL, NULL, 1)

insert into SMercado..Cuentas_Abonos values ( 9, 500, GETDATE(), 1, 1 )


Select	C1 = A.idAbono, 
		C2 = '$ ' + CONVERT(char, A.monto), 
		C3 = CONVERT(date, A.fecha), 
		C4 = A.idUsuario   
From SMercado..Cuentas_Abonos A
Inner join SMercado..Cat_Clientes C ON A.idCliente = C.IdCliente
Where C.Codigo = 'CLIENTE2'

Select * from SMercado..Cat_Clientes 
Select * from SMercado..Cuentas_Abonos  

Select * from SMercado..Cuentas_Cobrar 

select * from SMercado_Seguridad..Usuarios 

insert into SMercado_Seguridad..Usuarios
values ('admin', '12345', 'Administrador', 1)


CREATE TABLE Permisos (
idPermiso int identity not null,
nomPermiso char(50) not null,
RepProductos bit not null,
RepEntProd bit not null,
RepSalProd bit not null,
RepClientes bit not null,
RepProveedores bit not null,
RepFacturas bit not null,
RepVentas bit not null,
RepRetEfect bit not null,
RepDepEfect bit not null,
CatDepartamentos bit not null,
CatCategorias bit not null,
CatMarcas bit not null,
CatProductos bit not null,
CatClientes bit not null,
CatProveedores bit not null,
CatUnidades bit not null,
FacFactura bit not null,
FacCotizacion bit not null,
InvMovimientos bit not null,
InvConsultas bit not null,
CajaCorte bit not null,
CajaEntradas bit not null,
CajaSalidas bit not null,
SegUsuarios bit not null,
SegGrupPerm bit not null,
ConfCaja bit not null,
ConfFact bit not null,
ConfTick bit not null
)
insert into SMercado_Seguridad.. Usuarios
values ('admin', 'Administrador', '12345', 1, 1)

select * from SMercado_Seguridad..Permisos

select * from usuarios
insert into Permisos
values( 
'administrador',
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1
)
select * from SMercado_Seguridad..Permisos 

update SMercado_Seguridad..Permisos
set RepProductos = 'false'
where idPermiso = 1