CREATE DATABASE bancoT
GO
use bancoT
GO
CREATE TABLE SERVICCO(
CODIGO_SERVI�O INT PRIMARY KEY IDENTITY not null,
EMPRESA VARCHAR(100) NOT NULL,
CPFCNPJ VARCHAR(15) NOT NULL,
ENDERECO VARCHAR(50) NOT NULL,
CIDADE VARCHAR (50) NOT NULL,
UF VARCHAR (02) NOT NULL,
CEP VARCHAR (15) NOT NULL,
DataInicio VARCHAR(8)NOT NULL,
DataTermino VARCHAR(8),
VALOR varchar(50) NOT NULL,
DescricaoDoservico VARCHAR(20),
situacaoDoServico VARCHAR (15),
Relatorio VARCHAR(1000)
)
GO

--drop table SERVICCO
--select * from SERVICCO
--DROP DATABASE bancoT
--use master
GO
CREATE TABLE CLIENTE(
CODIGO int primary key identity not null,
NOME VARCHAR(40) NOT NULL,
CPF VARCHAR(11) NOT NULL,
ENDERE�O VARCHAR(40) NOT NULL,
CIDADE VARCHAR(20) NOT NULL,
UF VARCHAR(2) NOT NULL,
COMPLEMENTO VARCHAR(5) NOT NULL,
CEP VARCHAR(8) NOT NULL,
EMAIL VARCHAR(50) NOT NULL,
FONE_FAX VARCHAR(11) NOT NULL,
TIPO_CLIENTE VARCHAR (8) NOT NULL
)
GO

CREATE TABLE FUNCIONARIO(
CODIGO_FUNCIONARIO  INT PRIMARY KEY IDENTITY  NOT NULL, 
NOME VARCHAR(40) NOT NULL,
SENHA VARCHAR(10) NOT NULL,
CPF VARCHAR (11) NOT NULL,
ENDERECO VARCHAR(40) NOT NULL,
CIDADE VARCHAR (20) NOT NULL,
CEP VARCHAR (8) NOT NULL,
EMAIL VARCHAR (50) NOT NULL,
foneFax varchar (11) not null,
UF VARCHAR (10)NOT NULL,
IMAGEM VARCHAR (200) NOT NULL
)
GO

create table equipamento(
CODIGO_EQUIPAMENTO INT PRIMARY KEY IDENTITY NOT NULL,
MATERIAL VARCHAR(50),
MARCA VARCHAR (50),
FINALIDADE VARCHAR (100),
ESPECIFICACAO VARCHAR (50),
PRECO VARCHAR (7),
QUANTIDADE VARCHAR (10)
)
GO

--SELECT * FROM SERVICCO
--SELECT * FROM  CLIENTE
--SELECT * FROM  FUNCIONARIO
--SELECT * FROM EQUIPAMENTO