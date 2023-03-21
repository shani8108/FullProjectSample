USE [marketDB]
GO

/****** Object:  StoredProcedure [dbo].[InitDB]    Script Date: 20/03/2023 22:25:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InitDB]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
 select 'Start Init'

    -- Insert statements for procedure here
create table Department(
Id int identity not null,
[Name] nvarchar(100) not null,
[Describtion] nvarchar(1000) null
);

create table Product(
Id int identity not null,
[Name] nvarchar(100) not null,
Price money not null,
InStock int not null,
DepartmentId int not null
);

 select 'End Init'

END
GO


