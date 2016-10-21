USE GD2C2016
GO

-- CREACION DE TABLAS

create table MISSINGNO.Funcionalidad(
	funcionalidad_id int primary key identity,
	descripcion varchar(30))

create table MISSINGNO.Agenda(
	id_agenda int primary key identity,
	id_dia int,
	id_turno int)

create table MISSINGNO.Especialidades_de_profesional(
	especialidad_id int primary key identity,
	descripcion varchar(140))

create table MISSINGNO.Profesional(
	profesional_matricula int primary key,
	rol_name varchar(15) not null,
	especialidad_id int not null,
	funcionalidad_id int,
	id_agenda int)

create table MISSINGNO.Turno(
	id_turno int primary key identity,
	profesional_matricula int not null,
	id_consulta int not null,
	fecha datetime not null,
	horario datetime not null)

create table MISSINGNO.Dia(
	id_dia int primary key identity,
	horario_desde char(2),
	horario_hasta char(2),
	desc_dia varchar(10))

create table MISSINGNO.Afiliado_Historial(
	hist_id int primary key identity,
	motivo varchar(140),
	fecha_modif datetime)

create table MISSINGNO.Sintomas(
	id_sintoma int primary key identity,
	sintoma_nombre varchar(30))

create table MISSINGNO.Bono(
	bono_id int primary key identity,
	plan_id int not null,
	turno_id int not null,
	afiliado_id int not null,
	bono_estado varchar(15) not null,
	bono_precio decimal(8,2) not null)

create table MISSINGNO.Compra_bonos(
	compra_bono_id int primary key identity,
	bono_id int not null,
	fecha_compra datetime not null,
	afiliado_id int not null)

create table MISSINGNO.Planes(
	plan_id int primary key identity,
	plan_descripcion varchar(30),
	bono_precio_farmacia decimal(8,2) not null,
	bono_precio_consulta decimal(8,2) not null,
	compra_bono_id int)

create table MISSINGNO.Afiliado(
	afiliado_id int primary key identity,
	rol_name varchar(15) not null,
	afiliado_fec_baja datetime not null,
	afiliado_estado_civil varchar(10) not null,
	fam_a_cargo int,
	funcionalidad_id int,
	historial_id int,
	plan_id int not null)

create table MISSINGNO.Consulta_medica(
	id_consulta int primary key identity,
	profesional_matricula int not null,
	id_afiliado int not null,
	id_sintoma int not null,
	confirmacion_de_atencion char(2),
	diagnostico varchar(140),
	id_turno int)

create table MISSINGNO.Cancelacion_turno(
	id_cancelacion int primary key identity,
	id_turno int not null,
	cancelacion_motivo varchar(140),
	cancelacion_tipo varchar(20),
	cancelacion_fecha datetime)
	
create table MISSINGNO.Administrador(
	admin_id int primary key identity,
	rol_name varchar(15) not null,
	funcionalidad_id int)

create table MISSINGNO.Usuario (
	username varchar(15) primary key,
	doc_nro numeric(18,0) not null,
	contrasenia varchar(15) not null,
	nombre varchar(20) not null,
	apellido varchar(20) not null,
	fec_nac datetime not null,
	sexo varchar(10) not null,
	domicilio varchar(30) not null,
	mail varchar(30) not null,
	telefono int not null,
	doc_tipo varchar(10) not null,
	profesional_matricula int not null,
	afiliado_id int not null,
	admin_id int not null,
	unique (doc_nro))


--DECLARACION DE CONSTRAINT
alter table MISSINGNO.Profesional
	add constraint FK_Profesional_especialidad_id foreign key (especialidad_id) references MISSINGNO.Especialidades_de_profesional(especialidad_id);
alter table MISSINGNO.Profesional	
	add constraint FK_Profesional_funcionalidad_id foreign key (funcionalidad_id) references MISSINGNO.Funcionalidad(funcionalidad_id);
alter table MISSINGNO.Profesional	
	add constraint FK_Profesional_id_agenda foreign key (id_agenda) references MISSINGNO.Agenda(id_agenda);


alter table MISSINGNO.Bono
	add constraint FK_Bono_turno_id foreign key (turno_id) references MISSINGNO.Turno(id_turno);
alter table MISSINGNO.Bono
	add constraint FK_Bono_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);


alter table MISSINGNO.Compra_bonos
	add constraint FK_Compra_bonos_bono_id foreign key (bono_id) references MISSINGNO.Bono(bono_id);
alter table MISSINGNO.Compra_bonos
	add constraint FK_Compra_bonos_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);


alter table MISSINGNO.Planes
	add constraint FK_Planes_compra_bono_id foreign key (compra_bono_id) references MISSINGNO.Compra_bonos(compra_bono_id);


alter table MISSINGNO.Afiliado
	add constraint FK_Afiliado_fam_a_cargo foreign key (fam_a_cargo) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Afiliado	
	add constraint FK_Afiliado_funcionalidad_id foreign key (funcionalidad_id) references MISSINGNO.Funcionalidad(funcionalidad_id);
alter table MISSINGNO.Afiliado	
	add constraint FK_Afiliado_historial_id foreign key (historial_id) references MISSINGNO.Afiliado_Historial(hist_id);
alter table MISSINGNO.Afiliado	
	add constraint FK_Afiliado_plan_id foreign key (plan_id) references MISSINGNO.Planes(plan_id);


alter table MISSINGNO.Consulta_medica
	add constraint FK_Consulta_medica_profesional_matricula foreign key (profesional_matricula) references MISSINGNO.Profesional(profesional_matricula);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_id_afiliado foreign key (id_afiliado) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_id_sintoma foreign key (id_sintoma) references MISSINGNO.Sintomas(id_sintoma);
alter table MISSINGNO.Consulta_medica	
	add constraint FK_Consulta_medica_id_turno foreign key (id_turno) references MISSINGNO.Turno(id_turno);


alter table MISSINGNO.Cancelacion_turno
	add constraint FK_Cancelacion_turno_id_turno foreign key (id_turno) references MISSINGNO.Turno(id_turno);


alter table MISSINGNO.Administrador
	add constraint FK_Administrador_funcionalidad_id foreign key (funcionalidad_id) references MISSINGNO.Funcionalidad(funcionalidad_id);


alter table MISSINGNO.Agenda
	add constraint FK_Agenda_id_turno foreign key (id_turno) references MISSINGNO.Turno(id_turno);
alter table MISSINGNO.Agenda
	add constraint FK_Agenda_id_dia foreign key (id_dia) references MISSINGNO.Dia(id_dia);
 

alter table MISSINGNO.Usuario
	add constraint FK_Usuario_profesional_matricula foreign key (profesional_matricula) references MISSINGNO.Profesional(profesional_matricula);
alter table MISSINGNO.Usuario
	add constraint FK_Usuario_afiliado_id foreign key (afiliado_id) references MISSINGNO.Afiliado(afiliado_id);
alter table MISSINGNO.Usuario
	add constraint FK_Usuario_admin_id foreign key (admin_id) references MISSINGNO.Administrador(admin_id);
	

alter table MISSINGNO.Turno
	add constraint FK_Turno_profesional_matricula foreign key (profesional_matricula) references MISSINGNO.Profesional(profesional_matricula);
alter table MISSINGNO.Turno
	add constraint FK_Turno_id_consulta foreign key (id_consulta) references MISSINGNO.Consulta_medica(id_consulta);

