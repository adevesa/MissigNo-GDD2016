USE GD2C2016
GO


--ELIMINACION DE FOREIGN KEYS

alter table MISSINGNO.Administrador
  drop constraint FK_Administrador_funcionalidad_id;

alter table MISSINGNO.Consulta_medica
  drop constraint FK_Consulta_medica_profesional_matricula;
alter table MISSINGNO.Consulta_medica
  drop constraint FK_Consulta_medica_id_afiliado;
alter table MISSINGNO.Consulta_medica
  drop constraint FK_Consulta_medica_id_sintoma;
alter table MISSINGNO.Consulta_medica
  drop constraint FK_Consulta_medica_id_turno;
  
alter table MISSINGNO.Afiliado
  drop constraint FK_Afiliado_fam_a_cargo;
alter table MISSINGNO.Afiliado
  drop constraint FK_Afiliado_funcionalidad_id;
alter table MISSINGNO.Afiliado
  drop constraint FK_Afiliado_historial_id;
alter table MISSINGNO.Afiliado
  drop constraint FK_Afiliado_plan_id;
  
alter table MISSINGNO.Profesional
  drop constraint FK_Profesional_funcionalidad_id;
alter table MISSINGNO.Profesional
  drop constraint FK_Profesional_id_agenda;
alter table MISSINGNO.Profesional
  drop constraint FK_Profesional_especialidad_id;
  
alter table MISSINGNO.Agenda
  drop constraint FK_Agenda_id_turno;
alter table MISSINGNO.Agenda
  drop constraint FK_Agenda_id_dia;
  
alter table MISSINGNO.Cancelacion_turno
  drop constraint FK_Cancelacion_turno_id_turno;
  
alter table MISSINGNO.Planes
  drop constraint FK_Planes_compra_bono_id;
    
alter table MISSINGNO.Turno
  drop constraint FK_Turno_profesional_matricula
alter table MISSINGNO.Turno
  drop constraint FK_Turno_id_consulta;
  
alter table MISSINGNO.Usuario
  drop constraint FK_Usuario_profesional_matricula;
alter table MISSINGNO.Usuario
  drop constraint FK_Usuario_afiliado_id;
alter table MISSINGNO.Usuario
  drop constraint FK_Usuario_admin_id;
  
alter table MISSINGNO.Compra_bonos
  drop constraint FK_Compra_bonos_afiliado_id;
alter table MISSINGNO.Compra_bonos
  drop constraint FK_Compra_bonos_bono_id;
  
alter table MISSINGNO.Bono
  drop constraint FK_Bono_afiliado_id;
alter table MISSINGNO.Bono
  drop constraint FK_Bono_turno_id;

--  ELIMINACION DE TABLAS

if object_id('MISSINGNO.Administrador') is not null
drop table MISSINGNO.Administrador;

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

if object_id('MISSINGNO.Sintomas') is not null
drop table MISSINGNO.Sintomas;

if object_id('MISSINGNO.Compra_bonos') is not null
drop table MISSINGNO.Compra_bonos;

if object_id('MISSINGNO.Bono') is not null
drop table MISSINGNO.Bono;

if object_id('MISSINGNO.Afiliado') is not null
drop table MISSINGNO.Afiliado;

if object_id('MISSINGNO.Especialidades_de_profesional') is not null
drop table MISSINGNO.Especialidades_de_profesional;

if object_id('MISSINGNO.Turno') is not null
drop table MISSINGNO.Turno;

DROP SCHEMA [MISSINGNO]
GO