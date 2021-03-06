USE [master]
GO
/****** Object:  Database [VoteBase]    Script Date: 2014/12/1 20:25:15 ******/
CREATE DATABASE [VoteBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VoteBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VoteBase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VoteBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VoteBase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VoteBase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VoteBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VoteBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VoteBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VoteBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VoteBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VoteBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [VoteBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VoteBase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VoteBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VoteBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VoteBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VoteBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VoteBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VoteBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VoteBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VoteBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VoteBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VoteBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VoteBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VoteBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VoteBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VoteBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VoteBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VoteBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VoteBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VoteBase] SET  MULTI_USER 
GO
ALTER DATABASE [VoteBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VoteBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VoteBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VoteBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [VoteBase]
GO
/****** Object:  StoredProcedure [dbo].[ProAlterTitle]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日13:02:22
-- Description:	修改主题和简介
-- =============================================
CREATE PROCEDURE [dbo].[ProAlterTitle]
	-- Add the parameters for the stored procedure here
	@title varchar(30),
	@summary varchar(200),
	@id int
AS
BEGIN
update Title
set Title=@title,
Summary=@summary
where id=@id

END


GO
/****** Object:  StoredProcedure [dbo].[ProAlterVote]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月30日13:40:36
-- Description:修改投票人信息
-- =============================================
CREATE PROCEDURE [dbo].[ProAlterVote] 
	@id int,
	@introduce varchar(500),
    @className varchar(50),
    @name varchar(20),
    @picPath varchar(200),
    @sno varchar(30)

AS
BEGIN
	update Vote 
	set id=@id,Introduce=@introduce,className=@className,Name=@Name,
	PicPath=@PicPath
	where Sno=@Sno
END

GO
/****** Object:  StoredProcedure [dbo].[ProCountSelectAll]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月29日17:05:23
-- Description:	显示所有票数信息，以及百分比
-- =============================================
CREATE PROCEDURE [dbo].[ProCountSelectAll]
AS
BEGIN 
   declare @counting int
    set @counting=(select sum(count) from Vote)
	select ((n.count*100)/@counting) as percentage,n.Name,t.Title,n.Count from Vote n
	inner join  Title t on t.id=n.id
	where n.IsPermission=1
	order by percentage desc


END

GO
/****** Object:  StoredProcedure [dbo].[ProCountSelectByTitle]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月29日17:57:14
-- Description:	根据标题取出数据
-- =============================================
CREATE PROCEDURE [dbo].[ProCountSelectByTitle]
	@title varchar(20)
AS
BEGIN
	  declare @counting int
    set @counting=(select sum(count) from Vote)
	select ((n.count*100)/@counting) as percentage,n.Name,t.Title,n.Count from Vote n
	inner join  Title t on t.id=n.id
	where n.IsPermission=1 and t.Title=@title
	order by percentage desc
END

GO
/****** Object:  StoredProcedure [dbo].[ProDeleteTitle]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日12:54:30
-- Description:	删除主题
-- =============================================
CREATE PROCEDURE [dbo].[ProDeleteTitle]
	@title varchar(30),
	@id int
AS
BEGIN
	delete  from Vote where id=@id
	delete  from Title where [Title]=@title
END

GO
/****** Object:  StoredProcedure [dbo].[ProDeleteVote]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日15:13:42
-- Description: 删除参与投票人信息
-- =============================================
CREATE PROCEDURE [dbo].[ProDeleteVote]
@sno varchar(30)
AS
BEGIN
	delete from Vote where Sno=@sno
END

GO
/****** Object:  StoredProcedure [dbo].[ProInsertDetail]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日15:34:28
-- Description:	根据学号增加投票票数
-- =============================================
CREATE PROCEDURE [dbo].[ProInsertDetail]
   @sno varchar(30),
   @ip varchar(50)
AS
BEGIN
	--根据学号增加Vote表中的票数
	update Vote
	set Count=Count+1
	where Sno=@sno
	--向投票详细表中添加记录
	insert into VoteDetail (sno,voteIp) values(@sno,@ip)

END

GO
/****** Object:  StoredProcedure [dbo].[ProInsertTitle]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日12:37:45
-- Description:	添加主题,简介限制两百字
-- =============================================
CREATE PROCEDURE [dbo].[ProInsertTitle]
	@Title varchar(30),
	@Summary varchar(200)
AS
BEGIN
	insert into Title(Title,Summary) values(@Title,@Summary)
END

GO
/****** Object:  StoredProcedure [dbo].[ProInsertVote]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日14:58:08
-- Description:	增加参与投票人信息
-- =============================================
CREATE PROCEDURE [dbo].[ProInsertVote]
	@Sno varchar(30),
	@Name varchar(20),
	@PicPath varchar(100),
	@ClassName varchar(50),
	@Introduce varchar(500),
	@id int
AS
BEGIN
	insert into Vote(Sno,Name,PicPath,ClassName,Introduce,id,IsPermission,Count)
	values  (@Sno,@Name,@PicPath,@ClassName,@Introduce,@id,0,0)
END

GO
/****** Object:  StoredProcedure [dbo].[ProManager]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日11:03:12
-- Description:	后台用户验证登录
-- =============================================
CREATE PROCEDURE [dbo].[ProManager]
	@User varchar(20)
AS
BEGIN
	select * from Manager where [User]=@User
END

GO
/****** Object:  StoredProcedure [dbo].[ProPermission]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date:2014年11月28日20:39:18
-- Description:	通过审核
-- =============================================
CREATE PROCEDURE [dbo].[ProPermission]
	@sno varchar(20)
AS
BEGIN
	update vote
	set IsPermission=1
	where Sno=@sno and IsPermission=0

END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectByTitle]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月28日20:17:29
-- Description:	根据主题选择学生信息,降序排列
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectByTitle]
	@title varchar(20)
AS
BEGIN
	select n.className, n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,t.title,n.IsPermission  from Vote n 
	inner join Title t on t.id=n.id
	where t.Title=@title
	order by  n.count desc
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectByTitleRight]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	根据主题选择已通过的学生信息
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectByTitleRight]
	@title varchar(20)
AS
BEGIN
	select n.className, n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,t.title,n.IsPermission from Vote n 
	inner join Title t on t.id=n.id
	where t.Title=@title and n.IsPermission=1
	order by  n.count desc
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectByTitleWrong]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月28日20:17:29
-- Description:	根据主题选择学生信息(未通过),降序排列
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectByTitleWrong]
	@title varchar(20)
AS
BEGIN
	select n.className, n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,t.title,n.IsPermission from Vote n 
	inner join Title t on t.id=n.id
	where t.Title=@title and n.IsPermission=0
	order by  n.count desc
END


GO
/****** Object:  StoredProcedure [dbo].[ProSelectTitles]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日12:48:14
-- Description:	查看所有主题及简介
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectTitles]
AS
BEGIN
	select * from Title
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectVote]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日15:27:23
-- Description:	根据参与投票者的学号获得投票票数和姓名
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectVote]
	@sno varchar(30)
AS
BEGIN
	select n.className,n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,n.id,t.Title from Vote n  inner join Title t  on t.id=n.id 
	where n.Sno=@sno
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectVoteRight]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: 2014年11月28日20:03:09
-- Description:	根据学号显示通过的学生信息，过滤
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectVoteRight]
	@sno varchar(30)
AS
BEGIN
select n.className,n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,t.Title,n.id from Vote n  inner join Title t  on t.id=n.id 
where  Sno=@sno and n.IsPermission=1 ;
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectVotes]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日15:22:44
-- Description:	获取所有参与者信息和目录信息
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectVotes]
AS
BEGIN
	select n.className,n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,c.Title,n.IsPermission from Vote n inner join Title c on c.id=n.id
	order by n.Count desc
END

GO
/****** Object:  StoredProcedure [dbo].[ProSelectVotesRight]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Y.C
-- Create date: 2014年11月28日20:00:20
-- Description:	选择所有已通过的学生信息
-- =============================================
CREATE PROCEDURE [dbo].[ProSelectVotesRight]
AS
BEGIN
	select n.className,n.Count,n.Introduce,n.Name,n.PicPath,n.Sno,c.Title,n.IsPermission from Vote n inner join Title c on c.id=n.id
	where n.IsPermission=1
	order by n.Count desc
END

GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manager](
	[User] [varchar](20) NOT NULL,
	[Pwd] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Title]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Title](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](30) NOT NULL,
	[Summary] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vote]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vote](
	[Sno] [varchar](30) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[PicPath] [varchar](100) NOT NULL,
	[className] [varchar](50) NOT NULL,
	[Introduce] [varchar](500) NOT NULL,
	[IsPermission] [bit] NOT NULL,
	[Count] [int] NOT NULL,
	[id] [int] NOT NULL,
 CONSTRAINT [PK_Vote] PRIMARY KEY CLUSTERED 
(
	[Sno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VoteDetail]    Script Date: 2014/12/1 20:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VoteDetail](
	[sno] [varchar](30) NOT NULL,
	[voteIp] [varchar](50) NOT NULL,
	[votetime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[VoteDetail] ADD  CONSTRAINT [DF_VoteDetail_votetime]  DEFAULT (getdate()) FOR [votetime]
GO
ALTER TABLE [dbo].[Vote]  WITH CHECK ADD  CONSTRAINT [FK_Vote_Title] FOREIGN KEY([id])
REFERENCES [dbo].[Title] ([id])
GO
ALTER TABLE [dbo].[Vote] CHECK CONSTRAINT [FK_Vote_Title]
GO
USE [master]
GO
ALTER DATABASE [VoteBase] SET  READ_WRITE 
GO
