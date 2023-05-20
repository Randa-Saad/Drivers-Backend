

----1--Create Database
--CREATE DATABASE Transflo_DB;
-----------------------------------------------------------------------------------------
---2-- Select Database to use in below steps

-----------------------------------------------------------------------------------------
----3-- Create Table
--CREATE TABLE Drivers (
--    Id INT IDENTITY ,
--    FirstName nvarchar(30),
--    LastName nvarchar(30),
--    Email nvarchar(30),
--    PhoneNumber nvarchar(30),
--	  PRIMARY KEY (Id)
--);

-----------------------------------------------------------------------------------------
----4--Create Stored Procedures
----1--Stored Procedure: Get drivers
--CREATE PROC [DBO].[usp_Get_Drivers]
--AS
--BEGIN
--	SELECT Id,FirstName,LastName,Email,PhoneNumber from DBO.Drivers WITH (NOLOCK)
--End

--------------------------------------------------------

----2--Stored Procedure: Get driver by id
--CREATE PROC [DBO].[usp_Get_DriverById]
--(
--	@Id INT
--)
--AS
--BEGIN
--SELECT Id,FirstName,LastName,Email,PhoneNumber from DBO.Drivers WITH (NOLOCK)
--	WHERE ID=@Id
--END

--------------------------------------------------------

----3--Stored Procedure: Insert driver
--CREATE PROC [DBO].[usp_Insert_Driver]
--(
--@FirstName NVARCHAR(20),
--@LastName NVARCHAR(20),
--@Email NVARCHAR(20),
--@PhoneNumber NVARCHAR(20)
--)
--AS 
--BEGIN

--BEGIN TRY
--	BEGIN TRAN
--	INSERT INTO DBO.Drivers(FirstName, LastName, Email, PhoneNumber)
--		VALUES
--		(
--			@FirstName,
--			@LastName,
--			@Email,
--			@PhoneNumber
--		)
--	COMMIT TRAN
--END TRY
--BEGIN CATCH
--	ROLLBACK TRAN
--END CATCH
--END

--------------------------------------------------------

----4--Stored Procedure: Update driver
--CREATE PROC [DBO].[usp_Update_Driver]
--(
--	@Id INT,
--	@FirstName NVARCHAR(20),
--	@LastName NVARCHAR(20),
--	@Email NVARCHAR(20),
--	@PhoneNumber NVARCHAR(20)
--)
--AS
--BEGIN
--Declare @RowCount INT = 0
--	BEGIN TRY
--	SET @RowCount = (SELECT COUNT(1) FROM DBO.Drivers WITH (NOLOCK) WHERE Id= @Id )

--	if(@RowCount >0)
--		BEGIN
--			BEGIN TRAN
--				UPDATE DBO.Drivers
--					SET 
--						FirstName = @FirstName, 
--						LastName= @LastName,
--						Email = @Email,
--						PhoneNumber = @PhoneNumber 
--						WHERE Id = @Id
--			COMMIT TRAN
--		END
--	END TRY
--BEGIN CATCH
--	ROLLBACK TRAN
--END CATCH
--END

--------------------------------------------------------

----5--Stored Procedure: Delete driver
--CREATE PROC [DBO].[usp_Delete_Driver]
--(
--	@Id INT
--)
--AS
--BEGIN
--Declare @RowCount INT = 0
--	BEGIN TRY
--	SET @RowCount = (SELECT COUNT(1) FROM DBO.Drivers WITH (NOLOCK) WHERE Id= @Id )

--	if(@RowCount >0)
--		BEGIN
--			BEGIN TRAN
--				DELETE FROM  DBO.Drivers
					
--					WHERE Id = @Id
--			COMMIT TRAN
--		END
--	END TRY
--BEGIN CATCH
--	ROLLBACK TRAN
--END CATCH
--END

-----------------------------------------------------------------------------------