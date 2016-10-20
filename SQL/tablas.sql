use GD2C2016
go

create table Dia(
	id_dia int primary key identity,
	horario_desde char(2),
	horario_hasta char(2),
	desc_dia varchar(10))

create table Agenda(
	id_agenda int primary key identity,
	id_dia datetime not null,
	id_turno int,
	profesional_matricula int not null,
	especialidad_id ont not null,
	constraint FK_Agenda_id_agenda foreign key (id_agenda) references Agenda(id_agenda),
	constraint FK_Agenda_id_turno foreign key (id_turno) references Turno(id_turno),
	constraint FK_Agenda_profesional_matricula foreign key (profesional_matricula) references Profesional(profesional_matricula))

create table Especialidad_de_profesional(
	especialidad_id int primary key identity,
	id_agenda int,
	descripcion varchar(140),
	constraint FK_Especialidad_de_profesional foreign key (id_agenda) references Agenda(id_agenda))

create table Afiliado_Historial(
	afiliado_hist_id int primary key identity,
	motivo varchar(140),
	fecha_modif datetime)

create table Sintomas(
	id_sintoma int primary key identity,
	sintoma_nombre varchar(30))

create table Consulta_medica(
	id_consulta int primary key identity,
	profesional_matricula int not null,
	id_afiliado int not null,
	id_sintoma int not null,
	confirmacion_de_atencion char(2),
	diagnostico varchar(140),
	consulta_horario datetime,
	constraint FK_Consulta_medica_profesional_matricula foreign key (profesional_matricula) references Profesional(profesional_matricula),
	constraint FK_Consulta_medica_id_afiliado foreign key (id_afiliado) references Afiliado(id_afiliado),
	constraint FK_Consulta_medica_id_sintoma foreign key (id_sintoma) references Sintomas(id_sintoma)) 

create table Funcionalidad(
	funcionalidad_id int primary key identity,
	descripcion varchar(30))

create table Profesional(
	profesional_matricula int primary key,
	rol_name varchar(15) not null,
	especialidad_id int not null,
	funcionalidad_id int,
	constraint FK_Profesional_especialidad_id foreign key (especialidad_id) references Especialidades_de_profesional(especialidad_id),
	constraint FK_Profesional_funcionalidad_id foreign key (funcionalidad_id) references Funcionalidad(funcionalidad_id))

create table Afiliado(
	afiliado_id int primary key identity,
	rol_name varchar(15) not null,
	afiliado_fec_baja datetime not null,
	afiliado_estado_civil varchar(10) not null,
	fam_a_cargo int,
	funcionalidad_id int,
	historial_id int,
	constraint FK_Afiliado_fam_a_cargo foreign key (fam_a_cargo) references Afiliado(afiliado_id),
	constraint FK_Afiliado_funcionalidad_id foreign key (funcionalidad_id) references Funcionalidad(funcionalidad_id),
	constraint FK_Afiliado_historial_id foreign key (historial_id) references Afiliado_Historial(hist_id))

create table Turno(
	id_turno int primary key identity,
	profesional_matricula int not null,
	id_consulta int not null,
	fecha datetime not null,
	horario datetime not null,
	constraint FK_Turno_profesional_matricula foreign key (profesional_matricula) references Profesional(profesional_matricula),
	constraint FK_Turno_id_consulta foreign key (id_consulta) references Consulta_medica(id_consulta))

create table Canselacion_turno(
	id_cancelacion int primary key identity,
	id_turno int not null,
	cancelacion_motivo varchar(140),
	cancelacion_tipo varchar(20),
	cancelacion_fecha datetime,
	constraint FK_Canselacion_turno_id_turno foreign key (id_turno) references Turno(id_turno))

create table Bono(
	bono_id int primary key identity,
	plan_id int not null,
	turno_id int not null,
	afiliado_id int not null,
	bono_estado varchar(15) not null,
	bono_precio decimal(8,2) not null,
	constraint FK_Bono_plan_id foreign key (plan_id) references Planes(plan_id),
	constraint FK_turno_id foreign key (turno_id) references Turno(turno_id),
	constraint FK_afiliado_id foreign key (afiliado_id) references Afiliado(afiliado_id))

create table Compra_bonos(
	compra_bono_id int primary key identity,
	bono_id int not null,
	fecha_compra datetime not null,
	afiliado_id int not null,
	constraint FK_Compra_bonos_bono_id foreign key (bono_id) references Bono(bono_id),
	constraint FK_Compra_bonos_afiliad_id foreign key (afiliado_id) references Afiliado(afiliado_id))

create table Planes(
	plan_id int primary key identity,
	plan_descripcion varchar(30),
	bono_precio_farmacia decimal(8,2) not null,
	bono_precio_consulta decimal(8,2) not null,
	afiliado_id int,
	compra_bono_id int,
	constraint FK_Planes_afiliado_id foreign key (afiliado_id) references Afiliado(afiliado_id),
	constraint FK_Planes_afiliado_id foreign key (compra_bono_id) references Compra_bonos(compra_bono_id))

create table Administrador(
	admin_id int primary key identity,
	rol_name varchar(15) not null,
	funcionalidad_id int,
	constraint FK_Administrador_funcionalidad_id foreign key (funcionalidad_id) references Funcionalidad(funcionalidad_id))

create table Usuario (
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
	constraint FK_Usuario_profesional_matricula foreign key (profesional_matricula) references Profesional(profesional_matricula),
	constraint FK_Usuario_afiliado_id foreign key (afiliado_id) references Afiliado(afiliado_id),
	constraint FK_Usuario_admin_id foreign key (admin_id) references Administrador(admin_id),
	unique (doc_nro))
