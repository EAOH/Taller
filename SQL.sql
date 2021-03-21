--Formato de trabajo
set language 'SPANISH'
go

--Usar la master
use master
go
--validar que no exista una BD con ese nombre
if exists (select* from sys.databases where name='DBTallerF')
drop database DBTallerF
go

--Crear BD
create database DBTallerF
go

--Usarla 
use DBTallerF
go

--Crear tablas

--Cliente
create table Cliente(
ClienteDireccion varchar (100) not null,
ClienteIdentificacion varchar (20) not null,
ClienteNombre1 varchar (50) not null,
ClienteNombre2 varchar (50),
ClienteApellido1 varchar (50) not null,
ClienteApellido2 varchar (50),
ClienteTelefono varchar (20)  not null,
ClienteID int identity (1,1) primary key
)
go

--Vehiculo
create table Vehiculo (
ClienteID int not null,
VehiculoID int identity (1,1) primary key,
VehiculoColor Varchar (10) not null,
VehiculoEstado varchar (15) check (VehiculoEstado in ('Ocupado', 'Terminado')) not null,
VehiculoMarca varchar (50) not null, 
VehiculoModelo Varchar (50) not null,
VehiculoPlaca varchar (50) not null,
foreign key (ClienteID) references Cliente(ClienteID)
)
go
--estado char vehiculo

--Empleado
create table Usuario (
UsuarioID int identity (1,1) primary key,
UsuarioIdentificacion varchar (20) unique not null,
UsuarioDescripcion varchar (50) not null,
UsuarioDireccion varchar (100) not null,
UsuarioNombre1 varchar (50) not null,
UsuarioNombre2 varchar (50), 
UsuarioApellido1 varchar (50) not null,
UsuarioApellido2 varchar (50),
UsuarioSalario decimal (12,2)  not null,
UsuarioTipoSalario varchar (10) check (UsuarioTipoSalario in ('Fijo','Comisión','Hora')),
UsuarioRolID int not null,
UsuarioTelefono varchar (20)  not null,
UsuarioUsuario varchar (50) unique not null,
UsuarioPassword varchar (50) not null,
UsuarioEstado bit not null
)
go


--Factura
create table Factura (
FacturaImpuesto decimal (12,2) default 1 not null,
FacturaTotal decimal (12,2) default 1 not null,
FacturaFecha datetime not null,
FacturaId int identity (1,1) primary key,
FacturaDescuento decimal (12,2) not null,
FacturaSubtotal decimal (12,2) not null,
ClienteId int not null,
foreign key (ClienteID) references Cliente (ClienteID)
)
go



--Proveedor
create table Proveedor(
ProveedorId int identity (1,1) primary key,
ProveedorDescripcion Varchar (100) not null,
ProveedorFormaPago varchar (25) check (ProveedorFormaPago in ('Efectivo','Credito','Transferencia Bancaria')),
ProveedorNombre varchar (50) not null
)
go

--Producto
create table Producto(
ProductoId int identity (1,1) primary key,
ProveedorId int,
ProductoDescripcion varchar (100) not null,
ProductoExistencia int not null,
ProductoMarca varchar (50) not null,
ProductoNombre varchar(50) not null,
ProductoPrecioUnitario decimal (12,2) not null,
ProductoDescuento decimal (12,2) not null,
ProductoExistenciaMin int not null,
foreign key (ProveedorId) references Proveedor (ProveedorId)
)
go

--Actividades
create table Actividad(
ActividadDescripcion varchar (100) not null,
ActividadNombre Varchar (50) not null,
ActividadId int identity (1,1) primary key,
UsuarioId int not null,
ProductoId int,
ProductoCantidad int,
foreign key (UsuarioId) references Usuario (UsuarioId),
foreign key (ProductoId) references Producto (ProductoId)
)
go

--Estacion
create table Estacion (
EstacionNombre varchar (50) not null,
ActividadId int not null,
EstacionId int identity (1,1) primary key,
foreign key (ActividadId) references Actividad(ActividadId)
)
go

--Pedidos 
create table Pedido (
PedidoId int identity (1,1) primary key,
ProductoId int not null,
PedidoCantidad int not null,
PedidoDescripcion varchar (100) not null,
PedidoPrecioUnitario decimal (12,2) not null,
foreign key(ProductoId) references Producto (ProductoId)
)
go

--Detalle de la factura
create table FacturaDetalle (
FacturaDetalleID int identity (1,1) primary key,	
ProductoId int,
Cantidad int not null default 1,
Facturaid int not null,
Subtotal decimal (12,2) default 0 not null,
foreign key (ProductoId) references Producto (ProductoId),
foreign key (FacturaId) references Factura(FacturaId)
)
go

--Bitacora
create table Bitacora (
BitacoraId int identity (1,1) primary key,
BitacoraFormulario varchar (50) not null,
BitacoraFuncion varchar (50) not null,
BitacoraLlave int not null,
UsuarioId varchar (50) not null,
)
go

--Vista
create view SoloProductos as select * from Producto where ProductoExistenciaMin>=0
go

create view SoloServicios as select * from Producto where ProductoExistenciaMin=-1
go
--Procedimientos almacenados

CREATE PROCEDURE I_Factura
@Impuesto decimal (12,2),
@Total decimal (12,2),
@Fecha datetime,
@Descuento decimal (12,2),
@Subtotal decimal (12,2),
@Cliente int
AS
INSERT into Factura values (@Impuesto,@Total,@Fecha,@Descuento,@Subtotal,@Cliente )
GO

create PROCEDURE I_Detalle
@Producto int ,
@Cantidad int ,
@Factura int,
@Subtotal decimal (12,2)
AS
begin
declare @ExistenciaMin int
INSERT into FacturaDetalle values (@Producto,@Cantidad,@Factura,@Subtotal)
select @ExistenciaMin=Producto.ProductoExistenciaMin from FacturaDetalle inner join Producto on FacturaDetalle.ProductoId=Producto.ProductoId
if (@ExistenciaMin>=0)
begin
UPDATE Producto set Producto.ProductoExistencia=(Producto.ProductoExistencia-@Cantidad) where Producto.ProductoId=@Producto
end
end
GO

create procedure S_Detalle @Factura int
as
SELECT        FacturaDetalle.FacturaDetalleID, FacturaDetalle.Facturaid, FacturaDetalle.ProductoId, Producto.ProductoNombre, FacturaDetalle.Cantidad, CONVERT(Decimal(12, 2), FacturaDetalle.Subtotal / FacturaDetalle.Cantidad) AS Precio, 
                         FacturaDetalle.Subtotal
FROM            FacturaDetalle INNER JOIN
                         Producto ON FacturaDetalle.ProductoId = Producto.ProductoId
						 where FacturaDetalle.Facturaid=@Factura
ORDER BY FacturaDetalle.FacturaDetalleID
go

--Inserciones
insert into Usuario values ('0801-1999-18003','Recursos humanos','La keneddy','Maria','','Hernandez','',10000.00,'Fijo',4,'+504 9644-8004','MariaH','Maria1999',1)
insert into Usuario values ('0801-1990-18003','Gerente','La keneddy','Jose','Armando','Claros','Hernandez',25000.00,'Fijo',0,'+504 9723-7045','Micteris','Mendokusai',1)
select * from Usuario
go
/*
Gerente general/administrador	0		Sin restricciones
Atencion al cliente				1   	Uso general del sistema excepto en Bitacora, Acceso a ver factura
Cajero							2		Solo facturacion
Mecanico						3		Solo ver informacion de vehiculos
Recursos humanos				4		Solo personal (acceso unico a ver usuarios y gestionarlos)
*/ 

insert into Cliente values ('La keneddy','0801-1999-18003','Maria','','Hernandez','','+504 9644-8004')
insert into Cliente values ('La keneddy','0801-1990-18003','Jose','Armando','Claros','Hernandez','+504 9723-7045')
select * from Cliente
go


insert into Vehiculo values (1,'FFFFFF','Ocupado','Honda','Corola','FueraJOH')
insert into Vehiculo values (2,'FFFF00','Terminado','Toyota','Corola','Eldinero')
select * from Vehiculo
go



insert into Factura values (100.00,1100.00,'1/1/12 12:38:00',0.00,1000.00,1)
insert into Factura values (1000.00,2000.00,'1/1/12 12:38:00',0.00,1000.00,2)
select * from Factura
go

insert into Proveedor values ('Proveedor de Pintura','Efectivo','Pintuco')
insert into Proveedor values ('Proveedor de Aceite de motor','Transferencia Bancaria','Ultramotor')
insert into Proveedor values ('Provedor de mano de obra','Efectivo','CheakEngine')
select * from Proveedor
go

insert into Producto values (1,'Pintura Roja',100,'Pintuco','PicPaint Rojo',500.00,0.00,5)
insert into Producto values (2,'Aceite de motor',1000,'Ultramotor','UltraOil',100.00,0.00,10)
insert into Producto values (3,'Trabajo de pintura',5,'CheakEngine','Pintar',500.00,0.00,-1)
insert into Producto values (3,'Cambio de aceite',10,'Cheakengine','Cambio de aceite',100.00,0.00,-1)
select * from Producto
go


insert into Actividad values ('Pintar vehiculo','Trabajo de pintura',2,3,1)
insert into Actividad values ('Cambio de aceite','Trabajo preventibo',2,4,1)
select * from Actividad
go


insert into Estacion values ('Hojalateria y puntura',1)
insert into Estacion values ('Revision',2)
select * from Estacion
go

insert into FacturaDetalle  values (1,1,1,100.00)
insert into FacturaDetalle  values (2,2,2,2000.00)
select * from FacturaDetalle
go

insert into Bitacora values ('Usuario','Insertar',1,'Pedro')
insert into Bitacora values ('Pedidos','Insertar',2,'Juan')
select * from Bitacora
go

--Trigger

create trigger Tr_Producto on FacturaDetalle after Insert as
begin 
declare @existencia int, @ExistenciaMin int,@ProductoId int,@Descripcion varchar(100),@Precio decimal (12,2)
select @ExistenciaMin=Producto.ProductoExistenciaMin,@existencia=Producto.ProductoExistencia,@ProductoId=inserted.ProductoId, 
@Descripcion= Producto.ProductoDescripcion,@Precio=Producto.ProductoPrecioUnitario 
from inserted inner join Producto on inserted.ProductoId=Producto.ProductoId
if (@existencia<@ExistenciaMin)
begin
insert into Pedido values (@ProductoId,@ExistenciaMin,('Pedido de: ' + @Descripcion),convert(decimal(12,2),@Precio*0.60))
end
end
go

create trigger Tr_Bitacora_Estacion on Estacion after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=EstacionId from deleted
insert Bitacora values ('Estacion','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=EstacionId from inserted
insert Bitacora values ('Estacion','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=EstacionId from deleted
insert Bitacora values ('Estacion','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Actividad on Actividad after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=ActividadId from deleted
insert Bitacora values ('Actividad','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=ActividadId from inserted
insert Bitacora values ('Actividad','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=ActividadId from deleted
insert Bitacora values ('Actividad','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Producto on Producto after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=ProductoId from deleted
insert Bitacora values ('Producto','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=ProductoId from inserted
insert Bitacora values ('Producto','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=ProductoId from deleted
insert Bitacora values ('Producto','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Proveedor on Proveedor after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=ProveedorId from deleted
insert Bitacora values ('Proveedor','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=ProveedorId from inserted
insert Bitacora values ('Proveedor','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=ProveedorId from deleted
insert Bitacora values ('Proveedor','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Factura on Factura after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=FacturaId from deleted
insert Bitacora values ('Factura','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=FacturaId from inserted
insert Bitacora values ('Factura','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=FacturaId from deleted
insert Bitacora values ('Factura','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Vehiculo on Vehiculo after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=VehiculoId from deleted
insert Bitacora values ('Vehiculo','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=VehiculoId from inserted
insert Bitacora values ('Vehiculo','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=VehiculoId from deleted
insert Bitacora values ('Vehiculo','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Cliente on Cliente after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=ClienteId from deleted
insert Bitacora values ('Cliente','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=ClienteId from inserted
insert Bitacora values ('Cliente','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=ClienteId from deleted
insert Bitacora values ('Cliente','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create trigger Tr_Bitacora_Usuario on Usuario after INSERT,DELETE,UPDATE as
begin declare @Codigo int
IF EXISTS (select * from deleted) begin IF not exists (select * from inserted) begin
select @Codigo=UsuarioId from deleted
insert Bitacora values ('Usuario','DELETE',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from inserted) begin IF not exists (select * from deleted) begin
select @Codigo=UsuarioId from inserted
insert Bitacora values ('Usuario','INSERT',@Codigo,SUSER_NAME())
end end
IF EXISTS (select * from deleted) begin IF EXISTS (select * from inserted) begin
select @Codigo=UsuarioId from deleted
insert Bitacora values ('Usuario','UPDATE',@Codigo,SUSER_NAME())
end end end
go

create procedure S_Cliente @Buscar varchar (100) as
select ClienteID,ClienteDireccion,ClienteNombre1,ClienteNombre2,ClienteApellido1,ClienteApellido2,ClienteIdentificacion,ClienteTelefono
from Cliente where ((CONVERT(varchar(100),ClienteDireccion) like ('%'+@Buscar+'%')) or
(CONVERT(varchar(100),ClienteIdentificacion) like ('%'+@Buscar+'%')) or
(CONVERT(varchar(100),ClienteNombre1) like ('%'+@Buscar+'%')) or
(CONVERT(varchar(100),ClienteNombre2) like ('%'+@Buscar+'%')) or 
(CONVERT(varchar(100),ClienteApellido1) like ('%'+@Buscar+'%')) or
(CONVERT(varchar(100),ClienteApellido2) like ('%'+@Buscar+'%')) or
(CONVERT(varchar(100),ClienteTelefono) like ('%'+@Buscar+'%')) or 
(CONVERT(varchar(100),ClienteID) like ('%'+@Buscar+'%')))
go

create view vFactura as 
(SELECT f.FacturaFecha AS 'Fecha' , f.FacturaId AS 'Numero de factura', cl.ClienteIdentificacion AS 'Identidad', 
cl.ClienteNombre1 + ' ' + cl.ClienteApellido1 AS 'Nombre Cliente', cl.ClienteTelefono AS 'Telefono', f.FacturaSubtotal AS 'Sub total',
f.FacturaImpuesto AS 'Impuesto', f.FacturaTotal AS 'Total'
from Factura f inner join Cliente cl ON f.ClienteId = cl.ClienteID 
)
go