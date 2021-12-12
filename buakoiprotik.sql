-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2021 at 06:02 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `buakoiprotik`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `FullName` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `AdminID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`FullName`, `Password`, `Email`, `AdminID`) VALUES
('Protik Acharjay', 'protik11', 'protik7777777@gmail.com', 1),
('a', '12', 'a@gmail.com', 3);

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
  `UserID` int(11) DEFAULT NULL,
  `HiringStatus` int(30) NOT NULL DEFAULT 0,
  `HiringID` int(11) NOT NULL,
  `AdminID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hiringstatus`
--

INSERT INTO `hiringstatus` (`MaidID`, `UserID`, `HiringStatus`, `HiringID`, `AdminID`) VALUES
(16, 6, 1, 19, 0),
(1, 6, 1, 20, 0),
(1, 6, 1, 21, 0),
(13, 6, 1, 22, 0),
(15, 6, 1, 23, 0),
(17, 5, 1, 24, 0),
(18, 6, 1, 25, 0),
(32, NULL, 1, 33, NULL),
(27, NULL, 1, 34, NULL),
(26, NULL, 1, 35, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `maidinfo`
--

CREATE TABLE `maidinfo` (
  `FullName` varchar(30) NOT NULL,
  `WorkTime` varchar(30) NOT NULL,
  `MaidID` int(10) NOT NULL,
  `AdminID` int(10) DEFAULT NULL,
  `DOB` varchar(50) NOT NULL,
  `WorkExperience` int(10) NOT NULL,
  `WorkAddress` text NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `PhoneNumber` varchar(15) NOT NULL,
  `ExpectedSalary` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `maidinfo`
--

INSERT INTO `maidinfo` (`FullName`, `WorkTime`, `MaidID`, `AdminID`, `DOB`, `WorkExperience`, `WorkAddress`, `Gender`, `PhoneNumber`, `ExpectedSalary`) VALUES
('Khala', '8-11 am', 1, 1, '2021-12-10 20:11:48.121205', 2, 'Dhaka', 'Female', '01948945165', 2000),
('Bua', '1-5 pm', 13, 3, '2021-12-10 20:11:48.121205', 1, 'dhaka', 'Female', '01746555564', 2000),
('Rahima', '4pm - 10pm', 15, 1, '2021-12-12 13:57:21.248815', 5, 'Khilkhet', 'Female', '0167543287', 5000),
('Khadija', '5pm - 9pm', 16, 3, '2021-11-28 14:09:50', 3, 'dhaka', 'Female', '1234567', 8000),
('Ramu Kaka', '6am - 12pm', 17, 1, '2021-12-12 13:57:21.248815', 3, 'Rajshahi', 'Female', '01626070395', 12000),
('Prottoy', '3pm - 6pm', 18, 1, '2021-11-28 13:57:21', 4, 'dhaka', 'Male', '12345', 1234),
('manual', '2-5', 24, 3, '', 0, '', '', '', 2000),
('Bua2', '1-5 pm', 26, 0, '2021-12-12 14:22:12.488062', 1, 'dhaka', 'Female', '01746555564', 3000),
('Bua3', '1-5 pm', 27, 0, '2021-12-12 14:22:12.488062', 1, 'dhaka', 'Female', '01746555564', 4000),
('Bua8', '1-5 pm', 30, NULL, '2021-12-12 14:51:10.979103', 1, 'dhaka', 'Female', '01746555564', 4000),
('Bua27', '1-5 pm', 32, NULL, '2021-12-12 14:58:42.344623', 1, 'dhaka', 'Female', '01746555564', 4000);

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
  `FullName` varchar(30) NOT NULL,
  `DoB` datetime NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `PhoneNumber` varchar(15) NOT NULL,
  `Address` text DEFAULT NULL,
  `UserID` int(11) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`FullName`, `DoB`, `Password`, `Gender`, `PhoneNumber`, `Address`, `UserID`, `Email`) VALUES
('Partho', '2021-12-01 03:39:27', 'partho1234', 'Gender', '1626070395', NULL, 4, 'parthoshaon@gmail.com'),
('Protik Acharjay', '2001-12-11 18:16:19', 'protik11', 'Male', '1798141488', 'Rajshahi', 5, 'protik7777777@gmail.com'),
('Ratan', '2021-12-09 19:44:18', '1', 'Female', '179814546', 'dhaka', 6, 'a@gmail.com'),
('sagor', '2021-11-29 12:18:41', '12345', 'Male', '01634756345', 'dhaka', 7, 'sagor@gmail.com'),
('kamal', '2021-11-28 12:26:50', '123', 'Male', '01838257832', 'dhaka', 8, 'k@gmail.com'),
('apurbo', '2012-06-08 13:04:05', '12345', 'Male', '0158372098', 'raipur', 9, 'apurbo@gmail.com'),
('mazid ', '2021-12-12 15:26:50', '12345', '', '01983478967', 'nikunja-2, Dhaka', 10, 'mazid@aiub.edu'),
('rikta bhatt', '2021-12-12 16:21:53', 'katha065', '', '01814717355', 'raipur', 11, 'riktabhatt065@gmail.com');

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
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `hiringstatus`
--
ALTER TABLE `hiringstatus`
  MODIFY `HiringID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `maidinfo`
--
ALTER TABLE `maidinfo`
  MODIFY `MaidID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

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
