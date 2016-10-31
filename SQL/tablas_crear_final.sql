USE GD2C2016
GO

--ELIMINACION DE FOREIGN KEYS

	-- TABLA ADMINISTRATIVO

alter table MISSINGNO.Administrativo
	drop constraint FK_Administrativo_username;

  -- TABLA CONSULTA_MEDICA

alter table MISSINGNO.Consulta_medica
	drop constraint FK_Consulta_medica_profesional_id;
alter table MISSINGNO.Consulta_medica
	drop constraint FK_Consulta_medica_afiliado_id;
alter table MISSINGNO.Consulta_medica
	drop constraint FK_Consulta_medica_agenda_id;
alter table MISSINGNO.Consulta_medica
	drop constraint FK_Consulta_medica_turno_id;

  -- TABLA AFILIADO
  
alter table MISSINGNO.Afiliado
	drop constraint FK_Afiliado_username;
alter table MISSINGNO.Afiliado
	drop constraint FK_Afiliado_plan_id;
alter table MISSINGNO.Afiliado
	drop constraint FK_Afiliado_afiliado_encargado;

  -- TABLA PROFESIONAL
  
alter table MISSINGNO.Profesional
	drop constraint FK_Profesional_username;

  -- TABLA AGENDA
  
alter table MISSINGNO.Agenda
	drop constraint FK_Agenda_profesional_id;

  -- TABLA CANCELACION_TURNO
  
alter table MISSINGNO.Cancelacion_turno
	drop constraint FK_Cancelacion_turno_turno_id;

  -- TABLA TURNO
    
alter table MISSINGNO.Turno
	drop constraint FK_Turno_profesional_id;
alter table MISSINGNO.Turno
	drop constraint FK_Turno_bono_id;

  -- TABLA COMPRA_BONO
  
alter table MISSINGNO.Compra_bono
	drop constraint FK_Compra_bono_afiliado_id;
alter table MISSINGNO.Compra_bono
	drop constraint FK_Compra_bono_plan_id;

  -- TABLA BONO
  
alter table MISSINGNO.Bono
	drop constraint FK_Bono_plan_id;
alter table MISSINGNO.Bono
	drop constraint FK_Bono_afiliado_id;
alter table MISSINGNO.Bono
	drop constraint FK_Bono_compra_bono_id;

	-- TABLA ROL_DE_USUARIO

alter table MISSINGNO.Rol_de_usuario
	drop constraint FK_Rol_de_usuario_rol_id;
alter table MISSINGNO.Rol_de_usuario
	drop constraint FK_Rol_de_usuario_username;

	-- TABLA FUNCIONALIDAD_DE_ROL

alter table MISSINGNO.Funcionalidad_de_rol
	drop constraint FK_Funcionalidad_de_rol_funcionalidad_id;
alter table MISSINGNO.Funcionalidad_de_rol
	drop constraint FK_Funcionalidad_de_rol_rol_id;

	-- TABLA ESPECIALIDAD
alter table MISSINGNO.Especialidad
	drop constraint FK_Especialidad_tipo_especialidad_id 

	-- TABLA ESPECIALIDAD_DE_PROFESIONAL

alter table MISSINGNO.Especialidad_de_profesional
	drop constraint FK_Especialidad_de_profesional_profesional_id;
alter table MISSINGNO.Especialidad_de_profesional
	drop constraint FK_Especialidad_de_profesional_especialidad_id;

	-- TABLA AFILIADO_HISTORIAL

alter table MISSINGNO.Afiliado_historial
	drop constraint FK_Afiliado_historial_afiliado_id;

	-- TABLA DIA

alter table MISSINGNO.Dia
	drop constraint FK_Dia_agenda_id;

--  ELIMINACION DE TABLAS

if object_id('MISSINGNO.Tipo_especialidad') is not null
drop table MISSINGNO.Tipo_especialidad;

if object_id('MISSINGNO.Administrativo') is not null
drop table MISSINGNO.Administrativo;

if object_id('MISSINGNO.Consulta_medica') is not null
drop table MISSINGNO.Consulta_medica;

if object_id('MISSINGNO.Afiliado_Historial') is not null
drop table MISSINGNO.Afiliado_Historial;

if object_id('MISSINGNO.Agenda') is not null
drop table MISSINGNO.Agenda;

if object_id('MISSINGNO.Cancelacion_turno') is not null
drop table MISSINGNO.Cancelacion_turno;

if object_id('MISSINGNO.Dia') is not null
drop table MISSINGNO.Dia;

if object_id('MISSINGNO.Funcionalidad') is not null
drop table MISSINGNO.Funcionalidad;

if object_id('MISSINGNO.Planes') is not null
drop table MISSINGNO.Planes;

if object_id('MISSINGNO.Profesional') is not null
drop table MISSINGNO.Profesional;

if object_id('MISSINGNO.Usuario') is not null
drop table MISSINGNO.Usuario;

if object_id('MISSINGNO.Compra_bono') is not null
drop table MISSINGNO.Compra_bono;

if object_id('MISSINGNO.Bono') is not null
drop table MISSINGNO.Bono;

if object_id('MISSINGNO.Afiliado') is not null
drop table MISSINGNO.Afiliado;

if object_id('MISSINGNO.Especialidad_de_profesional') is not null
drop table MISSINGNO.Especialidad_de_profesional;

if object_id('MISSINGNO.Turno') is not null
drop table MISSINGNO.Turno;

if object_id('MISSINGNO.Rol_de_usuario') is not null
drop table MISSINGNO.Rol_de_usuario;

if object_id('MISSINGNO.Rol') is not null
drop table MISSINGNO.Rol;

if object_id('MISSINGNO.Funcionalidad_de_rol') is not null
drop table MISSINGNO.Funcionalidad_de_rol;

if object_id('MISSINGNO.Especialidad') is not null
drop table MISSINGNO.Especialidad;


DROP SCHEMA [MISSINGNO]
GO


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
		username varchar(50) primary key,
		doc_tipo varchar(10),
		doc_nro bigint,
		contrasenia nvarchar(30),
		nombre varchar(20),
		apellido varchar(20),
		fec_nac datetime, 
		sexo char,
		domicilio varchar(150),
		mail varchar(40),
		telefono bigint,
		unique (doc_nro))

	-- TABLA ROL_DE_USUARIO

	create table MISSINGNO.Rol_de_usuario(
		rol_id int not null,
		username varchar(50) not null,
		primary key (rol_id,username))

	-- TABLA FUNCIONALIDAD_DE_ROL

	create table MISSINGNO.Funcionalidad_de_rol(
		rol_id int,
		funcionalidad_id int)

	-- TABLA AGENDA

	create table MISSINGNO.Agenda(
		agenda_id int primary key identity,
		profesional_id int not null,
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
		username varchar(50) not null,
		profesional_matricula int )

	-- TABLA ESPECIALIDAD_DE_PROFESIONAL

	create table MISSINGNO.Especialidad_de_profesional(
		especialidad_id int not null,
		profesional_id int not null)

	-- TABLA TURNO

	create table MISSINGNO.Turno(
		turno_id int primary key identity,
		profesional_id int not null,
		bono_id int not null,
		fecha datetime not null,
		horario time not null)

	-- TABLA DIA

	create table MISSINGNO.Dia(
		dia_id int primary key,
		agenda_id int,
		horario_desde time,
		horario_hasta time,
		desc_dia varchar(10))

	-- TABLA AFILIADO

	create table MISSINGNO.Afiliado(
		afiliado_id int primary key identity,
		username varchar(50) not null,
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
		profesional_id int not null,
		afiliado_id int not null,
		agenda_id int not null,
		turno_id int not null,
		confirmacion_de_atencion char(2),
		diagnostico varchar(140),
		consulta_horario time,
		sintoma varchar(140))


	-- TABLA CANCELACION_TURNO

	create table MISSINGNO.Cancelacion_turno(
		cancelacion_id int primary key identity,
		turno_id int not null,
		cancelacion_motivo varchar(140),
		cancelacion_tipo4 varchar(20),
		cancelacion_fecha datetime)

	-- TABLA ADMINISTRATIVO
	
	create table MISSINGNO.Administrativo(
		admin_id int primary key identity,
		username varchar(50) not null)
	
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
	add constraint FK_Consulta_medica_profesional_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Consulta_medica
	add constraint FK_Consulta_medica_agenda_id foreign key (agenda_id) references MISSINGNO.Agenda(agenda_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_turno_id foreign key (turno_id) references MISSINGNO.Turno(turno_id);

	-- TABLA CANCELACION_TURNO

alter table MISSINGNO.Cancelacion_turno
	add constraint FK_Cancelacion_turno_turno_id foreign key (turno_id) references MISSINGNO.Turno(turno_id);

	-- TABLA ADMINISTRATIVO (FALTA QUE FUNCIONE FK ROL_ID)

alter table MISSINGNO.Administrativo
	add constraint FK_Administrativo_username foreign key (username) references MISSINGNO.Usuario(username);


	-- TABLA AGENDA

alter table MISSINGNO.Agenda
	add constraint FK_Agenda_profesional_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);
	
	-- TABLA TURNO

alter table MISSINGNO.Turno
	add constraint FK_Turno_profesional_id foreign key (profesional_id) references MISSINGNO.Profesional(profesional_id);
alter table MISSINGNO.Turno
	add constraint FK_Turno_bono_id foreign key (bono_id) references MISSINGNO.Bono(bono_id);

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