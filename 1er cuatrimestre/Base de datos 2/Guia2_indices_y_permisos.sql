

--Tabla categoría
create table categoria(
       idcategoria integer primary key identity,
       nombre varchar(50) not null unique,
       descripcion varchar(256) null,
       estado bit default(1)
);
insert into categoria (nombre,descripcion) values ('Cereales','');
select * from categoria;

--Tabla artículo
create table articulo(
       idarticulo integer primary key identity,
       idcategoria integer not null,
       codigo varchar(50) null,
       nombre varchar(100) not null unique,
       precio_venta decimal(11,2) not null,
       stock integer not null,
       descripcion varchar(256) null,
       estado bit default(1),
       FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);

--Tabla persona
create table persona(
       idpersona integer primary key identity,
       tipo_persona varchar(20) not null,
       nombre varchar(100) not null,
       tipo_documento varchar(20) null,
       num_documento varchar(20) null,
       direccion varchar(70) null,
       telefono varchar(20) null,
       email varchar(50) null
);



--Tabla rol
create table rol(
       idrol integer primary key identity,
       nombre varchar(30) not null,
       descripcion varchar(100) null,
       estado bit default(1)
);

--Tabla usuario
create table usuario(
       idusuario integer primary key identity,
       idrol integer not null,
       nombre varchar(100) not null,
       tipo_documento varchar(20) null,
       num_documento varchar(20) null,
       direccion varchar(70) null,
       telefono varchar(20) null,
       email varchar(50) not null,
       password varbinary not null,
       estado bit default(1),
       FOREIGN KEY (idrol) REFERENCES rol (idrol)
);

--Tabla ingreso
create table ingreso(
       idingreso integer primary key identity,
       idproveedor integer not null,
       idusuario integer not null,
       tipo_comprobante varchar(20) not null,
       serie_comprobante varchar(7) null,
       num_comprobante varchar (10) not null,
       fecha datetime not null,
       impuesto decimal (4,2) not null,
       total decimal (11,2) not null,
       estado varchar(20) not null,
       FOREIGN KEY (idproveedor) REFERENCES persona (idpersona),
       FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);

--Tabla detalle_ingreso
create table detalle_ingreso(
       iddetalle_ingreso integer primary key identity,
       idingreso integer not null,
       idarticulo integer not null,
       cantidad integer not null,
       precio decimal(11,2) not null,
       FOREIGN KEY (idingreso) REFERENCES ingreso (idingreso) ON DELETE CASCADE,
       FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);


--Tabla venta
create table venta(
       idventa integer primary key identity,
       idcliente integer not null,
       idusuario integer not null,
       tipo_comprobante varchar(20) not null,
       serie_comprobante varchar(7) null,
       num_comprobante varchar (10) not null,
       fecha_hora datetime not null,
       impuesto decimal (4,2) not null,
       total decimal (11,2) not null,
       estado varchar(20) not null,
       FOREIGN KEY (idcliente) REFERENCES persona (idpersona),
       FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);

--Tabla detalle_venta
create table detalle_venta(
       iddetalle_venta integer primary key identity,
       idventa integer not null,
       idarticulo integer not null,
       cantidad integer not null,
       precio decimal(11,2) not null,
       descuento decimal(11,2) not null,
       FOREIGN KEY (idventa) REFERENCES venta (idventa) ON DELETE CASCADE,
       FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);

/*
EJERCICIOS GUIA2

1. Crear un índice no agrupado para la tabla articulo sobre el campo nombre.
2. Eliminar el índice creado en el punto anterior.
3. Crear un índice que optimice la búsqueda y ordenamiento de la tabla detalle_venta,
   si la consulta que se quisiera optimizar es por cantidad.
4. Crear un nuevo índice agrupado sobre la tabla usuario sobre los campos nombre y email.     
⚠️ Solo puede haber un índice agrupado por tabla. Asegúrate de que la tabla usuario no tenga ya uno creado si estás haciendo esto.
5. Crear un índice que optimice la búsqueda por fecha y hora de la tabla venta (índice compuesto), teniendo en cuenta que
se realizan inserciones frecuentes (usar FILLFACTOR).
6. Conceder permiso de INSERT y UPDATE sobre la tabla articulo a los usuarios jPerez y aFernandez.
7. Eliminar los permisos de UPDATE sobre la tabla articulo para todos los usuarios.
8. Conceder permisos de CREATE TABLE al usuario jPerez.
9. Revocar los permisos de SELECT para el usuario public sobre la tabla persona.
10. Eliminar el índice sobre nombre y email en la tabla usuario.
11. Crear un índice único que impida ingresar dos usuarios con igual nombre y email.
12. Conceder al grupo CORDOBA permiso de SELECT para la tabla detalle_venta.
13. El usuario jPerez (parte del grupo CORDOBA) no debe poder ver el campo precio de la tabla detalle_venta, pero sí el resto.
¿Cómo se le deniega el permiso?
14. Conceder al grupo ADM todos los permisos aplicables sobre la base ComprasVentas.
15. Denegar al usuario aFernandez (miembro del grupo ADM) el permiso para realizar backups sobre la base y sobre el log de transacciones.
*/

/*1. Crear un índice no agrupado para la tabla articulo sobre el campo nombre.*/
CREATE NONCLUSTERED INDEX indx_nombre ON articulo(nombre);

/*2. Eliminar el índice creado en el punto anterior.*/
DROP INDEX articulo.indx_nombre;

/*3. Crear un índice que optimice la búsqueda y ordenamiento de la tabla detalle_venta,
   si la consulta que se quisiera optimizar es por cantidad.*/
CREATE INDEX indx_cantidad 
ON detalle_venta(cantidad)
WITH (FILLFACTOR = 90);

/*4. Crear un nuevo índice agrupado sobre la tabla usuario sobre los campos nombre y email.     
⚠️ Solo puede haber un índice agrupado por tabla. Asegúrate de que la tabla usuario no tenga ya uno creado si estás haciendo esto.*/
CREATE CLUSTERED INDEX indx_nombre_email ON usuario(nombre, email);
-- Error la PK de la tabla usuario cuenta como que esta ya tiene un indice clasterizado

/*5. Crear un índice que optimice la búsqueda por fecha y hora de la tabla venta (índice compuesto), teniendo en cuenta que
se realizan inserciones frecuentes (usar FILLFACTOR).*/
CREATE INDEX  indx_fecha_hora 
ON venta(fecha_hora)
WITH (FILLFACTOR = 70);

/*6. Conceder permiso de INSERT y UPDATE sobre la tabla articulo a los usuarios jPerez y aFernandez.*/
-- Crear logins
CREATE LOGIN jPerez WITH PASSWORD = '1';
CREATE LOGIN aFernandez WITH PASSWORD = '2';
GO

-- Crear los usuarios y asignarle los logins creados
CREATE USER jPerez FOR LOGIN jPerez;
CREATE USER aFernandez FOR LOGIN aFernandez;
GO

-- Conceder los permisos a los usuarios creados
GRANT INSERT, UPDATE
ON articulo
TO jPerez, aFernandez;

/*7. Eliminar los permisos de UPDATE sobre la tabla articulo para todos los usuarios.*/
REVOKE UPDATE
ON articulo 
FROM public;

/*8. Conceder permisos de CREATE TABLE al usuario jPerez.*/
GRANT CREATE TABLE 
TO jPerez;

/*9. Revocar los permisos de SELECT para el usuario public sobre la tabla persona.*/
REVOKE SELECT 
ON persona
TO public;

/*10. Eliminar el índice sobre nombre y email en la tabla usuario.*/
DROP INDEX indx_nombre_email;

/*11. Crear un índice único que impida ingresar dos usuarios con igual nombre y email.*/
CREATE UNIQUE INDEX indx_nombre_email_unique
ON usuario (nombre, email);

/*12. Conceder al grupo CORDOBA permiso de SELECT para la tabla detalle_venta.*/
--NOTA: Voy a suponer que con "grupo" se refiere a los "roles".
--Crear grupo CORDOBA
CREATE ROLE CORDOBA;

--Asignar permiso
GRANT SELECT
ON detalle_venta
TO CORDOBA;

/*13. El usuario jPerez (parte del grupo CORDOBA) no debe poder ver el campo precio de la tabla detalle_venta, pero sí el resto.
¿Cómo se le deniega el permiso?*/
--Agregar al usuario jPerez al rol CORDOBA.
ALTER ROLE CORDOBA ADD MEMBER jPerez;

--Denegar permiso
DENY SELECT (precio)
ON detalle_venta
TO jPerez;

/*14. Conceder al grupo ADM todos los permisos aplicables sobre la base ComprasVentas.*/
CREATE DATABASE ComprasVentas;
USE ComprasVentas;
CREATE ROLE ADM;
GRANT ALL ON DATABASE::ComprasVentas TO ADM;

/*15. Denegar al usuario aFernandez (miembro del grupo ADM) el permiso para realizar backups
sobre la base y sobre el log de transacciones.*/
USE Guia2;
ALTER ROLE ADM ADD MEMBER aFernandez;
DENY BACKUP DATABASE, BACKUP LOG TO aFernandez;