use SMercado 


-- No implementada.
CREATE TABLE Usuarios_Cuentas (
idUsuario int identity not null,
nombreUsuario char(50) not null,
nombre char(50),
apellidoPaterno char(50),
apellidoMaterno char(50),
contraseña int not null
)






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

CREATE TABLE CC_Clientes(
idCliente int identity not null,
nomCliente varchar(50) not null,
direccion varchar(250) null,
telefono varchar(50) null,
limCredito decimal(16,2)
)

CREATE TABLE CC_Abonos(
idAbono int identity not null,
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
cantidad int not null,
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
Select * from SMercado..Caja_entrada
exec grabar110 'V1=100|','','',''
exec grabar111 'V1=1|V2=1|V3=150.50|V4=ninguno|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=1.5|V4=|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=150.5|V4=asalté un banco, tío|', '', '', ''
exec Consulta110 '','','',''
exec consulta111 '','','',''
select * from SMercado..Caja_Configuracion 
select * from SMercado..Caja_Corte
delete from SMercado..Caja_Corte where idCorte = 10

exec Consulta105 'V1=1|','','','2'
select * from SMercado..Cat_Clientes 
