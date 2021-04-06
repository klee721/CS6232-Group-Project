-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema cs6232-g3
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema cs6232-g3
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `cs6232-g3` DEFAULT CHARACTER SET utf8 ;
USE `cs6232-g3` ;

-- -----------------------------------------------------
-- Table `cs6232-g3`.`state`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`state` (
  `stateCode` VARCHAR(2) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`stateCode`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`persons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`persons` (
  `firstName` VARCHAR(45) NOT NULL,
  `lastName` VARCHAR(45) NOT NULL,
  `dateOfBirth` DATE NOT NULL,
  `gender` VARCHAR(10) NOT NULL,
  `SSN` CHAR(9) NULL,
  `Address1` VARCHAR(45) NOT NULL,
  `Address2` VARCHAR(45) NULL,
  `city` VARCHAR(45) NOT NULL,
  `state` VARCHAR(45) NOT NULL,
  `zipcode` VARCHAR(10) NOT NULL,
  `phoneNumber` CHAR(10) NOT NULL,
  `id` INT NOT NULL,
  `state_stateCode` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `SSN_UNIQUE` (`SSN` ASC) VISIBLE,
  UNIQUE INDEX `PERSON_UNIQUE` (`firstName` ASC, `lastName` ASC, `dateOfBirth` ASC) VISIBLE,
  INDEX `fk_persons_state1_idx` (`state_stateCode` ASC) VISIBLE,
  CONSTRAINT `fk_persons_state1`
    FOREIGN KEY (`state_stateCode`)
    REFERENCES `cs6232-g3`.`state` (`stateCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = '																																										';


-- -----------------------------------------------------
-- Table `cs6232-g3`.`nurses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`nurses` (
  `Id` INT NOT NULL,
  `status` VARCHAR(45) NOT NULL,
  `persons_id` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_nurses_persons1_idx` (`persons_id` ASC) VISIBLE,
  CONSTRAINT `fk_nurses_persons1`
    FOREIGN KEY (`persons_id`)
    REFERENCES `cs6232-g3`.`persons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`login`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`login` (
  `userName` VARCHAR(45) NOT NULL,
  `password` VARCHAR(450) NOT NULL,
  `admin_id` INT NULL,
  `nurse_id` INT NULL,
  `doctor_id` INT NULL,
  `patient_id` INT NULL,
  `nurses_Id` INT NULL,
  PRIMARY KEY (`userName`),
  INDEX `fk_login_nurses1_idx` (`nurses_Id` ASC) VISIBLE,
  CONSTRAINT `fk_login_nurses1`
    FOREIGN KEY (`nurses_Id`)
    REFERENCES `cs6232-g3`.`nurses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`doctors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`doctors` (
  `Id` INT NOT NULL,
  `persons_id` INT NOT NULL,
  `login_userName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_doctors_persons1_idx` (`persons_id` ASC) VISIBLE,
  INDEX `fk_doctors_login1_idx` (`login_userName` ASC) VISIBLE,
  CONSTRAINT `fk_doctors_persons1`
    FOREIGN KEY (`persons_id`)
    REFERENCES `cs6232-g3`.`persons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_doctors_login1`
    FOREIGN KEY (`login_userName`)
    REFERENCES `cs6232-g3`.`login` (`userName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`patients`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`patients` (
  `id` INT NOT NULL,
  `persons_id` INT NOT NULL,
  `login_userName` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_patients_persons2_idx` (`persons_id` ASC) VISIBLE,
  INDEX `fk_patients_login1_idx` (`login_userName` ASC) VISIBLE,
  CONSTRAINT `fk_patients_persons2`
    FOREIGN KEY (`persons_id`)
    REFERENCES `cs6232-g3`.`persons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patients_login1`
    FOREIGN KEY (`login_userName`)
    REFERENCES `cs6232-g3`.`login` (`userName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`clinicAdmins`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`clinicAdmins` (
  `Id` INT NOT NULL,
  `persons_id` INT NOT NULL,
  `login_userName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_clinicAdmins_persons1_idx` (`persons_id` ASC) VISIBLE,
  INDEX `fk_clinicAdmins_login1_idx` (`login_userName` ASC) VISIBLE,
  CONSTRAINT `fk_clinicAdmins_persons1`
    FOREIGN KEY (`persons_id`)
    REFERENCES `cs6232-g3`.`persons` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_clinicAdmins_login1`
    FOREIGN KEY (`login_userName`)
    REFERENCES `cs6232-g3`.`login` (`userName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`doctorSpecialities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`doctorSpecialities` (
  `doctorId` INT NOT NULL,
  `specialityType` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) NULL,
  PRIMARY KEY (`doctorId`, `specialityType`),
  CONSTRAINT `fk_doctorSpecialities_doctors1`
    FOREIGN KEY (`doctorId`)
    REFERENCES `cs6232-g3`.`doctors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`appointments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`appointments` (
  `patientId` INT NOT NULL,
  `doctorId` INT NOT NULL,
  `AppointmentDateTime` DATETIME NOT NULL,
  `reasons` VARCHAR(45) NOT NULL,
  `Id` INT NOT NULL,
  `status` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_appointments_doctors1_idx` (`doctorId` ASC) INVISIBLE,
  UNIQUE INDEX `uk_doctor` (`doctorId` ASC, `AppointmentDateTime` ASC, `status` ASC) INVISIBLE,
  CONSTRAINT `fk_appointments_patients1`
    FOREIGN KEY (`patientId`)
    REFERENCES `cs6232-g3`.`patients` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_appointments_doctors1`
    FOREIGN KEY (`doctorId`)
    REFERENCES `cs6232-g3`.`doctors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`visits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`visits` (
  `patientId` INT NOT NULL,
  `AppointmentDateTime` DATETIME NOT NULL,
  `weight` DECIMAL(10,2) NOT NULL,
  `height` DECIMAL(10,2) NOT NULL,
  `bodyTemparature` INT NOT NULL,
  `pulse` INT NOT NULL,
  `doctorId` INT NOT NULL,
  `symptoms` VARCHAR(45) NOT NULL,
  `nurseId` INT NOT NULL,
  `bloodPressureSystolic` INT NOT NULL,
  `bloodPressureDiastolic` INT NOT NULL,
  `initialDiagnose` VARCHAR(45) NOT NULL,
  `finalDiagnose` VARCHAR(45) NULL,
  PRIMARY KEY (`patientId`, `AppointmentDateTime`, `doctorId`),
  INDEX `fk_visits_nurses1_idx` (`nurseId` ASC) VISIBLE,
  CONSTRAINT `fk_visits_appointments1`
    FOREIGN KEY (`patientId` , `AppointmentDateTime` , `doctorId`)
    REFERENCES `cs6232-g3`.`appointments` (`patientId` , `AppointmentDateTime` , `doctorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_visits_nurses1`
    FOREIGN KEY (`nurseId`)
    REFERENCES `cs6232-g3`.`nurses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`tests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`tests` (
  `testCode` VARCHAR(10) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) NULL,
  PRIMARY KEY (`testCode`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cs6232-g3`.`labTests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cs6232-g3`.`labTests` (
  `patientId` INT NOT NULL,
  `orderDateTime` DATETIME NOT NULL,
  `performedDateTime` DATETIME NULL,
  `testCode` VARCHAR(10) NOT NULL,
  `results` VARCHAR(45) NULL,
  `normal` VARCHAR(1) NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`patientId`, `orderDateTime`, `testCode`),
  INDEX `fk_labTests_tests1_idx` (`testCode` ASC) VISIBLE,
  CONSTRAINT `fk_labTests_tests1`
    FOREIGN KEY (`testCode`)
    REFERENCES `cs6232-g3`.`tests` (`testCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_labTests_visits1`
    FOREIGN KEY (`patientId` , `orderDateTime`)
    REFERENCES `cs6232-g3`.`visits` (`patientId` , `AppointmentDateTime`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
