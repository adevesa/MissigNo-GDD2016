USE GD2C2016
GO

DELETE FROM MISSINGNO.Usuario;
DELETE FROM MISSINGNO.Afiliado;
DELETE FROM MISSINGNO.Profesional;
DELETE FROM MISSINGNO.Administrador;
DELETE FROM MISSINGNO.Especialidades_de_profesional;
DELETE FROM MISSINGNO.Planes;
DELETE FROM MISSINGNO.Afiliado_Historial;
DELETE FROM MISSINGNO.Agenda;
DELETE FROM MISSINGNO.Dia;
DELETE FROM MISSINGNO.Consulta_medica;
DELETE FROM MISSINGNO.Sintomas;
DELETE FROM MISSINGNO.Compra_bonos;
DELETE FROM MISSINGNO.Bono;
DELETE FROM MISSINGNO.Turno;
DELETE FROM MISSINGNO.Cancelacion_turno;
DELETE FROM MISSINGNO.Funcionalidad;

GO


/* CREACION DE ROLES */

INSERT INTO MISSINGNO.Administrador(
	rol_name, funcionalidad_id)
	VALUES (
		'Administrador', NULL)
		
GO

INSERT INTO MISSINGNO.Usuario(
	username, doc_nro ,contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono,
	doc_tipo, profesional_matricula, afiliado_id, admin_id) 
	VALUES (
		'admin',-1, HASHBYTES('SHA2_256', 'w23e'),'Administrador',' ', '15/06/1995',
		'Hombre' ,'mi casa' , 'admin@gmail.com', 01140000000,'DNI',NULL,NULL,1)


/* CREACION DE FUNCIONALIDADES */
INSERT INTO MISSINGNO.Funcionalidad (funcionalidad_id, descripcion)
	VALUES 
		(1, 'Gestionar roles'), 
		(2, 'Gestionar afiliados'), 
		(3, 'Comprar bonos'), 
		(4, 'Pedir turnos'), 
		(5, 'Registrar llegada para atencion'), 
		(6, 'Registrar resultado de atencion'), 
		(7, 'Cancelar turnos'), 
		(8, 'Estadisticas')
GO




/* ASIGNACION DE FUNCIONALIDADES A ROLES*/



--DECLARE @id = 
--INSERT INTO MISSINGNO.Administrador (funcionalidad_id)
--	VALUES (1), (2), (5), (8)

--SELECT funcionalidad_id FROM MISSINGNO.Profecional
--INSERT INTO MISSINGNO.Profesional (funcionalidad_id)
--	VALUES (6)--, (7)

--SELECT funcionalidad_id FROM MISSINGNO.Afiliado
--INSERT INTO MISSINGNO.Afiliado(funcionalidad_id)
--	VALUES (3)--, (4), (7)

--GO