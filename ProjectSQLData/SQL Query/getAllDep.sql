USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[getAllDep]    Script Date: 20/03/2023 22:27:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getAllDep]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [Id]
      ,[Name]
      ,[Description]
  FROM [Department]
  
  END
GO


