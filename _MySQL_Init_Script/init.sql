CREATE DATABASE productsdb;

USE productsdb;

DROP TABLE IF EXISTS Products;

CREATE TABLE Products(
    ProductId INT AUTO_INCREMENT,
    Name VARCHAR(80) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (ProductId)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES Products WRITE;
INSERT INTO Products VALUES(1,'Estojo','Material Escolar', '3.40');
INSERT INTO Products VALUES(2,'Borracha','Material Escolar', '2.50');
INSERT INTO Products VALUES(3,'Caneta','Material Escolar', '6.50');
UNLOCK TABLES;