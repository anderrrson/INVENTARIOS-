-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Proveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Proveedor` (
  `idProveedor` INT NOT NULL,
  `Nombres` VARCHAR(45) NULL,
  `Apellidos` VARCHAR(45) NULL,
  `Edad` INT NULL,
  `Genero` VARCHAR(45) NULL,
  `Telefono` VARCHAR(45) NULL,
  `Dpi` VARCHAR(45) NULL,
  `NIT` VARCHAR(45) NULL,
  `Direccion` VARCHAR(45) NULL,
  `Disponible` TINYINT NULL,
  PRIMARY KEY (`idProveedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Categoria` (
  `idCategoria` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Tipo_Producto` VARCHAR(45) NULL,
  PRIMARY KEY (`idCategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Producto` (
  `idProducto` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Precio` DOUBLE NULL,
  `Saldo` DOUBLE NULL,
  `Cantidad_Maxima` VARCHAR(45) NULL,
  `Cantidad_Minima` VARCHAR(45) NULL,
  `Comentarios` VARCHAR(45) NULL,
  `idProveedor` INT NOT NULL,
  `idCategoria` INT NOT NULL,
  `Disponible` TINYINT NULL,
  PRIMARY KEY (`idProducto`),
  INDEX `fk_Prodcuto_Proveedor1_idx` (`idProveedor` ASC) VISIBLE,
  INDEX `fk_Prodcuto_Categoria1_idx` (`idCategoria` ASC) VISIBLE,
  CONSTRAINT `fk_Prodcuto_Proveedor1`
    FOREIGN KEY (`idProveedor`)
    REFERENCES `mydb`.`Tbl_Proveedor` (`idProveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Prodcuto_Categoria1`
    FOREIGN KEY (`idCategoria`)
    REFERENCES `mydb`.`Tbl_Categoria` (`idCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Impuesto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Impuesto` (
  `idImpuesto` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Tasa` DECIMAL(5) NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idImpuesto`),
  INDEX `fk_Impuesto_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Impuesto_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Stock`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Stock` (
  `idStock` INT NOT NULL,
  `Cantidad_Maxima` INT NULL,
  `Cantidad_Minima` INT NULL,
  PRIMARY KEY (`idStock`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Marca` (
  `idMarca` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Pais_Origen` VARCHAR(45) NULL,
  PRIMARY KEY (`idMarca`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Detalle_Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Detalle_Producto` (
  `idDetalle_Producto` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Presentacion` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(45) NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idDetalle_Producto`),
  INDEX `fk_Detalle_Producto_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Detalle_Producto_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Ubicacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Ubicacion` (
  `idUbicacion` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Direccion` VARCHAR(45) NULL,
  `Capacidad` INT(10) NULL,
  PRIMARY KEY (`idUbicacion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Producto_Marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Producto_Marca` (
  `idProducto` INT NOT NULL,
  `idMarca` INT NOT NULL,
  PRIMARY KEY (`idProducto`, `idMarca`),
  INDEX `fk_Prodcuto_has_Marca_Marca1_idx` (`idMarca` ASC) VISIBLE,
  INDEX `fk_Prodcuto_has_Marca_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Prodcuto_has_Marca_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Prodcuto_has_Marca_Marca1`
    FOREIGN KEY (`idMarca`)
    REFERENCES `mydb`.`Tbl_Marca` (`idMarca`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_UbicacionProdcuto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_UbicacionProdcuto` (
  `idUbicacion` INT NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idUbicacion`, `idProducto`),
  INDEX `fk_Ubicacion_has_Prodcuto_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  INDEX `fk_Ubicacion_has_Prodcuto_Ubicacion1_idx` (`idUbicacion` ASC) VISIBLE,
  CONSTRAINT `fk_Ubicacion_has_Prodcuto_Ubicacion1`
    FOREIGN KEY (`idUbicacion`)
    REFERENCES `mydb`.`Tbl_Ubicacion` (`idUbicacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ubicacion_has_Prodcuto_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Moviemiento_Inventario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Moviemiento_Inventario` (
  `idMoviemiento_Inventario` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Naturaleza` VARCHAR(45) NULL,
  PRIMARY KEY (`idMoviemiento_Inventario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Sucursal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Sucursal` (
  `idSucursal` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Direccion` VARCHAR(45) NULL,
  PRIMARY KEY (`idSucursal`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Bodega`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Bodega` (
  `idBodega` INT NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Status` VARCHAR(45) NULL,
  `idSucursal` INT NOT NULL,
  PRIMARY KEY (`idBodega`, `idSucursal`),
  INDEX `fk_Bodega_Sucursal1_idx` (`idSucursal` ASC) VISIBLE,
  CONSTRAINT `fk_Bodega_Sucursal1`
    FOREIGN KEY (`idSucursal`)
    REFERENCES `mydb`.`Tbl_Sucursal` (`idSucursal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Historia_Inventario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Historia_Inventario` (
  `idProducto` INT NOT NULL,
  `idMovimiento_Inventario` INT NOT NULL,
  `Fecha` DATETIME NULL,
  `Cantidad` VARCHAR(45) NULL,
  `idBodega` INT NOT NULL,
  `idSucursal` INT NOT NULL,
  PRIMARY KEY (`idProducto`, `idMovimiento_Inventario`),
  INDEX `fk_Prodcuto_has_Moviemiento_Inventario_Moviemiento_Inventar_idx` (`idMovimiento_Inventario` ASC) VISIBLE,
  INDEX `fk_Prodcuto_has_Moviemiento_Inventario_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  INDEX `fk_Historia_Inventario_Bodega1_idx` (`idBodega` ASC, `idSucursal` ASC) VISIBLE,
  CONSTRAINT `fk_Prodcuto_has_Moviemiento_Inventario_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Prodcuto_has_Moviemiento_Inventario_Moviemiento_Inventario1`
    FOREIGN KEY (`idMovimiento_Inventario`)
    REFERENCES `mydb`.`Tbl_Moviemiento_Inventario` (`idMoviemiento_Inventario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Historia_Inventario_Bodega1`
    FOREIGN KEY (`idBodega` , `idSucursal`)
    REFERENCES `mydb`.`Tbl_Bodega` (`idBodega` , `idSucursal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Existencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Existencia` (
  `idExistencia` INT NOT NULL,
  `Cantidad` VARCHAR(45) NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idExistencia`, `idProducto`),
  INDEX `fk_Existencia_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Existencia_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tbl_Inventario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tbl_Inventario` (
  `idBodega` INT NOT NULL,
  `idProducto` INT NOT NULL,
  `idStock` INT NOT NULL,
  `Cantidad` VARCHAR(45) NULL,
  `idExistencia` INT NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idBodega`, `idProducto`, `idStock`),
  INDEX `fk_Bodega_has_Prodcuto_Prodcuto1_idx` (`idProducto` ASC) VISIBLE,
  INDEX `fk_Bodega_has_Prodcuto_Bodega1_idx` (`idBodega` ASC) VISIBLE,
  INDEX `fk_Inventario_Stock1_idx` (`idStock` ASC) VISIBLE,
  INDEX `fk_Inventario_Existencia1_idx` (`idExistencia` ASC, `idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Bodega_has_Prodcuto_Bodega1`
    FOREIGN KEY (`idBodega`)
    REFERENCES `mydb`.`Tbl_Bodega` (`idBodega`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Bodega_has_Prodcuto_Prodcuto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Tbl_Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Inventario_Stock1`
    FOREIGN KEY (`idStock`)
    REFERENCES `mydb`.`Tbl_Stock` (`idStock`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Inventario_Existencia1`
    FOREIGN KEY (`idExistencia` , `idProducto`)
    REFERENCES `mydb`.`Tbl_Existencia` (`idExistencia` , `idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
