create database mini_imports 
go
use mini_imports  
go
create schema imports authorization dbo
go


create table imports.cadastrarFuncionarios (
cadFun_id int primary key identity(1,1),   --id
cadFun_nm varchar(40) not null,			--nome		
cadFun_rg int not null,					--RG
cadFun_fone int not null,					--telefone
cadFun_ender varchar(50) not null,			--endereco
cadFun_email varchar(50) not null,			--email 
cadFun_cargo varchar(50) not null,			--cargo 
cadFun_login varchar(50) unique,			--login
cadFun_senha varchar(50)					--senha
)
go

create table imports.cadastrarFornecedores (
cadFor_id int primary key identity(1,1),	--id
cadFor_rzSocial  int not null,				--razao social
cadFor_cnpj int not null,					--cnpj
cadFor_inscEstadu int not null,			--inscriao estadual
cadFor_ender varchar(50) not null,			--endereco
cadFor_fone int not null,					--telefone
cadFor_email varchar(50) not null,			--email
cadFor_repre varchar(50) not null,			--represetante

)
go
create table imports.controleDeEstoque(
ctrlEstoq_id int primary key identity(1,1),	--id
ctrlEstoq_codProd int not null,				--codigo do produto
ctrlEstoq_desc varchar(50) not null,			--descricao 
ctrlEstoq_data time not null,				--data 
ctrlEstoq_dataEntr time not null,			--data de entrada
ctrlEstoq_dataSaid time not null,			--data de saida 
ctrlEstoq_codForn int not null,				--codigo do fornecedor
ctrlEstoq_rzSocial int not null,				-- razao social
ctrlEstoq_uni int not null					--quantidade em unidade
)
go

create table imports.CadastrarProdutos(
cadProd_id int primary key identity(1,1),
cadProd_desc varchar(50) not null,			--descricao
cadProd_marc varchar(40) not null,			--marca
cadProd_tam float not null,					--tamanho
cadProd_valorAq money not null,				--valor de compra
cadProd_valorVe money not null				--valor de venda 
)
go

create table imports.feedbackClientes(
feedback_id int primary key identity (1,1),			--id
feedback_prod int not null,							--id produto  (FOREIGN KEY)
feedback_nmCompra varchar(50) not null,				--nome do comprador
feedback_depoi text not null,							--depoimento
feedback_diaHora time not null,						--dia e hora
)
go



alter table imports.feedbackClientes
add feedback_prod varchar(50);
go

alter table imports.feedbackClientes
add feedback_diaHora varchar(10);
go

alter table imports.feedbackClientes
add feedback_qty float NOT null;
go

alter table imports.feedbackClientes
add feedback_nmProduto varchar(50);
go

alter table imports.feedbackClientes
add feedback_nmComprador varchar(50) ;
go


alter table imports.feedbackClientes
add feedback_nmVendedor varchar(50) ;
go

 

create table imports.registroVendas(
regiVend_id int primary key identity(1,1),			--id
regiVend_nmProd varchar(40)not null,				--nome do produto
regiVend_horaSaida varchar(20) not null,					--hora de saida do produto
regiVend_nmCompra varchar(50) not null				--NOME DO COMPRADOR
)
go


create table imports.encomendarProdutos (
encomend_id int primary key identity(1,1),			--id
encomend_codProd int not null,						--codigo do produto
encomend_uni int not null,							--unidade
encomend_valor money not null,						--valor
encomendProd_diaHora time								--dia e hora
)
go

create table imports.produtosEncomendados (
encom_id int primary key identity(1,1),
encom_valor money,
encom_diaHora varchar(10),
encom_func varchar(50),
encom_Prod varchar(50)
)
go


alter table imports.cadastrarFuncionarios
alter column cadFun_nm varchar(50)
go

alter table imports.cadastrarProdutos
add cadProd_Fornecedor varchar(50);
go



alter table imports.cadastrarFornecedores
alter column cadFor_rzSocial varchar(50)
go

alter table imports.cadastrarFornecedores
alter column cadFor_cnpj varchar(15)
go

alter table imports.cadastrarFornecedores
alter column cadFor_inscEstadu varchar(15)
go


alter table imports.cadastrarFornecedores
alter column cadFor_fone varchar(15)
go


alter table imports.cadastrarFornecedores
alter column cadFor_cnpj varchar(15)
go


ALTER TABLE imports.cadastrarFuncionarios ALTER COLUMN cadFun_rg varchar(15);  
GO  





create table imports.caixa (
caixa_id int primary key identity(1,1),
cadProd_id int foreign key references imports.CadastrarProdutos(cadProd_id),
caixa_dtCompra date,
caixa_qty float,
caixa_vlTotal money,
caixa_pg varchar(50)
)
go







