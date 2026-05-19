-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-05-2026 a las 07:53:18
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `plataformaeducativa`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateModuleStats` (IN `p_UserId` INT, IN `p_QuestionId` INT, IN `p_WasCorrect` BOOL)   BEGIN
    DECLARE v_ModuleId INT;
    DECLARE v_ScoreChange INT;
    DECLARE v_CorrectChange INT;
    DECLARE v_IncorrectChange INT;

    -- Obtener el módulo de la pregunta
    SELECT `ModuleID` INTO v_ModuleId FROM `Questions` WHERE `QuestionID` = p_QuestionId;

    -- Calcular los cambios según si fue correcta o no
    IF p_WasCorrect THEN
        SET v_ScoreChange = 10;
        SET v_CorrectChange = 1;
        SET v_IncorrectChange = 0;
    ELSE
        SET v_ScoreChange = -5;
        SET v_CorrectChange = 0;
        SET v_IncorrectChange = 1;
    END IF;

    -- Actualizar o insertar las estadísticas del módulo para el usuario
    INSERT INTO `UserModuleStats` (`UserID`, `ModuleID`, `CorrectCount`, `IncorrectCount`, `Score`)
    VALUES (p_UserId, v_ModuleId, v_CorrectChange, v_IncorrectChange, v_ScoreChange)
    ON DUPLICATE KEY UPDATE
        `CorrectCount` = `CorrectCount` + v_CorrectChange,
        `IncorrectCount` = `IncorrectCount` + v_IncorrectChange,
        `Score` = `Score` + v_ScoreChange;

    -- Actualizar la puntuación total del jugador (sin permitir valores negativos)
    UPDATE `Users`
    SET `Score` = GREATEST(`Score` + v_ScoreChange, 0)
    WHERE `UserID` = p_UserId;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modules`
--

CREATE TABLE `modules` (
  `ModuleID` int(11) NOT NULL,
  `ModuleName_Es` varchar(100) NOT NULL,
  `ModuleName_En` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `modules`
--

INSERT INTO `modules` (`ModuleID`, `ModuleName_Es`, `ModuleName_En`) VALUES
(1, 'Arquitectura del computador', 'Computer Architecture'),
(2, 'Antropología', 'Anthropology'),
(3, 'Cálculo', 'Calculus'),
(4, 'Ed. Fisica', 'Fisic Ed.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `options`
--

CREATE TABLE `options` (
  `OptionID` int(11) NOT NULL,
  `QuestionID` int(11) NOT NULL,
  `OptionText_Es` varchar(255) NOT NULL,
  `OptionText_En` varchar(255) NOT NULL,
  `IsCorrect` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `options`
--

INSERT INTO `options` (`OptionID`, `QuestionID`, `OptionText_Es`, `OptionText_En`, `IsCorrect`) VALUES
(33, 6, 'El análisis de los restos fósiles y herramientas de homínidos antiguos.', 'The analysis of fossil remains and tools of ancient hominids.', 0),
(34, 6, 'La naturaleza, esencia, origen y sentido último del ser humano.', 'The nature, essence, origin, and ultimate meaning of the human being.', 1),
(35, 6, 'Las estructuras económicas que rigen a las sociedades contemporáneas.', 'The economic structures that govern contemporary societies.', 0),
(36, 6, 'El estudio exclusivo del comportamiento de los primates superiores en cautiverio.', 'The exclusive study of the behavior of higher primates in captivity.', 0),
(37, 7, 'Immanuel Kant', 'Immanuel Kant', 0),
(38, 7, 'Jean-Paul Sartre', 'Jean-Paul Sartre', 0),
(39, 7, 'Max Scheler', 'Max Scheler', 1),
(40, 7, 'Friedrich Nietzsche', 'Friedrich Nietzsche', 0),
(41, 8, 'Capaz de fabricar herramientas, trabajar y modificar activamente su entorno material.', 'Capable of making tools, working, and actively modifying their material environment.', 1),
(42, 8, 'Que fundamenta toda su existencia y decisiones en la fe y la espiritualidad pura.', 'Who bases all their existence and decisions on pure faith and spirituality.', 0),
(43, 8, 'Caracterizado únicamente por la capacidad de emitir sonidos y lenguaje no articulado.', 'Characterized solely by the ability to emit sounds and non-articulated language.', 0),
(44, 8, 'Cuya única motivación vital es la contemplación pasiva de las ideas abstractas.', 'Whose only vital motivation is the passive contemplation of abstract ideas.', 0),
(45, 9, 'Estar totalmente determinada y fijada de antemano por las leyes biológicas de la genética.', 'Being totally determined and fixed in advance by the biological laws of genetics.', 0),
(46, 9, 'Ser un proyecto abierto y libre que se construye a sí mismo a través de sus elecciones.', 'Being an open and free project that builds itself through its own choices.', 1),
(47, 9, 'Seguir un destino preestablecido e inmutable diseñado por las fuerzas físicas del universo.', 'Following a pre-established and immutable destiny designed by the physical forces of the universe.', 0),
(48, 9, 'Carecer por completo de autoconciencia y capacidad de reflexión interna.', 'Completely lacking self-awareness and capacity for internal reflection.', 0),
(49, 10, 'La capacidad del ser humano de despegarse de la Tierra para alcanzar una realidad mística.', 'The ability of the human being to detach from Earth to reach a mystical reality.', 0),
(50, 10, 'Aquello que pertenece, permanece o se desarrolla dentro de los límites y la realidad del propio ser.', 'That which belongs, remains, or develops within the limits and reality of the being itself.', 1),
(51, 10, 'La desconexión absoluta que tiene la mente humana con respecto a los estímulos del cuerpo.', 'The absolute disconnection that the human mind has with respect to bodily stimuli.', 0),
(52, 10, 'La tendencia de las civilizaciones antiguas a no registrar sus conocimientos por escrito.', 'The tendency of ancient civilizations not to record their knowledge in writing.', 0),
(53, 11, '¿Qué puedo conocer con certeza?', 'What can I know with certainty?', 0),
(54, 11, '¿Qué me está permitido esperar en el futuro?', 'What am I permitted to hope for in the future?', 0),
(55, 11, '¿Qué es el ser humano?', 'What is the human being?', 1),
(56, 11, '¿Cómo se originó el cosmos físico?', 'How did the physical cosmos originate?', 0),
(57, 12, 'El cuerpo material y el alma/mente como dos sustancias distintas e independientes.', 'The material body and the soul/mind as two distinct and independent substances.', 1),
(58, 12, 'Una única sustancia puramente física y mecánica sin ningún tipo de pensamiento.', 'A single purely physical and mechanical substance without any kind of thought.', 0),
(59, 12, 'Energía social y lenguaje abstracto sin ninguna base de órganos biológicos.', 'Social energy and abstract language without any basis in biological organs.', 0),
(60, 12, 'Impulsos eléctricos combinados con la herencia de la cultura grecorromana.', 'Electrical impulses combined with the heritage of Greco-Roman culture.', 0),
(61, 13, 'El área neta acumulada bajo la curva de la función en ese punto.', 'The net area accumulated under the curve of the function at that point.', 0),
(62, 13, 'La pendiente de la recta tangente a la curva de la función en ese punto.', 'The slope of the tangent line to the curve of the function at that point.', 1),
(63, 13, 'La longitud total del arco de la curva medido desde el origen de coordenadas.', 'The total length of the arc of the curve measured from the origin.', 0),
(64, 13, 'El promedio aritmético de todos los valores que toma la función en su dominio.', 'The arithmetic mean of all the values that the function takes in its domain.', 0),
(65, 14, 'Operaciones completamente independientes que nunca se relacionan entre sí.', 'Completely independent operations that never relate to each other.', 0),
(66, 14, 'Operaciones inversas una de la otra, de manera similar a la multiplicación y división.', 'Inverse operations of each other, similar to multiplication and division.', 1),
(67, 14, 'Métodos que solo se pueden aplicar a funciones polinómicas de grado par.', 'Methods that can only be applied to polynomial functions of even degree.', 0),
(68, 14, 'Procedimientos algebraicos que arrojan exactamente el mismo resultado numérico.', 'Algebraic procedures that yield exactly the same numerical result.', 0),
(69, 15, 'f\'(x) = 3x^2 + 5', 'f\'(x) = 3x^2 + 5', 1),
(70, 15, 'f\'(x) = 3x + 5', 'f\'(x) = 3x + 5', 0),
(71, 15, 'f\'(x) = x^2 + 5x', 'f\'(x) = x^2 + 5x', 0),
(72, 15, 'f\'(x) = 3x^2 + 5x - 2', 'f\'(x) = 3x^2 + 5x - 2', 0),
(73, 16, 'La velocidad instantánea de un objeto en el segundo exacto \"a\".', 'The instantaneous velocity of an object at the exact second \"a\".', 0),
(74, 16, 'El área neta comprendida entre la gráfica de la función y el eje horizontal de las abscisas.', 'The net area between the graph of the function and the horizontal x-axis.', 1),
(75, 16, 'El valor exacto al que se aproxima una función cuando su variable tiende al infinito.', 'The exact value that a function approaches as its variable tends to infinity.', 0),
(76, 16, 'Los puntos exactos en donde la curva intersecta al eje vertical de las ordenadas.', 'The exact points where the curve intersects the vertical y-axis.', 0),
(77, 17, 'Derivable o diferenciable en el punto A.', 'Differentiable at point A.', 0),
(78, 17, 'Continua en el punto A.', 'Continuous at point A.', 1),
(79, 17, 'Creciente en sentido estricto en el punto A.', 'Strictly increasing at point A.', 0),
(80, 17, 'Una asíntota vertical en el punto A.', 'A vertical asymptote at point A.', 0),
(81, 18, '-\\sin(x) + C', '-\\sin(x) + C', 0),
(82, 18, '\\sin(x) + C', '\\sin(x) + C', 1),
(83, 18, '\\tan(x) + C', '\\tan(x) + C', 0),
(84, 18, '-\\cos(x) + C', '-\\cos(x) + C', 0),
(85, 19, 'La función alcanza obligatoriamente su valor máximo absoluto en todo el dominio.', 'The function necessarily reaches its absolute maximum value over the entire domain.', 0),
(86, 19, 'La curva cambia su sentido de concavidad (pasa de cóncava a convexa o viceversa).', ' The curve changes its concavity (goes from concave to convex or vice versa).', 1),
(87, 19, 'La función sufre una discontinuidad inevitable y se rompe la gráfica.', 'The function suffers an unavoidable discontinuity and the graph breaks.', 0),
(88, 19, 'La recta tangente se vuelve completamente vertical e infinita.', 'The tangent line becomes completely vertical and infinite.', 0),
(89, 20, 'El equilibrio estático y dinámico.', 'Static and dynamic balance.', 0),
(90, 20, 'La fuerza muscular.', 'Muscular strength.', 1),
(91, 20, 'La orientación temporo-espacial.', 'Temporal-spatial orientation.', 0),
(92, 20, 'La capacidad de sincronización del ritmo.', 'Rhythm synchronization ability.', 0),
(93, 21, 'Principio de continuidad del estímulo.', 'Principle of stimulus continuity.', 0),
(94, 21, 'Principio de sobrecarga progresiva.', 'Principle of progressive overload.', 1),
(95, 21, 'Principio de especificidad del ejercicio.', 'Principle of exercise specificity.', 0),
(96, 21, 'Principio de la recuperación biológica.', 'Principle of biological recovery.', 0),
(97, 22, 'Sistema aeróbico u oxidativo de grasas.', 'Aerobic or fat oxidative system.', 0),
(98, 22, 'Sistema anaeróbico aláctico (Fosfágenos / ATP-PC).', 'Anaerobic alactic system (Phosphagens / ATP-PC).', 1),
(99, 22, 'Sistema anaeróbico láctico (Glucólisis rápida).', 'Anaerobic lactic system (Fast glycolysis).', 0),
(100, 22, 'Sistema de beta-oxidación de aminoácidos estructurales.', 'Beta-oxidation system of structural amino acids.', 0),
(101, 23, 'La máxima flexibilidad de la articulación de la cadera.', 'Maximum flexibility of the hip joint.', 0),
(102, 23, 'La potencia muscular explosiva de los brazos.', 'Explosive muscular power of the arms.', 0),
(103, 23, 'La resistencia cardiorrespiratoria y estimar el VO2 máximo.', 'Cardiorespiratory endurance and estimate VO2 max.', 1),
(104, 23, 'La velocidad de reacción pura ante un estímulo visual.', 'Pure reaction speed to a visual stimulus.', 0),
(105, 24, 'Elevar de manera abrupta los niveles de la frecuencia cardíaca.', 'Abruptly raising heart rate levels.', 0),
(106, 24, 'Facilitar la remoción del ácido láctico y evitar síncopes por estancamiento sanguíneo.', 'Facilitating the removal of lactic acid and preventing fainting due to blood pooling.', 1),
(107, 24, 'Incrementar la rigidez protectora de los tendones principales.', 'Increasing the protective stiffness of the main tendons.', 0),
(108, 24, 'Forzar al cuerpo a subir la temperatura interna corporal central.', 'Forcing the body to raise its internal core temperature.', 0),
(109, 25, 'Efectuar rebotes balísticos repetitivos a la máxima velocidad posible.', 'Performing repetitive ballistic bounces at maximum possible speed.', 0),
(110, 25, 'Mantener una posición de elongación muscular fija asistida por una fuerza externa o gravedad sin movimiento.', 'Holding a fixed muscle elongation position assisted by an external force or gravity without movement.', 1),
(111, 25, 'Realizar gestos deportivos técnicos explosivos sin detenerse en ningún punto.', 'Performing explosive technical sports gestures without stopping at any point.', 0),
(112, 25, 'Contraer fuertemente el músculo opuesto de forma isométrica durante varios minutos.', 'Strongly contracting the opposite muscle isometrically for several minutes.', 0),
(113, 26, 'La división del peso expresado en kilogramos entre la altura medida en metros.', 'Dividing weight expressed in kilograms by height measured in meters.', 0),
(114, 26, 'La división del peso expresado en kilogramos entre el cuadrado de la altura medida en metros.', 'Dividing weight expressed in kilograms by the square of height measured in meters.', 1),
(115, 26, 'La multiplicación de la estatura por el porcentaje total de grasa corporal.', 'Multiplying height by the total percentage of body fat.', 0),
(116, 26, 'La resta del peso magro corporal menos la densidad ósea calculada.', 'Subtracting lean body mass minus calculated bone density.', 0),
(117, 27, 'Ejecutar los cálculos aritméticos matemáticos y las operaciones lógicas booleanas.', 'Execute mathematical arithmetic calculations and Boolean logical operations.', 0),
(118, 27, 'Almacenar de forma definitiva y permanente los archivos de datos del usuario.', 'Permanently and definitively store user data files.', 0),
(119, 27, 'Buscar, decodificar y coordinar la ejecución secuencial de las instrucciones de los programas.', 'Fetch, decode, and coordinate the sequential execution of program instructions.', 1),
(120, 27, 'Modificar los voltajes eléctricos provenientes de la fuente de poder externa.', 'Modify the electrical voltages coming from the external power supply.', 0),
(121, 28, 'Sustituir por completo las funciones de almacenamiento masivo del disco duro.', 'Completely replacing the mass storage functions of the hard drive.', 0),
(122, 28, 'Reducir el tiempo de acceso de la CPU a los datos de uso frecuente alojados en la memoria RAM principal.', 'Reducing the CPU\'s access time to frequently used data located in the main RAM memory.', 1),
(123, 28, 'Guardar permanentemente los datos del sistema operativo incluso cuando el equipo está apagado.', 'Permanently storing operating system data even when the computer is turned off.', 0),
(124, 28, 'Gestionar de forma autónoma la salida de gráficos tridimensionales hacia los monitores externos.', 'Autonomously managing the output of three-dimensional graphics to external monitors.', 0),
(125, 29, 'Emplear canales físicos y bloques de memoria totalmente separados para los datos y para las instrucciones.', 'Using physically separate channels and memory blocks for data and instructions.', 0),
(126, 29, 'Compartir el mismo espacio físico de memoria y los mismos canales de bus tanto para datos como para instrucciones.', 'Sharing the same physical memory space and the same bus channels for both data and instructions.', 1),
(127, 29, 'Ser una estructura puramente analógica basada en circuitos magnéticos fijos de lectura.', 'Being a purely analog structure based on fixed magnetic reading circuits.', 0),
(128, 29, 'Impedir la modificación de los datos una vez que se inicia el ciclo de reloj de la máquina.', 'Preventing data modification once the machine clock cycle begins.', 0),
(129, 30, 'Bus de Datos', 'Data Bus', 0),
(130, 30, 'Bus de Direcciones', 'Address Bus', 1),
(131, 30, 'Bus de Control', 'Control Bus', 0),
(132, 30, 'Bus de Alimentación Eléctrica', 'Power Bus', 0),
(133, 31, 'Reducir el tamaño físico de los registros internos de datos a la mitad.', 'Reducing the physical size of internal data registers by half.', 0),
(134, 31, 'Dividir el procesamiento de las instrucciones en etapas separadas para ejecutar múltiples instrucciones de forma solapada.', 'Dividing instruction processing into separate stages to execute multiple instructions in an overlapped manner.', 1),
(135, 31, 'Eliminar la memoria caché de nivel 1 cada vez que el programa efectúa un cálculo matemático complejo.', 'Eliminating level 1 cache memory every time the program performs a complex mathematical calculation.', 0),
(136, 31, 'Desactivar el reloj principal del sistema de hardware cuando la computadora entra en reposo.', 'Deactivating the main system clock when the computer goes into standby.', 0),
(137, 32, 'CISC implementa únicamente instrucciones lógicas binarias sencillas y RISC complejas de texto.', 'CISC implements only simple binary logical instructions, while RISC implements complex text instructions.', 0),
(138, 32, 'RISC prioriza un conjunto de instrucciones reducido, simple y de ejecución veloz en un ciclo, mientras CISC posee un repertorio amplio y complejo.', 'RISC prioritizes a reduced, simple instruction set that executes quickly in one cycle, while CISC has a broad and complex repertoire.', 1),
(139, 32, 'RISC carece por completo de registros internos de propósito general dentro del chip físico.', 'RISC completely lacks general-purpose internal registers within the physical chip.', 0),
(140, 32, 'CISC fue desarrollado de manera exclusiva para arquitecturas de supercomputadoras de tipo cuántico.', 'CISC was developed exclusively for quantum-type supercomputer architectures.', 0),
(141, 33, 'Registro de Instrucción (IR)', 'Instruction Register (IR)', 0),
(142, 33, 'Contador de Programa (PC / Program Counter)', 'Program Counter (PC)', 1),
(143, 33, 'Registro Acumulador de Datos (AC)', 'Accumulator Register (AC)', 0),
(144, 33, 'Registro de Banderas o Estado (SR)', 'Status Register (SR) or Flags Register', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `questions`
--

CREATE TABLE `questions` (
  `QuestionID` int(11) NOT NULL,
  `ModuleID` int(11) NOT NULL,
  `QuestionText_Es` text NOT NULL,
  `QuestionText_En` text NOT NULL,
  `ImagePath` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `questions`
--

INSERT INTO `questions` (`QuestionID`, `ModuleID`, `QuestionText_Es`, `QuestionText_En`, `ImagePath`) VALUES
(6, 2, '¿Cuál es el objeto de estudio central de la antropología filosófica?', 'What is the central object of study of philosophical anthropology?', NULL),
(7, 2, '¿Qué filósofo es considerado uno de los fundadores de la antropología filosófica moderna gracias a su obra \"El puesto del hombre en el cosmos\"?', 'Which philosopher is considered one of the founders of modern philosophical anthropology thanks to his work \"The Position of Man in the Cosmos\"?', NULL),
(8, 2, 'El concepto antropológico de \"Homo Faber\" define al ser humano principalmente como un ser:', 'The anthropological concept of \"Homo Faber\" defines the human being mainly as a being:', NULL),
(9, 2, 'Según la antropología de corte existencialista, la condición humana se caracteriza por:', 'According to existentialist anthropology, the human condition is characterized by:', NULL),
(10, 2, '¿Qué significa el término \"inmanencia\" al estudiar la naturaleza humana en la filosofía?', 'What does the term \"immanence\" mean when studying human nature in philosophy?', NULL),
(11, 2, 'Para Immanuel Kant, ¿cuál es la pregunta fundamental que engloba y da sentido a todo el campo de la filosofía?', 'For Immanuel Kant, what is the fundamental question that encompasses and gives meaning to the entire field of philosophy?', NULL),
(12, 2, 'El dualismo antropológico, defendido por pensadores como René Descartes, sostiene que el ser humano está compuesto por:', 'Anthropological dualism, defended by thinkers such as René Descartes, holds that the human being is composed of:', NULL),
(13, 3, '¿Qué representa geométricamente la derivada de una función matemática en un punto específico?', 'What does the derivative of a mathematical function at a specific point represent geometrically?', NULL),
(14, 3, 'De acuerdo con el Teorema Fundamental del Cálculo, las operaciones de integración y diferenciación (derivación) son:', 'According to the Fundamental Theorem of Calculus, the operations of integration and differentiation are:', NULL),
(15, 3, '¿Cuál es la primera derivada de la función f(x) = x^3 + 5x - 2?', 'What is the first derivative of the function f(x) = x^3 + 5x - 2?', NULL),
(16, 3, '¿Qué permite evaluar analíticamente una integral definida en un intervalo [a, b]?', 'What does a definite integral analytically evaluate over an interval [a, b]?', NULL),
(17, 3, 'Si el límite de una función cuando X tiende a un punto A es exactamente igual al valor evaluado de la función en ese punto (f(a)), se afirma que la función es:', 'If the limit of a function as X approaches a point A is exactly equal to the evaluated value of the function at that point (f(a)), the function is said to be:', NULL),
(18, 3, '¿Cuál es el resultado de la integral indefinida \\int \\cos(x) \\, dx?', 'What is the result of the indefinite integral \\int \\cos(x) \\, dx?', NULL),
(19, 3, 'En el análisis de gráficas de funciones, un punto de inflexión se define como aquel lugar geométrico donde:', 'In function graph analysis, an inflection point is defined as the location where:', NULL),
(20, 4, '¿Cuál de las siguientes opciones se clasifica estrictamente como una capacidad física condicional?', 'Which of the following options is strictly classified as a conditional physical capacity?', NULL),
(21, 4, 'El principio del entrenamiento deportivo que dicta que las cargas de trabajo deben incrementarse gradualmente para seguir obteniendo adaptaciones se conoce como:', 'The sports training principle that dictates that workload must be gradually increased to continue obtaining adaptations is known as:', NULL),
(22, 4, '¿Qué sistema energético celular predomina en el cuerpo humano durante una carrera de velocidad máxima de 50 metros que dura menos de 10 segundos?', 'Which cellular energy system predominates in the human body during a 50-meter maximum speed sprint lasting less than 10 seconds?', NULL),
(23, 4, 'En las pruebas de aptitud física, el famoso test de Course Navette (o test de Leger) se emplea principalmente para medir:', 'In physical fitness tests, the famous Course Navette test (or Léger test) is primarily used to measure:', NULL),
(24, 4, '¿Cuál es el beneficio fisiológico primordial de realizar una fase de \"vuelta a la calma\" o enfriamiento ligero al concluir una sesión intensa?', 'What is the primary physiological benefit of performing a \"cool-down\" phase or light recovery after an intense session?', NULL),
(25, 4, 'Un estiramiento de tipo \"estático pasivo\" se caracteriza por:', 'A \"passive static\" type of stretching is characterized by:', NULL),
(26, 4, 'El Índice de Masa Corporal (IMC) es un indicador antropométrico básico que se obtiene matemáticamente mediante:', 'The Body Mass Index (BMI) is a basic anthropometric indicator obtained mathematically by:', NULL),
(27, 1, '¿Cuál es la función principal de la Unidad de Control (UC) integrada dentro del microprocesador o CPU?', 'What is the main function of the Control Unit (CU) integrated within the microprocessor or CPU?', NULL),
(28, 1, 'La memoria caché intermedia de la CPU se implementa en la arquitectura del computador con la finalidad de:', 'The intermediate CPU cache memory is implemented in computer architecture for the purpose of:', NULL),
(29, 1, 'En la clásica arquitectura de Von Neumann, ¿cuál es una característica fundamental de su estructura de memoria?', 'In the classic Von Neumann architecture, what is a fundamental characteristic of its memory structure?', NULL),
(30, 1, '¿Qué tipo de bus de hardware se encarga de transportar la información que especifica la celda exacta de memoria o el periférico con el que la CPU desea comunicarse?', 'What type of hardware bus is responsible for carrying the information that specifies the exact memory cell or peripheral with which the CPU wishes to communicate?', NULL),
(31, 1, 'La técnica arquitectónica conocida como \"Pipelining\" o segmentación de instrucciones consiste en:', 'The architectural technique known as \"Pipelining\" or instruction pipelining consists of:', NULL),
(32, 1, '¿Cuál es la principal diferencia conceptual entre los procesadores con arquitectura RISC y aquellos con arquitectura CISC?', 'What is the main conceptual difference between processors with RISC architecture and those with CISC architecture?', NULL),
(33, 1, '¿Qué registro especializado de la CPU almacena temporalmente la dirección de memoria de la próxima instrucción que debe ser buscada para su posterior ejecución?', 'Which special CPU register temporarily stores the memory address of the next instruction to be fetched for execution?', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `userattempts`
--

CREATE TABLE `userattempts` (
  `AttemptID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `QuestionID` int(11) NOT NULL,
  `WasCorrect` tinyint(1) NOT NULL,
  `AttemptDate` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `userattempts`
--

INSERT INTO `userattempts` (`AttemptID`, `UserID`, `QuestionID`, `WasCorrect`, `AttemptDate`) VALUES
(11, 10, 27, 0, '2026-05-19 05:30:53'),
(12, 10, 28, 0, '2026-05-19 05:30:59'),
(13, 10, 29, 0, '2026-05-19 05:31:01'),
(14, 10, 30, 0, '2026-05-19 05:31:04'),
(15, 10, 31, 0, '2026-05-19 05:31:06'),
(16, 10, 32, 0, '2026-05-19 05:31:08'),
(17, 10, 33, 0, '2026-05-19 05:31:10'),
(18, 10, 6, 0, '2026-05-19 05:43:08');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usermodulestats`
--

CREATE TABLE `usermodulestats` (
  `StatID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `ModuleID` int(11) NOT NULL,
  `CorrectCount` int(11) DEFAULT 0,
  `IncorrectCount` int(11) DEFAULT 0,
  `Score` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usermodulestats`
--

INSERT INTO `usermodulestats` (`StatID`, `UserID`, `ModuleID`, `CorrectCount`, `IncorrectCount`, `Score`) VALUES
(5, 10, 2, 1, 1, 5),
(6, 10, 1, 0, 7, -35);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Role` enum('Admin','Jugador') NOT NULL,
  `Score` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`UserID`, `Username`, `PasswordHash`, `Role`, `Score`) VALUES
(1, 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Admin', 0),
(2, 'Luis', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Admin', 0),
(5, 'Ronny', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Admin', 0),
(10, 'ByPolse', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Jugador', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `modules`
--
ALTER TABLE `modules`
  ADD PRIMARY KEY (`ModuleID`);

--
-- Indices de la tabla `options`
--
ALTER TABLE `options`
  ADD PRIMARY KEY (`OptionID`),
  ADD KEY `QuestionID` (`QuestionID`);

--
-- Indices de la tabla `questions`
--
ALTER TABLE `questions`
  ADD PRIMARY KEY (`QuestionID`),
  ADD KEY `ModuleID` (`ModuleID`);

--
-- Indices de la tabla `userattempts`
--
ALTER TABLE `userattempts`
  ADD PRIMARY KEY (`AttemptID`),
  ADD UNIQUE KEY `unique_attempt` (`UserID`,`QuestionID`),
  ADD KEY `QuestionID` (`QuestionID`);

--
-- Indices de la tabla `usermodulestats`
--
ALTER TABLE `usermodulestats`
  ADD PRIMARY KEY (`StatID`),
  ADD UNIQUE KEY `unique_user_module` (`UserID`,`ModuleID`),
  ADD KEY `ModuleID` (`ModuleID`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `modules`
--
ALTER TABLE `modules`
  MODIFY `ModuleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `options`
--
ALTER TABLE `options`
  MODIFY `OptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=145;

--
-- AUTO_INCREMENT de la tabla `questions`
--
ALTER TABLE `questions`
  MODIFY `QuestionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `userattempts`
--
ALTER TABLE `userattempts`
  MODIFY `AttemptID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de la tabla `usermodulestats`
--
ALTER TABLE `usermodulestats`
  MODIFY `StatID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `options`
--
ALTER TABLE `options`
  ADD CONSTRAINT `options_ibfk_1` FOREIGN KEY (`QuestionID`) REFERENCES `questions` (`QuestionID`) ON DELETE CASCADE;

--
-- Filtros para la tabla `questions`
--
ALTER TABLE `questions`
  ADD CONSTRAINT `questions_ibfk_1` FOREIGN KEY (`ModuleID`) REFERENCES `modules` (`ModuleID`) ON DELETE CASCADE;

--
-- Filtros para la tabla `userattempts`
--
ALTER TABLE `userattempts`
  ADD CONSTRAINT `userattempts_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE,
  ADD CONSTRAINT `userattempts_ibfk_2` FOREIGN KEY (`QuestionID`) REFERENCES `questions` (`QuestionID`) ON DELETE CASCADE;

--
-- Filtros para la tabla `usermodulestats`
--
ALTER TABLE `usermodulestats`
  ADD CONSTRAINT `usermodulestats_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE,
  ADD CONSTRAINT `usermodulestats_ibfk_2` FOREIGN KEY (`ModuleID`) REFERENCES `modules` (`ModuleID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
