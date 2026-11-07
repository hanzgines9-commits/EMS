-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: ems_db
-- ------------------------------------------------------
-- Server version	8.0.46

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendance` (
  `att_id` int NOT NULL AUTO_INCREMENT,
  `emp_id` int NOT NULL,
  `log_date` date NOT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`att_id`),
  UNIQUE KEY `uq_emp_day` (`emp_id`,`log_date`),
  CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `employees` (`emp_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4142 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (4126,14,'2026-10-27',NULL,NULL,'Absent'),(4128,15,'2026-10-27',NULL,NULL,'Absent'),(4130,14,'2026-10-28','08:02:19','08:12:10','Present'),(4131,15,'2026-10-28','08:10:39',NULL,'Late'),(4132,14,'2026-11-06','10:11:41','10:14:49','Present'),(4133,15,'2026-11-06','10:51:19','10:51:32','Late'),(4139,16,'2026-11-06','10:51:24','10:51:28','Late');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `audit_logs`
--

DROP TABLE IF EXISTS `audit_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `audit_logs` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `action` varchar(200) NOT NULL,
  `log_timestamp` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `audit_logs_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_logs`
--

LOCK TABLES `audit_logs` WRITE;
/*!40000 ALTER TABLE `audit_logs` DISABLE KEYS */;
INSERT INTO `audit_logs` VALUES (1,1,'LOGIN','2026-10-27 18:07:57'),(2,1,'MARK ABSENT employee #10','2026-10-27 18:09:09'),(3,1,'MARK ABSENT employee #10','2026-10-27 18:09:11'),(4,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:12'),(5,1,'MARK ABSENT employee #10','2026-10-27 18:09:14'),(6,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:17'),(7,1,'MARK ABSENT employee #10','2026-10-27 18:09:18'),(8,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:20'),(9,1,'MARK ABSENT employee #10','2026-10-27 18:09:21'),(10,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:22'),(11,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:32'),(12,1,'MARK ABSENT employee #10','2026-10-27 18:09:35'),(13,1,'MARK ABSENT employee #10','2026-10-27 18:09:37'),(14,1,'MARK ABSENT employee #10','2026-10-27 18:09:54'),(15,1,'MARK ON LEAVE employee #10','2026-10-27 18:09:56'),(16,1,'MARK ON LEAVE employee #10','2026-10-27 18:10:03'),(17,1,'MARK ABSENT employee #10','2026-10-27 18:10:04'),(18,1,'MARK ON LEAVE employee #10','2026-10-27 18:10:07'),(19,1,'CHECK-IN employee #4 (Late)','2026-10-27 18:10:24'),(20,1,'CHECK-IN employee #9 (Late)','2026-10-27 18:10:31'),(21,1,'CHECK-OUT employee #9','2026-10-27 18:10:37'),(22,1,'MARK ON LEAVE employee #9','2026-10-27 18:10:42'),(23,1,'MARK ON LEAVE employee #9','2026-10-27 18:10:43'),(24,1,'MARK ON LEAVE employee #4','2026-10-27 18:10:49'),(25,1,'MARK ABSENT employee #9','2026-10-27 18:12:42'),(26,1,'LOGIN','2026-10-27 18:18:38'),(27,1,'DELETE EMPLOYEE #3','2026-10-27 18:19:03'),(28,1,'ADD EMPLOYEE: Hanz Gian Gines','2026-10-27 18:20:23'),(29,1,'CHECK-IN employee #13 (Late)','2026-10-27 18:20:49'),(30,1,'CHECK-IN employee #7 (Late)','2026-10-27 18:20:54'),(31,1,'CHECK-IN employee #2 (Late)','2026-10-27 18:20:57'),(32,1,'CHECK-IN employee #8 (Late)','2026-10-27 18:21:00'),(33,1,'CHECK-IN employee #1 (Late)','2026-10-27 18:21:12'),(34,1,'CHECK-IN employee #12 (Late)','2026-10-27 18:21:19'),(35,1,'CHECK-IN employee #6 (Late)','2026-10-27 18:21:21'),(36,1,'LOGIN','2026-10-27 18:28:19'),(37,1,'EXPORT REPORT 2026-01-01 to 2026-10-27','2026-10-27 18:29:09'),(38,1,'DELETE EMPLOYEE #1','2026-10-27 18:30:50'),(39,1,'DELETE EMPLOYEE #2','2026-10-27 18:30:52'),(40,1,'DELETE EMPLOYEE #4','2026-10-27 18:30:55'),(41,1,'DELETE EMPLOYEE #5','2026-10-27 18:30:58'),(42,1,'DELETE EMPLOYEE #7','2026-10-27 18:31:01'),(43,1,'DELETE EMPLOYEE #6','2026-10-27 18:31:04'),(44,1,'DELETE EMPLOYEE #8','2026-10-27 18:31:08'),(45,1,'DELETE EMPLOYEE #9','2026-10-27 18:31:10'),(46,1,'DELETE EMPLOYEE #10','2026-10-27 18:31:12'),(47,1,'DELETE EMPLOYEE #11','2026-10-27 18:31:15'),(48,1,'DELETE EMPLOYEE #12','2026-10-27 18:31:17'),(49,1,'DELETE EMPLOYEE #13','2026-10-27 18:31:19'),(50,1,'ADD EMPLOYEE: Hanz Gian Gines','2026-10-27 18:32:13'),(51,1,'CHECK-IN employee #14 (Late)','2026-10-27 18:32:22'),(52,1,'LOGIN','2026-10-27 20:22:30'),(53,1,'EXPORT PDF REPORT','2026-10-27 20:23:09'),(54,1,'PRINT REPORT','2026-10-27 20:23:35'),(55,1,'CHECK-OUT employee #14','2026-10-27 20:23:57'),(56,1,'MARK ABSENT employee #14','2026-10-27 20:24:17'),(57,1,'LOGIN','2026-10-27 20:25:26'),(58,1,'ADD EMPLOYEE: hj tyui','2026-10-27 20:26:20'),(59,1,'CHECK-IN employee #15 (Late)','2026-10-27 20:26:49'),(60,1,'MARK ABSENT employee #15','2026-10-27 20:27:08'),(61,1,'EXPORT PDF REPORT','2026-10-27 20:27:55'),(62,1,'LOGIN','2026-10-28 08:01:23'),(63,1,'CHECK-IN employee #14 (Present)','2026-10-28 08:02:19'),(64,1,'LOGIN','2026-10-28 08:10:02'),(65,1,'CHECK-IN employee #15 (Late)','2026-10-28 08:10:39'),(66,1,'CHECK-OUT employee #14','2026-10-28 08:12:10'),(67,1,'LOGIN','2026-11-04 22:02:43');
/*!40000 ALTER TABLE `audit_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departments` (
  `dept_id` int NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(60) NOT NULL,
  `location` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`dept_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'IT Department','Main Office'),(2,'HR Department','Main Office'),(3,'Finance','Annex'),(4,'Operations','Warehouse'),(5,'Sales','Annex'),(6,'Marketing','Main Office'),(7,'Customer Service','Main Office');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `emp_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `dept_id` int NOT NULL,
  `position` varchar(60) DEFAULT NULL,
  `date_hired` date NOT NULL,
  `status` varchar(10) NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`emp_id`),
  KEY `dept_id` (`dept_id`),
  CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`dept_id`) REFERENCES `departments` (`dept_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (14,'Hanz Gian','Gines',5,'manager','2026-10-27','Active'),(15,'hj','tyui',3,'stock broker','2026-10-27','Active'),(16,'hb','ok',3,'min','2026-11-06','Active');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(40) NOT NULL,
  `password` char(64) NOT NULL,
  `role` varchar(10) NOT NULL,
  `employee_id` int DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `employee_id` (`employee_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`emp_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9','admin',NULL),(2,'encoder','6bb563de3349c24bb63d6465df4f24c49e4fe46b2e82948f46b79e31f15335c7','encoder',NULL),(3,'hanz','17756315ebd47b7110359fc7b168179bf6f2df3646fcc888bc8aa05c78b38ac1','encoder',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-07 13:28:56
