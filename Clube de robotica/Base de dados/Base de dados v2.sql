create database Clube_informatica
use Clube_informatica

/* identity(1,1) é o auto increment*/


create table tipo_utilizador (
UserID int IDENTITY(1,1) PRIMARY KEY ,
Nome varchar(250),
admin BIT,
cargo varchar(30),
)

drop table utilizador

alter table utilizador
ADD administrador BIT;

create table utilizador (
UserID int IDENTITY(1,1) PRIMARY KEY, 
NProcesso int ,
NIF int,
Nome varchar(255) NOT NULL,
Curso varchar(40) ,
Data_Nascimento date ,
Email varchar(255) NOT NULL,
Data_entrada date ,
palavrapasse varchar(255),
area int,
Administrador BIT,
)

create table user_eventos (
UserID int NOT NULL , 
ID_evento int NOT NULL ,
Data_entrada date NOT NULL,
primary key(UserID,ID_evento)
)


create table user_projectos (
UserID int NOT NULL , 
ID_projecto int NOT NULL ,
Data_entrada date NOT NULL,
primary key(UserID,ID_projecto)
)


create table encomenda (
ID_encomenda int NOT NULL primary key, 
UserID int NOT NULL,
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


create table detalhes_encomenda (
ID_encomenda int NOT NULL , 
ID_artigo int NOT NULL,
preço_total int,
quantidade_total int,
Data_realizacao date NOT NULL,
primary key(ID_artigo,ID_encomenda)
)
	

create table projectos (
ID_projecto int IDENTITY(1,1) primary key,
Nome varchar(255),
Data_inicio date NOT NULL,
Materiais int,
Data_fim date,
descricao varchar(255),
)


