CREATE TABLE Cars (
    Id int NOT NULL,
    BrandId int NOT NULL,
    ColorId int NOT NULL,
    CarName varchar(255) NOT NULL,
    ModelYear varchar(255) NOT NULL,
    DailyPrice decimal(18) NOT NULL,
    Description varchar(255) NOT NULL,
    CONSTRAINT PK_Cars PRIMARY KEY (Id)
);

Create Table Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);

Create Table Brands(
BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
    CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);
INSERT INTO Cars
VALUES (1,1,1, 'Renault-Clio',2005, 120,'Renault Marka Clio ');
