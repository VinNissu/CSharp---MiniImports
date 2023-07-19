create table imports.registroVendas (			
regiVend_id int primary key identity(1,1),			--id
regiVend_nmProd varchar(40)not null,				--nome do produto
regiVend_horaSaida varchar(20) not null,					--hora de saida do produto
regiVend_nmCompra varchar(50) not null				--NOME DO COMPRADOR
)
go



select * from imports.registroVendas
