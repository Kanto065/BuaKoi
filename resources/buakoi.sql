-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2021 at 03:04 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `buakoi`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `DoB` datetime NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Phone` int(13) NOT NULL,
  `Address` text NOT NULL,
  `Photo` longblob NOT NULL,
  `AdminID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `Message` text NOT NULL,
  `Rating` int(10) NOT NULL,
  `MaidID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `DateTime` datetime NOT NULL,
  `HiringID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `hiringstatus`
--

CREATE TABLE `hiringstatus` (
  `MaidID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `HiringStatus` varchar(30) NOT NULL,
  `HiringID` int(11) NOT NULL,
  `AdminID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `maidinfo`
--

CREATE TABLE `maidinfo` (
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `Address` text NOT NULL,
  `WorkTime` varchar(30) NOT NULL,
  `MaidID` int(11) NOT NULL,
  `AdminID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `UserStatus` varchar(30) NOT NULL,
  `MaidStatus` varchar(30) NOT NULL,
  `UserDate` datetime NOT NULL,
  `MaidDate` datetime NOT NULL,
  `AdminID` int(11) NOT NULL,
  `MaidID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `HiringID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `DoB` datetime NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `PhoneNumber` int(13) NOT NULL,
  `Address` text DEFAULT NULL,
  `Photo` longblob DEFAULT NULL,
  `UserID` int(11) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`FirstName`, `LastName`, `DoB`, `Password`, `Gender`, `PhoneNumber`, `Address`, `Photo`, `UserID`, `Email`) VALUES
('Partho', 'Roy', '0000-00-00 00:00:00', 'partho1234', 'Gender', 1626070395, NULL, NULL, 4, 'parthoshaon@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AdminID`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD KEY `UserID` (`UserID`),
  ADD KEY `MaidID` (`MaidID`),
  ADD KEY `HiringID` (`HiringID`);

--
-- Indexes for table `hiringstatus`
--
ALTER TABLE `hiringstatus`
  ADD PRIMARY KEY (`HiringID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `MaidID` (`MaidID`),
  ADD KEY `AdminID` (`AdminID`);

--
-- Indexes for table `maidinfo`
--
ALTER TABLE `maidinfo`
  ADD PRIMARY KEY (`MaidID`),
  ADD KEY `AdminID` (`AdminID`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `MaidID` (`MaidID`),
  ADD KEY `HiringID` (`HiringID`),
  ADD KEY `AdminID` (`AdminID`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `hiringstatus`
--
ALTER TABLE `hiringstatus`
  MODIFY `HiringID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `maidinfo`
--
ALTER TABLE `maidinfo`
  MODIFY `MaidID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `userinfo` (`UserID`),
  ADD CONSTRAINT `feedback_ibfk_2` FOREIGN KEY (`MaidID`) REFERENCES `maidinfo` (`MaidID`),
  ADD CONSTRAINT `feedback_ibfk_3` FOREIGN KEY (`HiringID`) REFERENCES `hiringstatus` (`HiringID`);

--
-- Constraints for table `hiringstatus`
--
ALTER TABLE `hiringstatus`
  ADD CONSTRAINT `hiringstatus_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `userinfo` (`UserID`),
  ADD CONSTRAINT `hiringstatus_ibfk_2` FOREIGN KEY (`MaidID`) REFERENCES `maidinfo` (`MaidID`),
  ADD CONSTRAINT `hiringstatus_ibfk_3` FOREIGN KEY (`AdminID`) REFERENCES `admin` (`AdminID`);

--
-- Constraints for table `maidinfo`
--
ALTER TABLE `maidinfo`
  ADD CONSTRAINT `maidinfo_ibfk_1` FOREIGN KEY (`AdminID`) REFERENCES `admin` (`AdminID`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `userinfo` (`UserID`),
  ADD CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`MaidID`) REFERENCES `maidinfo` (`MaidID`),
  ADD CONSTRAINT `payment_ibfk_3` FOREIGN KEY (`HiringID`) REFERENCES `hiringstatus` (`HiringID`),
  ADD CONSTRAINT `payment_ibfk_4` FOREIGN KEY (`AdminID`) REFERENCES `admin` (`AdminID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
