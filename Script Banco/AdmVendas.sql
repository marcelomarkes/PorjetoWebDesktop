-- MySQL Workbench Synchronization
-- Generated: 2018-09-13 07:03
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: Usuario

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `db_vendas` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_empresa` (
  `id_empresa` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_empresa` VARCHAR(45) NOT NULL COMMENT '',
  `email_empresa` VARCHAR(45) NOT NULL COMMENT '',
  `cnpj_empresa` VARCHAR(15) NOT NULL COMMENT '',
  `senha_empresa` VARCHAR(45) NOT NULL COMMENT '',
  `status_empresa` TINYINT(1) NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`id_empresa`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_marca` (
  `id_marca` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_marca` VARCHAR(20) NOT NULL COMMENT '',
  `id_empresa` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_marca`)  COMMENT '',
  INDEX `fk_tb_marca_tb_empresa_idx` (`id_empresa` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_marca_tb_empresa`
    FOREIGN KEY (`id_empresa`)
    REFERENCES `db_vendas`.`tb_empresa` (`id_empresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_modelo` (
  `id_modelo` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_modelo` VARCHAR(20) NOT NULL COMMENT '',
  `id_empresa` INT(11) NOT NULL COMMENT '',
  `id_marca` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_modelo`)  COMMENT '',
  INDEX `fk_tb_modelo_tb_empresa1_idx` (`id_empresa` ASC)  COMMENT '',
  INDEX `fk_tb_modelo_tb_marca1_idx` (`id_marca` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_modelo_tb_empresa1`
    FOREIGN KEY (`id_empresa`)
    REFERENCES `db_vendas`.`tb_empresa` (`id_empresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_modelo_tb_marca1`
    FOREIGN KEY (`id_marca`)
    REFERENCES `db_vendas`.`tb_marca` (`id_marca`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_cor` (
  `id_cor` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_cor` VARCHAR(35) NOT NULL COMMENT '',
  `id_empresa` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_cor`)  COMMENT '',
  INDEX `fk_tb_cor_tb_empresa1_idx` (`id_empresa` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_cor_tb_empresa1`
    FOREIGN KEY (`id_empresa`)
    REFERENCES `db_vendas`.`tb_empresa` (`id_empresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_veiculo` (
  `id_veiculo` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `placa_veiculo` VARCHAR(7) NOT NULL COMMENT '',
  `anofab_veiculo` SMALLINT(4) NOT NULL COMMENT '',
  `ano_veiculo` SMALLINT(4) NOT NULL COMMENT '',
  `km_veiculo` VARCHAR(6) NOT NULL COMMENT '',
  `porta_veiculo` SMALLINT(1) NOT NULL COMMENT '0 - 2 Portas\n1 - 4 Portas',
  `airbag_veiculo` SMALLINT(1) NOT NULL COMMENT '0 - nenhum\n1 - 2 airbags\n2 - 4 airbags\n3 - 8 airbags',
  `direcao_veiculo` SMALLINT(1) NOT NULL COMMENT '0 - Manul\n1 - Hidraulica\n2 - Eletrica',
  `situacao_veiculo` SMALLINT(1) NOT NULL COMMENT '0 - Ativo\n1 - Inativo\n2 - Vendido',
  `ar_veiculo` TINYINT(1) NOT NULL COMMENT '',
  `abs_veiculo` TINYINT(1) NOT NULL COMMENT '',
  `venda_veiculo` DECIMAL(10,2) NOT NULL COMMENT '',
  `compra_veiculo` DECIMAL(10,2) NOT NULL COMMENT '',
  `obs_veiculo` VARCHAR(200) NOT NULL COMMENT '',
  `data_veiculo` DATE NULL DEFAULT NULL COMMENT '',
  `id_modelo` INT(11) NOT NULL COMMENT '',
  `id_cor` INT(11) NOT NULL COMMENT '',
  `id_empresa` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_veiculo`)  COMMENT '',
  INDEX `fk_tb_veiculo_tb_modelo1_idx` (`id_modelo` ASC)  COMMENT '',
  INDEX `fk_tb_veiculo_tb_cor1_idx` (`id_cor` ASC)  COMMENT '',
  INDEX `fk_tb_veiculo_tb_empresa1_idx` (`id_empresa` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_veiculo_tb_modelo1`
    FOREIGN KEY (`id_modelo`)
    REFERENCES `db_vendas`.`tb_modelo` (`id_modelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_veiculo_tb_cor1`
    FOREIGN KEY (`id_cor`)
    REFERENCES `db_vendas`.`tb_cor` (`id_cor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_veiculo_tb_empresa1`
    FOREIGN KEY (`id_empresa`)
    REFERENCES `db_vendas`.`tb_empresa` (`id_empresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_vendedor` (
  `id_vendedor` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_vendedor` VARCHAR(45) NOT NULL COMMENT '',
  `email_vendedor` VARCHAR(45) NOT NULL COMMENT '',
  `tel_vendedor` VARCHAR(11) NOT NULL COMMENT '',
  `endereco_vendedor` VARCHAR(65) NOT NULL COMMENT '',
  `senha_vendedor` VARCHAR(12) NOT NULL COMMENT '',
  `status_vendedor` TINYINT(1) NOT NULL COMMENT '',
  `data_vendedor` DATE NULL DEFAULT NULL COMMENT '',
  `id_empresa` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_vendedor`)  COMMENT '',
  INDEX `fk_tb_vendedor_tb_empresa1_idx` (`id_empresa` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_vendedor_tb_empresa1`
    FOREIGN KEY (`id_empresa`)
    REFERENCES `db_vendas`.`tb_empresa` (`id_empresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_cliente` (
  `id_cliente` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `nome_cliente` VARCHAR(45) NOT NULL COMMENT '',
  `email_cliente` VARCHAR(45) NOT NULL COMMENT '',
  `tel_cliente` VARCHAR(11) NOT NULL COMMENT '',
  `endereco_cliente` VARCHAR(65) NOT NULL COMMENT '',
  `id_vendedor` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_cliente`)  COMMENT '',
  INDEX `fk_tb_cliente_tb_vendedor1_idx` (`id_vendedor` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_cliente_tb_vendedor1`
    FOREIGN KEY (`id_vendedor`)
    REFERENCES `db_vendas`.`tb_vendedor` (`id_vendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;

CREATE TABLE IF NOT EXISTS `db_vendas`.`tb_venda` (
  `id_venda` INT(11) NOT NULL AUTO_INCREMENT COMMENT '',
  `formapgto_venda` SMALLINT(1) NOT NULL COMMENT '1 - Dinheiro\n2 - Cheque\n3 - Cartão',
  `descricao_venda` VARCHAR(200) NOT NULL COMMENT '',
  `id_vendedor` INT(11) NOT NULL COMMENT '',
  `id_veiculo` INT(11) NOT NULL COMMENT '',
  `id_cliente` INT(11) NOT NULL COMMENT '',
  `data_venda` DATE NOT NULL COMMENT '',
  PRIMARY KEY (`id_venda`)  COMMENT '',
  INDEX `fk_tb_venda_tb_vendedor1_idx` (`id_vendedor` ASC)  COMMENT '',
  INDEX `fk_tb_venda_tb_veiculo1_idx` (`id_veiculo` ASC)  COMMENT '',
  INDEX `fk_tb_venda_tb_cliente1_idx` (`id_cliente` ASC)  COMMENT '',
  CONSTRAINT `fk_tb_venda_tb_vendedor1`
    FOREIGN KEY (`id_vendedor`)
    REFERENCES `db_vendas`.`tb_vendedor` (`id_vendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_venda_tb_veiculo1`
    FOREIGN KEY (`id_veiculo`)
    REFERENCES `db_vendas`.`tb_veiculo` (`id_veiculo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_venda_tb_cliente1`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `db_vendas`.`tb_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_general_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

use db_vendas;

INSERT INTO tb_empresa (nome_empresa, email_empresa, cnpj_empresa, status_empresa) VALUES('teste', 'teste@teste.com.br', '01124124000112', 1);

INSERT INTO tb_vendedor (nome_vendedor, email_vendedor, tel_vendedor, endereco_vendedor, senha_vendedor, status_vendedor, data_vendedor, id_empresa) VALUES('teste', 'teste@teste.com.br', '43303062621', 'Rua Portugal', '1234', 1, '20001212', 1);
