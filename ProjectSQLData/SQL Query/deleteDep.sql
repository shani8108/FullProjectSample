USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[deleteDep]    Script Date: 20/03/2023 22:27:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deleteDep] 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
      DELETE FROM [dbo].[Department]
      WHERE Id=@Id
	  
	  
	  END
GO


