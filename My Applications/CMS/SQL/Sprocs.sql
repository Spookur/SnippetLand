USE CMSDB
GO


CREATE PROC CaseAddOrEdit /* Add Or Edit Case By ID Stored Procedure */
@CaseId int,
@Details varchar(400),
@FilingDate date,
@Agency varchar(50),
@DefendantName varchar(50),
@DefendantAddress varchar(100),
@Charges varchar(400)
AS

	IF @CaseId =0
		INSERT INTO Cases(Details,FilingDate,Agency,DefendantName,DefendantAddress,Charges)
		VALUES (@Details,@FilingDate,@Agency,@DefendantName,@DefendantAddress,@Charges)
	ELSE 
		UPDATE Cases
		SET 
		Details=@Details,
		FilingDate=@FilingDate,
		Agency=@Agency,
		DefendantName=@DefendantName,
		DefendantAddress=@DefendantAddress,
		Charges=@Charges
		WHERE CaseId = @CaseId
GO


CREATE PROC CaseViewAll /* View All Cases Stored Procedure */ 
AS
	SELECT * FROM Cases
GO



CREATE PROC CaseViewById /* View Case By ID Stored Procedure */ 
@CaseId int
AS

	SELECT *
	FROM Cases
	WHERE CaseId = @CaseId
GO



CREATE PROC CaseDeleteById /* Delete By ID Stored Procedure */ 
@CaseId int
AS
	DELETE FROM Cases
	WHERE CaseId = @CaseId


