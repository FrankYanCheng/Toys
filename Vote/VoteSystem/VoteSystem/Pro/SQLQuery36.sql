USE [VoteBase]
GO
/****** Object:  StoredProcedure [dbo].[ProAlterTitle]    Script Date: 2014/11/28 13:27:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日13:02:22
-- Description:	修改主题和简介
-- =============================================
ALTER PROCEDURE [dbo].[ProAlterTitle]
	-- Add the parameters for the stored procedure here
	@title varchar(30),
	@summary varchar(200)
AS
BEGIN
update Title
set Title=@title,
Summary=@summary
where id=
(
	select id from Title 
	where Title=@title
	)
	

END

