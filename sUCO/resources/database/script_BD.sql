DROP DATABASE IF EXISTS sUCO;
CREATE DATABASE IF NOT EXISTS sUCO;
USE sUCO;

CREATE TABLE acao (
  cd_acao INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  ds_acao VARCHAR(40) NULL,
  cd_raia INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(cd_acao),
  INDEX Acao_FKIndex1(cd_raia)
);

CREATE TABLE casouso (
  cd_casoUso INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_casoUso VARCHAR(255) NOT NULL,
  cd_projeto INTEGER UNSIGNED NOT NULL,
  ds_objetivo VARCHAR(255) NULL,
  ds_preCondicao VARCHAR(255) NULL,
  ds_posCondicao VARCHAR(255) NULL,
  PRIMARY KEY(cd_casoUso),
  INDEX Caso_FKIndex1(cd_projeto)
);

CREATE TABLE cenario (
  cd_cenario INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_acao INTEGER UNSIGNED NOT NULL,
  nm_cenario VARCHAR(255) NOT NULL,
  fl_alternativo BOOL NULL,
  PRIMARY KEY(cd_cenario),
  INDEX cenario_FKIndex1(cd_acao)
);

CREATE TABLE componentediagrama (
  cd_componente INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_componente VARCHAR(255) NULL,
  ds_componente VARCHAR(255) NULL,
  nr_pos_x SMALLINT UNSIGNED NULL,
  nr_pos_y SMALLINT UNSIGNED NULL,
  nr_largura INTEGER UNSIGNED NULL,
  nr_altura INTEGER UNSIGNED NULL,
  cd_diagrama INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(cd_componente),
  INDEX ComponenteDiagrama_FKIndex1(cd_diagrama)
);

CREATE TABLE componenteligacao (
  cd_componente_in INTEGER UNSIGNED NOT NULL,
  cd_componente_out INTEGER UNSIGNED NULL,
  tp_ligacao SMALLINT UNSIGNED NULL,
  INDEX ComponenteLigacao_FKIndex1(cd_componente_in),
  INDEX ComponenteLigacao_FKIndex2(cd_componente_out)
);

CREATE TABLE diagrama (
  cd_diagrama INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_casoUso INTEGER UNSIGNED NOT NULL,
  nm_diagrama VARCHAR(255) NULL,
  ds_diagrama VARCHAR(255) NULL,
  PRIMARY KEY(cd_diagrama),
  INDEX Diagrama_FKIndex1(cd_casoUso)
);

CREATE TABLE projeto (
  cd_projeto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_projeto VARCHAR(255) NULL,
  dt_criacao VARCHAR(50) NULL,
  dt_atualizacao VARCHAR(50) NULL,
  nm_responsavel VARCHAR(255) NULL,
  PRIMARY KEY(cd_projeto)
);

CREATE TABLE raia (
  cd_raia INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_casoUso INTEGER UNSIGNED NULL,
  cd_cenario INTEGER UNSIGNED NULL,
  nm_raia VARCHAR(255) NULL,
  nr_tamanho INTEGER UNSIGNED NULL,
  PRIMARY KEY(cd_raia),
  INDEX Raia_FKIndex1(cd_cenario),
  INDEX raia_FKIndex2(cd_casoUso)
);

