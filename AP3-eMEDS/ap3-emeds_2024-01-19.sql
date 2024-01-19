# ************************************************************
# Sequel Ace SQL dump
# Version 20052
#
# https://sequel-ace.com/
# https://github.com/Sequel-Ace/Sequel-Ace
#
# Host: localhost (MySQL 8.2.0)
# Database: ap3-emeds
# Generation Time: 2024-01-19 11:31:26 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
SET NAMES utf8mb4;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE='NO_AUTO_VALUE_ON_ZERO', SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table allergie
# ------------------------------------------------------------

CREATE TABLE `allergie` (
  `id_al` int NOT NULL AUTO_INCREMENT,
  `libelle_al` varchar(100) NOT NULL,
  PRIMARY KEY (`id_al`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `allergie` WRITE;
/*!40000 ALTER TABLE `allergie` DISABLE KEYS */;

INSERT INTO `allergie` (`id_al`, `libelle_al`)
VALUES
	(1,'Allergie au pollen'),
	(3,'Allergie aux poils de chat'),
	(4,'Allergie à l\'aspirine'),
	(5,'Allergie au paracétamol'),
	(6,'Réaction allergique aux pénicillines'),
	(7,'Allergie aux achariens');

/*!40000 ALTER TABLE `allergie` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table antecedent
# ------------------------------------------------------------

CREATE TABLE `antecedent` (
  `id_a` int NOT NULL AUTO_INCREMENT,
  `libelle_a` varchar(100) NOT NULL,
  PRIMARY KEY (`id_a`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `antecedent` WRITE;
/*!40000 ALTER TABLE `antecedent` DISABLE KEYS */;

INSERT INTO `antecedent` (`id_a`, `libelle_a`)
VALUES
	(1,'Ulcères gastriques actifs'),
	(2,'Tendinite'),
	(3,'Insuffisance rénale'),
	(4,'Grossesse'),
	(5,'Hyperkaliémie'),
	(6,'Hypotension sévère'),
	(7,'Syndrome sérotoninergique'),
	(8,'Maladie du foie active'),
	(9,'Dépendance aux substances'),
	(10,'Infections fongiques systémiques'),
	(11,'Angioedème'),
	(12,'Tachycardie'),
	(13,'Dépendance'),
	(14,'Porphyrie aiguë'),
	(15,'Saignement actif');

/*!40000 ALTER TABLE `antecedent` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table avoir
# ------------------------------------------------------------

CREATE TABLE `avoir` (
  `id_a` int NOT NULL,
  `id_p` int NOT NULL,
  PRIMARY KEY (`id_a`,`id_p`),
  KEY `Avoir_Patient0_FK` (`id_p`),
  CONSTRAINT `Avoir_Antecedent_FK` FOREIGN KEY (`id_a`) REFERENCES `antecedent` (`id_a`),
  CONSTRAINT `Avoir_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `avoir` WRITE;
/*!40000 ALTER TABLE `avoir` DISABLE KEYS */;

INSERT INTO `avoir` (`id_a`, `id_p`)
VALUES
	(6,1),
	(7,1),
	(4,6),
	(3,9);

/*!40000 ALTER TABLE `avoir` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table etre
# ------------------------------------------------------------

CREATE TABLE `etre` (
  `id_al` int NOT NULL,
  `id_p` int NOT NULL,
  PRIMARY KEY (`id_al`,`id_p`),
  KEY `Etre_Patient0_FK` (`id_p`),
  CONSTRAINT `Etre_Allergie_FK` FOREIGN KEY (`id_al`) REFERENCES `allergie` (`id_al`),
  CONSTRAINT `Etre_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `etre` WRITE;
/*!40000 ALTER TABLE `etre` DISABLE KEYS */;

INSERT INTO `etre` (`id_al`, `id_p`)
VALUES
	(3,1),
	(4,1),
	(4,6),
	(6,8),
	(5,9);

/*!40000 ALTER TABLE `etre` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table incompatible
# ------------------------------------------------------------

CREATE TABLE `incompatible` (
  `id_a` int DEFAULT NULL,
  `id_med` int NOT NULL,
  `id_al` int DEFAULT NULL,
  `id_med_Medicament` int DEFAULT NULL,
  UNIQUE KEY `incompatible_PK` (`id_a`,`id_med`,`id_al`,`id_med_Medicament`),
  KEY `incompatible_Medicament0_FK` (`id_med`),
  KEY `incompatible_Allergie1_FK` (`id_al`),
  KEY `incompatible_Medicament2_FK` (`id_med_Medicament`),
  CONSTRAINT `incompatible_Allergie1_FK` FOREIGN KEY (`id_al`) REFERENCES `allergie` (`id_al`),
  CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id_a`) REFERENCES `antecedent` (`id_a`),
  CONSTRAINT `incompatible_Medicament0_FK` FOREIGN KEY (`id_med`) REFERENCES `medicament` (`id_med`),
  CONSTRAINT `incompatible_Medicament2_FK` FOREIGN KEY (`id_med_Medicament`) REFERENCES `medicament` (`id_med`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `incompatible` WRITE;
/*!40000 ALTER TABLE `incompatible` DISABLE KEYS */;

INSERT INTO `incompatible` (`id_a`, `id_med`, `id_al`, `id_med_Medicament`)
VALUES
	(NULL,1,5,NULL),
	(NULL,1,6,NULL),
	(NULL,2,NULL,6),
	(NULL,2,NULL,8),
	(NULL,2,4,NULL),
	(NULL,3,5,NULL);

/*!40000 ALTER TABLE `incompatible` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table ligne_ordonnance
# ------------------------------------------------------------

CREATE TABLE `ligne_ordonnance` (
  `id_o` int NOT NULL,
  `id_med` int NOT NULL,
  PRIMARY KEY (`id_o`,`id_med`),
  KEY `ligne_ordonnance_Medicament_FK` (`id_med`),
  CONSTRAINT `ligne_ordonnance_Medicament_FK` FOREIGN KEY (`id_med`) REFERENCES `medicament` (`id_med`),
  CONSTRAINT `ligne_ordonnance_Ordonnance_FK` FOREIGN KEY (`id_o`) REFERENCES `ordonnance` (`id_o`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `ligne_ordonnance` WRITE;
/*!40000 ALTER TABLE `ligne_ordonnance` DISABLE KEYS */;

INSERT INTO `ligne_ordonnance` (`id_o`, `id_med`)
VALUES
	(3,1),
	(4,2),
	(1,3),
	(3,6),
	(4,7),
	(4,12);

/*!40000 ALTER TABLE `ligne_ordonnance` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table medecin
# ------------------------------------------------------------

CREATE TABLE `medecin` (
  `id_m` int NOT NULL AUTO_INCREMENT,
  `nom_m` varchar(100) NOT NULL,
  `prenom_m` varchar(100) NOT NULL,
  `date_naissance_m` varchar(100) NOT NULL,
  `login_m` varchar(100) NOT NULL,
  `password_m` varchar(100) NOT NULL,
  `role` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_m`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `medecin` WRITE;
/*!40000 ALTER TABLE `medecin` DISABLE KEYS */;

INSERT INTO `medecin` (`id_m`, `nom_m`, `prenom_m`, `date_naissance_m`, `login_m`, `password_m`, `role`)
VALUES
	(1,'ITH','Kagnana','2003-03-17','ikagnana@gmail.com','$2a$11$vbqJRWkqy.etv1WJHIdU9Om3I8tP11WI2ryBp0BIzIrQmIf5Tipda','ADMIN'),
	(3,'Simple','User','1946-07-14','simpleuser@gmail.com','$2a$11$ExmcF1Q0cIeFTPLqmaqwQuvqKHx.hQXdOj.njXyxbRnxGcZ0qbqMi','USER');

/*!40000 ALTER TABLE `medecin` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table medicament
# ------------------------------------------------------------

CREATE TABLE `medicament` (
  `id_med` int NOT NULL AUTO_INCREMENT,
  `libelle_med` varchar(100) NOT NULL,
  `contre_indication` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_med`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `medicament` WRITE;
/*!40000 ALTER TABLE `medicament` DISABLE KEYS */;

INSERT INTO `medicament` (`id_med`, `libelle_med`, `contre_indication`)
VALUES
	(1,'doliprane','ne pas prendre plus de 6 par jours'),
	(2,'Aspirine','Allergie à l\'aspirine'),
	(3,'Paracétamol','Allergie au paracétamol'),
	(4,'Ibuprofène','Ulcères gastriques actifs'),
	(5,'Amoxicilline','Réaction allergique aux pénicillines'),
	(6,'Ciprofloxacine','Tendinite'),
	(7,'Metformine','Insuffisance rénale'),
	(8,'Omeprazole','Grossesse'),
	(9,'Losartan','Hyperkaliémie'),
	(10,'Simvastatine','Maladie du foie active'),
	(11,'Amlodipine','Hypotension sévère'),
	(12,'Atorvastatine','Maladie du foie active'),
	(13,'Sertraline','Syndrome sérotoninergique'),
	(14,'Fluoxetine','Syndrome sérotoninergique'),
	(15,'Diazepam','Dépendance aux substances'),
	(16,'Prednisone','Infections fongiques systémiques'),
	(17,'Lisinopril','Angioedème'),
	(18,'Albuterol','Tachycardie'),
	(19,'Gabapentine','Dépendance'),
	(20,'Ranitidine','Porphyrie aiguë'),
	(21,'Warfarine','Saignement actif');

/*!40000 ALTER TABLE `medicament` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table ordonnance
# ------------------------------------------------------------

CREATE TABLE `ordonnance` (
  `id_o` int NOT NULL AUTO_INCREMENT,
  `posologie` varchar(100) NOT NULL,
  `duree_traitement` varchar(100) NOT NULL,
  `instructions_specifique` varchar(100) NOT NULL,
  `code` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_m` int NOT NULL,
  `id_p` int NOT NULL,
  PRIMARY KEY (`id_o`),
  KEY `Ordonnance_Medecin_FK` (`id_m`),
  KEY `Ordonnance_Patient0_FK` (`id_p`),
  CONSTRAINT `Ordonnance_Medecin_FK` FOREIGN KEY (`id_m`) REFERENCES `medecin` (`id_m`),
  CONSTRAINT `Ordonnance_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `ordonnance` WRITE;
/*!40000 ALTER TABLE `ordonnance` DISABLE KEYS */;

INSERT INTO `ordonnance` (`id_o`, `posologie`, `duree_traitement`, `instructions_specifique`, `code`, `id_m`, `id_p`)
VALUES
	(1,'20mg','3 mois','Ne pas oublier','9c106609-9f75-4bea-9de9-0d066bc19ad2',1,1),
	(2,'1','2 jour','RAS','8c5f1510-bd6f-48ba-b996-5d0bda0c0920',1,1),
	(3,'','4 jour','','6cc0c6b0-66ec-4e07-90db-04375f9d1e26',1,1),
	(4,'1g de chaque','4 jour','Si douleurs persistante, coupler avec du doliprane','0b0f13f3-7cef-4292-9a53-bed3b41bf3de',1,1);

/*!40000 ALTER TABLE `ordonnance` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table patient
# ------------------------------------------------------------

CREATE TABLE `patient` (
  `id_p` int NOT NULL AUTO_INCREMENT,
  `nom_p` varchar(100) NOT NULL,
  `prenom_p` varchar(100) NOT NULL,
  `sexe_p` varchar(100) NOT NULL,
  `num_secu` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;

INSERT INTO `patient` (`id_p`, `nom_p`, `prenom_p`, `sexe_p`, `num_secu`)
VALUES
	(1,'Doe','John','M','123456789123412'),
	(2,'Martin','Thomas','M','154392345434566'),
	(3,'Laroche','Julie','F','243234523124323'),
	(4,'Delacourt','Francis','F','243243532341243'),
	(5,'Rabbit','Roger','M','123442342512314'),
	(6,'test','ajout','F','241231453121435'),
	(7,'test','test','F','1232341234353'),
	(8,'test','reload','M','123124123134325'),
	(9,'Demo','Demo','M','123144235125432');

/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;



/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
