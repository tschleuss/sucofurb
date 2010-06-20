DROP DATABASE IF EXISTS sUCO;
CREATE DATABASE IF NOT EXISTS sUCO;
USE sUCO;


DROP TABLE IF EXISTS acao;


CREATE TABLE acao (
  cd_acao int(10) unsigned NOT NULL AUTO_INCREMENT,
  ds_acao varchar(40) DEFAULT NULL,
  cd_raia int(10) unsigned NOT NULL,
  PRIMARY KEY (cd_acao),
  KEY Acao_FKIndex1 (cd_raia)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS casouso;


CREATE TABLE casouso (
  cd_casoUso int(10) unsigned NOT NULL AUTO_INCREMENT,
  nm_casoUso varchar(255) NOT NULL,
  cd_projeto int(10) unsigned NOT NULL,
  ds_objetivo varchar(255) DEFAULT NULL,
  ds_preCondicao varchar(255) DEFAULT NULL,
  ds_posCondicao varchar(255) DEFAULT NULL,
  PRIMARY KEY (cd_casoUso),
  KEY Caso_FKIndex1 (cd_projeto)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS cenario;


CREATE TABLE cenario (
  cd_cenario int(10) unsigned NOT NULL AUTO_INCREMENT,
  cd_acao int(10) unsigned NOT NULL,
  nm_cenario varchar(255) NOT NULL,
  fl_alternativo tinyint(1) DEFAULT NULL,
  PRIMARY KEY (cd_cenario),
  KEY cenario_FKIndex1 (cd_acao)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS componentediagrama;

CREATE TABLE componentediagrama (
  cd_casoUso int(11) DEFAULT NULL,
  ds_content longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS projeto;


CREATE TABLE projeto (
  cd_projeto int(10) unsigned NOT NULL AUTO_INCREMENT,
  nm_projeto varchar(255) DEFAULT NULL,
  dt_criacao varchar(50) DEFAULT NULL,
  dt_atualizacao varchar(50) DEFAULT NULL,
  nm_responsavel varchar(255) DEFAULT NULL,
  PRIMARY KEY (cd_projeto)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS raia;


CREATE TABLE raia (
  cd_raia int(10) unsigned NOT NULL AUTO_INCREMENT,
  cd_casoUso int(10) unsigned DEFAULT NULL,
  cd_cenario int(10) unsigned DEFAULT NULL,
  nm_raia varchar(255) DEFAULT NULL,
  nr_tamanho int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (cd_raia),
  KEY Raia_FKIndex1 (cd_cenario),
  KEY raia_FKIndex2 (cd_casoUso)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
