USE MASTER
GO
CREATE DATABASE SARH_ASISTENCIA
GO
USE SARH_ASISTENCIA
GO
/*
Created		10/11/2013
Modified		10/11/2013
Project		
Model			
Company		
Author		
Version			
Database		MS SQL 2005 
*/
Create table [TBL_AREA]
(
	[area_id] Integer NOT NULL,
	[nom_area] Varchar(50) NULL,
	[sigla_area] Varchar(5) NULL,
Primary Key ([area_id])
) 
GO
INSERT INTO [TBL_AREA] (area_id,nom_area,sigla_area) values (1,'Recursos Humanos','RH');
GO
Create table [TAB_USUARIO]
(
	[USU_ID] Integer NOT NULL,
	[usu_alias] Varchar(50) NULL,
	[usu_clave] Varchar(100) NULL,
	[usu_nombre] Varchar(80) NULL,
	[usu_apellido] Varchar(80) NULL,
	[usu_tipo] Char(1) NOT NULL,
	[usu_dni] Varchar(8) NULL,
	[usu_fecha_creacion] Datetime NULL,
	[usu_estado] char(1) NULL,
	[area_id] Integer NOT NULL,
Primary Key ([USU_ID])
) 
go
INSERT INTO TAB_USUARIO (usu_id, usu_alias,usu_clave,usu_nombre,usu_apellido,usu_tipo,usu_dni,usu_fecha_creacion,usu_estado, area_id) 
VALUES (1,'admin','admin','Administrador','Administrador','A','12345678','2013/10/10','A',1);  
GO
Alter table [TAB_USUARIO] add  foreign key([area_id]) references [TBL_AREA] ([area_id])  on update no action on delete no action 
go
Set quoted_identifier on
go
Set quoted_identifier off
go
SELECT * FROM TAB_USUARIO
GO
---procedimientos
CREATE PROCEDURE [dbo].[VerificarUsuario]
@Usuario varchar(50),
@Clave varchar(50)
as
begin
	declare @resultado int
	if exists (select * from TAB_USUARIO where usu_alias = @Usuario and usu_clave = @Clave)
	begin
		set @resultado = 1
	end
	else
	begin
		set @resultado = 0
	end
	
	select @resultado
end
GO
exec [VerificarUsuario] 'admin'
GO
CREATE TABLE TAB_HORARIO
(
  N_CODIGO_HORARIO  INTEGER                     NOT NULL,
  C_NOMBRE_HORARIO  VARCHAR(50),
  H_INGRESO         DATE,
  H_SALIDA          DATE,
  N_TOLERANCIA_DIA  INTEGER,
  N_TOLERANCIA_MES  INTEGER,
  N_LUNES           INTEGER,
  N_MARTES          INTEGER,
  N_MIERCOLES       INTEGER,
  N_JUEVES          INTEGER,
  N_VIERNES         INTEGER,
  N_SABADO          INTEGER,
  N_DOMINGO         INTEGER
  Primary Key ([N_CODIGO_HORARIO])
)
GO
Insert into TAB_HORARIO
   (N_CODIGO_HORARIO, C_NOMBRE_HORARIO, H_INGRESO, H_SALIDA, N_TOLERANCIA_DIA, 
    N_TOLERANCIA_MES, N_LUNES, N_MARTES, N_MIERCOLES, N_JUEVES, 
    N_VIERNES, N_SABADO, N_DOMINGO)
 Values
   (1, 'HORARIO GENERAL', '01/01/1990 08:30:00', '01/01/1990 17:00:00', 16,
    15, 1, 1, 1, 1, 
    1, 0, 0);
GO
SELECT * FROM TAB_USUARIO
GO
SELECT * FROM TAB_HORARIO