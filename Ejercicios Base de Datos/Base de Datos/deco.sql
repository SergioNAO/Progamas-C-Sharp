-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 31-07-2023 a las 19:13:02
-- Versión del servidor: 5.7.24
-- Versión de PHP: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `deco`
--

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `InsertOrUpdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdate` (IN `parametro` INT, IN `temp_id` INT, IN `temp_nombre` VARCHAR(100), IN `temp_direccion` VARCHAR(100), IN `temp_ciudad` VARCHAR(100), IN `temp_estado` VARCHAR(100), IN `temp_pais` VARCHAR(100), IN `temp_division` INT)  BEGIN
    IF parametro = 1 THEN
        INSERT INTO Oficinas (ID, Nombre, Direccion, Ciudad, Estado, Pais, Division)
        VALUES (temp_id, temp_nombre, temp_direccion, temp_ciudad, temp_estado, temp_pais, temp_division);
    ELSE
        UPDATE Oficinas
        SET Direccion = temp_direccion
        WHERE ID = temp_id;
    END IF;
END$$

DROP PROCEDURE IF EXISTS `InsertOrUpdateOficina`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOrUpdateOficina` (IN `param_insert_update` INT, IN `param_id` INT, IN `param_nombre` VARCHAR(100), IN `param_direccion` VARCHAR(100), IN `param_ciudad` VARCHAR(100), IN `param_estado` VARCHAR(100), IN `param_pais` VARCHAR(100), IN `param_division` INT)  BEGIN
    IF param_insert_update = 1 THEN
        INSERT INTO Oficinas (ID, Nombre, Direccion, Ciudad, Estado, Pais, Division)
        VALUES (param_id, param_nombre, param_direccion, param_ciudad, param_estado, param_pais, param_division);
    ELSE
        UPDATE Oficinas
        SET Direccion = param_direccion
        WHERE ID = param_id;
    END IF;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `oficinas`
--

DROP TABLE IF EXISTS `oficinas`;
CREATE TABLE IF NOT EXISTS `oficinas` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Direccion` varchar(100) NOT NULL,
  `Ciudad` varchar(100) NOT NULL,
  `Estado` varchar(100) NOT NULL,
  `Pais` varchar(100) NOT NULL,
  `Division` int(11) NOT NULL,
  UNIQUE KEY `ID` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `oficinas`
--

INSERT INTO `oficinas` (`ID`, `Nombre`, `Direccion`, `Ciudad`, `Estado`, `Pais`, `Division`) VALUES
(1, 'Oficina Principal', 'Calle Procedure', 'Monterrey', 'Nuevo Leon', 'Mexico', 1),
(2, 'Oficina Sur', 'Calle Juarez 435', 'Merida', 'Yucatan', 'Mexico', 5),
(3, 'Oficina USA', '2101 Holly St', 'Austin', 'Texas', 'Estados Unidos', 7),
(4, 'Oficina Procedure', 'Calle Rosas', 'San Nicolas', 'Nuevo Leon', 'Mexico', 3),
(5, 'Oficina Trigger', 'Calle Tauro', 'San Pedro', 'Nuevo Leon', 'Mexico', 12);

--
-- Disparadores `oficinas`
--
DROP TRIGGER IF EXISTS `trg_InsertarID`;
DELIMITER $$
CREATE TRIGGER `trg_InsertarID` BEFORE INSERT ON `oficinas` FOR EACH ROW BEGIN
    SET New.ID = (SELECT IFNULL((SELECT MAX(ID) FROM Oficinas), 0) + 1);
END
$$
DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
