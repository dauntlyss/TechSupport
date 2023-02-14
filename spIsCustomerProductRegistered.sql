USE [TechSupport]
GO
DROP PROCEDURE IF EXISTS spIsCustomerProductRegistered;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spIsCustomerProductRegistered (
	@CustomerID INT
    , @ProductCode VARCHAR(10)
)
AS

IF (ISNULL(@CustomerID, 0) = 0)
BEGIN
    RAISERROR('Invalid parameter: @CustomerID cannot be NULL or zero', 18, 0)
    RETURN
END

IF (ISNULL(@ProductCode, '') = '')
BEGIN
    RAISERROR('Invalid parameter: @ProductCode cannot be NULL or empty', 18, 0)
    RETURN
END

SELECT
CustomerID
, ProductCode
FROM Registrations
WHERE
(CustomerID = @CustomerID
AND ProductCode = @ProductCode);
GO

DECLARE @Count INT;

EXEC spIsCustomerProductRegistered 1002, "LEAG10"

SELECT @Count