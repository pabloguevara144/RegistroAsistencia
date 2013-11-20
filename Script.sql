USE MASTER
GO
create DATABASE SARH_ASISTENCIA
GO
USE SARH_ASISTENCIA
GO
CREATE TABLE TBL_TIPOUSUARIO
(
	[tipo_id] integer,
	[nom_tipo] varchar(50)
)
GO
INSERT INTO TBL_TIPOUSUARIO VALUES(1,'ADMINISTRADOR')
INSERT INTO TBL_TIPOUSUARIO VALUES(2,'USUARIO')
GO
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
	[USU_ID] [int] NOT NULL,
	[usu_alias] [varchar](50) NULL,
	[usu_clave] [varchar](100) NULL,
	[usu_tipo] [char](1) NOT NULL,
	[usu_fecha_creacion] [datetime] NULL,
	[usu_estado] [char](1) NULL,
	[N_CODIGO_EMPLEADO] INT NULL,
Primary Key ([USU_ID])
) 
go
Alter table [TAB_USUARIO] add  foreign key([area_id]) references [TBL_AREA] ([area_id])  on update no action on delete no action 
go
Set quoted_identifier on
go
Set quoted_identifier off
go
CREATE TABLE TAB_HORARIO
(
  N_CODIGO_HORARIO  INTEGER                     NOT NULL,
  C_NOMBRE_HORARIO  VARCHAR(50),
  H_INGRESO         DATETIME,
  H_SALIDA          DATETIME,
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
create TABLE TAB_EMPLEADO
(
	N_CODIGO_EMPLEADO INTEGER NOT NULL,
	[area_id] Integer NOT NULL,
	N_CODIGO_HORARIO  INTEGER                     NOT NULL,
	APE_PATERNO  VARCHAR(100),
	APE_MATERNO  VARCHAR(100),
	DNI VARCHAR(8),
	NOMBRES  VARCHAR(100),
	FEC_NAC DATETIME,
	FECINI DATETIME,
	FECFIN DATETIME,
	TELF_CELULAR VARCHAR(50),
	SEXO CHAR(1),
	ESTADO CHAR(1)
	Primary Key (N_CODIGO_EMPLEADO)
)
go
--Insertamos Empleados
INSERT INTO TAB_EMPLEADO (N_CODIGO_EMPLEADO,[area_id],N_CODIGO_HORARIO,APE_PATERNO,APE_MATERNO,DNI,NOMBRES, 
FEC_NAC,FECINI,FECFIN,TELF_CELULAR,SEXO,ESTADO) VALUES (2301,1,1,'DEMO','DEMO MAT','12345678','MANUEL','23/08/1990',
'01/01/2013','30/12/2013','98565325','M','A');
GO
CREATE TABLE TAB_CONTRATO
(
	NOMBRES VARCHAR(200) NULL,
	DNI VARCHAR(8),
	INI_CONTRATO DATETIME,
	FIN_CONTRATO DATETIME,
	INI_VACACION DATETIME,
	FIN_VACACION DATETIME,
	N_CODIGO_EMPLEADO INTEGER
)
GO
CREATE TABLE TAB_DIAS_NO_LABORALES
(
	FECHA DATETIME,
	DESCRIPCION VARCHAR(255),
	CODIGO INTEGER
)
GO
CREATE TABLE TAB_ASISTENCIA
(
	CODIGO_ASISTENCIA INT IDENTITY(1,1) NOT NULL,
	N_CODIGO_EMPLEADO INTEGER NOT NULL,
	D_FECHA DATETIME,
	D_HORA_INGRESO DATETIME,
	D_HORA_SALIDA DATETIME,
	N_TIEMPO_TRABAJADO	INTEGER,
	N_MINUTOS_EXTRA INTEGER,
	MARCACIONES INTEGER
)
GO
CREATE TABLE TAB_MARCACION
(
	FECHA DATETIME,
	HORA DATETIME,
	N_CODIGO_EMPLEADO INTEGER NOT NULL
)
GO
INSERT INTO TAB_EMPLEADO (N_CODIGO_EMPLEADO,[area_id],N_CODIGO_HORARIO,APE_PATERNO,APE_MATERNO,DNI,NOMBRES, 
FEC_NAC,FECINI,FECFIN,TELF_CELULAR,SEXO,ESTADO) VALUES (4180,1,1,'OCHOA','OCHOA MAT','41805269','ANGEL','23/08/1990',
'01/01/2013','30/12/2013','98565325','M','A');
GO
INSERT INTO TAB_EMPLEADO (N_CODIGO_EMPLEADO,[area_id],N_CODIGO_HORARIO,APE_PATERNO,APE_MATERNO,DNI,NOMBRES, 
FEC_NAC,FECINI,FECFIN,TELF_CELULAR,SEXO,ESTADO) VALUES (4704,1,1,'GONZALES','GONZALES MAT','47041524','ANTONIO','23/08/1990',
'01/01/2013','30/12/2013','98565325','M','A');
GO
INSERT INTO TAB_EMPLEADO (N_CODIGO_EMPLEADO,[area_id],N_CODIGO_HORARIO,APE_PATERNO,APE_MATERNO,DNI,NOMBRES, 
FEC_NAC,FECINI,FECFIN,TELF_CELULAR,SEXO,ESTADO) VALUES (4562,1,1,'EDSON','EDSON MAT','45627865','EDSON','23/08/1990',
'01/01/2013','30/12/2013','98565325','M','A');
GO
INSERT INTO TAB_EMPLEADO (N_CODIGO_EMPLEADO,[area_id],N_CODIGO_HORARIO,APE_PATERNO,APE_MATERNO,DNI,NOMBRES, 
FEC_NAC,FECINI,FECFIN,TELF_CELULAR,SEXO,ESTADO) VALUES (4670,1,1,'QUEREVALU','PURIZACA ','46707555','MANUEL','23/08/1990',
'01/01/2013','30/12/2013','98565325','M','A');
GO
----------------------------------------------------------------------------------------
------------------------------------ SP ------------------------------------------------
----------------------------------------------------------------------------------------

CREATE PROC SP_REGISTRAR_ASISTENCIA
@CODIGO_EMPLEADO INT--,
--@PO_MENSAJE INT OUTPUT 
AS
BEGIN
	/*
		PO_MENSAJE ESTADOS 
		0=TODO VA OK
		1=NO EXISTE USUARIO
	*/
	--Primero Verficamos si el empleado existe
	declare @resultado int
	declare @totMarc int
	declare @fecha_actual datetime
	declare @fecha_marcacion datetime
	DECLARE @Codigo_Empleado_In int
	DECLARE @Hora_Entrada datetime
	DECLARE @HorasTrabajadas int
	DECLARE @Minutos_extra int
	declare @Horario_entrada varchar
	declare @Horario_salida varchar

	set @fecha_actual = getdate();
	set @fecha_marcacion = getdate();
	if exists (select * from TAB_EMPLEADO  where N_CODIGO_EMPLEADO = @CODIGO_EMPLEADO or DNI = @CODIGO_EMPLEADO)
	begin
		--obtenemos el codigo de empleado
		SET @Codigo_Empleado_In = ( SELECT N_CODIGO_EMPLEADO FROM TAB_EMPLEADO  
			where N_CODIGO_EMPLEADO = @CODIGO_EMPLEADO or DNI = @CODIGO_EMPLEADO
		);
		--SI EXISTE REGISTRAMOS LA MARCACION
		INSERT INTO TAB_MARCACION (FECHA,HORA,N_CODIGO_EMPLEADO) VALUES (
		@fecha_actual,@fecha_marcacion,@Codigo_Empleado_In);
		--INSERTAMOS LA ASISTENCIA 
		--AVERIGUAMOS LA CANTIDAD DE MARCACIONES QUE REALIZO AL DIA
		set @totMarc = (SELECT COUNT(*) FROM TAB_MARCACION 
		WHERE CONVERT(VARCHAR,GETDATE(),103)  = CONVERT(VARCHAR,FECHA,103)AND N_CODIGO_EMPLEADO = @Codigo_Empleado_In);		
		
		--SELECT * FROM TAB_HORARIO;
		SET @Horario_entrada = (SELECT CONVERT(VARCHAR(8),H_INGRESO,108) FROM TAB_HORARIO WHERE N_CODIGO_HORARIO=1);
		SET @Horario_salida = (SELECT CONVERT(VARCHAR(8),H_SALIDA,108) FROM TAB_HORARIO WHERE N_CODIGO_HORARIO=1);

		--SELECT CONVERT(VARCHAR,FECHA,103),CONVERT(VARCHAR,GETDATE(),103) FROM TAB_MARCACION
		--SELECT  CONVERT(DATE,CONVERT(VARCHAR,GETDATE(),103),103) AS FECHA_ACTUAL;
		--SELECT * FROM TAB_ASISTENCIA
		IF @totMarc = 1 
			BEGIN
				INSERT INTO TAB_ASISTENCIA (N_CODIGO_EMPLEADO,D_FECHA,D_HORA_INGRESO,D_HORA_SALIDA,
				N_TIEMPO_TRABAJADO,N_MINUTOS_EXTRA,MARCACIONES)VALUES (@Codigo_Empleado_In,@fecha_actual,
				@fecha_marcacion,null,0,0,@totMarc)
			END			
		ELSE
			BEGIN
				--Obtenemos la hora de entrada
				set @Hora_Entrada = (select D_HORA_INGRESO FROM TAB_ASISTENCIA 
				WHERE N_CODIGO_EMPLEADO = @Codigo_Empleado_In
				AND CONVERT(VARCHAR,GETDATE(),103)  = CONVERT(VARCHAR,D_FECHA,103));
				--obtenemos las horas trabajados
				set @HorasTrabajadas =  DATEDIFF(MI, @Hora_Entrada , @fecha_marcacion);
				--obtenemos los minutos extras
				--set @Minutos_extra 	 = DATEDIFF(MI, CAST( @Horario_salida as datetime ) , 
				--CAST( CONVERT(VARCHAR(8),@fecha_marcacion,108) as datetime ));
				
--SELECT CAST(CONVERT(VARCHAR(8),GETDATE(),108) as datetime);
--select CAST( @Hora_Entrada as datetime )
--select CAST( CONVERT(VARCHAR(8),@fecha_marcacion,108) as datetime )

				UPDATE TAB_ASISTENCIA SET 
				D_HORA_SALIDA = @fecha_marcacion,
				MARCACIONES = @totMarc,
				N_TIEMPO_TRABAJADO = @HorasTrabajadas,
				N_MINUTOS_EXTRA = @Minutos_extra
				WHERE 
				N_CODIGO_EMPLEADO = @Codigo_Empleado_In AND
				CONVERT(VARCHAR,GETDATE(),103)  = CONVERT(VARCHAR(10),D_FECHA,103);
			END
		set @resultado = 0
	end
	else
	begin
		set @resultado = 1
	end
	select @resultado
END
GO
EXEC SP_REGISTRAR_ASISTENCIA '12345678'
GO
CREATE PROC LISTAR_ASISTENCIA
AS
SELECT E.N_CODIGO_EMPLEADO, (E.APE_PATERNO + ' '  + E.APE_MATERNO  + ' ' +  E.NOMBRES) AS NOMBRES, E.DNI,
 CONVERT(VARCHAR,A.D_FECHA,103) D_FECHA,	
 CONVERT(VARCHAR(8),A.D_HORA_INGRESO,108) D_HORA_INGRESO, 
 isnull(CONVERT(VARCHAR(8),A.D_HORA_SALIDA,108),'') D_HORA_SALIDA, A.N_TIEMPO_TRABAJADO
 FROM TAB_ASISTENCIA A INNER JOIN TAB_EMPLEADO E ON A.N_CODIGO_EMPLEADO = E.N_CODIGO_EMPLEADO
 ORDER BY A.D_FECHA DESC;
GO


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



------------------------------------------------- EMPLEADO -----------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
SELECT * FROM TAB_EMPLEADO
SELECT * FROM [dbo].[TAB_HORARIO]
SELECT * FROM TBL_AREA
GO
ALTER PROC LISTAREMPLEADO
AS
SELECT N_CODIGO_EMPLEADO 'CODIGO',NOMBRES 'NOMBRES',APE_PATERNO 'APEPAT',APE_MATERNO 'APEMAT',DNI 'DNI',
CONVERT(CHAR(10),FEC_NAC,103) 'FECNAC',TELF_CELULAR 'CEL',CASE WHEN SEXO = 'M' THEN 'MASCULINO' ELSE 'FEMENINO' END 'SEXO',
CASE WHEN ESTADO = 'A' THEN 'ACTIVO' ELSE 'INACTIVO' END 'ESTADO',H.C_NOMBRE_HORARIO 'HORARIO',
nom_area 'AREA' 
FROM TAB_EMPLEADO E INNER JOIN [TAB_HORARIO] H ON E.N_CODIGO_HORARIO = H.N_CODIGO_HORARIO
INNER JOIN TBL_AREA A ON E.area_id = A.area_id
GO
CREATE PROC ELIMINAREMPLEADO
@COD_EMP INT
AS
DELETE FROM TAB_EMPLEADO WHERE N_CODIGO_EMPLEADO = @COD_EMP
GO
CREATE PROC REGISTRAREMPLEADO
@COD_EMP int, 
@ID_AREA VARCHAR(50), 
@COD_HOR VARCHAR(50), 
@APE_PAT VARCHAR(100), 
@APE_MAT VARCHAR(100), 
@NOMBRE VARCHAR(100), 
@DNI VARCHAR(8), 
@FEC_NAC VARCHAR(10), 
@TEL_CEL VARCHAR(50), 
@SEXO CHAR(1), 
@ESTADO CHAR(1)
AS
DECLARE @AR CHAR(1)
DECLARE @HOR INT
SET @AR = (SELECT TOP 1 area_id FROM TBL_AREA WHERE nom_area = @ID_AREA )
SET @HOR = (SELECT TOP 1 N_CODIGO_HORARIO FROM TAB_HORARIO WHERE C_NOMBRE_HORARIO = @COD_HOR )

IF ((SELECT COUNT(*) FROM [TAB_EMPLEADO] WHERE [N_CODIGO_EMPLEADO] = @COD_EMP) > 0)
BEGIN
	INSERT INTO [dbo].[TAB_EMPLEADO]
			   ([N_CODIGO_EMPLEADO]
			   ,[area_id]
			   ,[N_CODIGO_HORARIO]
			   ,[APE_PATERNO]
			   ,[APE_MATERNO]
			   ,[DNI]
			   ,[NOMBRES]
			   ,[FEC_NAC]
			   ,[FECINI]
			   ,[FECFIN]
			   ,[TELF_CELULAR]
			   ,[SEXO]
			   ,[ESTADO])
		 VALUES
			   (@COD_EMP
			   ,@AR
			   ,@HOR
			   ,@APE_PAT
			   ,@APE_MAT
			   ,@DNI
			   ,@NOMBRE
			   ,@FEC_NAC
			   ,GETDATE()
			   ,GETDATE()
			   ,@TEL_CEL
			   ,@SEXO
			   ,@ESTADO)
END 
ELSE 
BEGIN 
UPDATE [TAB_EMPLEADO] SET [area_id] = @AR, [N_CODIGO_HORARIO] = @HOR, [APE_PATERNO] = @APE_PAT,
[APE_MATERNO] = @APE_MAT, [DNI] = @DNI, [NOMBRES] = @NOMBRE, [FEC_NAC] = @FEC_NAC, [FECFIN] = GETDATE(),
[TELF_CELULAR] = @TEL_CEL, [SEXO] = @SEXO, [ESTADO] = @ESTADO WHERE [N_CODIGO_EMPLEADO] = @COD_EMP
END 

------------------------------------------------- USUARIO ------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
GO
INSERT INTO TAB_USUARIO VALUES(1,'ADMIN','ADMIN',1,GETDATE(),'A',2301) 
GO
CREATE PROC LISTARUSUARIO
AS
SELECT usu_alias 'ALIAS', NOM_TIPO 'TIPO',CASE WHEN usu_estado = 'A' THEN 'Activo' ELSE 'Inactivo' END 'ESTADO', 
N_CODIGO_EMPLEADO 'EMPLEADO' FROM TAB_USUARIO USU
inner join TBL_TIPOUSUARIO TIP ON USU.usu_tipo = TIP.tipo_id
go

CREATE PROC ELIMINARUSUARIO --'ADMIN'
@alias VARCHAR(50)
AS
DELETE FROM TAB_USUARIO WHERE usu_alias = @alias 
GO

CREATE PROC REGISTRARUSUARIO
@usu_alias Varchar(50),
@usu_tipo Char(50),
@usu_est char(1),
@cod_emp int
AS
DECLARE @TIP CHAR(1)
SET @TIP = (SELECT TOP 1 tipo_id FROM TBL_TIPOUSUARIO WHERE nom_tipo = @usu_tipo )

IF ((SELECT COUNT(*) FROM [TAB_USUARIO] WHERE usu_alias = @usu_alias ) = 0)
BEGIN 
INSERT INTO [dbo].[TAB_USUARIO]
           ([USU_ID]
           ,[usu_alias]
           ,[usu_tipo]
           ,[usu_fecha_creacion]
           ,[usu_estado]
		   ,[N_CODIGO_EMPLEADO])
     VALUES
           ((SELECT MAX(USU_ID) + 1 FROM [TAB_USUARIO])
           ,@usu_alias
           ,@TIP
           ,GETDATE()
           ,'A'
		   ,@cod_emp)
END 
ELSE 
BEGIN
 UPDATE [TAB_USUARIO] SET [usu_tipo] = @TIP,[usu_estado] = @usu_est where usu_alias = @usu_alias
END
GO
------------------------------------------------- AREA    ------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
SELECT * FROM [TBL_AREA]
GO
CREATE PROC LISTARAREA
AS
SELECT nom_area 'AREA',sigla_area 'SIGLA' FROM [TBL_AREA]
GO

CREATE PROC ELIMINARAREA
@NOMAREA VARCHAR(50)
AS
DELETE FROM [TBL_AREA] WHERE nom_area = @NOMAREA
GO

CREATE PROC INSERTAREA
@NOMAREA VARCHAR(50),
@SIGLA VARCHAR(5)
AS
IF ((SELECT COUNT(*) FROM [TBL_AREA] WHERE nom_area = @NOMAREA) = 0)
BEGIN 
 INSERT INTO [TBL_AREA] VALUES((SELECT MAX([area_id]) + 1 FROM [TBL_AREA]),@NOMAREA,@SIGLA)
END
ELSE
BEGIN 
 UPDATE [TBL_AREA] SET nom_area = @NOMAREA,sigla_area = @SIGLA WHERE nom_area = @NOMAREA
END
GO
------------------------------------ TIPO USUARIO    -----------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
SELECT * FROM TBL_TIPOUSUARIO
GO
CREATE PROC LISTARTIPO
AS
SELECT tipo_id 'CODIGO',nom_tipo 'NOMBRE' FROM TBL_TIPOUSUARIO
go

CREATE PROC REGISTRARTIPO
@TIPOID INT,
@NOM_TIPO VARCHAR(50)
AS
IF((SELECT COUNT(*) FROM TBL_TIPOUSUARIO WHERE tipo_id=@TIPOID) = 0)
BEGIN 
 INSERT INTO TBL_TIPOUSUARIO VALUES((SELECT MAX(tipo_id)+1 from TBL_TIPOUSUARIO),@NOM_TIPO)
END
ELSE
BEGIN
 UPDATE TBL_TIPOUSUARIO SET nom_tipo = @NOM_TIPO WHERE tipo_id = @TIPOID
END
GO

CREATE PROC ELIMINARTIPO
@TIPOID INT
AS
DELETE FROM TBL_TIPOUSUARIO WHERE tipo_id = @TIPOID
GO
