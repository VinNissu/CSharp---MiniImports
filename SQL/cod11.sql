use mini_imports_real 
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

