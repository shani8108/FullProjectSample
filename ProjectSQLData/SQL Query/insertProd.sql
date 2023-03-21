USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[insertProd]    Script Date: 20/03/2023 22:26:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertProd]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(100),@Price money,@InStock int,@DepartmentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
INSERT INTO Product([Name],[Price],[InStock],[DepartmentId])
 VALUES(@Name,@Price,@InStock,@DepartmentId)
		   
		   END
GO


