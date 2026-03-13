create database eShopping;

use eShopping;

create table Products (
	ProductId int primary key identity,
	ProductName nvarchar(100) not null,
	ProductColorName nvarchar(100),
	ProductPrice decimal(18,2) not null,
	ProductDescription nvarchar(1000) not null
);

insert into Products (ProductName, ProductColorName, ProductPrice, ProductDescription) values
('IPhone 15 Pro', 'Titan Qara', 5499.99, 'Apple IPhone 15 Pro 256GB yaddas, A17 Pro cip, Titanium'),
('Samsung Galaxy S24', 'Night Purple', 3299.99, 'Samsung Galaxy S24 128GB, Snapdragon 8 Gen 3, 50MP kamera'),
('Sony WH-1000XM5', 'Silver', 1199.99, 'Sony simsiz qulaqliq, 30 saat batareya'),
('Logitech MX Master 3', 'Dark Blue', 449.99, 'Ergonomik simsiz mouse, 8K DPI sensor, USB-C sarj'),
('Dell XPS 15', 'Platinum Silver', 8999.99, 'Dell XPS 15 noutbuk, Intel Core i7, 16GB RAM, 512GB SSD, OLED ekran');