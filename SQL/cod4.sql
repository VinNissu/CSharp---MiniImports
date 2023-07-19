


SELECT* FROM imports.cadastrarFuncionarios

ALTER TABLE imports.cadastrarFuncionarios ALTER COLUMN cadFun_rg varchar(15);  
GO  




delete from imports.cadastrarFuncionarios
where cadFun_rg = 111


insert into imports.cadastrarFuncionarios values ('111','111','111','111','111','111','111','111')