CREATE DATABASE  IF NOT EXISTS `personnel` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `personnel`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: personnel
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `iddept` char(36) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `joblist` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`iddept`),
  UNIQUE KEY `idworker_UNIQUE` (`iddept`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES ('dc6ed2ec-70e0-44fc-be6d-f586248b3c71','Sellers','1f71992d-776b-40c8-b68f-ad8e68133696,57f66a83-a71f-4337-a9f5-0836d50cc2b1,57f66a83-a71f-4337-a9f5-0836d50cc2b1,569236ec-8734-4dff-ab55-66415472f641'),('ebeec8e3-bf86-4520-a23f-50c70cd86a43','Personnel','7c823840-f7bb-4807-b0b8-4e24b86ca285,57f66a83-a71f-4337-a9f5-0836d50cc2b1,57f66a83-a71f-4337-a9f5-0836d50cc2b1,57f66a83-a71f-4337-a9f5-0836d50cc2b1,5f49d247-bdac-469a-8160-0b7ede69f1ab');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departmentoffice`
--

DROP TABLE IF EXISTS `departmentoffice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departmentoffice` (
  `iddept` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`iddept`),
  UNIQUE KEY `iddept_UNIQUE` (`iddept`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departmentoffice`
--

LOCK TABLES `departmentoffice` WRITE;
/*!40000 ALTER TABLE `departmentoffice` DISABLE KEYS */;
/*!40000 ALTER TABLE `departmentoffice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job`
--

DROP TABLE IF EXISTS `job`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job` (
  `idjob` char(36) CHARACTER SET utf8 NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `jobrank` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  `workerslist` varchar(1000) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`idjob`),
  UNIQUE KEY `idjob_UNIQUE` (`idjob`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job`
--

LOCK TABLES `job` WRITE;
/*!40000 ALTER TABLE `job` DISABLE KEYS */;
INSERT INTO `job` VALUES ('1f71992d-776b-40c8-b68f-ad8e68133696','Postman','Senior',2000,''),('5427369d-2b18-44ed-a1be-b65865280517','Janitor','Junior',1000,''),('569236ec-8734-4dff-ab55-66415472f641','Director','Senior',2000,''),('57f66a83-a71f-4337-a9f5-0836d50cc2b1','Assisstant','Junior',282,''),('5f49d247-bdac-469a-8160-0b7ede69f1ab','Manager','Senior',22000,''),('7c823840-f7bb-4807-b0b8-4e24b86ca285','Admin','Senior',11000,''),('d9893d5e-e920-4140-815f-cb0dc1e55a33','Programmer','Junior',1111,'');
/*!40000 ALTER TABLE `job` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person` (
  `idperson` char(36) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `married` tinyint(4) DEFAULT NULL,
  `photo` varchar(100) DEFAULT NULL,
  `fk_department` char(36) DEFAULT NULL,
  `fk_job` char(36) DEFAULT NULL,
  `isfired` tinyint(4) DEFAULT NULL,
  `archive` varchar(1000) DEFAULT NULL,
  `fk_workerschedule` char(36) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idperson`),
  UNIQUE KEY `idperson_UNIQUE` (`idperson`),
  KEY `fk_department_idx` (`fk_department`),
  KEY `fk_job_idx` (`fk_job`),
  KEY `fk_workerschedule_idx` (`fk_workerschedule`),
  CONSTRAINT `fk_department` FOREIGN KEY (`fk_department`) REFERENCES `department` (`iddept`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_job` FOREIGN KEY (`fk_job`) REFERENCES `job` (`idjob`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_workerschedule` FOREIGN KEY (`fk_workerschedule`) REFERENCES `schedule` (`idschedule`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES ('0eac2b7d-4de4-4363-b328-1bb470578a7e','Mar Marie Marro','female','1988-05-30',1,'C:/Users/Никита/Pictures/119445.jpeg','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','569236ec-8734-4dff-ab55-66415472f641',0,'Компания:  Должность: () 5/30/2017-5/30/2017','f097aa14-a1d7-4503-be76-f55fa42f4b52','Mar','PHHFLr'),('416b9522-2405-4c61-8797-bd8bf3dcb04d','Little John Big','male','1990-05-30',1,'C:/Users/Никита/Pictures/41763.jpg','ebeec8e3-bf86-4520-a23f-50c70cd86a43','569236ec-8734-4dff-ab55-66415472f641',0,'','6cbaa96c-19ba-467a-a54e-edcc81c14ee0','Little','iL8ZUq'),('cc586cdc-681c-4344-993c-6704f1075d7f','admin admin admin','male','1990-05-30',0,'C:/Users/Никита/Pictures/70v6na8svOw.jpg','ebeec8e3-bf86-4520-a23f-50c70cd86a43','7c823840-f7bb-4807-b0b8-4e24b86ca285',0,'Компания: comp1 Должность: job1(rank1) 5/2/2017-5/3/2017','d969536a-15d1-4751-95b2-eab6e17e9be4','admin','15KXRp'),('f6dd06e8-a9f0-45d3-a8c4-730abbbc8980','Ivanov Ivan Ivanovich','female','1990-05-30',1,'C:/Users/Никита/Pictures/--_1_~1.JPG','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','1f71992d-776b-40c8-b68f-ad8e68133696',0,',Компания:  Должность: () 5/30/2017-5/30/2017,Компания:  Должность: () 5/30/2017-5/30/2017','0aba4328-d657-4683-ad94-a54cabaa2cf5','Ivanov','');
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedule` (
  `idschedule` char(36) NOT NULL,
  `fk_department` char(36) DEFAULT NULL,
  `fk_job` char(36) DEFAULT NULL,
  `fmonday` varchar(45) DEFAULT NULL,
  `ftuesday` varchar(45) DEFAULT NULL,
  `fwednesday` varchar(45) DEFAULT NULL,
  `fthursday` varchar(45) DEFAULT NULL,
  `ffriday` varchar(45) DEFAULT NULL,
  `fsaturday` varchar(45) DEFAULT NULL,
  `fsunday` varchar(45) DEFAULT NULL,
  `smonday` varchar(45) DEFAULT NULL,
  `stuesday` varchar(45) DEFAULT NULL,
  `swednesday` varchar(45) DEFAULT NULL,
  `sthursday` varchar(45) DEFAULT NULL,
  `sfriday` varchar(45) DEFAULT NULL,
  `ssaturday` varchar(45) DEFAULT NULL,
  `ssunday` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idschedule`),
  UNIQUE KEY `idschedule_UNIQUE` (`idschedule`),
  KEY `fk_scheddepartment_idx` (`fk_department`),
  KEY `fk_schedjob_idx` (`fk_job`),
  CONSTRAINT `fk_scheddepartment` FOREIGN KEY (`fk_department`) REFERENCES `department` (`iddept`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_schedjob` FOREIGN KEY (`fk_job`) REFERENCES `job` (`idjob`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` VALUES ('05276984-780c-45bb-b82e-81fb18392e17','ebeec8e3-bf86-4520-a23f-50c70cd86a43','57f66a83-a71f-4337-a9f5-0836d50cc2b1','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('0aba4328-d657-4683-ad94-a54cabaa2cf5','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','1f71992d-776b-40c8-b68f-ad8e68133696','9:00 - 14:00,13:00 - 18:00,none','none,13:00 - 18:00,none','9:00 - 14:00,13:00 - 18:00,17:00 - 22:00','none,13:00 - 18:00,none','none,13:00 - 18:00,none','9:00 - 14:00,13:00 - 18:00,17:00 - 22:00','9:00 - 14:00,13:00 - 18:00,17:00 - 22:00','none,none,17:00 - 22:00','9:00 - 14:00,none,none','none,none,17:00 - 22:00','9:00 - 14:00,none,none','none,13:00 - 18:00,none','none,none,17:00 - 22:00','none,13:00 - 18:00,none'),('0f22ccfd-4147-426c-95b1-4e2265967946',NULL,'d9893d5e-e920-4140-815f-cb0dc1e55a33','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('1622931a-5a84-4d88-bf88-4b771ee7b954','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','5427369d-2b18-44ed-a1be-b65865280517','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('19c4b198-a206-4a67-bb3b-4b5afae9ac98','ebeec8e3-bf86-4520-a23f-50c70cd86a43','5f49d247-bdac-469a-8160-0b7ede69f1ab','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('25f1440e-b18b-4367-83e2-8442bbe4983c',NULL,'5f49d247-bdac-469a-8160-0b7ede69f1ab','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('2793ac26-7815-40fe-b4a5-93447064d98b',NULL,'7c823840-f7bb-4807-b0b8-4e24b86ca285','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('3fb88c46-2de9-42a2-8761-762f63f99477','ebeec8e3-bf86-4520-a23f-50c70cd86a43','5427369d-2b18-44ed-a1be-b65865280517','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('4404ca6e-91c7-41e0-94cb-b0811dbe9886',NULL,'5427369d-2b18-44ed-a1be-b65865280517','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('56efc317-54a4-47a9-a310-56993d5edb90',NULL,'1f71992d-776b-40c8-b68f-ad8e68133696','9:00 - 14:00,none,none','none,none,17:00 - 22:00','9:00 - 14:00,13:00 - 18:00,17:00 - 22:00','none,none,none','none,none,none','none,13:00 - 18:00,none','none,none,none','none,none,none','none,none,none','none,none,none','9:00 - 14:00,13:00 - 18:00,none','none,none,none','none,13:00 - 18:00,17:00 - 22:00','none,none,none'),('6cbaa96c-19ba-467a-a54e-edcc81c14ee0','ebeec8e3-bf86-4520-a23f-50c70cd86a43','569236ec-8734-4dff-ab55-66415472f641','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('7420f0a5-1dca-4f67-ad24-bc66a031d590',NULL,NULL,'none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('7931bf77-8702-410f-b6eb-65f734cab0db','ebeec8e3-bf86-4520-a23f-50c70cd86a43','1f71992d-776b-40c8-b68f-ad8e68133696','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('939fba01-7dda-4b56-aa10-215fbae5d6c3',NULL,'1f71992d-776b-40c8-b68f-ad8e68133696','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,13:00 - 18:00,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('9da871eb-1aa9-43f8-ab6b-5f4167f9992e','ebeec8e3-bf86-4520-a23f-50c70cd86a43','d9893d5e-e920-4140-815f-cb0dc1e55a33','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('9fe52163-f8e2-4930-ac3a-b8ec9453cf26','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','57f66a83-a71f-4337-a9f5-0836d50cc2b1','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('abe3533d-2a75-48af-8ef8-a84209b571dd','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','7c823840-f7bb-4807-b0b8-4e24b86ca285','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('b5691737-e150-4d9c-af4a-d237b81037e5','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','d9893d5e-e920-4140-815f-cb0dc1e55a33','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('ca697f70-8b7c-4d85-af27-92820b962dea','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','5f49d247-bdac-469a-8160-0b7ede69f1ab','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('cb6c2518-5162-4fe6-ab91-68f0a5b307b8',NULL,'57f66a83-a71f-4337-a9f5-0836d50cc2b1','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('d969536a-15d1-4751-95b2-eab6e17e9be4','ebeec8e3-bf86-4520-a23f-50c70cd86a43','7c823840-f7bb-4807-b0b8-4e24b86ca285','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none'),('e938f5a2-76de-44a6-99f1-01061ce9e485',NULL,NULL,'none,13:00 - 18:00,none','none,none,none','none,13:00 - 18:00,none','none,none,none','none,13:00 - 18:00,none','none,none,none','none,13:00 - 18:00,none','9:00 - 14:00,none,none','none,none,17:00 - 22:00','9:00 - 14:00,none,none','none,none,17:00 - 22:00','9:00 - 14:00,none,none','none,none,17:00 - 22:00','9:00 - 14:00,none,none'),('f097aa14-a1d7-4503-be76-f55fa42f4b52','dc6ed2ec-70e0-44fc-be6d-f586248b3c71','569236ec-8734-4dff-ab55-66415472f641','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none','none,none,none');
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-27 18:57:34
