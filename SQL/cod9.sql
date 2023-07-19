create database biblioteca
go


use biblioteca 
go

create schema biblio authorization dbo 
go

create table biblio.livros (
livros_CD int identity(1,1) primary key,
livros_nm varchar(40) not null
)
go


create table biblio.autores (
autores_CD int identity(1,1) primary key,
autores_nm varchar(40) not null
)
go



create table biblio.acervo (
acervo_CD int identity(1,1) primary key,
livro_CD int not null,
autor_CD int not null,
foreign key (livro_CD) references biblio.livros (livros_CD),
foreign key (autor_CD) references biblio.autores (autores_CD)
)
go



INSERT INTO biblio.livros (livros_nm)
VALUES ('O Senhor dos Anéis'), ('Harry Potter e a Pedra Filosofal'), ('As Crônicas de Nárnia');

-- Inserir dados na tabela biblio.autores
INSERT INTO biblio.autores (autores_nm)
VALUES ('J.R.R. Tolkien'), ('J.K. Rowling'), ('C.S. Lewis');

-- Inserir dados na tabela biblio.acervo
INSERT INTO biblio.acervo (livro_CD, autor_CD)
VALUES (1, 1), (2, 2), (3, 3);


select * from biblio.livros 

update biblio.livros 
set livros_nm = 'O Senhor dos Anéis ' 
where livros_CD = 1

select * from biblio.autores 


select * from biblio.acervo 


select * from biblio.acervo 
join biblio.livros on biblio.livros.livros_CD = biblio.acervo.livro_CD 
join biblio.autores on biblio.autores.autores_CD = biblio.acervo.autor_CD;




create view biblio.VWacervolivro 
as
select biblio.livros.livros_nm , biblio.autores.autores_nm from biblio.acervo 
join biblio.livros on biblio.livros.livros_CD = biblio.acervo.livro_CD 
join biblio.autores on biblio.autores.autores_CD = biblio.acervo.autor_CD;







