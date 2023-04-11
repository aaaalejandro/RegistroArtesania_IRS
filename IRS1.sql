use master
go
create database IRS1
go
use IRS1
go

CREATE TABLE Empleado(
    CodEmp		char(4) not null,
    nombreEmp	varchar(30) not null,
    constraint pk_Empleado primary key(CodEmp, nombreEmp)
);

CREATE TABLE Artesanias(
    codArt		char(4) not null,
    nombreArt	varchar(30) not null,
    estadoArt	varchar(10) not null,
    fechRegis	date default getdate() not null,
    descripArt	varchar(100) not null,
    precioArt	decimal(10,2) not null,
    cantidadArt	int not null,
    estadoPuro	char(1) default '1' not null,
    CodEmp		char(4) not null,
	nombreEmp	varchar(30) not null,
    constraint pk_Artesania primary key(codArt),
    constraint fk_Empleado foreign key(CodEmp, nombreEmp) references Empleado(CodEmp, nombreEmp)
);

Insert Into Empleado(CodEmp, nombreEmp) Values ('E001', 'Matias Criollo');
Insert Into Empleado(CodEmp, nombreEmp) Values ('E002', 'Kevin Barrutia');
Insert Into Empleado(CodEmp, nombreEmp) Values ('E003', 'Roger Avalos');
Insert Into Empleado(CodEmp, nombreEmp) Values ('E004', 'Alejandro Diaz');

-- Crear Procedures
go
Create procedure sp_ListaArtesania
as
Select codArt,nombreArt,estadoArt,fechRegis,descripArt,precioArt,cantidadArt,CodEmp,nombreEmp
From Artesanias
where estadoPuro = 1
Order by nombreArt asc 

GO
Create procedure sp_IngresaArtesania
	@codArt			char(4) output, --salida  --A001  A002
	@nombreArt		varchar(30),
	@estadoArt		varchar(10),
	@fechRegis		date,
	@descripArt		varchar(100),
	@precioArt		decimal(10,2),
	@cantidadArt	int,
	@CodEmp			char(4),
	@nombreEmp		varchar(30)
As
begin
declare @num int
if (select max(convert(int,substring(codArt,2,3))) from Artesanias ) is not null
	begin
	select @num=max(convert(int,substring(codArt,2,3))) from Artesanias 
	select @codArt	='A'+replicate('0',3-dataLENGTH(convert(varchar,@num+1)))+convert(varchar,@num+1)
	end
else  --coloca la primera persona
	select @codArt='A001'
Insert Into Artesanias(codArt,nombreArt,estadoArt,fechRegis,descripArt,precioArt,cantidadArt,CodEmp,nombreEmp)
Values(@codArt,@nombreArt,@estadoArt,@fechRegis,@descripArt,@precioArt,@cantidadArt,@CodEmp,@nombreEmp)
end

go
Create procedure sp_EliminaArtesania
	@codArt		char(4)
As
update Artesanias set estadoPuro='0'
Where codArt = @codArt

Select * From Artesanias

--drop procedure sp_ListaArtesania
--drop procedure sp_IngresaArtesania
--drop procedure sp_EliminaArtesania

