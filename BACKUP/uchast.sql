CREATE DATABASE  IF NOT EXISTS `uchast` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `uchast`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: uchast
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `disp`
--

DROP TABLE IF EXISTS `disp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `disp` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `D_shifr` int(3) NOT NULL,
  `D_name` varchar(40) NOT NULL,
  `D_norm` int(3) NOT NULL,
  `D_lab` int(3) NOT NULL,
  `D_sem` int(11) NOT NULL,
  `D_type` varchar(40) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disp`
--

LOCK TABLES `disp` WRITE;
/*!40000 ALTER TABLE `disp` DISABLE KEYS */;
INSERT INTO `disp` VALUES (1,101,'Математика',132,0,1,'Диференцированный зачёт'),(2,201,'Биология',170,8,2,'Диференцированный зачёт'),(3,101,'Математика',124,0,2,'Экзамен');
/*!40000 ALTER TABLE `disp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gryp`
--

DROP TABLE IF EXISTS `gryp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `gryp` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `G_otdel` varchar(50) NOT NULL,
  `Sp_id` int(11) NOT NULL,
  `G_number` int(1) NOT NULL,
  `G_kyrs` int(1) NOT NULL,
  `G_born` int(4) NOT NULL,
  `P_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Sp_id_idx` (`Sp_id`),
  KEY `Pr_id_idx` (`P_id`),
  CONSTRAINT `Pr_id` FOREIGN KEY (`P_id`) REFERENCES `prepod` (`id`),
  CONSTRAINT `Sp_id` FOREIGN KEY (`Sp_id`) REFERENCES `specly` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gryp`
--

LOCK TABLES `gryp` WRITE;
/*!40000 ALTER TABLE `gryp` DISABLE KEYS */;
INSERT INTO `gryp` VALUES (1,'Программирование',1,1,1,18,NULL),(2,'Программирование',1,2,1,18,NULL),(3,'Программирование',1,3,1,18,NULL),(4,'Программирование',1,1,2,17,NULL),(5,'Программирование',1,2,2,17,NULL),(6,'Программирование',1,3,2,17,NULL),(7,'Программирование',1,1,3,16,NULL),(8,'Программирование',1,2,3,16,NULL),(9,'Программирование',1,3,3,16,NULL),(10,'Программирование',1,1,4,15,NULL),(11,'Программирование',1,2,4,15,NULL),(12,'Программирование',1,3,4,15,NULL),(13,'Компьютерная инженерия',2,1,1,18,NULL),(14,'Компьютерная инженерия',2,2,1,18,NULL),(15,'Компьютерная инженерия',2,3,1,18,NULL),(16,'Компьютерная инженерия',2,1,2,17,NULL),(17,'Компьютерная инженерия',2,2,2,17,NULL),(18,'Компьютерная инженерия',2,3,2,17,NULL),(19,'Компьютерная инженерия',2,1,3,16,NULL),(20,'Компьютерная инженерия',2,2,3,16,NULL),(21,'Компьютерная инженерия',2,3,3,16,NULL),(22,'Компьютерная инженерия',2,1,4,15,NULL),(23,'Компьютерная инженерия',2,2,4,15,NULL),(24,'Компьютерная инженерия',2,3,4,15,NULL),(25,'Радиотехника и телекомуникации',3,1,1,18,NULL),(26,'Радиотехника и телекомуникации',3,2,1,18,NULL),(27,'Радиотехника и телекомуникации',3,3,1,18,NULL),(28,'Радиотехника и телекомуникации',3,1,2,17,NULL),(29,'Радиотехника и телекомуникации',3,2,2,17,NULL),(30,'Радиотехника и телекомуникации',3,3,2,17,NULL),(31,'Радиотехника и телекомуникации',3,1,3,16,NULL),(32,'Радиотехника и телекомуникации',3,2,3,16,NULL),(33,'Радиотехника и телекомуникации',3,3,3,16,NULL),(34,'Радиотехника и телекомуникации',3,1,4,15,NULL),(35,'Радиотехника и телекомуникации',3,2,4,15,NULL),(36,'Радиотехника и телекомуникации',3,3,4,15,NULL),(37,'Машиностроение',4,1,1,18,NULL),(40,'Машиностроение',4,1,2,17,NULL),(43,'Машиностроение',4,1,3,16,NULL),(46,'Машиностроение',4,1,4,15,NULL),(49,'Механика',5,1,1,18,NULL),(52,'Механика',5,1,2,17,NULL),(55,'Механика',5,1,3,16,NULL),(58,'Механика',5,1,4,15,NULL),(61,'Электроника',6,1,1,18,NULL),(64,'Электроника',6,1,2,17,NULL),(67,'Электроника',6,1,3,16,NULL),(70,'Электроника',6,1,4,15,NULL);
/*!40000 ALTER TABLE `gryp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kafedra`
--

DROP TABLE IF EXISTS `kafedra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `kafedra` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `K_name` varchar(50) NOT NULL,
  `K_nomer` varchar(10) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kafedra`
--

LOCK TABLES `kafedra` WRITE;
/*!40000 ALTER TABLE `kafedra` DISABLE KEYS */;
INSERT INTO `kafedra` VALUES (1,'Программирование','101'),(2,'Языки и литература','102'),(3,'Математика','103'),(4,'Физ. воспитание','104'),(5,'Общественные науки','105');
/*!40000 ALTER TABLE `kafedra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prepod`
--

DROP TABLE IF EXISTS `prepod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `prepod` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `P_fio` varchar(50) NOT NULL,
  `P_kategory` varchar(10) NOT NULL,
  `K_id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `O_id_idx` (`K_id`),
  CONSTRAINT `K_id` FOREIGN KEY (`K_id`) REFERENCES `kafedra` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prepod`
--

LOCK TABLES `prepod` WRITE;
/*!40000 ALTER TABLE `prepod` DISABLE KEYS */;
INSERT INTO `prepod` VALUES (1,'Стяглик Н.И','1',1),(2,'Ахмедзянова О.А','2',1),(3,'Правдина Е. М.','1',1),(4,'Сосновский В.В','3',1),(5,'Радченко Е. П.','2',1),(6,'Федосеева А. И.','1',1),(7,'Архипцева Н. А.','2',1),(8,'Сериков В. И.','3',1),(9,'Колычева Л. Е.','3',1),(10,'Романовская И. А.','3',1),(11,'Даниленко И. В.','2',2),(12,'Пугачова О. А.','1',2);
/*!40000 ALTER TABLE `prepod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specly`
--

DROP TABLE IF EXISTS `specly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `specly` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Sp_name` varchar(50) NOT NULL,
  `Sp_nazv` varchar(2) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specly`
--

LOCK TABLES `specly` WRITE;
/*!40000 ALTER TABLE `specly` DISABLE KEYS */;
INSERT INTO `specly` VALUES (1,'Инженерия программного обеспечения','ПИ'),(2,'Компьютерная инженерия','КИ'),(3,'Телекомуникации и радиотехника','РТ'),(4,'Отраслевое машиностроение','ОМ'),(5,'Прикладная механика','ПМ'),(6,'Электроника','ЕТ');
/*!40000 ALTER TABLE `specly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stydent`
--

DROP TABLE IF EXISTS `stydent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `stydent` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `G_id` int(11) NOT NULL,
  `St_fio` varchar(50) NOT NULL,
  `St_data` date NOT NULL,
  `St_town` varchar(30) NOT NULL,
  `St_adres` varchar(100) NOT NULL,
  `St_postyp` date NOT NULL,
  `St_nomer` varchar(10) NOT NULL,
  `St_zach` int(7) NOT NULL,
  `St_opl` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `G_id_idx` (`G_id`),
  CONSTRAINT `G_id` FOREIGN KEY (`G_id`) REFERENCES `gryp` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stydent`
--

LOCK TABLES `stydent` WRITE;
/*!40000 ALTER TABLE `stydent` DISABLE KEYS */;
/*!40000 ALTER TABLE `stydent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yspeh`
--

DROP TABLE IF EXISTS `yspeh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `yspeh` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `St_id` int(11) NOT NULL,
  `P_id` int(11) NOT NULL,
  `D_id` int(11) NOT NULL,
  `Y_data` date NOT NULL,
  `Y_type` enum('0','1','2') NOT NULL,
  `Y_ball` int(2) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `St_id_idx` (`St_id`),
  KEY `P_id_idx` (`P_id`),
  KEY `D_id_idx` (`D_id`),
  CONSTRAINT `D_id` FOREIGN KEY (`D_id`) REFERENCES `disp` (`id`),
  CONSTRAINT `P_id` FOREIGN KEY (`P_id`) REFERENCES `prepod` (`id`),
  CONSTRAINT `St_id` FOREIGN KEY (`St_id`) REFERENCES `stydent` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yspeh`
--

LOCK TABLES `yspeh` WRITE;
/*!40000 ALTER TABLE `yspeh` DISABLE KEYS */;
/*!40000 ALTER TABLE `yspeh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'uchast'
--

--
-- Dumping routines for database 'uchast'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-11 21:37:57
