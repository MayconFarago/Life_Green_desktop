
USE master

CREATE DATABASE Life_Green_BD

use Life_Green_BD

CREATE TABLE Funcionarios(
ID int primary key identity,
nome varchar(50),
cargo varchar(50),
cpffunc varchar(11),
nomeUser varchar(20),
senhaUser varchar(60)
);
create table Produtos(
ID int primary key identity,
nomeProd varchar(50),
categoriaProd varchar(20),
qtdProd int,
precoProd double precision,
medidaPord varchar(10)
);

select * from Funcionarios
select * from Produtos

