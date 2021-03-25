CREATE DATABASE Visita
On Primary
(Name = Visitadatos, 
Filename = 'C:\sqlserver\Visita\Visita.MDF',
Size = 5MB,
MaxSize = 10MB,
Filegrowth = 20%)
Log on
(Name = SIESLog,
Filename = 'C:\sqlserver\Visita\VisitaLog.ldf',
size = 5MB,
Maxsize = 10MB,
Filegrowth = 1MB)



use Visita;


create table es_usuarios(
	USU_id int identity(1,1) primary key,
	USU_nombre varchar(50),
	USU_email varchar(50),	
	USU_fecharegistro date null,
	USU_ciudad varchar(50)	
); 

insert into es_usuarios (
	USU_nombre,
	USU_email,	
	USU_fecharegistro,
	USU_ciudad 	
) values 

	('Carlos', 'calape2@misena.edu.co', GETDATE(), 'Manizales')
;

select * from es_usuarios;

delete from es_usuarios
	--where USU_id = 3;


alter table es_usuarios alter column USU_celular varchar(20) 

SELECT 
*
FROM 
es_usuarios
WHERE USU_fecharegistro > '13-01-2021'
