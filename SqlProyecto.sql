/*
if exists (select * from sys.databases where name = 'Farmacia')
begin
	use master
	drop database Farmacia
end
go
*/

-- proyecto Final De Gestion De Proyectos
xp_create_subdir 'D:\DatosFarcia'
go
xp_create_subdir 'D:\BaseProductos'
go
create database Farmacia
on primary
(name ='Farmacia01', filename = 'D:\DatosFarcia\Farmacia01.mdf',
size=100MB, MaxSize =20GB ,Filegrowth =200MB),
(name = 'Farmacia02',filename= 'D:\BaseProductos\Farmacia02.ndf',
size=50MB,Filegrowth =200MB),
filegroup Administrador
(name = 'Farmacia03',filename='D:\BaseProductos\Farmacia03.ndf'),
filegroup Personal
(name ='Farmacia04', filename ='D:\BaseProductos\Farmacia04.ndf')
log on 
(name ='HistorialFarmacia',filename='D:\BaseProductos\HistorialFarmacia.ndf')

/*=============================================*/
set dateformat dmy
go
/*=======================================================*/

create schema Registrofarmacia
go

create table  Registrofarmacia.Precentacion(
PrecentacionesCodigo nchar(17),
PrecentacionesNombre varchar (50) ,
PrecentacionesDescripcion  nvarchar (100),
PrecentacionesEstado nchar(1) not null,
constraint PrecentacionesPK primary key (PrecentacionesCodigo),
constraint PrecentacionEstadoCK check (PrecentacionesEstado = 'A' or PrecentacionesEstado = 'E')
)
go

insert into Registrofarmacia.Precentacion values  ('0001','farmcia','buenafarmacia','A')
insert into Registrofarmacia.Precentacion  values ('0002','evlis','nomnre','A')


select * from Registrofarmacia.Precentacion 
go
/*======================================================*/

create table Registrofarmacia.Categorias(
CategoriasCodigo nchar (17),
CategoriaNombre varchar (50),
CategoriaDescripcion nvarchar (100) not null,
CategoriaEstado nchar(1) not null,
constraint CategoriaNombrePK primary key (CategoriasCodigo),
constraint CategoriaEstadosCK check (CategoriaEstado = 'A' or CategoriaEstado = 'E')

)
go
insert into Registrofarmacia.Categorias values  ('001','alimentacion','buenafarmacia','A')
insert into Registrofarmacia.Categorias values ('002','nutrientez',' para niños','A')
select * from Registrofarmacia.Categorias

go

----falta correr
/*=================================================================*/
create table Registrofarmacia.Administradora
(
AdministradorCodigo nchar(17),
AdministradorNombre nvarchar (100) not null,
AdministradorApellidos nvarchar (100)not null,
AdministradorSexo nchar (1),
AdministradorRuc nvarchar (100) not null,
AdministradorTelefono nvarchar (9),
AdministradorDni nvarchar (8),
AdministradorDireccion  nvarchar  (100),
AdministradorFechaNacimiento Date,
AdministradorFechaDeEntrada date,
AdministradorFoto image ,
AdministradoraEstado nchar(1) not null,
constraint AdministradoraPK primary key  (AdministradorCodigo),
constraint AdministradoraEstadoCK check (AdministradoraEstado = 'A' or AdministradoraEstado = 'E')

		)
		go


/*===================================================================*/
Create table  Registrofarmacia.Proveedores(
ProveedorCodigo nchar (17),
ProveedorNombre nvarchar (50),
ProveedorApellidos nvarchar (50),
ProveedorDireccion nvarchar (100),
ProveedorSexo nchar (1),
ProveedorDni nvarchar (8),
ProveedorTelefono nvarchar (9),
ProveedorFechaDeEntrada date,
Proveedorfoto image,
ProveedoraEstado nchar(1) not null,
ProveedoraAdministradorCodigo nchar(17),
constraint ProveedoresPK primary key (ProveedorCodigo),
constraint ProveedoraAdministradorFK foreign key (ProveedoraAdministradorCodigo) references Registrofarmacia.Administradora (AdministradorCodigo),

constraint ProveedoresEstadoCK check (ProveedoraEstado = 'A' or ProveedoraEstado = 'E')

)
go

/*===================================================================*/
create table Registrofarmacia.Cliente(
ClienteCodigo nchar (17),
ClienteNombre nvarchar (50),
ClienteTipoDocumento nvarchar(20),
ClienteNumeroDocumento nvarchar (15),
ClienteTelefono nvarchar (9),
ClienteSexo nchar (1),
ClienteDireccion nvarchar (100) ,
ClienteFechaDeNacimiento date,
ClienteEstado nchar(1) not null,
ClienteAdministradorCodigo nchar(17),
constraint ClientesPK primary key (ClienteCodigo),
constraint AdministradoraFK foreign key (ClienteAdministradorCodigo) references Registrofarmacia.Administradora (AdministradorCodigo),
constraint ClienteNumeroDocumentoUQ unique(ClienteNumeroDocumento),
constraint ClientesEstadoCK check (ClienteEstado = 'A' or ClienteEstado = 'E')
	  )

	  go
/*===================================================================*/

create table Registrofarmacia.Farmaceutico(
FarmaceuticoCodigo nchar (17),
FarmaceuticoNombre nvarchar(50),
FarmaceuticoApellidos nvarchar(50),
FarmaceuticoTelefono nvarchar(9),
FarmaceuticoDireccion nvarchar(100) not null,
FarmaceuticoDni nvarchar (8),
Farmaceuticofoto image,
FarmaceuticoSexo nchar(1),
FarmaceuticoFechaDeNacimiento date,
FarmaceuticoFechaDeEntrada date,
FarmaceuticoAdministradorCodigo nchar (17),
FarmaceuticoEstado nchar(1) not null,
constraint FarmaceuticoPK primary key (FarmaceuticoCodigo),
 constraint FarmaceuticoAdministradorFK foreign key (FarmaceuticoAdministradorCodigo)
references Registrofarmacia.Administradora(AdministradorCodigo),
constraint FarmaceuticoEstadoCK check (FarmaceuticoEstado = 'A' or FarmaceuticoEstado = 'E')
		)
		go

/*===================================================================*/
 create table  Registrofarmacia.MedicamentosDeBotica (
MedicamentosCodigo nchar (50),
MedicamentosNombre nvarchar (50),
MedicamentosLaboratorio nvarchar(50),
MedicamentosEspecificaciones nvarchar(100),
MedicamentosStock Numeric (10,2),
MedicamentosPrecioDeCompra numeric (10,2) ,
MedicamentosPrecioDeVenta numeric (10,2),
MedicamentosCito nvarchar(50),
MedicamentosFechaDeEntrada  date,
MedicamentosFechaVenceMedicamento  date ,
MedicamentosCategoriasCodigo nchar (17),
MedicamentosPrecentacionesCodigo nchar(17),
MedicamentosAdministradorCodigo nchar(17),  
MedicamentosEstado nchar(1) not null,
	constraint MedicamentosPK primary key (MedicamentosCodigo),
	constraint PrecentacionesFK Foreign key (MedicamentosPrecentacionesCodigo)
		references Registrofarmacia.Precentacion(PrecentacionesCodigo),
		constraint CategoriasFK Foreign key (MedicamentosCategoriasCodigo)
		references Registrofarmacia.Categorias(CategoriasCodigo),
			constraint AdministradorFK Foreign key (MedicamentosAdministradorCodigo)
		references  Registrofarmacia.Administradora(AdministradorCodigo),
		constraint MedicamentoEstadoCK check (MedicamentosEstado = 'A' or MedicamentosEstado = 'E')

)
go
/*===================================================================*/
create table Registrofarmacia.Pedido(
PedidoCodigo int  identity,
PedidoTotalApagar numeric (9,2) ,
PedidoNumeroDeOrden nvarchar (50) not null,
PedidoClienteCodigo nchar (17),
PedidoFarmaceuticoCodigo nchar(17),
PedidoFechaDePedido date,
PedidoEstado nchar(1) not null,
constraint PedidoPK primary key (PedidoCodigo),
constraint ClienteFK Foreign key(PedidoClienteCodigo )
      references Registrofarmacia.Cliente(ClienteCodigo),
constraint PedidoFarmaceuticoFK Foreign key(PedidoFarmaceuticoCodigo)
      references  Registrofarmacia.Farmaceutico(FarmaceuticoCodigo),
	  constraint PedidoEstadoCK check (PedidoEstado = 'A' or PedidoEstado = 'E')
)
go


create table RegistroFarmacia.DetallePedido(
PedidoCodigo int ,
MedicamentoCodigo nchar (50),
DetallePedidoImporte numeric (9,2),
DetallePedidoCantidad numeric (9,2) ,
DetallePedidoPrecio  numeric (9,2),
constraint DetallePedidoPK primary key (pedidoCodigo, MedicamentoCodigo),
constraint MedicamentoFK Foreign key(MedicamentoCodigo )
      references  Registrofarmacia.MedicamentosDeBotica(MedicamentosCodigo ),
	  constraint DetallePedidoFK Foreign key(PedidoCodigo )
      references  Registrofarmacia.Pedido(PedidoCodigo )
)
go

create procedure  dbo.AutogenerarNumeroPedido(@NumeroPedido  int output )
  as
  Begin
  set @NumeroPedido = (SELECT COUNT(*)+1 FROM Registrofarmacia.Pedido)
  End
 go

 create PROCEDURE spRegistrarPedido(
 @pedidoCodigo int output,
 @PedidoTotalApagar numeric (9,2),
 @PedidoNumeroDeOrden nvarchar (50),
 @PedidoClienteCodigo nchar (17),
 @PedidoFarmaceuticoCodigo nchar(17),
 @PedidoFechaDePedido date)
 As
 insert into Registrofarmacia.Pedido(PedidoNumeroDeOrden ,PedidoClienteCodigo,
 PedidoFarmaceuticoCodigo ,PedidoFechaDePedido , PedidoTotalApagar, PedidoEstado  ) 
 VALUES (@PedidoNumeroDeOrden, @PedidoClienteCodigo, @PedidoFarmaceuticoCodigo,
 @PedidoFechaDePedido, @PedidoTotalApagar, 'A')
 set @pedidoCodigo=SCOPE_IDENTITY() 
 go

create procedure spRegistrarDetallePedido(
@PedidoCodigo int, 
@MedicamentoCodigo nchar (50),
@DetallePedidoImporte numeric (9,2),
@DetallePedidoCantidad  numeric (9,2),
@DetallePedidoPrecio  numeric (9,2))
AS
insert into RegistroFarmacia.DetallePedido(PedidoCodigo , MedicamentoCodigo , DetallePedidoImporte , 
DetallePedidoCantidad , DetallePedidoPrecio) values
(@PedidoCodigo, @MedicamentoCodigo, @DetallePedidoImporte, @DetallePedidoCantidad, @DetallePedidoPrecio)
go
select* from Registrofarmacia.Pedido
go
/*===================================================================*/
-- proceidmientos almacenados   para precentaciones
  -- listado
  create procedure spPrecentacioneslistados
  with encryption 
  as 
    select * from Registrofarmacia.Precentacion where PrecentacionesEstado  <>'E'
	go

-- insertar Precentaciones 
  create procedure spinsertarlistadoPrecentacion
  (
  @PrecentacionesCodigo nchar (17),
@PrecentacionesNombre varchar (50) ,
@PrecentacionesDescripcion  nvarchar (100),
@PrecentacionesEstado nchar(1)

	)
	with encryption
	As
	insert into Registrofarmacia.Precentacion
	([PrecentacionesCodigo],[PrecentacionesNombre],[PrecentacionesDescripcion],[PrecentacionesEstado])
	values
	(
	@PrecentacionesCodigo,
	@PrecentacionesNombre  ,
@PrecentacionesDescripcion,
@PrecentacionesEstado
	 )
	go

--Modificar los datos  del producto
create procedure spModificarPrecentacion
	(
@PrecentacionesCodigo nchar (17),
@PrecentacionesNombre varchar (50) ,
@PrecentacionesDescripcion  nvarchar (100) 

	)

	with encryption
	as
	update Registrofarmacia.Precentacion
	set
	[PrecentacionesCodigo]=@PrecentacionesCodigo,
	[PrecentacionesNombre]=@PrecentacionesNombre ,
[PrecentacionesDescripcion] =@PrecentacionesDescripcion

	 where [PrecentacionesCodigo] = @PrecentacionesCodigo
	 go

	 --Eliminar 
	 create procedure spEliminarlistados
	(
@PrecentacionesCodigo nchar (17)
	)
	with encryption
	As
		update Registrofarmacia.Precentacion
			Set		[PrecentacionesEstado] = 'E'
			where	PrecentacionesCodigo = @PrecentacionesCodigo
go



/*=============================================================*/

-- proceidmientos almacenados para categorias
  -- listado
  create procedure spCategorialistado
  with encryption 
  as 
    select * from Registrofarmacia.Categorias where CategoriaEstado  <>'E'
	go

-- insertar Categoria
 create procedure spinsertarlistadoategoria
  (

@CategoriasCodigo nchar (17),
@CategoriaNombre varchar (50),
@CategoriaDescripcion nvarchar (100),
@CategoriaEstado nchar(1) 

	)
	with encryption
	As
	insert into Registrofarmacia.Categorias
	([CategoriasCodigo],[CategoriaNombre],[CategoriaDescripcion],[CategoriaEstado])
	values
	(	
@CategoriasCodigo,
@CategoriaNombre,
@CategoriaDescripcion,
@CategoriaEstado
	 )
	go

--Modificar los datos  del producto
create procedure spModificadolistadoCategoria
	(
@CategoriasCodigo nchar (17),
@CategoriaNombre varchar (50),
@CategoriaDescripcion nvarchar (100) 

	)
	as
	update Registrofarmacia.Categorias
	set
	[CategoriasCodigo]=@CategoriasCodigo,
	[CategoriaNombre]=@CategoriaNombre ,
[CategoriaDescripcion] =@CategoriaDescripcion

	 where [CategoriasCodigo]=@CategoriasCodigo
	 go
	

	 --Eliminar 
	 create procedure spEliminarlistadoCategoria
	(
@CategoriasCodigo nchar (17)
	)
	with encryption
	As
		update  Registrofarmacia.Categorias
			Set		[CategoriaEstado] = 'E'
			where	CategoriasCodigo = @CategoriasCodigo
go



/*======================================================== Administrador*/
-- proceidmientos almacenados para categorias
  -- listado
   create procedure spAdministradorlistados
  with encryption 
  as 
    select * from Registrofarmacia.Administradora where AdministradoraEstado  <>'E'
	go
	Alter table Registrofarmacia.Administradora add constraint RegistrofarmaciaAdministradora
	Unique (AdministradorDni)
go	
--------------------------------------------------------
create procedure  spAdministradorInsertada
(
@AdministradorNombre nvarchar (100) ,
@AdministradorApellidos nvarchar (100),
@AdministradorSexo nchar (1),
@AdministradorRuc nvarchar (100) ,
@AdministradorTelefono nvarchar (9),
@AdministradorDni nvarchar (8),
@AdministradorDireccion varchar (100),
@AdministradorFechaNacimiento Date,
@AdministradorFechaDeEntrada date,
@AdministradorFoto image ,
@AdministradoraEstado nchar(1)
)

as
declare @Codigo nchar (17)
set @Codigo = (
upper (left (trim(@AdministradorNombre),2))+
UPPER(left(trim(@AdministradorApellidos),2))+
+iif(upper(@AdministradorSexo)='M','1','0')+
upper (left(trim(@AdministradorRuc),2))+
upper (left(trim(@AdministradorTelefono),2))+
upper(left(trim(@AdministradorDni),2))
)

declare @codigoVerificacion int
select @codigoVerificacion =COUNT(P.AdministradorCodigo)+1 from Registrofarmacia.Administradora as P where left (P.AdministradorCodigo,15) = @Codigo
declare @CodigoVerificaTexto nchar (9)
set @CodigoVerificaTexto =right ('000'+trim(str(@codigoVerificacion)),4)
insert into Registrofarmacia.Administradora ([AdministradorCodigo],[AdministradorNombre],[AdministradorApellidos],[AdministradorSexo],[AdministradorRuc],
[AdministradorTelefono],[AdministradorDni],[AdministradorDireccion],[AdministradorFechaNacimiento],[AdministradorFechaDeEntrada],[AdministradorFoto],[AdministradoraEstado])
values
(TRIM(@Codigo)+TRIM(@CodigoVerificaTexto), @AdministradorNombre , @AdministradorApellidos, @AdministradorSexo, @AdministradorRuc,
@AdministradorTelefono, @AdministradorDni  ,@AdministradorDireccion,@AdministradorFechaNacimiento,@AdministradorFechaDeEntrada,@AdministradorFoto,@AdministradoraEstado)
go


set dateformat dmy
go

-------------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------
-- insertar Administrador
create procedure spAdministradoraModificar
	(
	@AdministradorCodigo nchar(17),
@AdministradorNombre nvarchar (100) ,
@AdministradorApellidos nvarchar (100),
@AdministradorSexo nchar (1),
@AdministradorRuc nvarchar (100) ,
@AdministradorTelefono nvarchar (9),
@AdministradorDni nvarchar (8),
@AdministradorDireccion varchar (100),
@AdministradorFechaNacimiento Date,
@AdministradorFechaDeEntrada date,
@AdministradorFoto image 
	)
As begin
	update Registrofarmacia.Administradora set  [AdministradorNombre] = @AdministradorNombre, 
		[AdministradorApellidos] = @AdministradorApellidos,  [AdministradorSexo] =@AdministradorSexo ,
		[AdministradorRuc] =@AdministradorRuc , [AdministradorTelefono] = @AdministradorTelefono, 
		[AdministradorDni] = @AdministradorDni, [AdministradorDireccion]=@AdministradorDireccion,
		[AdministradorFechaNacimiento]=@AdministradorFechaNacimiento, [AdministradorFechaDeEntrada]=@AdministradorFechaDeEntrada,
		[AdministradorFoto]=@AdministradorFoto 

	 where [AdministradorCodigo] =@AdministradorCodigo
	 end 
go

------------------------------------------------------------------------------
	 create procedure spEliminarAdministradora
	(
@AdministradorCodigo nchar(17)
	)
	with encryption
	As
		delete  Registrofarmacia.Administradora
			Set		[AdministradoraEstado] = 'E'
			where	AdministradorCodigo = @AdministradorCodigo
go


/*====================================================== provedorr*/
 create procedure spProveedorlistados
  with encryption 
  as 
    select * from Registrofarmacia.Proveedores where ProveedoraEstado  <>'E'
	go

	select AdministradorCodigo, AdministradorNombre from Registrofarmacia.Administradora
	order by AdministradorNombre
go
---------------------------------------------------------------------------------------------



--------------------------------------------------------------------------------------------
-- Indice para Administrador


create index AdministradorNombreIDXa on Registrofarmacia.Administradora (AdministradorNombre)
go
create procedure sproveedoresListadoAdministrador
	with encryption
	As
		Select C.AdministradorCodigo, C.AdministradorNombre
			 from Registrofarmacia.Administradora  As C
			order by AdministradorNombre
go

-------------------------------------------------------------------------------------------------------


---para		Insertar Datos  A Visual estudio
create procedure  spProveedoraInsertar
(
@ProveedorNombre nvarchar (50),
@ProveedorApellidos nvarchar (50),
@ProveedorDireccion nvarchar (100),
@ProveedorSexo nchar (1),
@ProveedorDni nvarchar (8),
@ProveedorTelefono nvarchar (9),
@ProveedorFechaDeEntrada date,
@Proveedorfoto image,
@ProveedoraEstado nchar(1),
@ProveedoraAdministradorCodigo nchar(17)

)

as
declare @Codigo nchar (17)
set @Codigo = (
upper (left (trim(@ProveedorNombre),2))+
UPPER(left(trim(@ProveedorApellidos),2))+
+iif(upper(@ProveedorSexo)='M','1','0')+
upper (left(trim(@ProveedorTelefono),2))+
upper(left(trim(@ProveedorDni),2))
)
declare @codigoVerificacion int
select @codigoVerificacion =COUNT(P.ProveedorCodigo)+1 from  Registrofarmacia.Proveedores as P where left (P.ProveedorCodigo,13) = @Codigo
declare @CodigoVerificaTexto nchar (7)
set @CodigoVerificaTexto =right ('000'+trim(str(@codigoVerificacion)),4)
--  la instruccion para insertar 
insert into Registrofarmacia.Proveedores([ProveedorCodigo],[ProveedorNombre],[ProveedorApellidos],[ProveedorDireccion],[ProveedorSexo],
[ProveedorDni],[ProveedorTelefono],[ProveedorFechaDeEntrada],[Proveedorfoto],[ProveedoraAdministradorCodigo],[ProveedoraEstado])
values
(TRIM(@Codigo)+TRIM(@CodigoVerificaTexto), @ProveedorNombre , @ProveedorApellidos, @ProveedorDireccion, @ProveedorSexo,
@ProveedorDni,@ProveedorTelefono,@ProveedorFechaDeEntrada,@Proveedorfoto,@ProveedoraAdministradorCodigo,@ProveedoraEstado)
go



Alter table Registrofarmacia.proveedores add constraint RegistrofarmaciaProveedor
	Unique (ProveedorDni)
go	
create procedure spProveedoresModificar
	(
	@ProveedorCodigo nchar (17),
@ProveedorNombre nvarchar (50),
@ProveedorApellidos nvarchar (50),
@ProveedorDireccion nvarchar (100),
@ProveedorSexo nchar (1),
@ProveedorDni nvarchar (8),
@ProveedorTelefono nvarchar (9),
@ProveedorFechaDeEntrada date,
@Proveedorfoto image,
@ProveedoraAdministradorCodigo nchar(17)
	)
As begin
	update Registrofarmacia.Proveedores set  [ProveedorNombre] = @ProveedorNombre, 
		[ProveedorApellidos] = @ProveedorApellidos,  [ProveedorDireccion] =@ProveedorDireccion ,
		[ProveedorSexo] =@ProveedorSexo , [ProveedorDni] = @ProveedorDni, 
		[ProveedorTelefono] = @ProveedorTelefono, [ProveedorFechaDeEntrada]=@ProveedorFechaDeEntrada,
		[Proveedorfoto]=@Proveedorfoto, [ProveedoraAdministradorCodigo]=@ProveedoraAdministradorCodigo

	 where [ProveedorCodigo] =@ProveedorCodigo
	 end 
go


create procedure spEliminarProveedores
	(
@ProveedorCodigo nchar(17)
	)
	with encryption
	As
		update  Registrofarmacia.Proveedores
			Set		[ProveedoraEstado] = 'E'
			where	[ProveedorCodigo] = @ProveedorCodigo
go


/*============================================================== cliente*/
create procedure spClienteslistados
  with encryption 
  as 
    select [ClienteCodigo], [ClienteNombre],  [ClienteTipoDocumento], [ClienteNumeroDocumento], [ClienteTelefono], [ClienteSexo], [ClienteDireccion], [ClienteFechaDeNacimiento], [ClienteEstado], [ClienteAdministradorCodigo] from Registrofarmacia.Cliente where ClienteEstado  <>'E'
	go

-------------------------------------------------------------------------------------------
create index  AdministradorNombresIDXa on Registrofarmacia.Administradora(AdministradorNombre)
go
Create procedure spClientesListadoAdministradores
	with encryption
	As
		Select P.AdministradorCodigo, P.AdministradorNombre
			 from Registrofarmacia.Administradora  As P
			order by P.AdministradorNombre
go

-------------------------------------------------------------------------------------------------------

---para		Insertar Datos  A Visual estudio
create procedure  spClientesInsertar
(

@ClienteNombre nvarchar (50),
@ClienteTipoDocumento nvarchar(20),
@ClienteNumeroDocumento nvarchar (15),
@ClienteTelefono nvarchar (9),
@ClienteSexo nchar (1),
@ClienteDireccion nvarchar (100) ,
@ClienteFechaDeNacimiento date,
@ClienteEstado nchar(1),
@ClienteAdministradorCodigo nchar(17)

)

as
declare @Codigo nchar (17)
set @Codigo = (
upper (left (trim(@ClienteNombre),4))+
upper (left(trim(@ClienteNumeroDocumento),4))+
upper (left(trim(@ClienteTelefono),2))+
+iif(upper(@ClienteSexo)='M','1','0')
)
declare @codigoVerificacion int
select @codigoVerificacion =COUNT(P.ClienteCodigo)+1 from Registrofarmacia.Cliente as P where left (P.ClienteCodigo,13) = @Codigo
declare @CodigoVerificaTexto nchar (8)
set @CodigoVerificaTexto =right ('00000'+trim(str(@codigoVerificacion)),6)
--  la instruccion para insertar 
insert into Registrofarmacia.Cliente([ClienteCodigo],[ClienteNombre],[ClienteTipoDocumento],[ClienteNumeroDocumento],
[ClienteTelefono],[ClienteSexo],[ClienteDireccion],[ClienteFechaDeNacimiento],[ClienteEstado],[ClienteAdministradorCodigo])
values
(TRIM(@Codigo)+TRIM(@CodigoVerificaTexto), @ClienteNombre , @ClienteTipoDocumento, @ClienteNumeroDocumento,
@ClienteTelefono,@ClienteSexo,@ClienteDireccion,@ClienteFechaDeNacimiento,@ClienteEstado,@ClienteAdministradorCodigo)
go



create procedure spClienteModificar

	(
	@ClienteCodigo nchar (17),
@ClienteNombre nvarchar (50),
@ClienteTipoDocumento nvarchar(20),
@ClienteNumeroDocumento nvarchar (15),
@ClienteTelefono nvarchar (9),
@ClienteSexo nchar (1),
@ClienteDireccion nvarchar (100) ,
@ClienteFechaDeNacimiento date,
@ClienteAdministradorCodigo nchar(17)
	)
As begin
	update Registrofarmacia.Cliente set  [ClienteNombre] = @ClienteNombre, 
		  [ClienteTipoDocumento] =@ClienteTipoDocumento ,
		[ClienteNumeroDocumento] =@ClienteNumeroDocumento , [ClienteTelefono] = @ClienteTelefono, 
		[ClienteSexo] = @ClienteSexo, [ClienteDireccion]=@ClienteDireccion,
		[ClienteFechaDeNacimiento]=@ClienteFechaDeNacimiento, [ClienteAdministradorCodigo]=@ClienteAdministradorCodigo

	 where [ClienteCodigo] =@ClienteCodigo
	 end 
go

create procedure spEliminarClientes
	(
@ClienteCodigo nchar(17)
	)
	with encryption
	As
		update  Registrofarmacia.Cliente
			Set		[ClienteEstado] = 'E'
			where	[ClienteCodigo] = @ClienteCodigo
go


/*======================================================== farmaceutico*/


create procedure spFarmaceuticolistados
  with encryption 
  as 
   select * from Registrofarmacia.Farmaceutico where FarmaceuticoEstado <>'E'
	go
		Alter table Registrofarmacia.Farmaceutico add constraint RegistrofarmaciaFarmaceutico
	Unique (FarmaceuticoDni)
go	
-------------------------------------------------------------------------------------------

Create procedure spFarmaceuticoListadoAdministradores
	with encryption
	As
		Select P.AdministradorCodigo, P.AdministradorNombre
			 from Registrofarmacia.Administradora  As P
			order by P.AdministradorNombre
go
create index  FarmaceuticoNombresIDXa on Registrofarmacia.Farmaceutico(FarmaceuticoSexo)
go
-------------------------------------------------------InsertarFarmaceutico

create procedure  spFarmaceuticoInsertar
(
@FarmaceuticoNombre nvarchar(50),
@FarmaceuticoApellidos nvarchar(50),
@FarmaceuticoTelefono nvarchar(9),
@FarmaceuticoDireccion nvarchar(100),
@FarmaceuticoDni nvarchar (8),
@Farmaceuticofoto image,
@FarmaceuticoSexo nchar (1),
@FarmaceuticoFechaDeNacimiento date,
@FarmaceuticoFechaDeEntrada date,
@FarmaceuticoAdministradorCodigo nchar (17),
@FarmaceuticoEstado nchar(1)

)

as
declare @Codigo nchar (17)
set @Codigo = (
upper (left (trim(@FarmaceuticoNombre),2))+
UPPER(left(trim(@FarmaceuticoApellidos),2))+
upper(left(trim(@FarmaceuticoDni),2))+
+iif(upper(@FarmaceuticoSexo)='M','1','0')
)
declare @codigoVerificacion int
select @codigoVerificacion =COUNT(P.FarmaceuticoCodigo)+1 from Registrofarmacia.Farmaceutico as P where left (P.FarmaceuticoCodigo,10) = @Codigo
declare @CodigoVerificaTexto nchar (7)
set @CodigoVerificaTexto =right ('0000'+trim(str(@codigoVerificacion)),5)
--  la instruccion para insertar 
insert into Registrofarmacia.Farmaceutico([FarmaceuticoCodigo],[FarmaceuticoNombre],[FarmaceuticoApellidos],[FarmaceuticoTelefono],
[FarmaceuticoDireccion],[FarmaceuticoDni],[Farmaceuticofoto],[FarmaceuticoSexo],[FarmaceuticoFechaDeNacimiento],[FarmaceuticoFechaDeEntrada],[FarmaceuticoAdministradorCodigo],[FarmaceuticoEstado])
values
(TRIM(@Codigo)+TRIM(@CodigoVerificaTexto), @FarmaceuticoNombre , @FarmaceuticoApellidos, @FarmaceuticoTelefono, @FarmaceuticoDireccion,
@FarmaceuticoDni,@Farmaceuticofoto,@FarmaceuticoSexo,@FarmaceuticoFechaDeNacimiento,@FarmaceuticoFechaDeEntrada,@FarmaceuticoAdministradorCodigo,@FarmaceuticoEstado)
go
-----------------------------------------------------------------------------------------
create procedure spFarmaceuticoModificar

	(
	@FarmaceuticoCodigo nchar (17),
@FarmaceuticoNombre nvarchar(50),
@FarmaceuticoApellidos nvarchar(50),
@FarmaceuticoTelefono nvarchar(9),
@FarmaceuticoDireccion nvarchar(100),
@FarmaceuticoDni nvarchar (8),
@Farmaceuticofoto image,
@FarmaceuticoSexo nchar (1),
@FarmaceuticoFechaDeNacimiento date,
@FarmaceuticoFechaDeEntrada date,
@FarmaceuticoAdministradorCodigo nchar (17)

	)
As begin
	update Registrofarmacia.Farmaceutico set  [FarmaceuticoNombre] = @FarmaceuticoNombre, 
		[FarmaceuticoApellidos] = @FarmaceuticoApellidos,  [FarmaceuticoTelefono] =@FarmaceuticoTelefono ,
		[FarmaceuticoDireccion] =@FarmaceuticoDireccion , [FarmaceuticoDni] = @FarmaceuticoDni, 
		[Farmaceuticofoto] = @Farmaceuticofoto, [FarmaceuticoSexo]=@FarmaceuticoSexo,
		[FarmaceuticoFechaDeNacimiento]=@FarmaceuticoFechaDeNacimiento,[FarmaceuticoFechaDeEntrada]=@FarmaceuticoFechaDeEntrada, [FarmaceuticoAdministradorCodigo]=@FarmaceuticoAdministradorCodigo

	 where [FarmaceuticoCodigo] =@FarmaceuticoCodigo
	 end 
go
----------------------------------------------------------------------------------------------
create procedure spEliminarFarmaceutico
	(
@FarmaceuticoCodigo nchar(17)
	)
	with encryption
	As
		update  Registrofarmacia.Farmaceutico
			Set		[FarmaceuticoEstado] = 'E'
			where	[FarmaceuticoCodigo] = @FarmaceuticoCodigo
go
------------------------------------------------------------------------------------------------
/*======================================================== medicamentos*/
create procedure spMedicamentoslistados
  with encryption 
  as 
   select * from Registrofarmacia.MedicamentosDeBotica where MedicamentosEstado <>'E'
	go
	
Create procedure spMedicamentosListadoAdministradores
	with encryption
	As
		Select P.AdministradorCodigo, P.AdministradorNombre
			 from Registrofarmacia.Administradora  As P
			order by P.AdministradorNombre
go

Create procedure spMedicamentosListadoCategorias
	with encryption
	As
		Select P.CategoriasCodigo, P.CategoriaNombre
			 from Registrofarmacia.Categorias  As P
			order by P.CategoriaNombre
go
Create procedure spMedicamentosListadoPrecentaciones
	with encryption
	As
		Select P.PrecentacionesCodigo, P.PrecentacionesNombre
			 from Registrofarmacia.Precentacion  As P
			order by P.PrecentacionesNombre
go

create index MedicamentosNombresIDXa on Registrofarmacia.Categorias(CategoriaNombre)
go
create index MedicamentosNombresPrecentacionesIDXa on Registrofarmacia.Precentacion(PrecentacionesNombre)
go
create index MedicamentosNombresadministradoresIDXa on Registrofarmacia.Administradora(AdministradorNombre)
go
-------------------------------------------------------insertar
create procedure  spMedicamentosInsertar
(
@MedicamentosNombre nvarchar (50),
@MedicamentosLaboratorio nvarchar(50),
@MedicamentosEspecificaciones nvarchar(100),
@MedicamentosStock Numeric (10,2),
@MedicamentosPrecioDeCompra numeric (10,2) ,
@MedicamentosPrecioDeVenta numeric (10,2),
@MedicamentosCito nvarchar(50),
@MedicamentosFechaDeEntrada  date,
@MedicamentosFechaVenceMedicamento  date ,
@MedicamentosCategoriasCodigo nchar (17),
@MedicamentosPrecentacionesCodigo nchar(17),
@MedicamentosAdministradorCodigo nchar(17),  
@MedicamentosEstado nchar(1) 

)

as
declare @Codigo nchar (50)
set @Codigo = (
upper (left (trim(@MedicamentosNombre),2))+
UPPER(left(trim(@MedicamentosEspecificaciones),2))+
upper(left(trim(@MedicamentosLaboratorio),2))+
right(Trim(Str(year(@MedicamentosFechaDeEntrada))),2) +
		iif(month(@MedicamentosFechaDeEntrada)<10,'0'+Trim(Str(month(@MedicamentosFechaDeEntrada))),Trim(Str(month(@MedicamentosFechaDeEntrada))))+
		iif(day(@MedicamentosFechaDeEntrada)<10,'0'+Trim(Str(day(@MedicamentosFechaDeEntrada))),Trim(Str(day(@MedicamentosFechaDeEntrada))))
)
declare @codigoVerificacion int
select @codigoVerificacion =COUNT(P.MedicamentosCodigo)+1 from Registrofarmacia.MedicamentosDeBotica as P where left (P.MedicamentosCodigo,13) = @Codigo
declare @CodigoVerificaTexto nchar (10)
set @CodigoVerificaTexto =right ('000000'+trim(str(@codigoVerificacion)),7)
--  la instruccion para insertar 
insert into Registrofarmacia.MedicamentosDeBotica([MedicamentosCodigo],[MedicamentosPrecentacionesCodigo],[MedicamentosCategoriasCodigo],[MedicamentosAdministradorCodigo],
[MedicamentosNombre],[MedicamentosLaboratorio],[MedicamentosEspecificaciones],[MedicamentosStock],[MedicamentosPrecioDeCompra],[MedicamentosPrecioDeVenta],[MedicamentosCito],[MedicamentosFechaDeEntrada],[MedicamentosFechaVenceMedicamento],[MedicamentosEstado])
values
(TRIM(@Codigo)+TRIM(@CodigoVerificaTexto), @MedicamentosPrecentacionesCodigo , @MedicamentosCategoriasCodigo, @MedicamentosAdministradorCodigo, @MedicamentosNombre,
@MedicamentosLaboratorio,@MedicamentosEspecificaciones,@MedicamentosStock,@MedicamentosPrecioDeCompra,@MedicamentosPrecioDeVenta,@MedicamentosCito,@MedicamentosFechaDeEntrada,@MedicamentosFechaVenceMedicamento,@MedicamentosEstado)
go
-------------------------------------------------------------------------------------------------


create procedure spMedicamentosModificar

	(
@MedicamentosCodigo nchar (50),
@MedicamentosNombre nvarchar (50),
@MedicamentosLaboratorio nvarchar(50),
@MedicamentosEspecificaciones nvarchar(100),
@MedicamentosStock Numeric (10,2),
@MedicamentosPrecioDeCompra numeric (10,2) ,
@MedicamentosPrecioDeVenta numeric (10,2),
@MedicamentosCito nvarchar(50),
@MedicamentosFechaDeEntrada  date,
@MedicamentosFechaVenceMedicamento  date ,
@MedicamentosCategoriasCodigo nchar (17),
@MedicamentosPrecentacionesCodigo nchar(17),
@MedicamentosAdministradorCodigo nchar(17)

	)
As begin
	update Registrofarmacia.MedicamentosDeBotica set  [MedicamentosNombre] = @MedicamentosNombre, 
		[MedicamentosLaboratorio] = @MedicamentosLaboratorio,  [MedicamentosEspecificaciones] =@MedicamentosEspecificaciones,
		[MedicamentosStock] =@MedicamentosStock , 
		[MedicamentosPrecioDeCompra]=@MedicamentosPrecioDeCompra, [MedicamentosPrecioDeVenta] = @MedicamentosPrecioDeVenta, 
		[MedicamentosCito] = @MedicamentosCito, [MedicamentosFechaDeEntrada]=@MedicamentosFechaDeEntrada,
		[MedicamentosFechaVenceMedicamento]=@MedicamentosFechaVenceMedicamento, [MedicamentosCategoriasCodigo]=@MedicamentosCategoriasCodigo, [MedicamentosPrecentacionesCodigo]=@MedicamentosPrecentacionesCodigo,
		[MedicamentosAdministradorCodigo]=@MedicamentosAdministradorCodigo

	 where [MedicamentosCodigo] =@MedicamentosCodigo
	 end 
go

create procedure spEliminarMedicamentos
	(
@MedicamentosCodigo nchar(50)
	)
	with encryption
	As
		update  Registrofarmacia.MedicamentosDeBotica
			Set		[MedicamentosEstado] = 'E'
			where	[MedicamentosCodigo] = @MedicamentosCodigo
go

/*==================================================================================*/
create procedure spListadoPedido
with encryption
as
select * from  Registrofarmacia.Pedido  where PedidoEstado <>'E'
go

 create procedure spListadoDetallePedido (@pedidoCodigo int)
  with encryption 
  as 
    select * from Registrofarmacia.DetallePedido where PedidoCodigo = @pedidoCodigo
	go




/*
create table Resgistrofarmacias.FacturaVenta(
FacturaVentaCodigo nchar (8),
FacturaVentaDescripcion nvarchar (100) not null,
FacturaVentaFecha date,
FacturaVentaPrecioDeVenta numeric (9,2),
FacturaTotalPago numeric (9,2),
FacturaVentaCantidad nvarchar (100) not null,
FacturaVentaAdministradorCodigo nchar(8),
FacturaVentaFarmaceuticoCodigo nchar (8),
FacturaVentaMedicamentoCodigo nchar (8),
		constraint FacturaVentaPK primary key (FacturaVentaCodigo),
		constraint FacturaVentaAdministradorFK Foreign key(FacturaVentaAdministradorCodigo )
      references Resgistrofarmacias.Administrador(AdministradorCodigo),
	  	constraint FacturaVentaFarmaceuticoFK Foreign key(FacturaVentaFarmaceuticoCodigo )
      references Resgistrofarmacias.Farmaceutico(FarmaceuticoCodigo),
	  constraint FacturaVentaMedicamentoFK Foreign key(FacturaVentaMedicamentoCodigo )
      references Resgistrofarmacias.Medicamentos(MedicamentosCodigo),
)
go
*/



