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
-- Create date: 2014��11��28��12:37:45
-- Description:	�������,�������������
-- =============================================
CREATE PROCEDURE ProInsertTitle
	@Title varchar(30),
	@Summary varchar(200)
AS
BEGIN
	insert into Title(Title,Summary) values(@Title,@Summary)
END
GO
