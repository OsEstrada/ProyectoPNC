create database Biblioteca;
use Biblioteca;
drop database Biblioteca;

create table Rol(
IdRol int identity(0,1) primary key,
Nombre varchar(30),
Estado bit default 1
);

create table Usuario(
IdUsuario int identity(0,1) primary key,
Username varchar(30) unique,
Nombres varchar(60),
Apellidos varchar(60),
Password varchar(30),
IdRol int foreign key references Rol(idRol)
);

create table Libro(
IdLibro int identity(0,1) primary key,
Nombre varchar(150),
Autor varchar(60),
ISBN varchar(30) --Considero el quitarlo
);

create table Ejemplar(
IdEjemplar int identity(0,1) primary key,
IdLibro int foreign key references Libro(IdLibro),
Ubicacion varchar(100),
Estado varchar(30) not null CHECK (Estado in('Disponible', 'Prestado', 'En Reparacion')) default 'Disponible',
);

create table Prestamo(
IdPrestamo int identity(0,1) primary key,
IdEjemplar int not null,
IdUsuario int not null,
FechaPrestamo date not null,
FechaDevolucion date,
Estado bit default 1,  --Si es 1, esta activo si es 0, esta inactivo
constraint FK_PRESTAMO_EJEMPLAR	foreign key(IdEjemplar) references Ejemplar(IdEjemplar),
constraint FK_PRESTAMO_USUARIO foreign key(IdUsuario) references Usuario(IdUsuario)
);

--Insert libros
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'La niña de oro', N'Austin Garrett', N'978-987-24500')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'El libro de los gnomos, los gigantes y los duendes', N'Cedric Rosales', N'978-987-24500')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Historia de Malik y Luna Llena', N'Cedric Rosales', N'978-987-24500')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'El cascanueces y el rey de los ratones', N'Hanae Fuller', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Cuentos + cuentos', N'Cedric Rosales', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Sección policiales', N'Athena Daniels', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Callejón sin salida', N'Hanna Lamb', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'El Gigante Amapolas + El matadero', N'Ava Cohen', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Prometeo encadenado + Una libra de carne', N'Jacob Walsh', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Los libros sagrados - Mitología griega', N'Aurelia Maynard', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Los relatos del tiempo', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'El centroforward murió al amanecer', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Siete fantásticos latinoamericanos', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Del terror al horror', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Las aventuras de Gilgamesh', N'Anonimo', N'978-987-24143')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Las Mil y una noches', N'Hanae Fuller', N'978-987-24143')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Cuentos policiales para chicos curiosos', N'Austin Garrett', N'978-987-24143')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Cuentos populares de pícaros y necios', N'Anonimo', N'978-987-24143')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'Antiguas leyendas de héroes y princesas', N'Jacob Walsh', N'978-987-24143')
INSERT [dbo].[Libro] ([Nombre], [Autor], [ISBN]) VALUES (N'La isla misteriosa', N'Hanna Lamb', N'978-987-24500')

go;

create or alter trigger UpdateAfterDevolucion
on Prestamo
for UPDATE
as begin
	set NOCOUNT on;
	declare @IdEjemplar int;
	declare @Estado bit;
	select @IdEjemplar = d.IdEjemplar,  @Estado = i.Estado from inserted i, deleted d;

	update Ejemplar set Estado = 'Disponible' where IdEjemplar = @IdEjemplar and @Estado = 'Disponible';
end;
go;

create or alter procedure ListarLibros
as begin
	select l.IdLibro as Id, l.Nombre, l.Autor, l.ISBN
	from Libro l
	order by l.IdLibro desc;
end;
go;

create or alter procedure BuscarLibro
@valor varchar(150)
as begin
	select l.IdLibro as Id, l.Nombre, l.Autor, l.ISBN
	from Libro l
	where l.Nombre like '%' + @valor + '%' or l.Autor like '%' + @valor + '%'
			or l.ISBN like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
	order by l.IdLibro desc
end;
go;

create or alter procedure ListarEjemplares
as begin
	select e.IdEjemplar as Id, l.Nombre, e.Ubicacion, e.Estado
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	order by l.IdLibro desc;
end;
go;

create or alter procedure BuscarEjemplares
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.Nombre, e.Ubicacion, e.Estado
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where l.Nombre like '%' + @valor + '%' or l.ISBN like '%' + @valor + '%'
		or e.IdEjemplar like '%' + @valor + '%' or e.Ubicacion like '%' + @valor + '%'
		or e.Estado like '%' + @valor + '%'
	order by l.IdLibro desc;
end;
go;

create or alter procedure Login
@username varchar(60),
@password varchar(60)
as begin
	select TOP 1 u.*, r.Nombre 
	from Usuario u inner join Rol r on u.IdRol = r.IdRol
	where u.Username = @username and u.Password = @password
end;
go;

create or alter procedure ListarPrestamos
as begin
	select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Nombre, e.IdEjemplar 'Numero Ejemplar',
			p.FechaPrestamo 'Fecha Prestamo'
	from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
	inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
	inner join Libro l on e.IdLibro = l.IdLibro
	where p.Estado = 1
	order by FechaPrestamo desc;
end;
go;

create or alter procedure ListarDevoluciones
as begin
	select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Nombre, e.IdEjemplar 'Numero Ejemplar',
			p.FechaDevolucion 'Fecha Devolucion'
	from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
	inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
	inner join Libro l on e.IdLibro = l.IdLibro
	where p.Estado = 0
	order by FechaPrestamo desc;
end;
go;

create or alter procedure BuscarPrestamos
@valor varchar(150)
as begin
		select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Nombre, e.IdEjemplar 'Numero Ejemplar',
			   p.FechaPrestamo 'Fecha Prestamo'
		from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
		inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
		inner join Libro l on e.IdLibro = l.IdLibro
		where (p.IdPrestamo like '%'+@valor+'%' or u.Nombres like '%'+@valor+'%' or u.Apellidos like '%'+@valor+'%'
			   or l.Nombre like '%'+@valor+'%' or e.IdEjemplar like '%'+@valor+'%') and p.Estado = 1
		order by FechaPrestamo desc;

end;
go;

create or alter procedure BuscarDevoluciones
@valor varchar(150)
as begin
		select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Nombre, e.IdEjemplar 'Numero Ejemplar',
			   p.FechaDevolucion 'Fecha Devolucion'
		from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
		inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
		inner join Libro l on e.IdLibro = l.IdLibro
		where (p.IdPrestamo like '%'+@valor+'%' or u.Nombres like '%'+@valor+'%' or u.Apellidos like '%'+@valor+'%'
			   or l.Nombre like '%'+@valor+'%' or e.IdEjemplar like '%'+@valor+'%') and p.Estado = 0
		order by FechaPrestamo desc;
end;
go;

