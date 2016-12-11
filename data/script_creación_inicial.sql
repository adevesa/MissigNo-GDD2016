USE GD2C2016
GO



--  ELIMINACION DE TABLAS
/*

DROP PROCEDURE PR_CREAR_FAMILIAR

if object_id('MISSINGNO.Administrativo') is not null
drop table MISSINGNO.Administrativo;

if object_id('MISSINGNO.Consulta_medica') is not null
drop table MISSINGNO.Consulta_medica;

if object_id('MISSINGNO.Afiliado_Historial') is not null
drop table MISSINGNO.Afiliado_Historial;

if object_id('MISSINGNO.Cancelacion_turno') is not null
drop table MISSINGNO.Cancelacion_turno;

if object_id('MISSINGNO.Dia') is not null
drop table MISSINGNO.Dia;

if object_id('MISSINGNO.Turno') is not null
drop table MISSINGNO.Turno;

if object_id('MISSINGNO.Rol_de_usuario') is not null
drop table MISSINGNO.Rol_de_usuario;

if object_id('MISSINGNO.Funcionalidad_de_rol') is not null
drop table MISSINGNO.Funcionalidad_de_rol;

if object_id('MISSINGNO.Rol') is not null
drop table MISSINGNO.Rol;

if object_id('MISSINGNO.Funcionalidad') is not null
drop table MISSINGNO.Funcionalidad;

if object_id('MISSINGNO.Bono') is not null
drop table MISSINGNO.Bono;

if object_id('MISSINGNO.Compra_bono') is not null
drop table MISSINGNO.Compra_bono;

if object_id('MISSINGNO.Agenda') is not null
drop table MISSINGNO.Agenda;

if object_id('MISSINGNO.Afiliado') is not null
drop table MISSINGNO.Afiliado;

if object_id('MISSINGNO.Planes') is not null
drop table MISSINGNO.Planes;

if object_id('MISSINGNO.Especialidad_de_profesional') is not null
drop table MISSINGNO.Especialidad_de_profesional;

if object_id('MISSINGNO.Especialidad') is not null
drop table MISSINGNO.Especialidad;

if object_id('MISSINGNO.Tipo_especialidad') is not null
drop table MISSINGNO.Tipo_especialidad;

if object_id('MISSINGNO.Profesional') is not null
drop table MISSINGNO.Profesional;

if object_id('MISSINGNO.Usuario') is not null
drop table MISSINGNO.Usuario;

DROP SCHEMA [MISSINGNO]
GO
*/
CREATE SCHEMA [MISSINGNO]
GO
-- CREACION DE TABLAS

	-- TABLA FUNCIONALIDAD

	create table MISSINGNO.Funcionalidad(
		funcionalidad_id int primary key identity,
		funcionalidad_nombre varchar(50) not null)

	-- TABLA ROL

	create table MISSINGNO.Rol(
		rol_id int primary key identity,
		rol_nombre varchar(20) not null,
		rol_habilitado bit not null)

	-- TABLA USUARIO

	create table MISSINGNO.Usuario (
		username varchar(60) primary key,
		doc_tipo varchar(10),
		doc_nro bigint,
		contrasenia nvarchar(30),
		nombre varchar(60),
		apellido varchar(60),
		fec_nac datetime, 
		sexo char,
		domicilio varchar(150),
		mail varchar(60),
		telefono bigint,
		unique (doc_nro))

	-- TABLA ROL_DE_USUARIO

	create table MISSINGNO.Rol_de_usuario(
		rol_id int not null,
		username varchar(60) not null,
		primary key (rol_id,username))

	-- TABLA FUNCIONALIDAD_DE_ROL

	create table MISSINGNO.Funcionalidad_de_rol(
		rol_id int,
		funcionalidad_id int)

	-- TABLA AGENDA

	create table MISSINGNO.Agenda(
		agenda_id int primary key identity,
		prof_esp_id int not null,
		agenda_inicio datetime,
		agenda_fin datetime)

	-- TABLA ESPECIALIDAD

	create table MISSINGNO.Especialidad(
		especialidad_id int primary key identity,
		tipo_especialidad_id int not null,
		especialidad_descripcion varchar (50))

	-- TABLA TIPO_ESPECIALIDAD

	create table MISSINGNO.Tipo_especialidad(
		tipo_especialidad_id int primary key identity,
		tipo_especialidad_desc varchar (50))

	-- TABLA PROFESIONAL

	create table MISSINGNO.Profesional(
		profesional_id int primary key identity,
		username varchar(60) not null,
		profesional_matricula int )

	-- TABLA ESPECIALIDAD_DE_PROFESIONAL

	create table MISSINGNO.Especialidad_de_profesional(
		prof_esp_id int primary key identity,
		especialidad_id int not null,
		profesional_id int not null)

	-- TABLA TURNO

	create table MISSINGNO.Turno(
		turno_id int primary key identity,
		profesional_id int not null,
		afiliado_id int not null,
		fecha datetime not null,
		horario time not null,
		en_uso bit not null)

	-- TABLA DIA

	create table MISSINGNO.Dia(
		dia_id int primary key identity,
		agenda_id int,
		horario_desde time,
		horario_hasta time,
		desc_dia varchar(10))

	-- TABLA AFILIADO

	create table MISSINGNO.Afiliado(
		afiliado_id int primary key identity,
		username varchar(60) not null,
		plan_id int not null,
		afiliado_encargado int,
		afiliado_fec_baja datetime,
		afiliado_estado_civil varchar(15),
		afiliado_baja_logica bit)

	-- TABLA AFILIADO_HISTORIAL

	create table MISSINGNO.Afiliado_historial(
		afiliado_hist_id int primary key identity,
		afiliado_id int,
		motivo varchar(140),
		fecha_modif datetime)

	-- TABLA BONO

	create table MISSINGNO.Bono(
		bono_id int primary key identity,
		plan_id int not null,
		afiliado_id int not null,
		compra_bono_id int not null,
		bono_estado bit not null,
		bono_precio decimal(8,2) not null)

	-- TABLA COMPRA_BONOS

	create table MISSINGNO.Compra_bono(
		compra_bono_id int primary key identity,
		afiliado_id int not null,
		plan_id int not null,
		fecha_compra datetime not null)

	-- TABLA PLANES

	create table MISSINGNO.Planes(
		plan_id int primary key identity,
		plan_descripcion varchar(30),
		bono_precio_farmacia decimal(8,2) not null,
		bono_precio_consulta decimal(8,2) not null)

	-- TABLA CONSULTA_MEDICA

	create table MISSINGNO.Consulta_medica(
		consulta_id int primary key identity,
		agenda_id int,
		bono_id int,
		turno_id int,
		profesional_id int,
		confirmacion_de_atencion char(2),
		diagnostico varchar(140),
		consulta_horario time,
		sintoma varchar(140))


	-- TABLA CANCELACION_TURNO

	create table MISSINGNO.Cancelacion_turno(
		cancelacion_id int primary key identity,
		turno_id int not null,
		cancelacion_motivo varchar(140),
		cancelacion_tipo varchar(20),
		cancelacion_fecha datetime)

	-- TABLA ADMINISTRATIVO
	
	create table MISSINGNO.Administrativo(
		admin_id int primary key identity,
		username varchar(60) not null)
	
set dateformat dmy;
GO

--DECLARACION DE CONSTRAINTS

	-- TABLA PROFESIONAL (FALTA QUE FUNCIONE FK ROL_ID)

alter table MISSINGNO.Profesional
	add constraint FK_Profesional_username foreign key (username) references MISSINGNO.Usuario(username);

	-- TABLA BONO

alter table MISSINGNO.Bono
	add constraint FK_Bono_plan_id foreign key (plan_id) references MISSINGNO.Planes(plan_id);
alter table MISSINGNO.Bono
	add constraint FK_Bono_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Bono
	add constraint FK_Bono_compra_bono_id foreign key (compra_bono_id) references MISSINGNO.Compra_bono(compra_bono_id);

	-- TABLA COMPRA_BONO

alter table MISSINGNO.Compra_bono
	add constraint FK_Compra_bono_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Compra_bono
	add constraint FK_Compra_bono_plan_id foreign key (plan_id) references MISSINGNO.Planes(plan_id);

	-- TABLA AFILIADO 

alter table MISSINGNO.Afiliado	
	add constraint FK_Afiliado_plan_id foreign key (plan_id) references MISSINGNO.Planes(plan_id);
alter table MISSINGNO.Afiliado 
	add constraint FK_Afiliado_username foreign key (username) references MISSINGNO.Usuario(username);
alter table MISSINGNO.Afiliado
	add constraint FK_Afiliado_afiliado_encargado foreign key (afiliado_encargado) references MISSINGNO.Afiliado(afiliado_id);


	-- TABLA CONSULTA_MEDICA

alter table MISSINGNO.Consulta_medica
	add constraint FK_Consulta_medica_agenda_id foreign key (agenda_id) references MISSINGNO.Agenda(agenda_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_turno_id foreign key (turno_id) references MISSINGNO.Turno(turno_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_bono_id foreign key (bono_id) references MISSINGNO.BONO(bono_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_profesibonal_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);

	-- TABLA CANCELACION_TURNO

alter table MISSINGNO.Cancelacion_turno
	add constraint FK_Cancelacion_turno_turno_id foreign key (turno_id) references MISSINGNO.Turno(turno_id);

	-- TABLA ADMINISTRATIVO (FALTA QUE FUNCIONE FK ROL_ID)

alter table MISSINGNO.Administrativo
	add constraint FK_Administrativo_username foreign key (username) references MISSINGNO.Usuario(username);


	-- TABLA AGENDA

alter table MISSINGNO.Agenda
	add constraint FK_Agenda_prof_esp_id foreign key (prof_esp_id) references MISSINGNO.Especialidad_de_profesional(prof_esp_id);
	
	-- TABLA TURNO

alter table MISSINGNO.Turno
	add constraint FK_Turno_profesional_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);
alter table MISSINGNO.Turno
	add constraint FK_Turno_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);

	-- TABLA ROL_DE_USUARIO

alter table MISSINGNO.Rol_de_usuario
	add constraint FK_Rol_de_usuario_rol_id foreign key (rol_id) references MISSINGNO.Rol(rol_id);
alter table MISSINGNO.Rol_de_usuario
	add constraint FK_Rol_de_usuario_username foreign key (username) references MISSINGNO.Usuario(username);

	-- TABLA FUNCIONALIDAD_DE_ROL

alter table MISSINGNO.Funcionalidad_de_rol
	add constraint FK_Funcionalidad_de_rol_rol_id foreign key (rol_id) references MISSINGNO.Rol(rol_id);
alter table MISSINGNO.Funcionalidad_de_rol
	add constraint FK_Funcionalidad_de_rol_funcionalidad_id foreign key (funcionalidad_id) references MISSINGNO.Funcionalidad(funcionalidad_id);

	-- TABLA AFILIADO_HISTORIAL

alter table MISSINGNO.Afiliado_historial
	add constraint FK_Afiliado_historial_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);


	-- TABLA DIA

alter table MISSINGNO.Dia
	add constraint FK_Dia_agenda_id foreign key (agenda_id) references MISSINGNO.Agenda(agenda_id);

	-- TABLA ESPECIALIDAD

alter table MISSINGNO.Especialidad
	add constraint FK_Especialidad_tipo_especialidad_id foreign key (tipo_especialidad_id) references MISSINGNO.Tipo_especialidad(tipo_especialidad_id);

	--TABLA ESPECIALIDAD_DE_PROFESIONAL

alter table MISSINGNO.Especialidad_de_profesional
	add constraint FK_Especialidad_de_profesional_especialidad_id foreign key (especialidad_id) references MISSINGNO.Especialidad(especialidad_id);
alter table MISSINGNO.Especialidad_de_profesional
	add constraint FK_Especialidad_de_profesional_profesional_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);



/* PROCEDURES */

CREATE PROCEDURE PR_CREAR_FAMILIAR( @username varchar(60), @plan_id int, @ENCARGADO int, @ESTADO_CIVIL varchar(15), @ES_CONCUBINATO bit)
AS 
BEGIN

	DECLARE @ID_FAMILIAR int
	SET @ID_FAMILIAR = (SELECT max(afiliado_id) FROM MISSINGNO.Afiliado)

	IF(@ID_FAMILIAR > 10000) SET @ID_FAMILIAR = @ID_FAMILIAR / 100 + 1

	IF(@ENCARGADO IS NULL)
		SET IDENTITY_INSERT MISSINGNO.AFILIADO ON
		INSERT INTO MISSINGNO.Afiliado(afiliado_id, username, plan_id,afiliado_encargado,afiliado_fec_baja,afiliado_estado_civil,afiliado_baja_logica) 
		VALUES (( @ID_FAMILIAR* 100 + 1), @username, @plan_id, NULL, NULL, @ESTADO_CIVIL, 0)
		SET IDENTITY_INSERT MISSINGNO.AFILIADO OFF

	if(@ENCARGADO IS NOT NULL AND @ES_CONCUBINATO = 1)
	BEGIN
		SET IDENTITY_INSERT MISSINGNO.AFILIADO ON
		INSERT INTO MISSINGNO.Afiliado(afiliado_id, username, plan_id,afiliado_encargado,afiliado_fec_baja,afiliado_estado_civil,afiliado_baja_logica) 
		VALUES (@ENCARGADO + 1, @username, @plan_id, @ENCARGADO, NULL, @ESTADO_CIVIL, 0)

	END

	if(@ENCARGADO IS NOT NULL AND @ES_CONCUBINATO = 0)
	BEGIN
		DECLARE @YA_EXISTE bit
		DECLARE @CONTADOR tinyint
		SET @YA_EXISTE = 1
		SET @CONTADOR = 2

		WHILE(@YA_EXISTE = 1)
		BEGIN
			IF(NOT EXISTS (SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE afiliado_id = @ENCARGADO + @CONTADOR))
				BEGIN
					SET @YA_EXISTE = 0
					
				END
			ELSE
			begin
			SET @CONTADOR = @CONTADOR + 1
			end
		END
		
		SET IDENTITY_INSERT MISSINGNO.AFILIADO ON
		INSERT INTO MISSINGNO.Afiliado(afiliado_id, username, plan_id,afiliado_encargado,afiliado_fec_baja,afiliado_estado_civil,afiliado_baja_logica) 
		VALUES((@ENCARGADO + @CONTADOR), @username, @plan_id, @ENCARGADO, NULL, @ESTADO_CIVIL, 0)

	END
END;


	--MIGRACION

SET NOCOUNT ON
-- EJECUTAR LOS DELETES MAS DE UNA VEZ ( DEBE HABER UN ERROR CON LAS PRECEDENCIAS)

DBCC CHECKIDENT ('MISSINGNO.Afiliado', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Administrativo', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Especialidad_de_profesional',RESEED,0)
GO
DBCC CHECKIDENT ('MISSINGNO.Planes',RESEED,0)
GO
DBCC CHECKIDENT ('MISSINGNO.Afiliado_historial', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Agenda', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Consulta_medica', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Compra_bono', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Bono', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Turno', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Cancelacion_turno', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Funcionalidad', RESEED, 1)
GO
DBCC CHECKIDENT ('MISSINGNO.Especialidad', RESEED, 0)
GO
DBCC CHECKIDENT ('MISSINGNO.Rol', RESEED, 1)
GO

/* CREACION DE ROLES */

INSERT INTO MISSINGNO.Rol(
			rol_nombre,
			rol_habilitado)
			VALUES
			('Administrativo',1),
			('Profesional',1),
			('Afiliado',1)

/* CREACION DE FUNCIONALIDADES */

INSERT INTO MISSINGNO.Funcionalidad (funcionalidad_nombre)
	VALUES 
		('Gestionar roles'), 
		('Gestionar afiliados'), 
		('Comprar bonos'), 
		('Pedir turnos'), 
		('Registrar llegada para atencion'), 
		('Registrar resultado de atencion'), 
		('Cancelar turnos'), 
		('Estadisticas')
		
GO

/* CREACION DEL USUARIO "admin" */

INSERT INTO MISSINGNO.Usuario(
		username,
		doc_nro ,
		contrasenia, 
		nombre, 
		apellido, 
		fec_nac, 
		sexo, 
		domicilio, 
		mail, 
		telefono,
		doc_tipo) 
	VALUES(
		'admin',
		-1, 
		HASHBYTES('SHA2_256', 'w23e'),
		'Administrador',
		' ',
		'15/06/1995',
		'M',
		'mi casa',
		 'admin',
		 01140000000,
		 'DNI')

/* ASIGNACION DE ROL AL USUARIO "admin" */

INSERT INTO MISSINGNO.Rol_de_usuario(
			rol_id,
			username)
			VALUES
			(1,'admin')

/* ASIGNACION DE FUNCIONALIDADES A CADA ROL */

	-- Administrativo

INSERT INTO MISSINGNO.Funcionalidad_de_rol(
			rol_id,
			funcionalidad_id)
		VALUES (1,1), (1,2), (1,5), (1,8)

	-- Profesional

INSERT INTO MISSINGNO.Funcionalidad_de_rol(
			rol_id,
			funcionalidad_id)
		VALUES (2,6), (2,7)


	-- Afiliado

INSERT INTO MISSINGNO.Funcionalidad_de_rol(
			rol_id,
			funcionalidad_id)
		VALUES (3,3), (3,4), (3,5)

GO

/* MIGRACION DE TIPOS DE ESPECIALIDAD */
SET IDENTITY_INSERT MISSINGNO.Tipo_especialidad ON
INSERT INTO MISSINGNO.Tipo_especialidad(tipo_especialidad_id,tipo_especialidad_desc)
SELECT DISTINCT Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL
SET IDENTITY_INSERT MISSINGNO.Tipo_especialidad OFF
DBCC CHECKIDENT ("MISSINGNO.Tipo_especialidad")

/* MIGRACION DE ESPECIALIDADES */
SET IDENTITY_INSERT MISSINGNO.Especialidad ON
INSERT INTO MISSINGNO.Especialidad (especialidad_id,tipo_especialidad_id,especialidad_descripcion)
SELECT DISTINCT Especialidad_Codigo,Tipo_Especialidad_Codigo,Especialidad_Descripcion
FROM gd_esquema.Maestra
WHERE Especialidad_Codigo IS NOT NULL
SET IDENTITY_INSERT MISSINGNO.Especialidad OFF
DBCC CHECKIDENT ("MISSINGNO.Especialidad")

/* MIGRACION DE PLANES */
SET IDENTITY_INSERT MISSINGNO.Planes ON
INSERT INTO MISSINGNO.Planes (plan_id, plan_descripcion, bono_precio_farmacia, bono_precio_consulta)
SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Farmacia, Plan_Med_Precio_Bono_Consulta 
FROM gd_esquema.Maestra
WHERE Plan_Med_Codigo IS NOT NULL
SET IDENTITY_INSERT MISSINGNO.Planes OFF
DBCC CHECKIDENT ("MISSINGNO.Planes")

/* DECLARACION DE VARIABLES PARA CURSORES */

DECLARE @DNI bigint, @Nombre varchar(255), @Apellido varchar(255), @Domicilio varchar(255), @Telefono bigint, @Mail varchar(255), @Fec_nac datetime
DECLARE @Plan int
DECLARE @Existe int

/* DECLARACION PARA VARIABLE ROL */

DECLARE @Rol int

/* DECLARACION DE CURSOR DE AFILIADOS */

DECLARE cursorAfiliados CURSOR FOR SELECT DISTINCT Paciente_DNI, Paciente_Nombre, Paciente_Apellido, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo
FROM gd_esquema.Maestra
WHERE Paciente_Dni IS NOT NULL

/* MIGRACION DE AFILIADOS */

SET @Rol = (SELECT rol_id FROM MISSINGNO.Rol WHERE rol_nombre = 'Afiliado')

OPEN cursorAfiliados
FETCH NEXT FROM cursorAfiliados INTO @DNI, @Nombre, @Apellido, @Domicilio, @Telefono, @Mail, @Fec_nac, @Plan
WHILE @@FETCH_STATUS=0
BEGIN

SET @Existe = NULL

SELECT @Existe = username FROM MISSINGNO.Usuario WHERE doc_nro = @DNI

IF (@Existe IS NULL) 
	BEGIN
		IF(EXISTS(select 1 from MISSINGNO.Usuario WHERE username = @Mail))
		BEGIN
		INSERT INTO MISSINGNO.Usuario (doc_nro, doc_tipo, nombre, apellido, domicilio, telefono, mail, fec_nac, sexo, username, contrasenia)
		VALUES (@DNI, '-', @Nombre, @Apellido, @Domicilio, @Telefono, @Mail, @Fec_nac, '-', CONCAT(@Nombre,'_',@Apellido,'1','@gmail.com'), HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))))
		INSERT INTO MISSINGNO.Afiliado(username, afiliado_estado_civil, afiliado_encargado,plan_id, afiliado_baja_logica, afiliado_fec_baja) VALUES (CONCAT(@Nombre,'_',@Apellido,'1','@gmail.com'), 0, NULL, @Plan,0, NULL)
		INSERT INTO MISSINGNO.Rol_de_usuario(username, rol_id) VALUES (CONCAT(@Nombre,'_',@Apellido,'1','@gmail.com'), @Rol)
		END
		ELSE
		BEGIN
		INSERT INTO MISSINGNO.Usuario (doc_nro, doc_tipo, nombre, apellido, domicilio, telefono, mail, fec_nac, sexo, username, contrasenia)
		VALUES (@DNI, '-', @Nombre, @Apellido, @Domicilio, @Telefono, @Mail, @Fec_nac, '-', @Mail, HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))))
		INSERT INTO MISSINGNO.Afiliado(username, afiliado_estado_civil, afiliado_encargado,plan_id, afiliado_baja_logica, afiliado_fec_baja) VALUES (@Mail, 0, NULL, @Plan,0, NULL)
		INSERT INTO MISSINGNO.Rol_de_usuario(username, rol_id) VALUES (@Mail, @Rol)
		END
	END



FETCH NEXT FROM cursorAfiliados INTO @DNI, @Nombre, @Apellido, @Domicilio, @Telefono, @Mail, @Fec_Nac, @Plan
END
CLOSE cursorAfiliados
DEALLOCATE cursorAfiliados

/* MIGRACION DE PROFESIONALES */

DECLARE cursorMedicos CURSOR FOR SELECT DISTINCT Medico_DNI, Medico_Nombre, Medico_Apellido, Medico_Direccion, Medico_Telefono, Medico_Mail, Medico_Fecha_Nac
FROM gd_esquema.Maestra
WHERE Medico_DNI IS NOT NULL
DECLARE @Direccion varchar(255)
DECLARE @Fecha_nac datetime

SET @Rol = (SELECT rol_id FROM MISSINGNO.Rol WHERE rol_nombre = 'Profesional')

OPEN cursorMedicos
FETCH NEXT FROM cursorMedicos INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac
WHILE @@FETCH_STATUS=0
BEGIN

SET @Existe = NULL

SELECT @Existe = username FROM MISSINGNO.Usuario WHERE doc_nro = @DNI

IF (@Existe IS NULL) 
	BEGIN
		INSERT INTO MISSINGNO.Usuario (doc_nro, doc_tipo, nombre, apellido, domicilio, telefono, mail, fec_nac, sexo, username, contrasenia)
		VALUES (@DNI, '-', @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_nac, '-', @Mail, HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))))
		SET @Existe = @@IDENTITY
	END

INSERT INTO MISSINGNO.Profesional(username, profesional_matricula) VALUES (@MaiL, -1) -- -1 valor a revisar.

INSERT INTO MISSINGNO.Rol_de_usuario(username, rol_id) VALUES (@Mail, @Rol)


FETCH NEXT FROM cursorMedicos INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac
END
CLOSE cursorMedicos
DEALLOCATE cursorMedicos

-- MIGRACION DE ESPECIALIDAD CON PROFESIONAL.
DBCC CHECKIDENT ('MISSINGNO.Especialidad_de_profesional',RESEED,0)
INSERT INTO MISSINGNO.Especialidad_de_profesional(especialidad_id, profesional_id)
SELECT DISTINCT E.especialidad_id, P.profesional_id
from gd_esquema.Maestra, MISSINGNO.Profesional P, MISSINGNO.Especialidad E
where P.username = Medico_Mail and
	  E.especialidad_id = Especialidad_Codigo


/* MIGRACION DE COMPRA DE BONOS*/

INSERT INTO MISSINGNO.Compra_bono
	(Afiliado_id, plan_id, fecha_compra)
SELECT DISTINCT afiliado_id, A.plan_id , Compra_Bono_Fecha
FROM gd_esquema.Maestra, MISSINGNO.Afiliado A, MISSINGNO.Planes P, MISSINGNO.Usuario U
WHERE Compra_Bono_Fecha IS NOT NULL 
and A.username = U.username 
and U.doc_nro = Paciente_Dni
and A.plan_id = Plan_Med_Codigo 
and P.plan_id = A.plan_id

/* MIGRACION DE BONOS */ 

SET IDENTITY_INSERT MISSINGNO.Bono ON
INSERT INTO MISSINGNO.Bono(bono_id, plan_id, afiliado_id, compra_bono_id, bono_estado, bono_precio)
SELECT DISTINCT Bono_Consulta_Numero, C.plan_id, C.afiliado_id, C.compra_bono_id, 1, Plan_Med_Precio_Bono_Consulta
	FROM gd_esquema.Maestra, MISSINGNO.Compra_bono C, MISSINGNO.Afiliado A, MISSINGNO.Planes P, MISSINGNO.Usuario U
	WHERE Compra_Bono_Fecha IS NOT NULL 
	and C.plan_id = Plan_Med_Codigo 
	and C.afiliado_id = A.afiliado_id 
	and A.username = U.username 
	and U.doc_nro = Paciente_Dni
	and P.plan_id = C.plan_id 
	and C.fecha_compra = Compra_Bono_Fecha
SET IDENTITY_INSERT MISSINGNO.Bono OFF
	
/* MIGRACION DE TURNOS */

SET IDENTITY_INSERT MISSINGNO.Turno ON
INSERT INTO MISSINGNO.Turno(turno_id, profesional_id, fecha, horario, en_uso, afiliado_id)
SELECT DISTINCT Turno_Numero, P.profesional_id, Turno_fecha,cast(Turno_Fecha as time), 1, A.afiliado_id
FROM gd_esquema.Maestra, MISSINGNO.Profesional P, MISSINGNO.Bono B, MISSINGNO.Afiliado A, MISSINGNO.Usuario U
WHERE Turno_Numero IS NOT NULL
and P.username = Medico_Mail
and Bono_Consulta_Numero = B.bono_id
and U.doc_nro = Paciente_Dni
and U.username = A.username
SET IDENTITY_INSERT MISSINGNO.Turno OFF

/* MIGRACION DE AGENDAS */

INSERT INTO MISSINGNO.Agenda(prof_esp_id, agenda_inicio, agenda_fin)
SELECT DISTINCT EP.prof_esp_id, Turno_fecha, DATEADD(minute,30,Turno_Fecha)
FROM gd_esquema.Maestra GD, MISSINGNO.Profesional P, MISSINGNO.Especialidad E, MISSINGNO.Especialidad_de_profesional EP
WHERE EP.profesional_id = P.profesional_id
and EP.especialidad_id = E.especialidad_id
and E.especialidad_descripcion = GD.Especialidad_Descripcion
and P.username = Medico_Mail


/* MIGRACION DE CONSULTAS MEDICAS */

INSERT INTO MISSINGNO.Consulta_medica(turno_id, bono_id, sintoma, diagnostico, agenda_id, consulta_horario, confirmacion_de_atencion, profesional_id)
SELECT DISTINCT Turno_Numero, Bono_Consulta_Numero, Consulta_Sintomas, Consulta_Enfermedades, AG.agenda_id , cast(Turno_Fecha as time),'SI', P.profesional_id
FROM gd_esquema.Maestra GD, MISSINGNO.Turno T, MISSINGNO.Profesional P, MISSINGNO.Agenda AG, MISSINGNO.Especialidad_de_profesional EP, MISSINGNO.Especialidad E
WHERE Consulta_Sintomas IS NOT NULL
and Turno_Numero = T.turno_id
and P.username = Medico_Mail
and AG.agenda_inicio = Turno_Fecha
and AG.prof_esp_id = EP.prof_esp_id
and EP.profesional_id = P.profesional_id
and EP.especialidad_id = E.especialidad_id
and E.Especialidad_Descripcion = GD.Especialidad_Descripcion
and T.fecha = Turno_Fecha
and T.profesional_id = P.profesional_id
