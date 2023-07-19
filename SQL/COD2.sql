
create database mini_imports_real
go

use mini_imports_real
go

create schema imports authorization dbo
go


create table imports.cadastrarFuncionarios (
cadFun_id int primary key identity(1,1),	--id
cadFun_nm varchar(40) not null,				--nome		
cadFun_rg int not null,						--RG
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
cadFor_inscEstadu int not null,				--inscriao estadual
cadFor_ender varchar(50) not null,			--endereco
cadFor_fone int not null,					--telefone
cadFor_email varchar(50) not null,			--email
cadFor_repre varchar(50) not null,			--represetante

)
go
create table imports.controleDeEstoque(
ctrlEstoq_id int primary key identity(1,1),	--id
ctrlEstoq_desc varchar(50) not null,		--descricao 
ctrlEstoq_data time not null,				--data 
ctrlEstoq_dataEntr time not null,			--data de entrada
ctrlEstoq_dataSaid time not null,			--data de saida 
ctrlEstoq_rzSocial int not null,			-- razao social
ctrlEstoq_uni int not null,					--quantidade em unidade


--FOREIGN KEYs
cadProd_id int foreign key references imports.CadastrarProdutos (cadProd_id),--codigo do produto
cadFor_id int foreign key references imports.cadastrarFornecedores(cadFor_id)--codigo do fornecedor


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
 
create table imports.registroVendas (			
regiVend_id int primary key identity(1,1),			--id
regiVend_nmProd varchar(40)not null,				--nome do produto
regiVend_horaSaida time not null,					--hora de saida do produto
regiVend_nmCompra varchar(50) not null				--NOME DO COMPRADOR
)
go

create table imports.encomendarProdutos (
encomend_id int primary key identity(1,1),			--id
encomend_uni int not null,							--unidade
encomend_valor money not null,						--valor
encomendProd_diaHora time,							--dia e hora

--FOREIGN KEY
cadProd_id int foreign key references imports.CadastrarProdutos (cadProd_id),--codigo do produto
)
go

create table imports.produtosEncomendados(
encomendados_id int primary key identity(1,1),			--id
encomendados_uni int not null,							--unidade
encomendados_valor money not null,						--valor
encomendados_diaHora time not null,						--dia e hora

--FOREIGN KEYs
encomend_id int references imports.encomendarProdutos (encomend_id),
cadProd_id int foreign key references imports.CadastrarProdutos (cadProd_id),--codigo do produto

)
go