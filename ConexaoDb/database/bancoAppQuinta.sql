create database dbAppBanco;
use dbAppBanco;

create table tbUsuario
(
	IdUsu int primary key auto_increment,
    NomeUsu varchar(50) not null,
    Cargo varchar(50) not null,
    DataNasc datetime
);

insert into tbUsuario
values(default, "Akira", "Ator", '2000/05/15');


select * from tbUsuario;
Select * from tbUsuario;