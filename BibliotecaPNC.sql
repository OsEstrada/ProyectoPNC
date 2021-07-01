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
Estado bit default 1 --1 disponible, 0 prestado
);


create table Prestamo(
IdPrestamo int identity(1,1) primary key,
IdEjemplar int not null,
IdUsuario int not null,
FechaPrestamo date not null,
FechaDevolucion date,
FechaDevuelto date,
Estado bit default 1,  --Si es 1, esta activo si es 0, esta inactivo
constraint FK_PRESTAMO_EJEMPLAR	foreign key(IdEjemplar) references Ejemplar(IdEjemplar),
constraint FK_PRESTAMO_USUARIO foreign key(IdUsuario) references Usuario(IdUsuario)
);

--Insert libros
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y la piedra filosofal', N'J. K. Rowling', N'978-987-24500',N'Literatura',N'1997',1,20500,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y la c�mara secreta', N'J. K. Rowling', N'138-887-12500',N'Literatura',N'1998',2,10500,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y el prisionero de Azkaban', N'J. K. Rowling', N'278-587-24350',N'Literatura',N'1999',1,1500,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y el c�liz de fuego', N'J. K. Rowling', N'278-487-84500',N'Literatura',N'2000',1,2500,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y la Orden del F�nix', N'J. K. Rowling', N'778-287-34400',N'Literatura',N'2003',1,3500,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y el misterio del pr�ncipe', N'J. K. Rowling',N'368-687-24700',N'Literatura',N'2005',1,4300,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y las reliquias de la Muerte', N'J. K. Rowling',N'578-887-24500',N'Literatura',N'2007',2,4220,N'Fantasia')
INSERT [dbo].[Libro] ([Titulo], [Autor], [ISBN],[Materia],[AnioEdicion],[NoEdicion],[NoPaginas],[Descripcion]) VALUES (N'Harry Potter y el legado maldito', N'J. K. Rowling',N'678-987-22400',N'Literatura',N'2009',2,2320,N'Fantasia')

--Insert Ejemplar
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (1,'Tercer Planta','Bloomsbury Publishing','Ingles','Reino Unido')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (1,'Segunda Planta','Bloomsbury Publishing','Espa�ol','Espa�a')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (3,'Segunda Planta','Bloomsbury Publishing','Ingles','Reino Unido')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (4,'Tercer Planta','Bloomsbury Publishing','Ingles','Reino Unido')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (5,'Primera Planta','Bloomsbury Publishing','Ingles','Reino Unido')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (6,'Planta Baja','Bloomsbury Publishing','Ingles','Reino Unido')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (6,'Tercer Planta','Bloomsbury Publishing','Espa�ol','M�xico')
INSERT [dbo].[Ejemplar]([IdLibro], [Ubicacion],[Editorial],[Idioma],[Pais]) VALUES (8,'Primera Planta','Bloomsbury Publishing','Ingles','Reino Unido')

--Insert Rol
INSERT [dbo].[Rol]([Nombre]) VALUES ('Admin')
INSERT [dbo].[Rol]([Nombre]) VALUES ('Profesor')

--Insert Usuario
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('aspleitez','Adriana Sofia', 'Pleitez Perez','root', 1)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('cloarca','Carlos', 'Loarca','rootroot', 1)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('enxel','Enmanuel', 'Amaya','rootx4', 2)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('dasosa','Daniel', 'Sosa','hola', 2)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('evarela','Erick', 'Varela','holis', 2)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('rcanizales','Ronaldo', 'Canizales','god', 2)
INSERT [dbo].[Usuario]([Username], [Nombres], [Apellidos], [Password], [IdRol]) VALUES ('oestrada','Oscar Alejandro', 'Estrada Corena','12345', 2)


--Insert Prestamo
select * from Prestamo
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion], [estado]) VALUES (1,3,'2021-06-30 15:00:00.000','2021-07-15 15:00:00.000', 1)
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion], [estado], [FechaDevuelto]) VALUES (4,3,'2021-06-08 15:00:00.000','2021-07-03 15:00:00.000', 0, '2021-07-01 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion], [estado]) VALUES (5,2,'2021-06-06 15:00:00.000','2021-07-17 15:00:00.000', 1)
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion], [estado], [FechaDevuelto]) VALUES (6,1,'2021-06-07 15:00:00.000','2021-07-06 15:00:00.000', 0, '2021-07-01 15:00:00.000')
INSERT [dbo].[Prestamo]([IdEjemplar], [IdUsuario], [FechaPrestamo], [FechaDevolucion], [estado]) VALUES (7,2,'2021-06-09 15:00:00.000','2021-07-24 15:00:00.000', 1)

SELECT * FROM LIBRO
SELECT * FROM Ejemplar
SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Prestamo

go


create or alter trigger CreatePrestamo
on Prestamo
for INSERT
as begin
	set NOCOUNT on;
	declare @idEjemplar int;
	declare @Estado bit;
	select @idEjemplar = i.IdEjemplar, @Estado = i.Estado from inserted i
	IF @Estado = 1
	begin
		update Ejemplar set Estado = 0 where IdEjemplar = @idEjemplar
	end
end;
go


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
		update Ejemplar set Estado = 1 where IdEjemplar = @IdEjemplar;
	END
end;
go

create or alter procedure InsertarLibros
@Titulo varchar(150),
@Autor varchar(150),
@ISBN varchar(30),
@Materia varchar(80),
@AnioEdicion varchar(4),
@NoEdicion int,
@NoPaginas int,
@Descripcion varchar(200),
@Id int OUTPUT
as begin
	begin try
	insert into Libro(Titulo, Autor, ISBN, Materia, AnioEdicion, NoEdicion, NoPaginas, Descripcion)
	values (@Titulo, @Autor, @ISBN, @Materia, @AnioEdicion, @NoEdicion, @NoPaginas, @Descripcion);
	set @Id = SCOPE_IDENTITY();
	end try
	begin catch
	set @Id = -1;
	end catch
end;
go

create or alter procedure ListarLibros
as begin
	select l.IdLibro as Id, l.Titulo, l.Autor, l.ISBN, l.Materia, l.AnioEdicion, l.NoEdicion,
		l.NoPaginas, l.Descripcion
	from Libro l
	order by l.IdLibro desc;
end;
go

create or alter procedure BuscarLibro
@valor varchar(150)
as begin
	select l.IdLibro as Id, l.Titulo, l.Autor, l.ISBN, l.Materia, l.AnioEdicion, l.NoEdicion,
		l.NoPaginas, l.Descripcion
	from Libro l
	where l.Titulo like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
	order by l.IdLibro desc
end;
go

create or alter procedure BuscarLibroPorId
@valor int
as begin
	select l.IdLibro as Id, l.Titulo, l.Autor, l.ISBN, l.Materia, l.AnioEdicion, l.NoEdicion,
		l.NoPaginas, l.Descripcion
	from Libro l
	where l.IdLibro = @valor
	order by l.IdLibro desc
end;
go

create or alter procedure ListarEjemplares
@idLibro int
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado, IIF(e.Estado = 1, 'Disponible', 'Prestado') as 'EstadoLibro'
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where e.IdLibro = @idLibro
	order by e.IdEjemplar desc;
end;
go

create or alter procedure ListarTodosEjemplares
as begin
	select e.IdEjemplar as Id, l.IdLibro, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado, IIF(e.Estado = 1, 'Disponible', 'Prestado') as 'EstadoLibro'
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	order by e.IdEjemplar desc;
end;
go

create or alter procedure ListarEjemplaresDisponibles
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where e.Estado = 1
	order by e.IdEjemplar desc;
end;
go

create or alter procedure BuscarEjemplares
@valor varchar(150),
@idLibro int
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado, IIF(e.Estado = 1, 'Disponible', 'Prestado') as 'EstadoLibro'
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (l.Titulo like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
		or e.Ubicacion like '%' + @valor + '%') and e.IdLibro = @idLibro
	order by e.IdEjemplar desc;
end;
go

create or alter procedure BuscarEjemplaresSinIdLibro
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.IdLibro, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais, e.Estado, IIF(e.Estado = 1, 'Disponible', 'Prestado') as 'EstadoLibro'
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (l.Titulo like '%' + @valor + '%' or l.IdLibro like '%' + @valor + '%'
		or e.Ubicacion like '%' + @valor + '%' or e.Editorial like '%' + @valor + '%' or e.Pais like '%' + @valor + '%')
	order by e.IdEjemplar desc;
end;
go

create or alter procedure Login
@username varchar(60),
@password varchar(60)
as begin
	select TOP 1 u.*, r.Nombre 
	from Usuario u inner join Rol r on u.IdRol = r.IdRol
	where u.Username = @username and u.Password = @password
end;
go

create or alter procedure ListarProfesores
as begin
	select IdUsuario 'Id', Nombres, Apellidos
	from Usuario
	where IdRol = 2
	order by Id;
end;
go

create or alter procedure BuscarProfesor
@valor varchar(150)
as begin
	select u.IdUsuario as Id, u.Nombres as Nombres, u.Apellidos as Apellidos
	from Usuario u
	where IdRol = 2 and u.Nombres like '%' + @valor + '%' or u.Apellidos like '%' + @valor + '%'
	order by Id;
end;
go

create or alter procedure ListarPrestamos
as begin
	select p.IdEjemplar, p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Usuario', l.Titulo, e.IdEjemplar 'NumeroEjemplar',
			p.FechaPrestamo 'FechaPrestamo', p.FechaDevolucion 'FechaLimiteDevolucion'
	from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
	inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
	inner join Libro l on e.IdLibro = l.IdLibro
	where p.Estado = 1
	order by FechaPrestamo desc;
end;
go

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
go

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
go

create or alter procedure BuscarPrestamosActivosProfesor
@valor int
as begin
	select p.IdUsuario, p.IdPrestamo 'Id', u.Nombres+' '+u.Apellidos 'Profesor', l.Titulo, e.IdEjemplar 'Numero Ejemplar',
			p.FechaPrestamo 'Fecha Prestamo', p.FechaDevolucion 'Fecha Limite de Devolucion'
	from Prestamo p inner join Usuario u on p.IdUsuario = u.IdUsuario
	inner join Ejemplar e on p.IdEjemplar = e.IdEjemplar
	inner join Libro l on e.IdLibro = l.IdLibro
	where p.Estado = 1 and p.IdUsuario = @valor and u.IdRol = 2
	order by FechaPrestamo desc;
end;
go

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
go

create or alter procedure BuscarEjemplaresPorLibro
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (l.Titulo like '%' + @valor + '%')  
	order by e.IdEjemplar desc;
end;
go

create or alter procedure BuscarEjemplaresPorCodigoLibro
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (l.IdLibro like '%' + @valor + '%')  
	order by e.IdEjemplar desc;
end;
go

create or alter procedure BuscarEjemplaresPorCodigoEjemplar
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (e.IdEjemplar like '%' + @valor + '%')  
	order by e.IdEjemplar desc;
end;
go

create or alter procedure BuscarEjemplaresPorEditorial
@valor varchar(150)
as begin
	select e.IdEjemplar as Id, l.Titulo, e.Ubicacion, e.Editorial, e.Idioma, e.Pais
	from Ejemplar e inner join Libro l on e.IdLibro = l.IdLibro
	where (e.Editorial like '%' + @valor + '%')  
	order by e.IdEjemplar desc;
end;
go
