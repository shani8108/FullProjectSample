USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[getProd]    Script Date: 20/03/2023 22:28:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getProd]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT pr.[Id]
      ,pr.[Name]
      ,pr.[Price]
      ,pr.[InStock]
	  ,pr.DepartmentId
FROM [Product] pr 
  where pr.[Id]=@id
  
  END
GO


