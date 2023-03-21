USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[insertDep]    Script Date: 20/03/2023 22:25:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[insertDep] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(100),
    @Description nvarchar(1000)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   INSERT INTO [dbo].[Department]
           ([Name]
           ,[Description])
     VALUES
           (@Name,@Description)
END
GO


