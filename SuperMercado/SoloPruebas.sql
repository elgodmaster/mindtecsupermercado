use SMercado 

CREATE TABLE Usuarios_Cuentas (
idUsuario int identity not null,
nombreUsuario char(50) not null,
nombre char(50),
apellidoPaterno char(50),
apellidoMaterno char(50),
contraseña int not null
)

CREATE TABLE Caja_Entrada(
idEntrada int identity not null,
idCaja int not null,
usuario int not null,
monto decimal(18,2),
concepto varchar(250),
fecha datetime
)

-- CAMBIO EN EL CAMPO CONCEPTO
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


Update Caja_Corte set dineroActual = dineroActual + 100
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

select * from SMercado..Caja_entrada
--drop table Smercado..caja_entrada


insert into SMercado..Caja_Salida values ( 1, 1, 150.00, 'Ninguno', '14/04/2010 16:21:00')
insert into SMercado..Caja_Salida values ( 1, 1, 151.00, 'Ninguno', '30-04-2010 16:53:00')

Select * from SMercado..Caja_Entrada
exec grabar111 'V1=1|V2=1|V3=150.50|V4=ninguno|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=1.5|V4=|', '', '', ''
exec grabar112 'V1=1|V2=1|V3=150.5|V4=asalté un banco, tío|', '', '', ''
exec Consulta110 '','','',''
exec consulta111 '', '', '', ''