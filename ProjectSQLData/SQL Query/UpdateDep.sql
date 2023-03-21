USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[UpdateDep]    Script Date: 20/03/2023 22:26:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateDep] 
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name nvarchar(100),
    @Description nvarchar(1000)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   update [dbo].[Department]
    set [Name]=@Name,
        [Description]=@Description
     where
         Id=@Id
		   
		   END
GO


