USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[updateProd]    Script Date: 20/03/2023 22:26:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateProd]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(100),
	@Price money,
	@InStock int,
	@DepartmentId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
UPDATE [Product]
   SET [Name] = @Name
      ,[Price] = @Price
      ,[InStock] = @InStock
      ,[DepartmentId] = @DepartmentId
 WHERE [Id]=@Id
 
 END
GO


