-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_wstock
-- ------------------------------------------------------
-- Server version	8.0.17

CREATE DATABASE bd_wstock;
USE bd_wstock;

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
-- Table structure for table `tb_agendamento`
--

DROP TABLE IF EXISTS `tb_agendamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_agendamento` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `CODIGO_TRANSPORTADOR` int(11) NOT NULL,
  `CODIGO_EMPRESA` int(11) NOT NULL,
  `CODIGO_TIPO_AGENDAMENTO` int(11) NOT NULL,
  `CODIGO_TIPO_PALLET` int(11) NOT NULL,
  `CODIGO_TIPO_CARGA` int(11) NOT NULL,
  `CODIGO_TIPO_VEICULO` int(11) NOT NULL,
  `NFE` varchar(1000) NOT NULL,
  `NOME_MOTORISTA` varchar(1000) DEFAULT NULL,
  `ORIGEM` varchar(1000) DEFAULT NULL,
  `DESTINO` varchar(1000) DEFAULT NULL,
  `QUANTIDADE_PALLET` decimal(18,6) NOT NULL,
  `DATA_AGENDAMENTO` datetime NOT NULL,
  `DATA_CANCELAMENTO` datetime DEFAULT NULL,
  `OBSERVACAO` varchar(4000) DEFAULT NULL,
  `DATA_ENTRADA` datetime DEFAULT NULL,
  `DATA_SAIDA` datetime DEFAULT NULL,
  PRIMARY KEY (`CODIGO`),
  KEY `fk_TB_AGENDAMENTO_TB_TRANSPORTADOR_idx` (`CODIGO_TRANSPORTADOR`),
  KEY `fk_TB_AGENDAMENTO_TB_EMPRESA1_idx` (`CODIGO_EMPRESA`),
  KEY `fk_TB_AGENDAMENTO_TB_TIPO_AGENDAMENTO1_idx` (`CODIGO_TIPO_AGENDAMENTO`),
  KEY `fk_TB_AGENDAMENTO_TB_TIPO_PALLET1_idx` (`CODIGO_TIPO_PALLET`),
  KEY `fk_TB_AGENDAMENTO_TB_TIPO_CARGA1_idx` (`CODIGO_TIPO_CARGA`),
  KEY `fk_TB_AGENDAMENTO_TB_TIPO_VEICULO1_idx` (`CODIGO_TIPO_VEICULO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_EMPRESA1` FOREIGN KEY (`CODIGO_EMPRESA`) REFERENCES `tb_empresa` (`CODIGO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_TIPO_AGENDAMENTO1` FOREIGN KEY (`CODIGO_TIPO_AGENDAMENTO`) REFERENCES `tb_tipo_agendamento` (`CODIGO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_TIPO_CARGA1` FOREIGN KEY (`CODIGO_TIPO_CARGA`) REFERENCES `tb_tipo_carga` (`CODIGO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_TIPO_PALLET1` FOREIGN KEY (`CODIGO_TIPO_PALLET`) REFERENCES `tb_tipo_pallet` (`CODIGO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_TIPO_VEICULO1` FOREIGN KEY (`CODIGO_TIPO_VEICULO`) REFERENCES `tb_tipo_veiculo` (`CODIGO`),
  CONSTRAINT `fk_TB_AGENDAMENTO_TB_TRANSPORTADOR` FOREIGN KEY (`CODIGO_TRANSPORTADOR`) REFERENCES `tb_transportador` (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_agendamento`
--

LOCK TABLES `tb_agendamento` WRITE;
/*!40000 ALTER TABLE `tb_agendamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_agendamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_empresa`
--

DROP TABLE IF EXISTS `tb_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_empresa` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `EMPRESA` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_empresa`
--

LOCK TABLES `tb_empresa` WRITE;
/*!40000 ALTER TABLE `tb_empresa` DISABLE KEYS */;
INSERT INTO `tb_empresa` VALUES (1,'EXCEL'),(2,'WINE'),(3,'GLOBALBEV');
/*!40000 ALTER TABLE `tb_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tipo_agendamento`
--

DROP TABLE IF EXISTS `tb_tipo_agendamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tipo_agendamento` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO_AGENDAMENTO` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tipo_agendamento`
--

LOCK TABLES `tb_tipo_agendamento` WRITE;
/*!40000 ALTER TABLE `tb_tipo_agendamento` DISABLE KEYS */;
INSERT INTO `tb_tipo_agendamento` VALUES (1,'EXPEDIÇÃO'),(2,'RECEBIMENTO'),(3,'DEVOLUÇÃO');
/*!40000 ALTER TABLE `tb_tipo_agendamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tipo_carga`
--

DROP TABLE IF EXISTS `tb_tipo_carga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tipo_carga` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO_CARGA` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tipo_carga`
--

LOCK TABLES `tb_tipo_carga` WRITE;
/*!40000 ALTER TABLE `tb_tipo_carga` DISABLE KEYS */;
INSERT INTO `tb_tipo_carga` VALUES (1,'FECHADA'),(2,'FRACIONADA');
/*!40000 ALTER TABLE `tb_tipo_carga` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tipo_pallet`
--

DROP TABLE IF EXISTS `tb_tipo_pallet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tipo_pallet` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO_PALLET` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tipo_pallet`
--

LOCK TABLES `tb_tipo_pallet` WRITE;
/*!40000 ALTER TABLE `tb_tipo_pallet` DISABLE KEYS */;
INSERT INTO `tb_tipo_pallet` VALUES (1,'PBR'),(2,'DESCARTÁVEL');
/*!40000 ALTER TABLE `tb_tipo_pallet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tipo_veiculo`
--

DROP TABLE IF EXISTS `tb_tipo_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tipo_veiculo` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO_VEICULO` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tipo_veiculo`
--

LOCK TABLES `tb_tipo_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_tipo_veiculo` DISABLE KEYS */;
INSERT INTO `tb_tipo_veiculo` VALUES (1,'CARRETA'),(2,'TRUCK');
/*!40000 ALTER TABLE `tb_tipo_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_transportador`
--

DROP TABLE IF EXISTS `tb_transportador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_transportador` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `TRANSPORTADOR` varchar(1000) NOT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_transportador`
--

LOCK TABLES `tb_transportador` WRITE;
/*!40000 ALTER TABLE `tb_transportador` DISABLE KEYS */;
INSERT INTO `tb_transportador` VALUES (1,'CIRCULO'),(2,'GHISOLFI'),(3,'JTS');
/*!40000 ALTER TABLE `tb_transportador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `CODIGO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(1000) DEFAULT NULL,
  `EMAIL` varchar(1000) NOT NULL,
  `SENHA` varchar(1000) NOT NULL,
  `PERMISSAO` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`CODIGO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` VALUES (1,'Suellene Moledo da Conceição','suellene@wine.com.br','12345','Administrador');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bd_wstock'
--

--
-- Dumping routines for database 'bd_wstock'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-07  6:40:02
