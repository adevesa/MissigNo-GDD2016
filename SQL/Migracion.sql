USE GD2C2016
GO

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
DELETE FROM MISSINGNO.Sintoma;
DBCC CHECKIDENT ('MISSINGNO.Sintoma', RESEED, 0)
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
DBCC CHECKIDENT ('MISSINGNO.Funcionalidad', RESEED, 0)
GO
DELETE FROM MISSINGNO.Especialidad;
DBCC CHECKIDENT ('MISSINGNO.Especialidad', RESEED, 0)
GO
DELETE FROM MISSINGNO.Funcionalidad_de_rol;
DELETE FROM MISSINGNO.Rol;
DBCC CHECKIDENT ('MISSINGNO.Rol', RESEED, 0)
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
		 'admin@gmail.com',
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
		VALUES (3,3), (3,4), (3,7)

GO

/* pruebas */
select * from MISSINGNO.Usuario
select * from MISSINGNO.Rol
select * from MISSINGNO.Funcionalidad
select * from MISSINGNO.Rol_de_usuario
select * from MISSINGNO.Funcionalidad_de_rol
select U.username, F.Funcionalidad_nombre, R.rol_nombre from MISSINGNO.Usuario as U, MISSINGNO.Funcionalidad as F, MISSINGNO.Rol as R, MISSINGNO.Rol_de_usuario as RO, MISSINGNO.Funcionalidad_de_rol as FO
	where U.username = RO.username and
		  RO.rol_id = R.rol_id and
		  R.rol_id = FO.rol_id and
		  FO.funcionalidad_id = F.funcionalidad_id	
		  

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

INSERT INTO MISSINGNO.Afiliado(Paci_Usuario,Paci_Numero, Paci_Estado_Civil, Paci_Cant_Hijos, Paci_Plan) VALUES (@Existe, @Existe, 0, 0, @Plan)

INSERT INTO CHAMBA.Rol_X_Usuario (Rol_X_Usua_Usuario, Rol_X_Usua_Rol) VALUES (@Existe, @Rol)

FETCH NEXT FROM cursorPacientes INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac, @Plan
END
CLOSE cursorPacientes
DEALLOCATE cursorPacientes

