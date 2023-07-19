create database mini_imports_real
go
use mini_imports_real 
go
create schema imports authorization dbo
go


create table imports.cadastrarFornecedores (
cadFor_id int primary key identity(1,1) not null,
cadFor_rzSocial varchar(50) not null,				
cadFor_cnpj varchar(15) not null,					
cadFor_inscEstadu varchar(15) not null,			
cadFor_ender varchar(50) not null,			
cadFor_fone varchar(15) null,					
cadFor_email varchar(50) not null,			
cadFor_repre varchar(50) not null,			
)
go





create table imports.cadastrarFuncionarios (
cadFun_id int primary key identity(1,1),   
cadFun_nm varchar(50) not null,
cadFun_CPF varchar(15)not null unique,				
cadFun_rg varchar(15) not null,		
cadFun_fone varchar(15) not null,	
cadFun_ender varchar(50) not null,	
cadFun_email varchar(50) not null,	 
cadFun_cargo varchar(50) not null,	 
cadFun_login varchar(50),	
cadFun_senha varchar(50)		
)
go

create table imports.CadastrarProdutos(
cadProd_id int primary key identity(1,1),
cadProd_desc varchar(50) not null,			
cadProd_marc varchar(40) not null,			
cadProd_tam varchar(10) not null,				
cadProd_valorAq money null,				
cadProd_valorVe money not null,
cadProd_Fornecedor varchar(50) null				 
)
go


create table imports.caixa (
caixa_id int primary key identity(1,1),
cadProd_id int foreign key references imports.CadastrarProdutos(cadProd_id),
caixa_dtCompra date,
caixa_qty float,
caixa_vlTotal money,
caixa_pg varchar(50)
)
go


create table imports.controleDeEstoque(
ctrlEstoq_id int primary key identity(1,1) not null,	
cadProd_id_FK int foreign key references imports.CadastrarProdutos(cadProd_id) not null,
ctrlEstoq_desc varchar(50) not null,
ctrlEstoq_data time not null,
ctrlEstoq_dataEntr time not null,
cadFor_id_FK int foreign key references imports.cadastrarFornecedores(cadFor_id) not null,
cadFor_rzSocial_FK int references imports.registroVendas(regiVend_id),
ctrlEstoq_uni int not null
)
go


create table imports.encomendarProdutos (
encomend_id int primary key identity(1,1) not null,				
encomend_uni int not null,		
encomend_valor money not null,			
encomendProd_diaHora time,
cadProd_id int foreign key references imports.CadastrarProdutos(cadProd_id)			
)
go



create table imports.feedbackClientes(
feedback_id int primary key identity (1,1),
feedback_depoi text null,
feedback_qty float not null,
feedback_diaHora varchar(10)null,				
feedback_nmProduto varchar(50)null,					
feedback_nmComprador varchar(50)null,
feedback_nmVendedor varchar(50)null								
)
go


create table imports.produtosEncomendados (
encom_id int primary key identity(1,1),
encom_valor money,
encom_diaHora varchar(10),
encom_func varchar(50),
encom_Prod varchar(50),
encome_qty float
)
go



create table imports.registroVendas(
regiVend_id int primary key identity(1,1),	
regiVend_nmProd varchar(40)not null,
regiVend_nmCompra varchar(50) not null,	
regiVend_qty float null,		
regiVend_horaSaida varchar(10) not null,			
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











