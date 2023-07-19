use mini_imports_real


drop table imports.controleDeEstoque 


create table imports.controleDeEstoque(
ctrlEstoq_id int primary key identity(1,1),										--id
cadProd_id_FK int references imports.CadastrarProdutos (cadProd_id),			--codigo do produto
ctrlEstoq_desc varchar(50) not null,											--descricao 
ctrlEstoq_data time not null,													--data 
ctrlEstoq_dataEntr time not null,												--data de entrada
cadFor_id_FK int references imports.cadastrarFornecedores not null,				--codigo do fornecedor
cadFor_rzSocial_FK int references imports.cadastrarFornecedores not null,		--razao social
ctrlEstoq_uni int not null														--quantidade em unidade
)
go

