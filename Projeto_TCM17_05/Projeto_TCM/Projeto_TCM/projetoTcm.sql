create  database  projetoTcm 
go
use projetoTcm
go
--use master

--drop database projetoTcm

--drop table Servi�os


create table Contato_Clientes(
codigo int primary key identity,
nome varchar (50),
cpf varchar (50),
endereco varchar (100),
email varchar (100),
telefone varchar (50),
cidade varchar (50),
cep varchar (50)

)

go

create table Contato_Funcionarios(
codigo int primary key identity,
nome varchar (50),
cpf int,
endereco varchar (100),
emil varchar (100),
telefone int,
cidade varchar (50),
cep int

)
go

create table Servi�os(
numeroServi�o int primary key identity,
empresa varchar(50),
endereco varchar (50),
cidade varchar (50),
cep varchar (50),
encarregado varchar(50),
inicio varchar (50),
termino varchar (50),
observa��es varchar (3000),
)
go
-- select Login from 

create table Login(
usuario varchar (20) primary key,
senha varchar (30)
)
go
-- delete contato_clientes from projetoTcm
--go
--delete Contato_Funcionarios from projetoTcm

--drop table contato_clientes 

--select * from Contato_Funcionarios

--select * from Contato_Clientes

--select * from Servi�os

--use master
--where codigo = 0

--insert into Login (usuario, senha) values('ed','ed')

--select * from Login