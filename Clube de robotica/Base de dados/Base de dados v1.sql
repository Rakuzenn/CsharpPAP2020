create database Clube_informatica
use Clube_informatica

create table alunos (
NProcesso int NOT NULL primary key, 
Nome varchar(255) NOT NULL,
Curso varchar(40) NOT NULL,
Data_Nascimento date NOT NULL,
Email varchar(255) NOT NULL,
Data_entrada date NOT NULL,
palavrapasse varchar(255),
)

create table alunos_eventos (
NProcesso int NOT NULL , 
ID_evento int NOT NULL ,
Data_entrada date NOT NULL,
primary key(NProcesso,ID_evento)
)


create table alunos_projectos (
NProcesso int NOT NULL , 
ID_projecto int NOT NULL ,
Data_entrada date NOT NULL,
primary key(NProcesso,ID_projecto)
)


create table encomenda (
ID_encomenda int NOT NULL primary key, 
NIF int NOT NULL,
Data_entrada date NOT NULL,

)

create table eventos (
ID_evento int NOT NULL primary key, 
Nome_evento varchar(255) NOT NULL,
local_evento varchar(255) NOT NULL,
Data_evento date NOT NULL,
)


create table Materiais (
ID_artigo int NOT NULL primary key, 
Nome_artigo varchar(255) NOT NULL,
quantidade int NOT NULL,
preco int NOT NULL,
)

create table material_encomenda (
ID_encomenda int NOT NULL , 
ID_artigo int NOT NULL,
Data_realizacao date NOT NULL,
primary key(ID_artigo,ID_encomenda)
)

create table Professores (
NIF int NOT NULL primary key, 
Nome varchar(255) NOT NULL,
Curso varchar(40) NOT NULL,
Data_Nascimento date NOT NULL,
Email varchar(255) NOT NULL,
Data_entrada date NOT NULL,
Area int NOT NULL,
)

create table professores_eventos (
NIF int NOT NULL , 
ID_projecto int NOT NULL,
Data_inicio date NOT NULL,
primary key(NIF,ID_projecto)
)

create table professores_projectos (
NIF int NOT NULL, 
ID_projecto int NOT NULL ,
Data_inico date NOT NULL,
Data_fim date ,
primary key(NIF,ID_projecto)
)

create table projectos (
ID_projecto int NOT NULL primary key, 
Data_inico date NOT NULL,
Materiais int,
Data_fim date,
)


