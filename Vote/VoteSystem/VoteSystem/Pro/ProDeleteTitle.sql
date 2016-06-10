-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日12:54:30
-- Description:	删除主题
-- =============================================
CREATE PROCEDURE ProDeleteTitle
	@title varchar(30)
AS
BEGIN
	delete  from Title where [Title]=@title
END
GO
