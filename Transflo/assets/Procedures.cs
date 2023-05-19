
//--GET DRIVERS

//Create PROC [DBO].[usp_Get_Drivers]
//AS
//BEGIN
//  SELECT Id, FirstName, LastName, Email, PhoneNumber from DBO.Drivers WITH (NOLOCK)
//End

//---------------------------------------------------------------------------------------//

//--GET DRIVER BY ID
//CREATE PROC [DBO].[usp_Get_DriverById]
//(
//@Id INT
//)
//AS
//BEGIN
//  SELECT Id, FirstName, LastName, Email, PhoneNumber from DBO.Drivers WITH (NOLOCK)
//		WHERE ID = @Id
//END

//---------------------------------------------------------------------------------------//

//--INSERT
//ALTER PROC [DBO].[usp_Insert_Driver]
//(
//@FirstName NVARCHAR(20),
//@LastName NVARCHAR(20),
//@Email NVARCHAR(20),
//@PhoneNumber NVARCHAR(20)
//)
//AS
//BEGIN

//BEGIN TRY
//	BEGIN TRAN
//	INSERT INTO DBO.Drivers(FirstName, LastName, Email, PhoneNumber)
//		VALUES
//        (
//            @FirstName,
//            @LastName,
//            @Email,
//            @PhoneNumber
//        )

//    COMMIT TRAN
//END TRY
//BEGIN CATCH
//	ROLLBACK TRAN
//END CATCH
//END

//---------------------------------------------------------------------------------------//

//--UPDATE
//CREATE PROC [DBO].[usp_Update_Driver]
//(
//    @Id INT,
//    @FirstName NVARCHAR(20),
//	@LastName NVARCHAR(20),
//	@Email NVARCHAR(20),
//	@PhoneNumber NVARCHAR(20)
//)
//AS
//BEGIN
//Declare @RowCount INT = 0
//	BEGIN TRY
//	SET @RowCount = (SELECT COUNT(1) FROM DBO.Drivers WITH (NOLOCK) WHERE Id= @Id)


//    if (@RowCount > 0)
//    BEGIN
//        BEGIN TRAN
//            UPDATE DBO.Drivers
//					SET 
//						FirstName = @FirstName,
//                    LastName = @LastName,
//                    Email = @Email,
//                    PhoneNumber = @PhoneNumber 
//						WHERE Id = @Id
//			COMMIT TRAN
//		END
//	END TRY
//BEGIN CATCH
//	ROLLBACK TRAN
//END CATCH
//END

//---------------------------------------------------------------------------------------//

//--DELETE
//CREATE PROC[DBO].[usp_Delete_Driver]
//(
//	@Id INT
//)
//AS
//BEGIN
//Declare @RowCount INT = 0
//	BEGIN TRY
//	SET @RowCount = (SELECT COUNT(1) FROM DBO.Drivers WITH (NOLOCK) WHERE Id= @Id)

//	if (@RowCount > 0)
//	BEGIN
//		BEGIN TRAN
//			DELETE FROM  DBO.Drivers

//						WHERE Id = @Id
//			COMMIT TRAN
//		END
//	END TRY
//BEGIN CATCH
//	ROLLBACK TRAN
//END CATCH
//END
