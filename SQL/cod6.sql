use mini_imports_real 
go

create table imports.feedbackClientes(
feedback_id int primary key identity (1,1),			--id
feedback_prod int not null,							--id produto  (FOREIGN KEY)
feedback_nmCompra varchar(50) not null,				--nome do comprador
feedback_depoi text not null,							--depoimento
feedback_diaHora time not null,						--dia e hora
)
go
 

 drop table imports.registroVendas

create table imports.registroVendas (			
regiVend_id int primary key identity(1,1),				--id
cadProd_id int foreign key references imports.CadastrarProdutos(cadProd_id),
regiVend_nmProd varchar(40)not null,				--nome do produto
regiVend_horaSaida time not null,					--hora de saida do produto
regiVend_nmCompra varchar(50) not null				--NOME DO COMPRADOR
)
go