CREATE TABLE Colors(
	ColorId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ColorName NVARCHAR (50) NOT NULL,
);

CREATE TABLE Brands(
	BrandId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	BrandName NVARCHAR (50) NOT NULL,
);

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	BrandId INT NOT NULL,
	ColorId INT NOT NULL,
	ModelName NVARCHAR(25) NOT NULL,
	ModelYear INT NOT NULL,
	DailyPrice DECIMAL NOT NULL,
	Descriptions NTEXT NOT NULL,
);

CREATE TABLE Users(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR (100) NOT NULL,
    LastName NVARCHAR (100) NOT NULL,
    Email NVARCHAR (100) UNIQUE NOT NULL,
    PasswordSalt BINARY(128) NOT NULL,
    PasswordHash BINARY(128) NOT NULL,
    Status BIT NOT NULL
);

CREATE TABLE Customers(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    UserId INT UNIQUE NOT NULL,
    CompanyName NVARCHAR (100) NOT NULL
);

CREATE TABLE Rentals(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    CarId INT  NOT NULL,
    CustomerId INT  NOT NULL,
    RentDate DATE NOT NULL,
    ReturnDate DATE NULL
);

CREATE TABLE CarImages(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    CarId INT,
    ImagePath NVARCHAR(MAX),
    Date DATE
);
CREATE TABLE UserOperationsClaims(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    UserId INT NOT NULL,
    OperationClaimId INT NOT NULL
);
CREATE TABLE OperationsClaims(
    Id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    Name VARCHAR(250) NOT NULL
);
