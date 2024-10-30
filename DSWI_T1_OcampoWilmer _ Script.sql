-- DSW I - CASO DE LABORATORIO 1
-- Wilmer Ocampo Quispe - i202216252

USE Negocios2023
GO

/*
Pregunta 1:
Implementa una solución que permita listar los datos de la tabla tb_clientes de la base de datos Negocios2023
*/
CREATE OR ALTER PROC SP_Clientes
@n VARCHAR(60) = ''
AS
	SELECT C.IdCliente, C.NombreCia, C.Direccion, P.NombrePais, C.Telefono
    FROM tb_clientes C
	JOIN tb_paises P ON P.Idpais = C.idpais
    WHERE NombreCia LIKE '%' + @n + '%'
GO

EXEC SP_Clientes ''
GO

/*
Pregunta 2:
Sobre la solución creada en la pregunta 1, implemente lo necesario para listar los datos de la tabla tb_empleados de la base de datos Negocios2023
*/
CREATE OR ALTER PROC SP_Empleados
@n VARCHAR(60) = ''
AS
	SELECT E.IdEmpleado, E.NomEmpleado + SPACE(1) + E.ApeEmpleado NomCompleto, E.FecNac, E.DirEmpleado, E.idDistrito, E.fonoEmpleado, E.idCargo, E.FecContrata
    FROM tb_empleados E
    WHERE E.NomEmpleado LIKE '%' + @n + '%' OR E.ApeEmpleado LIKE '%' + @n + '%'
GO

EXEC SP_Empleados ''
GO

