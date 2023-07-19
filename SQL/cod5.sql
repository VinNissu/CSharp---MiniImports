use mini_imports_real



ALTER TABLE imports.cadastrarFuncionarios ALTER COLUMN cadFun_rg varchar(15);  
GO  

drop table imports.cadastrarFuncionarios;

create table imports.cadastrarFuncionarios (
cadFun_id int primary key identity(1,1),	--id
cadFun_nm varchar(40) not null,				--nome
cadFun_CPF varchar(15),
cadFun_rg varchar(15) not null,						--RG
cadFun_fone varchar(15) not null,					--telefone
cadFun_ender varchar(50) not null,			--endereco
cadFun_email varchar(50) not null,			--email 
cadFun_cargo varchar(50) not null,			--cargo 
cadFun_login varchar(50) unique,			--login
cadFun_senha varchar(50)					--senha
)
go


insert into imports.cadastrarFuncionarios values ('vini','cpf','rg','fone','ender','email','CEO','vini','vini')

drop table imports.controleDeEstoque;


create table imports.controleDeEstoque(
ctrlEstoq_id int primary key identity(1,1),	--id
ctrlEstoq_desc varchar(50) not null,		--descricao 
ctrlEstoq_data time not null,				--data 
ctrlEstoq_dataEntr time not null,			--data de entrada
ctrlEstoq_rzSocial int not null,			-- razao social
ctrlEstoq_uni int not null,					--quantidade em unidade


--FOREIGN KEYs
cadProd_id int foreign key references imports.CadastrarProdutos (cadProd_id),--codigo do produto
cadFor_id int foreign key references imports.cadastrarFornecedores(cadFor_id)--codigo do fornecedor


)
go