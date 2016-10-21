USE GD2C2016
GO
--  ELIMINACION DE TABLAS
if object_id('Funcionalidad') is not null
drop table Funcionalidad;

if object_id('Agenda') is not null
drop table Agenda;

if object_id('Especialidades_de_profesional') is not null
drop table Especialidades_de_profesional;

if object_id('Profesional') is not null
drop table Profesional;

if object_id('Turno') is not null
drop table Turno;

if object_id('Dia') is not null
drop table Dia;

if object_id('Afiliado_Historial') is not null
drop table Afiliado_Historial;

if object_id('Sintomas') is not null
drop table Sintomas;

if object_id('Bono') is not null
drop table Bono;

if object_id('Compra_bonos') is not null
drop table Compra_bonos;

if object_id('Planes') is not null
drop table Planes;

if object_id('Afiliado') is not null
drop table Afiliado;

if object_id('Consulta_medica') is not null
drop table Consulta_medica;

if object_id('Cancelacion_turno') is not null
drop table Cancelacion_turno;

if object_id('Administrador') is not null
drop table Administrador;

if object_id('Usuario') is not null
drop table Usuario;

--ELIMINACION DE FOREIGN KEYS
alter table Profesional
  drop constraint FK_Profesional_especialidad_id;
alter table Profesional
  drop constraint FK_Profesional_funcionalidad_id;
alter table Profesional
  drop constraint FK_Profesional_id_agenda;

alter table Bono
  drop constraint FK_Bono_afiliado_id;
alter table Bono
  drop constraint FK_Bono_turno_id;

alter table Compra_bonos
  drop constraint FK_Compra_bonos_afiliado_id;
alter table Compra_bonos
  drop constraint FK_Bono_turno_id;
  
alter table Planes
  drop constraint FK_Planes_compra_bono_id;
  
alter table Afiliado
  drop constraint FK_Afiliado_fam_a_cargo;
alter table Afiliado
  drop constraint FK_Afiliado_funcionalidad_id;
alter table Afiliado
  drop constraint FK_Afiliado_historial_id;
alter table Afiliado
  drop constraint FK_Afiliado_plan_id;
  
alter table Consulta_medica
  drop constraint FK_Consulta_medica_profesional_matricula;
alter table Consulta_medica
  drop constraint FK_Consulta_medica_id_afiliado;
alter table Consulta_medica
  drop constraint FK_Consulta_medica_id_sintoma;
alter table Consulta_medica
  drop constraint FK_Consulta_medica_id_turno;
  
alter table Cancelacion_turno
  drop constraint FK_Cancelacion_turno_id_turno;
  
alter table Administrador
  drop constraint FK_Administrador_funcionalidad_id;
  
alter table Agenda
  drop constraint FK_Agenda_id_turno;
alter table Agenda
  drop constraint FK_Agenda_id_dia;
  
alter table Usuario
  drop constraint FK_Usuario_profesional_matricula;
alter table Usuario
  drop constraint FK_Usuario_afiliado_id;
alter table Usuario
  drop constraint FK_Usuario_admin_id;
  
alter table Turno
  drop constraint FK_Turno_profesional_matricula
alter table Turno
  drop constraint FK_Turno_id_consulta;
