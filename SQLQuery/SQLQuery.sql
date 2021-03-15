CREATE TABLE Categoties(
Id INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
name VARCHAR(30)
);

CREATE TABLE Products(
Id INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
name VARCHAR(30)
);

CREATE TABLE CategoryProduct
(
    Id INT  NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categoties(Id),
    ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(Id)
);

INSERT Categoties VALUES ('Техника');
INSERT Categoties VALUES ('Питание');
INSERT Categoties VALUES ('Мебель');
INSERT Categoties VALUES ('Одежда');

INSERT Products VALUES ('Телефон');
INSERT Products VALUES ('Плита');
INSERT Products VALUES ('Мясо');
INSERT Products VALUES ('Рыба');
INSERT Products VALUES ('Лодка');
INSERT Products VALUES ('Цветы');

INSERT CategoryProduct VALUES (1,1);
INSERT CategoryProduct VALUES (1,2);
INSERT CategoryProduct VALUES (2,3);
INSERT CategoryProduct VALUES (2,4);
INSERT CategoryProduct VALUES (3,2);

--Итоговый запрос:--
SELECT p.name AS Product, c.name AS Category
FROM CategoryProduct cp
RIGHT OUTER JOIN Products p ON p.Id=cp.ProductId
LEFT OUTER JOIN Categoties c ON c.Id=cp.CategoryId;

--Для просмотра таблиц:--
/*  
	SELECT * FROM Products;
	SELECT * FROM Categoties;
	SELECT * FROM CategoryProduct;
*/