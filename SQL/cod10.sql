ALTER TABLE imports.registroVendas
add regiVend_qty float;

alter table imports.registroVendas
add regiVend_horaSaida varchar(10);





alter table imports.produtosEncomendados
drop column encomendados_diaHora
go



alter table imports.produtosEncomendados
add encomendados_diaHora varchar(10)
go


alter table imports.produtosEncomendados
add encomendados_func varchar(50)
go


alter table imports.produtosEncomendados
add encome_qty float
go



create table imports.produtosEncomendados (
encom_id int primary key identity(1,1),
encom_valor money,
encom_diaHora varchar(10),
encom_func varchar(50),
encom_Prod varchar(50)
)
go