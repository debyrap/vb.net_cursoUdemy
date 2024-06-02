create procedure insertar_ususario
@nombres_y_apellidos varchar(50),
@login varchar (50),
@password varchar (50)
as
if EXISTS(select login from USUARIO2 where login = @login) 
RAISERROR('Login existente. Ingresar otro',16,1)
else 
insert into USUARIO2 VALUES (@nombres_y_apellidos, @login, @password)
