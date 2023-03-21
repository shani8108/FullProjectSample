USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[getAllProd]    Script Date: 20/03/2023 22:27:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getAllProd]
	-- Add the parameters for the stored procedure here
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
	  ,dp.[Name] as Department
FROM [Product] pr 
join Department dp on pr.DepartmentId=dp.Id

  
  END
GO


