CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY,
    Color NVARCHAR(100) NOT NULL,
    FuelAmount INT CHECK (FuelAmount >= 0) NOT NULL,
    LoadCapacity INT CHECK (LoadCapacity >= 0) NOT NULL,
    ConsumptionType NVARCHAR(100) NOT NULL
);

CREATE TABLE FuelConsumption (
    Id INT PRIMARY KEY IDENTITY,
    CarID INT NOT NULL,
	FOREIGN KEY (CarID) REFERENCES Cars(Id),
    Speed INT CHECK (SPEED >= 0) NOT NULL,
    FuelConsumption INT CHECK (FuelConsumption >= 0) NOT NULL
);

CREATE TABLE Cargo (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Weight INT CHECK (Weight >= 0) NOT NULL,
    BatchNumber INT CHECK (BatchNumber > 0) NOT NULL,
	Distance INT CHECK (Distance >= 0) NOT NULL,
    AverageSpeed INT CHECK (AverageSpeed >= 0) NOT NULL,
	ColorFilter NVARCHAR(100),
    ConsumptionTypeFilter NVARCHAR(100)
);

INSERT INTO Cars (Color, FuelAmount, LoadCapacity, ConsumptionType)
VALUES ('Red', 50, 300, 'Light'),
       ('Green', 70, 350, 'Heavy'),
       ('Blue', 60, 275, 'Light');

INSERT INTO FuelConsumption (CarID, Speed, FuelConsumption)
VALUES (1, 50, 10), (1, 80, 12), (2, 60, 15), (2, 90, 18), (3, 55, 11), (3, 85, 14);

INSERT INTO Cargo (Name, Weight, BatchNumber, Distance, AverageSpeed, ColorFilter, ConsumptionTypeFilter)
VALUES ('A', 150, 1, 200, 60, 'Red', 'Light'),
       ('B', 200, 2, 300, 70, 'Green', 'Heavy'),
       ('C', 250, 3, 250, 55, 'Blue', 'Light');

GO
CREATE TRIGGER ForbidChanges
ON Cargo
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM DELETED)
		THROW 50000, 'Changes are not allowed', 1
END

GO

CREATE FUNCTION CalculateFuel(@batchNum INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @result DECIMAL(10, 2);
    DECLARE @distance INT;
    DECLARE @avgSpeed INT;
    DECLARE @fuelConsumption INT;
    DECLARE @carId INT;

	SELECT @distance = Distance, @avgSpeed = AverageSpeed, @carId = Id
    FROM Cargo
    WHERE BatchNumber = @batchNum;

	IF @distance IS NULL OR @avgSpeed IS NULL OR @carId IS NULL
        RETURN 0;

	SELECT TOP 1 @fuelConsumption = FuelConsumption
    FROM FuelConsumption
    WHERE CarID = @carId
    AND Speed >= @avgSpeed

	SET @result = @fuelConsumption * @distance;
    
    RETURN @result;
END;
GO