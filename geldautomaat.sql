-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 01, 2020 at 09:45 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `geldautomaat`
--

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) UNSIGNED NOT NULL,
  `amount` decimal(20,2) NOT NULL,
  `type` varchar(45) NOT NULL,
  `description` longtext DEFAULT NULL,
  `created_at` date NOT NULL,
  `users_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`id`, `amount`, `type`, `description`, `created_at`, `users_id`) VALUES
(20, '100.00', 'deposit', NULL, '2020-10-11', 7),
(21, '100.00', 'withdraw', NULL, '2020-10-11', 7),
(22, '100.00', 'deposit', NULL, '2020-10-12', 7),
(23, '100.00', 'deposit', NULL, '2020-10-15', 7),
(24, '50.00', 'withdraw', NULL, '2020-10-15', 7),
(25, '150.00', 'withdraw', NULL, '2020-10-26', 7),
(26, '900.00', 'deposit', NULL, '2020-10-26', 7),
(27, '5.00', 'withdraw', NULL, '2020-11-01', 7),
(28, '10.00', 'withdraw', NULL, '2020-11-01', 7),
(29, '100.00', 'deposit', NULL, '2020-11-01', 7),
(30, '1000.00', 'deposit', NULL, '2020-11-01', 7),
(31, '50.00', 'withdraw', NULL, '2020-11-01', 7),
(32, '99999.00', 'deposit', NULL, '2020-11-01', 7);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `email` varchar(45) NOT NULL,
  `sex` varchar(45) NOT NULL,
  `birthday` date NOT NULL,
  `bsn_number` int(11) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `zipcode` varchar(45) NOT NULL,
  `town` varchar(45) NOT NULL,
  `pincode` varchar(64) NOT NULL,
  `account_number` int(11) NOT NULL,
  `balance` decimal(20,2) NOT NULL,
  `role` int(11) NOT NULL DEFAULT 0,
  `blocked` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `sex`, `birthday`, `bsn_number`, `first_name`, `last_name`, `address`, `zipcode`, `town`, `pincode`, `account_number`, `balance`, `role`, `blocked`) VALUES
(1, 'rheimer@icloud.com', 'male', '2001-08-23', 987498275, 'Rheimer', 'van Dijk', 'test', 'test', 'test', '9af15b336e6a9619928537df30b2e6a2376569fcf9d7e773eccede65606529a0', 0, '0.00', 1, 0),
(4, 'rheime@me.com', 'male', '2020-10-08', 23574, 'rheimer', 'van dijk', 'test', 'test', 'test', '6ae6efde2b863944726fbacc695fbbb845f870389acbb52c8ae81c683ab51fdf', 20675647, '0.00', 0, 0),
(5, 'thijmen@me.com', 'male', '2020-10-08', 2547892, 'thijmen', 'van dijk', 'test', 'tes', 'test', '5817ae4948371f9b6b7d94615c0704e6a13ba5a773938351ebd832d0fcdbdf2f', 68971954, '0.00', 0, 0),
(6, 'merel@me.com', 'female', '2020-10-08', 38721805, 'merel', 'peters', 'test', 'test', 'test', 'cb5611d87825a1dd6d0c724d68396193dc9d07a0db6a756d34b18bceea1aa46b', 23679112, '0.00', 0, 0),
(7, 'test@test', 'male', '2020-10-08', 92357843, 'test', 'test', 'test', 'test', 'test', 'f0f250b303d9994d2d71fbb6597b91085cd697ed00df19a5c40026493cb28c9a', 98114938, '101934.00', 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_transactions_users` (`users_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `fk_transactions_users` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
