create database Biblioteca;
use Biblioteca;
drop database Biblioteca;

create table Rol(
IdRol int identity(1,1) primary key,
Nombre varchar(30),
Estado bit default 1
);

create table Usuario(
IdUsuario int identity(1,1) primary key,
Username varchar(30) unique,
Nombres varchar(60),
Apellidos varchar(60),
Password varchar(30),
IdRol int foreign key references Rol(idRol)
);

create table Libro(
IdLibro int identity(1,1) primary key,
Titulo varchar(150),
Autor varchar(150),
ISBN varchar(30),
Materia varchar(80),
AnioEdicion varchar(4),
NoEdicion int,
NoPaginas int,
Descripcion varchar(200)
);

create table Ejemplar(
IdEjemplar int identity(1,1) primary key,
IdLibro int foreign key references Libro(IdLibro),
Ubicacion varchar(100),
Editorial varchar(150),
Idioma varchar(80),
Pais varchar(80),
Estado varchar(30) not null CHECK (Estado in('Disponible', 'Prestado', 'En Reparacion')) default 'Disponible',
);

create table Prestamo(
IdPrestamo int identity(1,1) primary key,
IdEjemplar int not null,
IdUsuario int not null,
FechaPrestamo date not null,
FechaDevolucion date,
Estado bit default 1,  --Si es 1, esta activo si es 0, esta inactivo
constraint FK_PRESTAMO_EJEMPLAR	foreign key(IdEjemplar) references Ejemplar(IdEjemplar),
constraint FK_PRESTAMO_USUARIO foreign key(IdUsuario) references Usuario(IdUsuario)
);

--Insert libros
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'La niña de oro', N'Austin Garrett', N'978-987-24500')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'El libro de los gnomos, los gigantes y los duendes', N'Cedric Rosales', N'978-987-24500')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Historia de Malik y Luna Llena', N'Cedric Rosales', N'978-987-24500')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'El cascanueces y el rey de los ratones', N'Hanae Fuller', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Cuentos + cuentos', N'Cedric Rosales', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Sección policiales', N'Athena Daniels', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Callejón sin salida', N'Hanna Lamb', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'El Gigante Amapolas + El matadero', N'Ava Cohen', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Prometeo encadenado + Una libra de carne', N'Jacob Walsh', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Los libros sagrados - Mitología griega', N'Aurelia Maynard', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Los relatos del tiempo', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'El centroforward murió al amanecer', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Siete fantásticos latinoamericanos', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Del terror al horror', N'Anonimo', N'978-987-1565-')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Las aventuras de Gilgamesh', N'Anonimo', N'978-987-24143')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Las Mil y una noches', N'Hanae Fuller', N'978-987-24143')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Cuentos policiales para chicos curiosos', N'Austin Garrett', N'978-987-24143')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Cuentos populares de pícaros y necios', N'Anonimo', N'978-987-24143')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'Antiguas leyendas de héroes y princesas', N'Jacob Walsh', N'978-987-24143')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN]) VALUES (N'La isla misteriosa', N'Hanna Lamb', N'978-987-24500')

--Insert Ejemplar

INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (1,'Planta Baja')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (2,'Primera Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (3,'Primera Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (4,'Tercer Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (5,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (6,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (7,'Tercer Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (8,'Primera Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (9,'Planta Baja')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (10,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (11,'Tercer Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (12,'Tercer Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (13,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (14,'Primera Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (15,'Primera Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (16,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (17,'Planta Baja')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (18,'Segunda Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (19,'Tercer Planta')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion]) VALUES (20,'Tercer Planta')

--Insert Rol
INSERT [dbo].[Rol]([Nombre]) VALUES ('Admin')
INSERT [dbo].[Rol]([Nombre]) VALUES ('Profesor')

--Insert Usuario
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('aspleitez','Adriana Sofia', 'Pleitez Perez','root', 1)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('cloarca','Carlos', 'Loarca','rootroot', 1)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('nexxtor','Nestor', 'Aldana','rootx3', 2)

--Insert Prestamo

INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion]) VALUES (2,3,'2021-06-06 15:00:00.000','2021-06-15 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo]) VALUES (19,3,'2021-06-08 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion]) VALUES (7,2,'2021-06-06 15:00:00.000','2021-06-17 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo]) VALUES (10,1,'2021-06-07 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion]) VALUES (14,2,'2021-06-09 15:00:00.000','2021-06-24 15:00:00.000')



SELECT * FROM LIBRO
SELECT * FROM Ejemplar
SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Prestamo

go;

create or alter trigger UpdateAfterDevolucion
on Prestamo
for UPDATE
as begin
	set NOCOUNT on;
	declare @IdEjemplar int;
	declare @Estado bit;
	select @IdEjemplar = d.IdEjemplar,  @Estado = i.Estado from inserted i, deleted d;

	IF @Estado = 0
	BEGIN
		update Ejemplar set Estado = 'Disponible' where IdEjemplar = @IdEjemplar;
	END
end;
go;
create or alter procedure ListarLibros
as begin
    select l.IdLibro as Id, l.Titulo, l.Autor, l.ISBN, l.Materia, l.AnioEdicion, l.NoEdicion,
        l.NoPaginas, l.Descripcion
    from Libro l
    order by l.IdLibro desc;
end;
go;

create or alter procedure BuscarLibro
@valor varchar(150)
as begin
    select l.IdLibro as Id, l.Titulo, l.Autor, l.ISBN, l.Materia, l.AnioEdicion, l.NoEdicion,
        l.NoPaginas, l.Descripcion
    from Libro l
    where l.Titulo like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
    order by l.IdLibro desc
end;
go;

create or alter procedure ListarEjemplares
as begin
    select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado
    from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
    order by l.IdLibro desc;
end;
go;

create or alter procedure BuscarEjemplares
@valor varchar(150)
as begin
    select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado
    from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
    where l.Titulo like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
        or e.Ubicacion like '%' + @valor + '%' or e.Estado like '%' + @valor + '%'
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
	select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Titulo, e.IdEjemplar 'Numero Ejemplar',
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
	select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Titulo, e.IdEjemplar 'Numero Ejemplar',
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
		select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Titulo, e.IdEjemplar 'Numero Ejemplar',
			   p.FechaPrestamo 'Fecha Prestamo'
		from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
		inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
		inner join Libro l on e.IdLibro = l.IdLibro
		where (p.IdPrestamo like '%'+@valor+'%' or u.Nombres like '%'+@valor+'%' or u.Apellidos like '%'+@valor+'%'
			   or l.Titulo like '%'+@valor+'%' or e.IdEjemplar like '%'+@valor+'%') and p.Estado = 1
		order by FechaPrestamo desc;

end;
go;

create or alter procedure BuscarDevoluciones
@valor varchar(150)
as begin
		select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Titulo, e.IdEjemplar 'Numero Ejemplar',
			   p.FechaDevolucion 'Fecha Devolucion'
		from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
		inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
		inner join Libro l on e.IdLibro = l.IdLibro
		where (p.IdPrestamo like '%'+@valor+'%' or u.Nombres like '%'+@valor+'%' or u.Apellidos like '%'+@valor+'%'
			   or l.Titulo like '%'+@valor+'%' or e.IdEjemplar like '%'+@valor+'%') and p.Estado = 0
		order by FechaPrestamo desc;
end;
go;


