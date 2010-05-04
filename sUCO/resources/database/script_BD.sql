

CREATE DATABASE IF NOT EXISTS sUCO;
USE sUCO;


DROP TABLE IF EXISTS Projeto;
CREATE TABLE Projeto (
  cd_projeto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_projeto VARCHAR(255) NULL,
  dt_criacao DATETIME NULL,
  dt_atualizacao DATETIME NULL,
  nm_responsavel VARCHAR(255) NULL,
  PRIMARY KEY(cd_projeto)
);

DROP TABLE IF EXISTS CasoUso;
CREATE TABLE CasoUso (
  cd_casoUso INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_casoUso VARCHAR(255) NOT NULL,
  cd_projeto INTEGER UNSIGNED NOT NULL,
  ds_objetivo VARCHAR(255) NULL,
  ds_preCondicao VARCHAR(255) NULL,
  ds_posCondicao VARCHAR(255) NULL,
  PRIMARY KEY(cd_casoUso),
  INDEX Caso_FK_Projeto(cd_projeto),
  FOREIGN KEY(cd_projeto)
    REFERENCES Projeto(cd_projeto)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS Cenario;
CREATE TABLE Cenario (
  cd_cenario INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_casoUso INTEGER UNSIGNED NOT NULL,
  nm_cenario VARCHAR(255) NOT NULL,
  fl_principal BOOL NULL,
  fl_alternativo BOOL NULL,
  cd_cenarioPrincipal INTEGER UNSIGNED,
  PRIMARY KEY(cd_cenario),
  INDEX Cenario_FKIndex(cd_cenarioPrincipal),
  FOREIGN KEY(cd_casoUso)
    REFERENCES CasoUso(cd_casoUso)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(cd_cenarioPrincipal)
    REFERENCES Cenario(cd_cenario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS Diagrama;
CREATE TABLE Diagrama (
  cd_diagrama INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_casoUso INTEGER UNSIGNED NOT NULL,
  nm_diagrama VARCHAR(255) NULL,
  ds_diagrama VARCHAR(255) NULL,
  PRIMARY KEY(cd_diagrama),
  FOREIGN KEY(cd_casoUso)
    REFERENCES CasoUso(cd_casoUso)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS Raia;
CREATE TABLE Raia (
  cd_raia INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  cd_cenario INTEGER UNSIGNED NOT NULL,
  nm_raia VARCHAR(255) NULL,
  nr_tamanho INTEGER UNSIGNED NULL,
  PRIMARY KEY(cd_raia),
  INDEX Raia_FK_Cenario(cd_cenario),
  FOREIGN KEY(cd_cenario)
    REFERENCES Cenario(cd_cenario)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS ComponenteDiagrama;
CREATE TABLE ComponenteDiagrama (
  cd_componente INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nm_componente VARCHAR(255) NULL,
  ds_componente VARCHAR(255) NULL,
  nr_pos_x SMALLINT UNSIGNED NULL,
  nr_pos_y SMALLINT UNSIGNED NULL,
  nr_largura INTEGER UNSIGNED NULL,
  nr_altura INTEGER UNSIGNED NULL,
  cd_diagrama INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(cd_componente),
  INDEX ComponenteDiagrama_FK_Diagrama(cd_diagrama),
  FOREIGN KEY(cd_diagrama)
    REFERENCES Diagrama(cd_diagrama)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS Acao;
CREATE TABLE Acao (
  cd_acao INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  ds_acao VARCHAR(40) NULL,
  cd_raia INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(cd_acao),
  INDEX Acao_FK_Raia(cd_raia),
  FOREIGN KEY(cd_raia)
    REFERENCES Raia(cd_raia)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

DROP TABLE IF EXISTS ComponenteLigacao;
CREATE TABLE ComponenteLigacao (
  cd_componente_origem INTEGER UNSIGNED NOT NULL,
  cd_componente_destino INTEGER UNSIGNED NULL,
  tp_ligacao SMALLINT UNSIGNED NULL,
  INDEX ComponenteLigacao_FKIndex1(cd_componente_origem),
  INDEX ComponenteLigacao_FKIndex2(cd_componente_destino),
  FOREIGN KEY(cd_componente_origem)
    REFERENCES ComponenteDiagrama(cd_componente)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(cd_componente_destino)
    REFERENCES ComponenteDiagrama(cd_componente)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

