-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 12:28 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbplaylist`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblagu`
--

CREATE TABLE `tblagu` (
  `kodeLagu` varchar(5) NOT NULL,
  `judulLagu` varchar(100) NOT NULL,
  `artis` varchar(100) NOT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `durasi` varchar(10) DEFAULT NULL,
  `linkSpotify` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblagu`
--

INSERT INTO `tblagu` (`kodeLagu`, `judulLagu`, `artis`, `genre`, `durasi`, `linkSpotify`) VALUES
('L001', '\'Cause You Have To', 'LANY', 'Pop', '4:11', 'https://open.spotify.com/track/1GZnoLPpR9p2CwclsZnOXD?si=74be71d6baa44bc6'),
('L002', 'Jatuh Suka', 'Tulus', 'Pop', '3:55', 'https://open.spotify.com/track/6PqWdGIYq5xdLaa4zCZfRp?si=4dcc2be509ec4b74'),
('L003', 'Labyrinth', 'Taylor Swift', 'Pop', '4:18', 'https://open.spotify.com/track/0A1JLUlkZkp2EFrosoNQi0?si=7c50e54b99924dc6'),
('L004', 'Pelangi', 'Hivi', 'Pop', '3:55', 'https://open.spotify.com/track/3ZwqWrRpylU9nfy99qwKdR?si=bc56eb83da7144d1'),
('L005', 'Red', 'Taylor Swift', 'Pop', '3:43', 'https://open.spotify.com/track/4OAuvHryIVv4kMDNSLuPt6?si=b8713965ceec404d');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblagu`
--
ALTER TABLE `tblagu`
  ADD PRIMARY KEY (`kodeLagu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
