USE [VoteBase]
GO
/****** Object:  StoredProcedure [dbo].[ProManager]    Script Date: 2014/11/28 12:15:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日11:03:12
-- Description:	后台用户验证登录
-- =============================================
ALTER PROCEDURE [dbo].[ProManager]
	@User varchar(20)
AS
BEGIN
	select * from Manager where User=@User
END
