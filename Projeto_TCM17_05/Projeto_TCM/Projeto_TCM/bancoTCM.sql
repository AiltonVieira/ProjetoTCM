CREATE DATABASE bancoTCM
GO
use bancoTCM
GO
CREATE TABLE EMPRESA(
CODIGO_EMPRESA INT PRIMARY KEY IDENTITY,
NOME_DA_EMPRESA VARCHAR(100) NOT NULL,
ENDERE�O VARCHAR(200) NOT NULL,
CNPJ VARCHAR (100) NOT NULL
)
GO

CREATE TABLE SERVI�O(
CODIGO_DO_SERVI�O INT  PRIMARY KEY IDENTITY,
NOME VARCHAR(100) NOT NULL,
TIPO VARCHAR (20) NOT NULL,
DESCRI��O_DO_SERVI�O VARCHAR(20) NOT NULL,
PRE�O VARCHAR (10) NOT NULL,
Relatorio varchar(256),
Data_Inicio varchar(10) NOT NULL,
Data_Termino varchar(10)
)



GO
CREATE TABLE CLIENTE(

NOME VARCHAR(100) NOT NULL,
CPF VARCHAR(50) NOT NULL,
ENDERE�O VARCHAR(100) NOT NULL,
CIDADE VARCHAR(20) NOT NULL,
CEP VARCHAR(8) NOT NULL,
EMAIL VARCHAR(30) NOT NULL,
FONEFAX VARCHAR(10) NOT NULL,
)



CREATE TABLE FUNCIONARIO(
CODIGO_EMPRESA INT FOREIGN KEY REFERENCES EMPRESA(CODIGO_EMPRESA),
CODIGO_FUNCIONARIO  INT PRIMARY KEY IDENTITY(1,1)  NOT NULL, 
NOME VARCHAR(100) NOT NULL,
CPF VARCHAR (50) NOT NULL,
DESCRI��O_DE_NIVEL_DE_ACESSO VARCHAR (50) NOT NULL,
NIVEL_DE_ACESSO VARCHAR (13) NOT NULL,
SENHA VARCHAR(8) NOT NULL
)
GO

Alter table Funcionario
update Codigo_funcionario int primary

SELECT * FROM  SERVI�O
SELECT * FROM  CLIENTE
SELECT * FROM  FUNCIONARIO
SELECT * FROM  EMPRESA


create table Login(
id int identity primary key,
usuario varchar (16),
senha varchar (16)
)
go

insert into login values('adm', '1234567')

select * from Login