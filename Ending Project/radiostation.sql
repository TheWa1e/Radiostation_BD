-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 17 2020 г., 10:38
-- Версия сервера: 10.3.13-MariaDB-log
-- Версия PHP: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `radiostation`
--

-- --------------------------------------------------------

--
-- Структура таблицы `artist`
--

CREATE TABLE `artist` (
  `id_artist` smallint(11) NOT NULL,
  `name` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `artist`
--

INSERT INTO `artist` (`id_artist`, `name`, `description`) VALUES
(1, 'Виктор Цой', 'Советский рок-музыкант, автор песен и художник. Основатель и лидер рок-группы «Кино», в которой пел, играл на гитаре и являлся автором песен. Кроме этого, снялся также в нескольких фильмах.'),
(2, 'Вячеслав Бутусов', 'Советский и российский рок-музыкант, лидер и вокалист рок-групп Nautilus Pompilius и «Ю-Питер» и новой группы «Орден Славы» и «Орден Феникса».'),
(3, 'Андрей Макаревич', 'Советский и российский музыкант, певец, поэт, бард, композитор, художник, продюсер, телеведущий, актёр, лидер, основатель и единственный бессменный участник рок-группы «Машина времени».'),
(4, 'Юрий Шевчук', 'Советский и российский рок-музыкант, автор песен, поэт, актёр, художник, продюсер и общественный деятель. Основатель, лидер и единственный бессменный участник группы ДДТ.'),
(5, 'Александр Васильев', 'Российский рок-музыкант, певец, гитарист, поэт, композитор, автор-исполнитель песен, основатель и бессменный лидер группы «Сплин».');

-- --------------------------------------------------------

--
-- Структура таблицы `customers`
--

CREATE TABLE `customers` (
  `id_customers` smallint(6) NOT NULL,
  `full_name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `employees`
--

CREATE TABLE `employees` (
  `id_employees` smallint(11) NOT NULL,
  `full_name` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `age` int(2) NOT NULL,
  `gender` varchar(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `serial_and_number` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `place_of_issue` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `date_issue` date NOT NULL,
  `id_position` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `employees`
--

INSERT INTO `employees` (`id_employees`, `full_name`, `age`, `gender`, `address`, `phone`, `serial_and_number`, `place_of_issue`, `date_issue`, `id_position`) VALUES
(1, 'Сотрудник_1', 18, 'м', 'Адрес_2', '79998423677', '1207 147312', 'УМВД в г.Тула', '2005-11-14', 2),
(2, 'Сотрудник_2', 24, 'ж', 'Адрес_2', '79998887777', '1204 132452', 'УМВД в г.Тула', '2010-11-14', 5),
(3, 'Сотрудник_3', 32, 'м', 'Адрес_3', '79207777211', '1140 614877', 'УМВД в г.Тула', '2006-04-12', 4),
(4, 'Сотрудник_4', 19, 'м', 'Адрес_4', '79997707157', '1300 754523', 'УМВД в г.Тула', '2017-08-15', 2),
(5, 'Сотрудник_5', 22, 'м', 'Адрес_5', '79057347211', '1201 614817', 'УМВД в г.Тула', '2011-04-02', 1),
(6, 'Сотрудник_6', 26, 'м', 'Адрес_6', '79107677211', '1470 514217', 'УМВД в г.Тула', '2002-06-12', 3),
(7, 'Сотрудник_7', 28, 'ж', 'Адрес_7', '79537757211', '1770 414879', 'УМВД в г.Тула', '2005-07-11', 5),
(8, 'Сотрудник_8', 31, 'м', 'Адрес_8', '79597657211', '1910 313277', 'УМВД в г.Тула', '2009-10-17', 4),
(9, 'Сотрудник_9', 20, 'ж', 'Адрес_9', '79209546211', '2040 914696', 'УМВД в г.Тула', '2003-08-12', 5),
(10, 'Сотрудник_10', 30, 'ж', 'Адрес_10', '79207745511', '1240 614877', 'УМВД в г.Тула', '2006-04-13', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `generes`
--

CREATE TABLE `generes` (
  `id_genere` smallint(6) NOT NULL,
  `name` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `generes`
--

INSERT INTO `generes` (`id_genere`, `name`, `description`) VALUES
(1, 'Пост-панк', 'Жанр рок-музыки, сложившийся в конце 1970-х годов в Великобритании как продолжение панк-рока.'),
(2, 'Симфорок', 'Стиль рок-музыки, разновидность прогрессивного рока. Термин был предложен для обозначения прогрессивных групп, более всего сориентированных на академический подход к музыке.'),
(3, 'Фолк-рок', 'Музыкальное направление, объединяющее элементы народной музыки и рока.'),
(4, 'Альтернативный рок', 'Жанр рок-музыки, сформировавшийся из музыкального андеграунда 1980-х и ставший популярным в 1990-е и 2000-е годы. В данном случае слово «альтернатива» подразумевает антитезу мейнстримовой рок-музыке'),
(5, 'Ритм-энд-блюз', 'Стиль популярной музыки афроамериканцев, включающий элементы блюза. Изначально, обобщённое название массовой музыки, основанной на блюзовых и джазовых направлениях 1930—1940-х годов');

-- --------------------------------------------------------

--
-- Структура таблицы `positions`
--

CREATE TABLE `positions` (
  `id_position` smallint(6) NOT NULL,
  `name_position` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `salary` float DEFAULT NULL,
  `duties` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `demands` text COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `positions`
--

INSERT INTO `positions` (`id_position`, `name_position`, `salary`, `duties`, `demands`) VALUES
(1, 'Выпускающий редактор', 15000, 'Обязанность_1', 'Требование_1'),
(2, 'Редактор', 25000, 'Обязанность_2', 'Требование_2'),
(3, 'Администратор', 25000, 'Обязанность_3', 'Требование_3'),
(4, 'Звукорежиссер', 15000, 'Обязанность_4', 'Требование_4'),
(5, 'Менеджер по персоналу', 20000, 'Обязанность_4', 'Требование_4');

-- --------------------------------------------------------

--
-- Структура таблицы `records`
--

CREATE TABLE `records` (
  `id_record` smallint(6) NOT NULL,
  `name` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_artist` smallint(11) NOT NULL,
  `album` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `year` year(4) DEFAULT NULL,
  `id_genere` smallint(6) NOT NULL,
  `date_recording` date NOT NULL,
  `duration` time NOT NULL,
  `rating` float DEFAULT NULL,
  `id_customers` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `records`
--

INSERT INTO `records` (`id_record`, `name`, `id_artist`, `album`, `year`, `id_genere`, `date_recording`, `duration`, `rating`, `id_customers`) VALUES
(1, 'Запись_1', 5, 'Ключ к шифру', 2016, 3, '2018-11-16', '01:19:21', 7.3, 0),
(2, 'Запись_2', 1, 'Ночь', 1985, 1, '2010-03-05', '02:19:21', 8.4, 1),
(3, 'Запись_3', 1, 'Последний герой', 1989, 1, '2002-01-01', '01:19:31', 6.4, 1),
(4, 'Запись_4', 2, 'Яблокитай', 1996, 2, '2005-02-16', '01:19:22', 6.8, 1),
(5, 'Запись_5', 2, 'Князь тишины', 2016, 2, '2006-02-16', '01:29:13', 7.9, 1),
(6, 'Запись_6', 2, 'Крылья', 2007, 2, '2007-03-01', '01:39:54', 4.5, 1),
(7, 'Запись_7', 4, 'Мир номер ноль', 1999, 4, '2009-04-09', '01:49:45', 5.6, 1),
(8, 'Запись_8', 3, 'В круге света', 1988, 5, '2010-05-08', '01:59:36', 6.8, 1),
(9, 'Запись_9', 3, 'В добрый час', 1986, 5, '2011-06-06', '01:19:27', 9.1, 1),
(10, 'Запись_10', 3, 'Реки и мосты', 1987, 5, '2012-07-14', '01:29:18', 8.2, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `records_list`
--

CREATE TABLE `records_list` (
  `id_records` smallint(6) NOT NULL,
  `code_records_1` smallint(6) NOT NULL,
  `time_records_1` time NOT NULL,
  `code_records_2` smallint(6) NOT NULL,
  `time_records_2` time NOT NULL,
  `code_records_3` smallint(6) NOT NULL,
  `time_records_3` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `records_list`
--

INSERT INTO `records_list` (`id_records`, `code_records_1`, `time_records_1`, `code_records_2`, `time_records_2`, `code_records_3`, `time_records_3`) VALUES
(1, 1, '01:19:21', 2, '02:19:21', 3, '01:19:31'),
(2, 1, '01:19:22', 2, '01:29:13', 3, '01:39:54'),
(3, 1, '01:49:45', 2, '01:59:36', 3, '01:19:27'),
(4, 1, '01:19:25', 2, '01:29:26', 3, '01:39:37'),
(5, 1, '01:29:27', 2, '01:35:29', 3, '01:34:49'),
(6, 1, '01:21:57', 2, '01:25:21', 3, '01:44:47'),
(7, 1, '01:39:29', 2, '01:45:49', 3, '01:54:31'),
(8, 1, '01:19:27', 2, '01:25:29', 3, '01:44:49'),
(9, 1, '01:29:41', 2, '01:35:33', 3, '01:34:51'),
(10, 1, '01:47:32', 2, '01:31:27', 3, '01:56:21');

-- --------------------------------------------------------

--
-- Структура таблицы `tbluser`
--

CREATE TABLE `tbluser` (
  `id` int(11) NOT NULL,
  `user` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pass` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `tbluser`
--

INSERT INTO `tbluser` (`id`, `user`, `pass`) VALUES
(1, 'admin', 'admin'),
(2, 'personnel _department', '12345'),
(3, 'editor', '67891'),
(4, 'сommissioning_editor', '01112');

-- --------------------------------------------------------

--
-- Структура таблицы `working_list`
--

CREATE TABLE `working_list` (
  `id_employee` smallint(6) NOT NULL,
  `date` date NOT NULL,
  `id_records` smallint(6) DEFAULT NULL,
  `time_records` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `working_list`
--

INSERT INTO `working_list` (`id_employee`, `date`, `id_records`, `time_records`) VALUES
(1, '2020-11-07', 1, '00:41:01'),
(2, '2020-11-08', 2, '00:29:02'),
(3, '2020-11-09', 3, '00:37:03'),
(4, '2020-11-10', 4, '00:38:04'),
(5, '2020-11-11', 5, '00:47:05'),
(6, '2020-11-12', 6, '00:54:06'),
(7, '2020-11-13', 7, '00:58:07'),
(8, '2020-11-14', 8, '00:47:08'),
(9, '2020-11-15', 9, '00:35:09'),
(10, '2020-11-16', 10, '00:26:10');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `artist`
--
ALTER TABLE `artist`
  ADD PRIMARY KEY (`id_artist`);

--
-- Индексы таблицы `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id_customers`);

--
-- Индексы таблицы `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id_employees`);

--
-- Индексы таблицы `generes`
--
ALTER TABLE `generes`
  ADD PRIMARY KEY (`id_genere`);

--
-- Индексы таблицы `positions`
--
ALTER TABLE `positions`
  ADD PRIMARY KEY (`id_position`);

--
-- Индексы таблицы `records`
--
ALTER TABLE `records`
  ADD PRIMARY KEY (`id_record`);

--
-- Индексы таблицы `records_list`
--
ALTER TABLE `records_list`
  ADD PRIMARY KEY (`id_records`);

--
-- Индексы таблицы `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `working_list`
--
ALTER TABLE `working_list`
  ADD PRIMARY KEY (`id_employee`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `artist`
--
ALTER TABLE `artist`
  MODIFY `id_artist` smallint(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `generes`
--
ALTER TABLE `generes`
  MODIFY `id_genere` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `positions`
--
ALTER TABLE `positions`
  MODIFY `id_position` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `records`
--
ALTER TABLE `records`
  MODIFY `id_record` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `records_list`
--
ALTER TABLE `records_list`
  MODIFY `id_records` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
