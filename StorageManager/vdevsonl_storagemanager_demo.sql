-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране:  7 апр 2023 в 05:03
-- Версия на сървъра: 10.4.27-MariaDB
-- Версия на PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `vdevsonl_storagemanager_demo`
--

-- --------------------------------------------------------

--
-- Структура на таблица `currencies`
--

CREATE TABLE `currencies` (
  `currency_id` int(200) NOT NULL,
  `currency_type` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Структура на таблица `items`
--

CREATE TABLE `items` (
  `item_id` int(200) NOT NULL,
  `item_code` varchar(256) NOT NULL,
  `item_q_in_storage_id` int(200) NOT NULL,
  `item_location` varchar(256) NOT NULL,
  `item_name` varchar(256) NOT NULL,
  `item_price` double NOT NULL,
  `item_price_currency` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Схема на данните от таблица `items`
--

INSERT INTO `items` (`item_id`, `item_code`, `item_q_in_storage_id`, `item_location`, `item_name`, `item_price`, `item_price_currency`) VALUES
(1, 'SKU-253', 4, 'Бул 3-ти Март - Добрич', 'Слушалки Razer Kraken', 87, 'BGN'),
(2, 'SKU-254', 4, 'Бул 3-ти Март - Добрич', 'Слушалки Razer Barracuda X', 214, 'BGN');

-- --------------------------------------------------------

--
-- Структура на таблица `logs`
--

CREATE TABLE `logs` (
  `log_type` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `log_date` varchar(256) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `log_ip` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `log_status` tinyint(1) NOT NULL,
  `log_host` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Схема на данните от таблица `logs`
--

INSERT INTO `logs` (`log_type`, `log_date`, `log_ip`, `log_status`, `log_host`) VALUES
('ВПИСВАНЕ', '31.8.2022', '77.77.77.77', 1, 'Bergon EAD');

-- --------------------------------------------------------

--
-- Структура на таблица `storage_info`
--

CREATE TABLE `storage_info` (
  `storage_id` int(200) NOT NULL,
  `storage_location` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Схема на данните от таблица `storage_info`
--

INSERT INTO `storage_info` (`storage_id`, `storage_location`) VALUES
(1, 'Бул 3-ти Март - Добрич'),
(2, 'Генерал Гурко №9');

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE `users` (
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `name` varchar(256) NOT NULL,
  `phone_number` varchar(256) NOT NULL,
  `email` varchar(256) NOT NULL,
  `pinEnabled` tinyint(1) NOT NULL,
  `pin` int(200) NOT NULL,
  `admin_rights` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`username`, `password`, `name`, `phone_number`, `email`, `pinEnabled`, `pin`, `admin_rights`) VALUES
('dayofpay', 'fidelio7777', 'Vladislav Ivanov', '', 'support@v-devs.online', 0, 7777, 0),
('demo', 'demo', 'Demo User', '', 'demo@v-devs.online', 1, 7777, 1);

-- --------------------------------------------------------

--
-- Структура на таблица `users_details`
--

CREATE TABLE `users_details` (
  `user` varchar(256) NOT NULL,
  `user_workplace` varchar(256) NOT NULL,
  `user_position` varchar(256) NOT NULL,
  `user_salary` double NOT NULL,
  `user_can_edit_items` tinyint(1) NOT NULL,
  `user_salary_currency` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Схема на данните от таблица `users_details`
--

INSERT INTO `users_details` (`user`, `user_workplace`, `user_position`, `user_salary`, `user_can_edit_items`, `user_salary_currency`) VALUES
('dayofpay', 'Dobrich Bul 3-TI Mart', 'CEO', 7800, 1, 'BGN'),
('demo', 'Varna Bul. Vladislav Varnenchik', 'Moderator', 7800, 1, 'BGN');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `currencies`
--
ALTER TABLE `currencies`
  ADD PRIMARY KEY (`currency_id`);

--
-- Индекси за таблица `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_id`);

--
-- Индекси за таблица `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_type`);

--
-- Индекси за таблица `storage_info`
--
ALTER TABLE `storage_info`
  ADD PRIMARY KEY (`storage_id`);

--
-- Индекси за таблица `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- Индекси за таблица `users_details`
--
ALTER TABLE `users_details`
  ADD PRIMARY KEY (`user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
