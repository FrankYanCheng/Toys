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
-- Create date: 2014��11��28��11:03:12
-- Description:	��̨�û���֤��¼
-- =============================================
CREATE PROCEDURE ProManager
	@User varchar(20)
AS
BEGIN
	select Pwd from Manager where User=@User
END
GO
