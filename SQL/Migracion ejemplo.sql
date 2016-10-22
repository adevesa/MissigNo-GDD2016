USE GD2C2016
GO


DELETE FROM CHAMBA.Rol_X_Usuario
DELETE FROM CHAMBA.Bonos
DELETE FROM CHAMBA.Compra_Bonos
DBCC CHECKIDENT ('CHAMBA.Compra_Bonos', RESEED, 0)
GO
DELETE FROM CHAMBA.Consultas
DELETE FROM CHAMBA.Turnos
DELETE FROM CHAMBA.Tipo_Especialidad_X_Profesional
DELETE FROM CHAMBA.Profesionales
DELETE FROM CHAMBA.Pacientes
DELETE FROM CHAMBA.Usuarios
DBCC CHECKIDENT ('CHAMBA.Usuarios', RESEED, 0)
GO
DELETE FROM CHAMBA.Planes
DELETE FROM CHAMBA.Tipo_Especialidad
DELETE FROM CHAMBA.Especialidades
DELETE FROM CHAMBA.Funcionalidad_X_Rol
DELETE FROM CHAMBA.Funcionalidades
DELETE FROM CHAMBA.Roles
DBCC CHECKIDENT ('CHAMBA.Roles', RESEED, 0)
GO
/* CREACION DE ROLES */

INSERT INTO CHAMBA.Roles (Rol_Nombre, Rol_Estado) VALUES ('Administrativo', 1), ('Profesional', 1), ('Afiliado', 1)

INSERT INTO CHAMBA.Usuarios (Usua_Usuario, Usua_Clave, Usua_Nombre, Usua_Intentos) VALUES ('admin', HASHBYTES('SHA2_256', 'w23e'), 'Administrador General', 0)

INSERT INTO CHAMBA.Rol_X_Usuario(Rol_X_Usua_Usuario, Rol_X_Usua_Rol) VALUES ((SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_Usuario = 'admin'), (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Administrativo'))

/* CREACION DE FUNCIONALIDADES */
INSERT INTO CHAMBA.Funcionalidades (Func_Id, Func_Descripcion) VALUES (1, 'Gestionar roles'), (2, 'Gestionar afiliados'), (3, 'Comprar bonos'), (4, 'Pedir turnos'), (5, 'Registrar llegada para atencion'), (6, 'Registrar resultado de atencion'), (7, 'Cancelar turnos'), (8, 'Estadisticas')

/* ASIGNACION DE FUNCIONALIDADES A ROLES*/
DECLARE @Rol numeric(18,0) = (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Administrativo')

INSERT INTO CHAMBA.Funcionalidad_X_Rol (Func_X_Rol_Rol, Func_X_Rol_Funcionalidad) VALUES (@Rol, 1), (@Rol, 2), (@Rol, 5), (@Rol, 8)

SET @Rol = (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Profesional')
INSERT INTO CHAMBA.Funcionalidad_X_Rol (Func_X_Rol_Rol, Func_X_Rol_Funcionalidad) VALUES (@Rol, 6), (@Rol, 7)

SET @Rol = (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Afiliado')
INSERT INTO CHAMBA.Funcionalidad_X_Rol (Func_X_Rol_Rol, Func_X_Rol_Funcionalidad) VALUES (@Rol, 3), (@Rol, 4), (@Rol, 7)

/* MIGRACION DE ESPECIALIDADES */

INSERT INTO CHAMBA.Especialidades (Espe_Codigo, Espe_Descripcion)
SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion 
FROM gd_esquema.Maestra
WHERE Especialidad_Codigo IS NOT NULL

/* MIGRACION DE TIPOS DE ESPECIALIDAD */

DECLARE @Temp numeric(18,0)

INSERT INTO CHAMBA.Tipo_Especialidad (Tipo_Espe_Codigo, Tipo_Espe_Descripcion, Tipo_Espe_Especialidad)
SELECT CAST(CAST(Especialidad_Codigo AS VARCHAR(18)) + CAST(Tipo_Especialidad_Codigo AS VARCHAR(18)) AS NUMERIC(18,0)), Tipo_Especialidad_Descripcion, Especialidad_Codigo 
FROM gd_esquema.Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL
GROUP BY Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion, Especialidad_Codigo 

/* MIGRACION DE PLANES */

INSERT INTO CHAMBA.Planes (Plan_Codigo, Plan_Descripcion, Plan_Precio_Bono_Consulta, Plan_Precio_Bono_Farmacia)
SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia 
FROM gd_esquema.Maestra
WHERE Plan_Med_Codigo IS NOT NULL


/* DECLARACION DE VARIABLES PARA CURSORES */

DECLARE @DNI numeric(18,0), @Nombre varchar(255), @Apellido varchar(255), @Direccion varchar(255), @Telefono numeric(18,0), @Mail varchar(255), @Fecha_Nac datetime
DECLARE @Plan numeric(18,0)
DECLARE @Existe numeric(18,0)

/* DECLARACION DE CURSOR DE PACIENTES */

DECLARE cursorPacientes CURSOR FOR SELECT DISTINCT Paciente_DNI, Paciente_Nombre, Paciente_Apellido, Paciente_Direccion, Paciente_Telefono, Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo
FROM gd_esquema.Maestra
WHERE Paciente_DNI IS NOT NULL


/* MIGRACION DE PACIENTES */

SET @Rol = (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Afiliado')

OPEN cursorPacientes
FETCH NEXT FROM cursorPacientes INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac, @Plan
WHILE @@FETCH_STATUS=0
BEGIN

SET @Existe = NULL

SELECT @Existe = Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = @DNI

IF (@Existe IS NULL) 
	BEGIN
		INSERT INTO CHAMBA.Usuarios (Usua_DNI, Usua_TipoDNI, Usua_Nombre, Usua_Apellido, Usua_Direccion, Usua_Telefono, Usua_Mail, Usua_Fecha_Nac, Usua_Sexo, Usua_Usuario, Usua_Clave, Usua_Intentos)
		VALUES (@DNI, 0, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac, 'M', @Mail, HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))), 0)
		SET @Existe = @@IDENTITY
	END

INSERT INTO CHAMBA.Pacientes (Paci_Usuario, Paci_Numero, Paci_Estado_Civil, Paci_Cant_Hijos, Paci_Plan) VALUES (@Existe, @Existe, 0, 0, @Plan)

INSERT INTO CHAMBA.Rol_X_Usuario (Rol_X_Usua_Usuario, Rol_X_Usua_Rol) VALUES (@Existe, @Rol)

FETCH NEXT FROM cursorPacientes INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac, @Plan
END
CLOSE cursorPacientes
DEALLOCATE cursorPacientes

/* DECLARACION DE CURSOR DE PROFESIONALES */

DECLARE cursorMedicos CURSOR FOR SELECT DISTINCT Medico_DNI, Medico_Nombre, Medico_Apellido, Medico_Direccion, Medico_Telefono, Medico_Mail, Medico_Fecha_Nac
FROM gd_esquema.Maestra
WHERE Medico_DNI IS NOT NULL


/* MIGRACION DE PROFESIONALES */

SET @Rol = (SELECT Rol_Id FROM CHAMBA.Roles WHERE Rol_Nombre = 'Profesional')

OPEN cursorMedicos
FETCH NEXT FROM cursorMedicos INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac
WHILE @@FETCH_STATUS=0
BEGIN

SET @Existe = NULL

SELECT @Existe = Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = @DNI

IF (@Existe IS NULL)
	BEGIN
		INSERT INTO CHAMBA.Usuarios (Usua_DNI, Usua_TipoDNI, Usua_Nombre, Usua_Apellido, Usua_Direccion, Usua_Telefono, Usua_Mail, Usua_Fecha_Nac, Usua_Sexo, Usua_Usuario, Usua_Clave, Usua_Intentos)
		VALUES (@DNI, 0, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac, 'M', @Mail, HASHBYTES('SHA2_256', CAST(@DNI AS VARCHAR(18))), 0)
		SET @Existe = @@IDENTITY
	END

INSERT INTO CHAMBA.Profesionales (Prof_Usuario) VALUES (@Existe)

INSERT INTO CHAMBA.Rol_X_Usuario (Rol_X_Usua_Usuario, Rol_X_Usua_Rol) VALUES (@Existe, @Rol)


FETCH NEXT FROM cursorMedicos INTO @DNI, @Nombre, @Apellido, @Direccion, @Telefono, @Mail, @Fecha_Nac
END
CLOSE cursorMedicos
DEALLOCATE cursorMedicos


/* MIGRACION DE TIPO_ESPECIALIDAD_X_PROFESIONAL */

INSERT INTO CHAMBA.Tipo_Especialidad_X_Profesional (Tipo_Espec_X_Pof_Tipo_Especialidad, Tipo_Espec_X_Prof_Profesional)
SELECT CAST(CAST(Especialidad_Codigo AS VARCHAR(18)) + CAST(Tipo_Especialidad_Codigo AS VARCHAR(18)) AS NUMERIC(18,0)), (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = Medico_DNI) FROM
(SELECT DISTINCT Especialidad_Codigo, Tipo_Especialidad_Codigo, Medico_DNI
FROM gd_esquema.Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL) AS S1


/* MIGRACION DE TURNOS */

INSERT INTO CHAMBA.Turnos (Turn_Numero, Turn_Fecha, Turn_Paciente, Turn_Profesional)
SELECT DISTINCT Turno_Numero, Turno_Fecha, (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = Paciente_DNI), (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = Medico_DNI)
FROM gd_esquema.Maestra
WHERE Turno_Numero IS NOT NULL


/* MIGRACION DE CONSULTAS */

INSERT INTO CHAMBA.Consultas (Cons_Turno, Cons_Sintoma, Cons_Diagnostico)
SELECT Turno_Numero, Consulta_Sintomas, Consulta_Enfermedades
FROM gd_esquema.Maestra
WHERE Consulta_Sintomas IS NOT NULL


/* MIGRACION DE COMPRA DE BONOS */

INSERT INTO CHAMBA.Compra_Bonos(Comp_Bono_Fecha, Comp_Bono_Paciente, Comp_Bono_Plan)
SELECT DISTINCT Compra_Bono_Fecha, (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = Paciente_DNI), Plan_Med_Codigo
FROM gd_esquema.Maestra
WHERE Compra_Bono_Fecha IS NOT NULL

/* MIGRACION DE BONOS */

INSERT INTO CHAMBA.Bonos(Bono_Compra, Bono_Numero, Bono_Valor, Bono_Fecha_Impresion)
SELECT DISTINCT (SELECT Comp_Bono_Id FROM CHAMBA.Compra_Bonos WHERE Comp_Bono_Fecha = Compra_Bono_Fecha AND Comp_Bono_Paciente = (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = Paciente_DNI) AND Comp_Bono_Plan = Plan_Med_Codigo), Bono_Consulta_Numero, Plan_Med_Precio_Bono_Consulta, Bono_Consulta_Fecha_Impresion
FROM gd_esquema.Maestra
WHERE Compra_Bono_Fecha IS NOT NULL

UPDATE CHAMBA.Bonos SET Bono_Turno_Uso = i.Turno_Numero, Bono_Paciente_Uso = (SELECT Usua_Id FROM CHAMBA.Usuarios WHERE Usua_DNI = i.Paciente_DNI)
FROM 
	(SELECT Turno_Numero, Paciente_DNI, Bono_Consulta_Numero FROM gd_esquema.Maestra) AS i 
WHERE CHAMBA.Bonos.Bono_Numero = i.Bono_Consulta_Numero 