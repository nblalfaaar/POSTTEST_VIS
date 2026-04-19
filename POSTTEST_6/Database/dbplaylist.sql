-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2026 at 08:16 AM
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
  `linkSpotify` varchar(255) DEFAULT NULL,
  `kodePlaylist` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblagu`
--

INSERT INTO `tblagu` (`kodeLagu`, `judulLagu`, `artis`, `genre`, `durasi`, `linkSpotify`, `kodePlaylist`) VALUES
('L001', 'Jatuh Suka', 'Tulus', 'Pop', '3:55', 'https://open.spotify.com/track/6PqWdGIYq5xdLaa4zCZfRp?si=0f60395d839c4e51', 'P001'),
('L002', 'WIsh List', 'Taylor Swift', 'Dance-pop', '3:27', 'https://open.spotify.com/track/2TEQvxxQabwLQMqWMg1qGu?si=0f68dc0db7c546b9', 'P001'),
('L003', 'Cinta Sendiri', 'Kahitna', 'Pop dan Jazz', '4:14', 'https://open.spotify.com/track/0pX5IztL39thiVjIlb2ksW?si=54673a6661b2444e', 'P002'),
('L004', '\'Cause You Have To', 'LANY', 'Pop Alternatif', '4:11', 'https://open.spotify.com/track/1GZnoLPpR9p2CwclsZnOXD?si=425910c257174571', 'P002'),
('L005', 'Soft Spot', 'Keshi', 'Pop Alternatif', '3:24', 'https://open.spotify.com/track/2aL4lMGhWdPpyPL6COPou7?si=40ca58d2b0a546fe', 'P001');

-- --------------------------------------------------------

--
-- Table structure for table `tbplaylist`
--

CREATE TABLE `tbplaylist` (
  `kodePlaylist` varchar(5) NOT NULL,
  `namaPlaylist` varchar(100) NOT NULL,
  `deskripsi` varchar(255) DEFAULT NULL,
  `tanggalDibuat` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbplaylist`
--

INSERT INTO `tbplaylist` (`kodePlaylist`, `namaPlaylist`, `deskripsi`, `tanggalDibuat`) VALUES
('P001', 'Happy', 'Yang senang senang aja', '2026-04-19'),
('P002', 'Sad bgt', 'Yang sedih-sedih aja', '2026-04-19');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblagu`
--
ALTER TABLE `tblagu`
  ADD PRIMARY KEY (`kodeLagu`),
  ADD KEY `fk_lagu_playlist` (`kodePlaylist`);

--
-- Indexes for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  ADD PRIMARY KEY (`kodePlaylist`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblagu`
--
ALTER TABLE `tblagu`
  ADD CONSTRAINT `fk_lagu_playlist` FOREIGN KEY (`kodePlaylist`) REFERENCES `tbplaylist` (`kodePlaylist`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
