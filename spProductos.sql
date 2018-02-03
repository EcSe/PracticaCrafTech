use BDEcommerce
go

if OBJECT_ID('spcListarProducto') is not null
drop proc spcListarProducto
go
create proc spcListarProducto
as
begin
	select*from TProducto
end
go

exec spcListarProducto
