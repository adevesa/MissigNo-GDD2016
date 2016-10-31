USE GD2C2016
GO

-- EJECUTAR LOS DELETES MAS DE UNA VEZ ( DEBE HABER UN ERROR CON LAS PRECEDENCIAS)

DELETE FROM MISSINGNO.Usuario;
DELETE FROM MISSINGNO.Afiliado;
DBCC CHECKIDENT ('MISSINGNO.Afiliado', RESEED, 0)
GO
DELETE FROM MISSINGNO.Tipo_especialidad;
DELETE FROM MISSINGNO.Profesional;
DELETE FROM MISSINGNO.Administrativo;
DBCC CHECKIDENT ('MISSINGNO.Administrativo', RESEED, 0)
GO
DELETE FROM MISSINGNO.Especialidad_de_profesional;
DBCC CHECKIDENT ('MISSINGNO.Especialidad_de_profesional',RESEED,0)
GO
DELETE FROM MISSINGNO.Planes
DBCC CHECKIDENT ('MISSINGNO.Planes',RESEED,0)
GO
DELETE FROM MISSINGNO.Afiliado_Historial;
DBCC CHECKIDENT ('MISSINGNO.Afiliado_historial', RESEED, 0)
GO
DELETE FROM MISSINGNO.Agenda;
DBCC CHECKIDENT ('MISSINGNO.Agenda', RESEED, 0)
GO
DELETE FROM MISSINGNO.Dia;
DELETE FROM MISSINGNO.Consulta_medica;
DBCC CHECKIDENT ('MISSINGNO.Consulta_medica', RESEED, 0)
GO
DELETE FROM MISSINGNO.Compra_bono;
DBCC CHECKIDENT ('MISSINGNO.Compra_bono', RESEED, 0)
GO
DELETE FROM MISSINGNO.Bono;
DBCC CHECKIDENT ('MISSINGNO.Bono', RESEED, 0)
GO
DELETE FROM MISSINGNO.Turno;
DBCC CHECKIDENT ('MISSINGNO.Turno', RESEED, 0)
GO
DELETE FROM MISSINGNO.Cancelacion_turno;
DBCC CHECKIDENT ('MISSINGNO.Cancelacion_turno', RESEED, 0)
GO
DELETE FROM MISSINGNO.Funcionalidad;
DBCC CHECKIDENT ('MISSINGNO.Funcionalidad', RESEED, 1)
GO
DELETE FROM MISSINGNO.Especialidad;
DBCC CHECKIDENT ('MISSINGNO.Especialidad', RESEED, 0)
GO
DELETE FROM MISSINGNO.Funcionalidad_de_rol;
DELETE FROM MISSINGNO.Rol;
DBCC CHECKIDENT ('MISSINGNO.Rol', RESEED, 1)
GO
DELETE FROM MISSINGNO.Rol_de_usuario;

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

--VALORES MIGRADOS.
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
		'MIGRADO',
		-2, 
		HASHBYTES('SHA2_256', 'MIGRADO'),
		'MIGRADO',
		'MIGRADO',
		'16/01/1995',
		'M',
		'CASA MIGRADA',
		 'MIGRADO',
		 01140000000,
		 'DNI')

SET IDENTITY_INSERT MISSINGNO.Administrativo ON
INSERT INTO MISSINGNO.Administrativo(admin_id,username) VALUES(1,'admin')
SET IDENTITY_INSERT MISSINGNO.Administrativo OFF

SET IDENTITY_INSERT MISSINGNO.Tipo_especialidad ON
INSERT INTO MISSINGNO.Tipo_especialidad(tipo_especialidad_id,tipo_especialidad_desc) VALUES(-1,'MIGRADO')
SET IDENTITY_INSERT MISSINGNO.Tipo_especialidad OFF

SET IDENTITY_INSERT MISSINGNO.Especialidad ON
INSERT INTO MISSINGNO.Especialidad(especialidad_id,especialidad_descripcion,tipo_especialidad_id) VALUES(-1,'MIGRADO',-1)
SET IDENTITY_INSERT MISSINGNO.Especialidad OFF

SET IDENTITY_INSERT MISSINGNO.Profesional ON
INSERT INTO MISSINGNO.Profesional(profesional_id,username,profesional_matricula) VALUES(-1,'MIGRADO',-1)
SET IDENTITY_INSERT MISSINGNO.Profesional OFF

SET IDENTITY_INSERT MISSINGNO.Especialidad_de_profesional ON
INSERT INTO MISSINGNO.Especialidad_de_profesional(prof_esp_id,especialidad_id,profesional_id) VALUES(-1,-1,-1)
SET IDENTITY_INSERT MISSINGNO.Especialidad_de_profesional OFF


SET IDENTITY_INSERT MISSINGNO.Agenda ON
INSERT INTO MISSINGNO.Agenda(agenda_id,prof_esp_id,agenda_inicio,agenda_fin) VALUES(-1,-1,getdate(),getdate()) -- Valor migrado
SET IDENTITY_INSERT MISSINGNO.Agenda OFF


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

DECLARE @DNI numeric(18,0), @Nombre varchar(255), @Apellido varchar(255), @Domicilio varchar(255), @Telefono numeric(18,0), @Mail varchar(255), @Fec_nac datetime
DECLARE @Plan numeric(18,0)
DECLARE @Existe numeric(18,0)

/* DECLARACION PARA VARIABLE ROL */

DECLARE @Rol numeric(18,0)

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
		INSERT INTO MISSINGNO.Usuario (doc_nro, doc_tipo, nombre, apellido, domicilio, telefono, mail, fec_nac, sexo, username, contrasenia)
		VALUES (@DNI, '-', @Nombre, @Apellido, @Domicilio, @Telefono, @Mail, @Fec_nac, '-', @Mail, HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))))
		SET @Existe = @@IDENTITY
	END

IF(NOT EXISTS(SELECT username from MISSINGNO.Afiliado where username = @MAIL))
BEGIN
INSERT INTO MISSINGNO.Afiliado(username, afiliado_estado_civil, afiliado_encargado,plan_id, afiliado_baja_logica, afiliado_fec_baja) VALUES (@Mail, 0, NULL, @Plan,0, NULL)
END
INSERT INTO MISSINGNO.Rol_de_usuario(username, rol_id) VALUES (@Mail, @Rol)

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
FROM gd_esquema.Maestra, MISSINGNO.Afiliado A, MISSINGNO.Planes P
WHERE Compra_Bono_Fecha IS NOT NULL 
and A.username = Paciente_Mail 
and A.plan_id = Plan_Med_Codigo 
and P.plan_id = A.plan_id

/* MIGRACION DE BONOS */ 

SET IDENTITY_INSERT MISSINGNO.Bono ON
INSERT INTO MISSINGNO.Bono(bono_id, plan_id, afiliado_id, compra_bono_id, bono_estado, bono_precio)
SELECT DISTINCT Bono_Consulta_Numero, C.plan_id, C.afiliado_id, C.compra_bono_id, 0, Plan_Med_Precio_Bono_Consulta
	FROM gd_esquema.Maestra, MISSINGNO.Compra_bono C, MISSINGNO.Afiliado A, MISSINGNO.Planes P
	WHERE Compra_Bono_Fecha IS NOT NULL 
	and C.plan_id = Plan_Med_Codigo 
	and C.afiliado_id = A.afiliado_id 
	and A.username = Paciente_Mail 
	and P.plan_id = C.plan_id 
	and C.fecha_compra = Compra_Bono_Fecha
SET IDENTITY_INSERT MISSINGNO.Bono OFF
	
/* MIGRACION DE TURNOS */

SET IDENTITY_INSERT MISSINGNO.Turno ON
INSERT INTO MISSINGNO.Turno(turno_id, profesional_id, bono_id, fecha, horario)
SELECT DISTINCT Turno_Numero, P.profesional_id, Bono_Consulta_Numero,Turno_fecha,cast(Turno_Fecha as time)
FROM gd_esquema.Maestra, MISSINGNO.Profesional P, MISSINGNO.Bono B
WHERE Turno_Numero IS NOT NULL 
and Bono_Consulta_Numero IS NOT NULL
and P.username = Medico_Mail
and Bono_Consulta_Numero = B.bono_id
SET IDENTITY_INSERT MISSINGNO.Turno OFF

/* MIGRACION DE CONSULTAS MEDICAS */

INSERT INTO MISSINGNO.Consulta_medica(turno_id, sintoma, diagnostico, profesional_id, afiliado_id, agenda_id, consulta_horario, confirmacion_de_atencion)
SELECT Turno_Numero, Consulta_Sintomas, Consulta_Enfermedades,P.profesional_id,A.afiliado_id, -1, cast(Turno_Fecha as time),1
FROM gd_esquema.Maestra, MISSINGNO.Turno T, MISSINGNO.Profesional P, MISSINGNO.Afiliado A
WHERE Consulta_Sintomas IS NOT NULL
and Turno_Numero = T.turno_id
and P.username = Medico_Mail
and A.username = Paciente_Mail



/* PRUEBAS

SELECT * FROM MISSINGNO.Administrativo
SELECT * FROM MISSINGNO.Afiliado
SELECT * FROM MISSINGNO.Afiliado_historial
SELECT * FROM MISSINGNO.Agenda
SELECT * FROM MISSINGNO.Bono
SELECT * FROM MISSINGNO.Cancelacion_turno
SELECT * FROM MISSINGNO.Compra_bono
SELECT * FROM MISSINGNO.Consulta_medica
SELECT * FROM MISSINGNO.Dia
SELECT * FROM MISSINGNO.Especialidad
SELECT * FROM MISSINGNO.Especialidad_de_profesional A1, MISSINGNO.Especialidad A2, Missingno.profesional A3 where A1.PROFESIONAL_ID= A3.PROFESIONAL_ID AND A1.ESPECIALIDAD_ID = A2.ESPECIALIDAD_ID ORDER BY A3.USERNAME
SELECT * FROM MISSINGNO.Funcionalidad
SELECT * FROM MISSINGNO.Funcionalidad_de_rol
SELECT * FROM MISSINGNO.Planes
SELECT * FROM MISSINGNO.Profesional
SELECT * FROM MISSINGNO.Rol
SELECT * FROM MISSINGNO.Rol_de_usuario
SELECT * FROM MISSINGNO.Tipo_especialidad
SELECT * FROM MISSINGNO.Turno
SELECT * FROM MISSINGNO.Usuario

*/