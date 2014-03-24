using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zephyr.Core;
using Zephyr.Data;

namespace Zephyr.Web.Sys
{
    public class SqlServerCreator : DbCreatorBase
    {
        #region 数据库类型
        public override string providerName { get { return "SqlServer"; } }
        #endregion

        #region 获取默认【master】数据库的连接字符串
        public override string GetDefaultConnectionString()
        {
            return string.Format("server={0};uid={1};pwd={2};database={3}", server, uid, pwd, "master");
        }
        #endregion

        #region 获取当前数据库的连接字符串
        public override string GetConnectionString()
        {
            return string.Format("server={0};uid={1};pwd={2};database={3}", server, uid, pwd, database);
        }
        #endregion
 
        #region 获取数据库创建脚本
        public override string GetScriptCreateDatabase()
        {
            return string.Format("create database [{0}];", database);
        }
        #endregion

        #region 获取数据库删除脚本
        public override string GetScriptDropDatabase()
        {
            return string.Format("drop database [{0}];", database);
        }
        #endregion

        #region 获取切换database脚本
        public override string GetScriptUseDatabase()
        {
            return string.Format("use [{0}]; \r\n", database);
        }
        #endregion

        #region 获取数据库表结构脚本
        public override string GetScriptCreateTable()
        {
            string scriptTable = @"
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_parameter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_parameter](
	[ParamCode] [varchar](100) NOT NULL,
	[ParamValue] [varchar](200) NULL,
	[IsUserEditable] [bit] NULL,
	[Description] [varchar](2048) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParamCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_role](
	[RoleCode] [varchar](100) NOT NULL,
	[RoleSeq] [varchar](10) NULL,
	[RoleName] [varchar](200) NULL,
	[Description] [varchar](2048) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_loginHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_loginHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](20) NULL,
	[UserName] [varchar](200) NULL,
	[HostName] [varchar](200) NULL,
	[HostIP] [varchar](50) NULL,
	[LoginCity] [varchar](200) NULL,
	[LoginDate] [datetime] NULL,
 CONSTRAINT [PK__SysLoginHistory__7D439ABD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_log](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](20) NULL,
	[UserName] [varchar](100) NULL,
	[Position] [varchar](1024) NULL,
	[Target] [varchar](255) NULL,
	[Type] [varchar](50) NULL,
	[Message] [varchar](max) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK__SysLog__7B5B524B] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_user]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_user](
	[UserCode] [varchar](100) NOT NULL,
	[UserSeq] [varchar](10) NULL,
	[UserName] [varchar](200) NULL,
	[Description] [varchar](2048) NULL,
	[Password] [varchar](40) NULL,
	[RoleName] [varchar](1000) NULL,
	[OrganizeName] [varchar](1000) NULL,
	[ConfigJSON] [nvarchar](4000) NULL,
	[IsEnable] [bit] NULL,
	[LoginCount] [int] NULL,
	[LastLoginDate] [datetime] NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK__SysUser__06CD04F7] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_button]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_button](
	[ButtonCode] [varchar](20) NOT NULL,
	[ButtonName] [varchar](20) NULL,
	[ButtonSeq] [int] NULL,
	[Description] [varchar](100) NULL,
	[ButtonIcon] [varchar](50) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [XPK按钮管理] PRIMARY KEY CLUSTERED 
(
	[ButtonCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_permission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_permission](
	[PermissionCode] [varchar](100) NOT NULL,
	[PermissionName] [varchar](200) NULL,
	[ParentCode] [varchar](100) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PermissionCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_menu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_menu](
	[MenuCode] [varchar](100) NOT NULL,
	[ParentCode] [varchar](100) NULL,
	[MenuName] [varchar](200) NULL,
	[URL] [varchar](200) NULL,
	[IconClass] [varchar](50) NULL,
	[IconURL] [varchar](200) NULL,
	[MenuSeq] [varchar](10) NULL,
	[Description] [varchar](2048) NULL,
	[IsVisible] [bit] NULL,
	[IsEnable] [bit] NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK__SysFunction__797309D9] PRIMARY KEY CLUSTERED 
(
	[MenuCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fun_getPY]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
--set ANSI_NULLS ON
--set QUOTED_IDENTIFIER ON
 
-- =============================================
-- Description:	提供中文首字母
-- Demo: select * from 表 where fun_getPY(字段) like N''%zgr%''
-- =============================================
CREATE FUNCTION [dbo].[fun_getPY]
(
	@str NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN
	DECLARE @word NCHAR(1),@PY NVARCHAR(4000)
	SET @PY=''''
	WHILE len(@str)>0
	BEGIN
		SET @word=left(@str,1)
		SET @PY=@PY+(CASE WHEN unicode(@word) BETWEEN 19968 AND 19968+20901
		THEN (SELECT TOP 1 PY FROM (
		SELECT ''A'' AS PY,N''驁'' AS word
		UNION ALL SELECT ''B'',N''簿''
		UNION ALL SELECT ''C'',N''錯''
		UNION ALL SELECT ''D'',N''鵽''
		UNION ALL SELECT ''E'',N''樲''
		UNION ALL SELECT ''F'',N''鰒''
		UNION ALL SELECT ''G'',N''腂''
		UNION ALL SELECT ''H'',N''夻''
		UNION ALL SELECT ''J'',N''攈''
		UNION ALL SELECT ''K'',N''穒''
		UNION ALL SELECT ''L'',N''鱳''
		UNION ALL SELECT ''M'',N''旀''
		UNION ALL SELECT ''N'',N''桛''
		UNION ALL SELECT ''O'',N''漚''
		UNION ALL SELECT ''P'',N''曝''
		UNION ALL SELECT ''Q'',N''囕''
		UNION ALL SELECT ''R'',N''鶸''
		UNION ALL SELECT ''S'',N''蜶''
		UNION ALL SELECT ''T'',N''籜''
		UNION ALL SELECT ''W'',N''鶩''
		UNION ALL SELECT ''X'',N''鑂''
		UNION ALL SELECT ''Y'',N''韻''
		UNION ALL SELECT ''Z'',N''咗''
		) T 
		WHERE word>=@word COLLATE Chinese_PRC_CS_AS_KS_WS 
		ORDER BY PY ASC) ELSE @word END)
		SET @str=right(@str,len(@str)-1)
	END
	RETURN @PY
END' 
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_codeType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_codeType](
	[CodeType] [varchar](100) NOT NULL,
	[CodeTypeName] [varchar](200) NULL,
	[Description] [varchar](2048) NULL,
	[Seq] [varchar](10) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK__SysCodeType__778AC167] PRIMARY KEY CLUSTERED 
(
	[CodeType] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_organize]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_organize](
	[OrganizeCode] [varchar](100) NOT NULL,
	[ParentCode] [varchar](100) NULL,
	[OrganizeSeq] [varchar](10) NULL,
	[OrganizeName] [varchar](200) NULL,
	[Description] [varchar](2048) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrganizeCode] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_organizeRoleMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_organizeRoleMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizeCode] [varchar](100) NOT NULL,
	[RoleCode] [varchar](100) NOT NULL,
 CONSTRAINT [XPK机构角色] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_roleMenuButtonMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_roleMenuButtonMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [varchar](100) NULL,
	[MenuCode] [varchar](100) NULL,
	[ButtonCode] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_roleMenuColumnMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_roleMenuColumnMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [varchar](100) NULL,
	[MenuCode] [varchar](100) NULL,
	[IsReject] [bit] NULL,
	[FieldName] [varchar](100) NULL,
 CONSTRAINT [PK__sys_roleColumnPe__345EC57D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_rolePermissionMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_rolePermissionMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [varchar](100) NULL,
	[PermissionCode] [varchar](100) NULL,
	[IsDefault] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_userRoleMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_userRoleMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](100) NULL,
	[RoleCode] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_roleMenuMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_roleMenuMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleCode] [varchar](100) NULL,
	[MenuCode] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_userOrganizeMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_userOrganizeMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizeCode] [varchar](100) NULL,
	[UserCode] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_userSetting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_userSetting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserCode] [varchar](100) NULL,
	[SettingCode] [varchar](100) NULL,
	[SettingName] [varchar](200) NULL,
	[SettingValue] [varchar](100) NULL,
	[Description] [varchar](2048) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_menuButtonMap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_menuButtonMap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MenuCode] [varchar](100) NULL,
	[ButtonCode] [varchar](20) NULL,
 CONSTRAINT [PK_sys_menuButtonMap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_code]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_code](
	[Code] [varchar](100) NOT NULL,
	[Value] [varchar](200) NULL,
	[Text] [varchar](200) NULL,
	[ParentCode] [varchar](100) NULL,
	[Seq] [varchar](10) NULL,
	[IsEnable] [bit] NULL,
	[IsDefault] [bit] NULL,
	[Description] [varchar](2048) NULL,
	[CodeTypeName] [varchar](200) NULL,
	[CodeType] [varchar](100) NULL,
	[CreatePerson] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[UpdatePerson] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK__SysCode__5BAD9CC8] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetChild]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

CREATE function [dbo].[GetChild](@type varchar(100),@value varchar(1024))
returns @Tree table (ID varchar(1024))
As
begin  
	if @type = ''Sys_Organize''
	begin
		insert into @Tree select OrganizeCode from Sys_Organize where OrganizeCode=@value  
		while @@rowcount<>0  
		insert into @Tree select a.OrganizeCode from Sys_Organize a   
		inner join @Tree b on a.ParentCode=b.ID and not exists(select 1 from @Tree where ID=a.OrganizeCode)  
	end
	return  
end
' 
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[R_38]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_organizeRoleMap]'))
ALTER TABLE [dbo].[sys_organizeRoleMap]  WITH CHECK ADD  CONSTRAINT [R_38] FOREIGN KEY([OrganizeCode])
REFERENCES [dbo].[sys_organize] ([OrganizeCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[R_39]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_organizeRoleMap]'))
ALTER TABLE [dbo].[sys_organizeRoleMap]  WITH CHECK ADD  CONSTRAINT [R_39] FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleM__Butto__27F8EE98]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuButtonMap]'))
ALTER TABLE [dbo].[sys_roleMenuButtonMap]  WITH CHECK ADD FOREIGN KEY([ButtonCode])
REFERENCES [dbo].[sys_button] ([ButtonCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleM__MenuC__28ED12D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuButtonMap]'))
ALTER TABLE [dbo].[sys_roleMenuButtonMap]  WITH CHECK ADD FOREIGN KEY([MenuCode])
REFERENCES [dbo].[sys_menu] ([MenuCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleM__RoleC__29E1370A]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuButtonMap]'))
ALTER TABLE [dbo].[sys_roleMenuButtonMap]  WITH CHECK ADD FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleC__MenuC__36470DEF]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuColumnMap]'))
ALTER TABLE [dbo].[sys_roleMenuColumnMap]  WITH CHECK ADD  CONSTRAINT [FK__sys_roleC__MenuC__36470DEF] FOREIGN KEY([MenuCode])
REFERENCES [dbo].[sys_menu] ([MenuCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleC__RoleC__3552E9B6]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuColumnMap]'))
ALTER TABLE [dbo].[sys_roleMenuColumnMap]  WITH CHECK ADD  CONSTRAINT [FK__sys_roleC__RoleC__3552E9B6] FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleA__AuthC__2EA5EC27]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_rolePermissionMap]'))
ALTER TABLE [dbo].[sys_rolePermissionMap]  WITH CHECK ADD FOREIGN KEY([PermissionCode])
REFERENCES [dbo].[sys_permission] ([PermissionCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_roleA__RoleC__2F9A1060]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_rolePermissionMap]'))
ALTER TABLE [dbo].[sys_rolePermissionMap]  WITH CHECK ADD FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysUserRo__RoleC__114A936A]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_userRoleMap]'))
ALTER TABLE [dbo].[sys_userRoleMap]  WITH CHECK ADD FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysUserRo__UserC__10566F31]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_userRoleMap]'))
ALTER TABLE [dbo].[sys_userRoleMap]  WITH CHECK ADD  CONSTRAINT [FK__SysUserRo__UserC__10566F31] FOREIGN KEY([UserCode])
REFERENCES [dbo].[sys_user] ([UserCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysRoleFu__Funct__0D7A0286]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuMap]'))
ALTER TABLE [dbo].[sys_roleMenuMap]  WITH CHECK ADD  CONSTRAINT [FK__SysRoleFu__Funct__0D7A0286] FOREIGN KEY([MenuCode])
REFERENCES [dbo].[sys_menu] ([MenuCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysRoleFu__RoleC__0C85DE4D]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_roleMenuMap]'))
ALTER TABLE [dbo].[sys_roleMenuMap]  WITH CHECK ADD FOREIGN KEY([RoleCode])
REFERENCES [dbo].[sys_role] ([RoleCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysUserOr__Organ__0E6E26BF]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_userOrganizeMap]'))
ALTER TABLE [dbo].[sys_userOrganizeMap]  WITH CHECK ADD FOREIGN KEY([OrganizeCode])
REFERENCES [dbo].[sys_organize] ([OrganizeCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysUserOr__UserC__0F624AF8]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_userOrganizeMap]'))
ALTER TABLE [dbo].[sys_userOrganizeMap]  WITH CHECK ADD  CONSTRAINT [FK__SysUserOr__UserC__0F624AF8] FOREIGN KEY([UserCode])
REFERENCES [dbo].[sys_user] ([UserCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_userS__UserC__32767D0B]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_userSetting]'))
ALTER TABLE [dbo].[sys_userSetting]  WITH CHECK ADD FOREIGN KEY([UserCode])
REFERENCES [dbo].[sys_user] ([UserCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_menuB__Butto__16CE6296]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_menuButtonMap]'))
ALTER TABLE [dbo].[sys_menuButtonMap]  WITH CHECK ADD FOREIGN KEY([ButtonCode])
REFERENCES [dbo].[sys_button] ([ButtonCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_menuB__MenuC__12FDD1B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_menuButtonMap]'))
ALTER TABLE [dbo].[sys_menuButtonMap]  WITH CHECK ADD  CONSTRAINT [FK__sys_menuB__MenuC__12FDD1B2] FOREIGN KEY([MenuCode])
REFERENCES [dbo].[sys_menu] ([MenuCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__sys_menuB__MenuC__17C286CF]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_menuButtonMap]'))
ALTER TABLE [dbo].[sys_menuButtonMap]  WITH CHECK ADD FOREIGN KEY([MenuCode])
REFERENCES [dbo].[sys_menu] ([MenuCode])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__SysCode__TypeCod__5CA1C101]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_code]'))
ALTER TABLE [dbo].[sys_code]  WITH CHECK ADD  CONSTRAINT [FK__SysCode__TypeCod__5CA1C101] FOREIGN KEY([CodeType])
REFERENCES [dbo].[sys_codeType] ([CodeType])
";

            return scriptTable.Replace("\r\nGO\r\n", "\r\n");
        }
        #endregion

        #region 获取数据库存初始数据脚本
        public override string GetScriptInsertData()
        {
            string scriptData = @"
--=============================================================
-- Export Database:Zephyr.Sys
--=============================================================

--=============================================================
--   sys_button 2013-11-17 0:53:53
--=============================================================
set nocount on
--set identity_insert sys_button on
delete from  sys_button

insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('accredit', '授权', 9, '', 'icon-wrench_orange', Null, Null, '超级管理员', '2013-07-10 16:43:45')
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('add', '新增', 1, '', 'icon-add', Null, Null, '刘会胜', '2013-08-31 13:58:31')
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('audit', '审核', 10, '', 'icon-folder_key', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('browse', '浏览', 1, '', 'icon-folder_magnify', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('copy', '复制', 12, '', 'icon-page_copy', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('delete', '删除', 3, 'aa', 'icon-cross', Null, Null, '刘会胜', '2013-09-23 12:07:42')
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('download', '下载', 7, '', 'icon-download', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('edit', '编辑', 2, '', 'icon-edit', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('inport', '导入', 11, '', 'icon-page_white_excel', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('print', '打印', 8, '', 'icon-printer', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('refresh', '刷新', 5, '', 'icon-arrow_refresh', Null, Null, Null, Null)
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('save', '保存', 13, '1', 'icon-save', Null, Null, 'LHS', '2013-11-13 16:42:27')
insert into sys_button(ButtonCode, ButtonName, ButtonSeq, Description, ButtonIcon, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('search', '查询', 4, '', 'icon-zoom', Null, Null, '刘会胜', '2013-10-09 15:51:40')

--set identity_insert sys_button off
set nocount off
--=============================================================


--=============================================================
--   sys_codeType 2013-11-17 0:53:54
--=============================================================
set nocount on
--set identity_insert sys_codeType on
delete from  sys_codeType

insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('ApprovalStatus', '审批状态', Null, '19', Null, Null, Null, Null)
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('BusinessType', '企业性质', '', '04', Null, Null, 'lhs', '2013-04-28 22:40:14')
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('ContractType', '合同类型', Null, '15', Null, Null, Null, Null)
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('PayKind', '支付方式', Null, '12', Null, Null, Null, Null)
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('PersonType', '人员类型', '', '', Null, Null, 'lhs', '2013-04-28 22:29:05')
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('Pricing', '计价方式', Null, '20', Null, Null, Null, Null)
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('QualificationLevel', '资质等级', '', '05', Null, Null, 'lhs', '2013-04-28 22:40:14')
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('Sex', '性别', '', '', Null, Null, 'lhs', '2013-04-28 15:50:12')
insert into sys_codeType(CodeType, CodeTypeName, Description, Seq, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('StockState', '库存状态', Null, Null, Null, Null, Null, Null)

--set identity_insert sys_codeType off
set nocount off
--=============================================================


--=============================================================
--   sys_code 2013-11-17 0:53:54
--=============================================================
set nocount on
--set identity_insert sys_code on
delete from  sys_code

insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('015', ' Public', '国有', '0', '1', 'True', Null, Null, '企业性质', 'BusinessType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('016', 'Private', '民营', '0', '2', 'True', Null, Null, '企业性质', 'BusinessType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('017', 'Personal', '私人', '0', '3', 'True', Null, Null, '企业性质', 'BusinessType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('018', 'Special', '特级', '0', '1', 'True', 'True', '12', '资质等级', 'QualificationLevel', Null, Null, 'lhs', '2013-05-15 11:26:25')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('019', 'One', '一级', '0', '2', 'True', Null, Null, '资质等级', 'QualificationLevel', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('020', 'Two', '二级', '0', '3', 'True', Null, Null, '资质等级', 'QualificationLevel', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('021', 'UnderThree', '三级及以下', '0', '4', 'True', Null, Null, '资质等级', 'QualificationLevel', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('039', 'CashCheck', '现金支票', '0', '1', 'True', Null, Null, '支付方式', 'PayKind', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040', 'TransferCheck', '转帐支票', '0', '2', 'True', Null, Null, '支付方式', 'PayKind', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('041', 'Bill', '汇票', '0', '3', 'True', Null, Null, '支付方式', 'PayKind', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('074', 'Stock', '采购', '0', '1', 'True', Null, Null, '合同类型', 'ContractType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('075', 'Rent', '租赁', '0', '2', 'True', Null, Null, '合同类型', 'ContractType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('076', 'Other', '其他', '0', '3', 'True', Null, Null, '合同类型', 'ContractType', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('087', 'Unapproved', '未审批', '0', '1', 'True', Null, Null, '审批状态', 'ApprovalStatus', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('088', 'ApprovalIn', '审批中', '0', '2', 'True', Null, Null, '审批状态', 'ApprovalStatus', Null, Null, 'lhs', '2013-01-08 16:52:25')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('089', 'ApprovalPass', '审批通过', '0', '3', 'True', Null, Null, '审批状态', 'ApprovalStatus', Null, Null, 'lhs', '2013-01-08 16:47:23')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('090', 'ApprovalUnPass', '审批未通过', '0', '4', 'True', Null, Null, '审批状态', 'ApprovalStatus', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('091', 'Batch', '批次', '0', '1', 'True', 'True', '', '计价方式', 'Pricing', Null, Null, '刘会胜', '2013-05-24 15:33:18')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('092', 'FIFO', '先进先出', '0', '2', 'True', 'False', '', '计价方式', 'Pricing', Null, Null, '刘会胜', '2013-05-24 15:33:18')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('098', '0', '安全库存', '0', '0', 'True', Null, Null, '库存状态', 'StockState', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('099', '1', '库存即将不足', '0', '1', 'True', Null, Null, '库存状态', 'StockState', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('100', '2', '库存不足', '0', '2', 'True', Null, Null, '库存状态', 'StockState', Null, Null, Null, Null)
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('107', 'PersonType1', '人员类型1', '', '', 'True', 'False', '', Null, 'PersonType', '刘会胜', '2013-09-24 11:05:08', '刘会胜', '2013-09-24 11:05:33')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('108', 'PersonType2', '人员类型2', '', '', 'False', 'False', '', Null, 'PersonType', '刘会胜', '2013-09-24 11:05:08', '刘会胜', '2013-09-24 11:05:33')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('109', 'man', '男', '', '', 'False', 'False', '', Null, 'Sex', '管理员', '2013-11-17 0:14:25', '管理员', '2013-11-17 0:14:25')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('110', 'woman', '女', '', '', 'False', 'False', '', Null, 'Sex', '管理员', '2013-11-17 0:14:25', '管理员', '2013-11-17 0:14:25')
insert into sys_code(Code, Value, Text, ParentCode, Seq, IsEnable, IsDefault, Description, CodeTypeName, CodeType, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('111', 'unknown', '春哥', '', '', 'False', 'False', '', Null, 'Sex', '管理员', '2013-11-17 0:14:25', '管理员', '2013-11-17 0:14:25')

--set identity_insert sys_code off
set nocount off
--=============================================================


--=============================================================
--   sys_log 2013-11-17 0:53:54
--=============================================================
set nocount on
set identity_insert sys_log on
delete from  sys_log

insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (210, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""652134dd-dbbc-466e-9c2c-cd594541cd60"",""MenuName"":""代码生成"",""MenuCode"":""9810"",""ParentCode"":""98"",""IconClass"":""icon-page_code"",""URL"":""/sys/generator"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-08-31 14:02:54')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (211, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""37e0617e-6dec-4deb-8748-7b1c748e5fe8"",""MenuName"":""测试页面"",""MenuCode"":""9930"",""ParentCode"":""10"",""IconClass"":""icon-anchor"",""URL"":""/mms/productTest"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-09-05 22:47:03')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (212, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""c605c038-e36c-47b0-90d7-9ba44fcc8c73"",""MenuName"":""测试1"",""MenuCode"":""9950"",""ParentCode"":""98"",""IconClass"":""icon-application_cascade"",""URL"":""/mms/liy"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-09-10 11:31:25')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (213, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""9930"",""MenuName"":""测试页面"",""MenuCode"":""9930"",""ParentCode"":""10"",""IconClass"":""icon-anchor"",""URL"":""/mms/productTest"",""IsVisible"":""false"",""IsEnable"":""false"",""MenuSeq"":""""}],""_changed"":true}}', '2013-09-18 16:21:19')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (214, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""4620a34a-b5c8-4f95-9290-058b371d91c8"",""MenuName"":""员工管理"",""MenuCode"":""9960"",""ParentCode"":""98"",""IconClass"":""icon-user_b"",""URL"":""/mms/staff"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-09-24 11:11:14')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (215, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""577fa65f-95b7-423c-bf2e-9c81ddc1f5a3"",""MenuName"":""员工编辑"",""MenuCode"":""9961"",""ParentCode"":""98"",""IconClass"":"""",""URL"":""/mms/staff/edit"",""IsVisible"":""false"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-09-24 11:35:22')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (216, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""0101"",""MenuName"":""采购管理"",""MenuCode"":""0101"",""ParentCode"":""10"",""IconClass"":""icon-application_osx_add"",""URL"":""/psi/purchase"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""1010""}],""_changed"":true}}', '2013-10-11 11:54:21')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (217, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""310ea02c-2468-4fb0-8f77-20f855d67d7b"",""MenuName"":""采购明细"",""MenuCode"":""1019"",""ParentCode"":""01"",""IconClass"":"""",""URL"":""/psi/purchase/edit"",""IsVisible"":""false"",""IsEnable"":""true"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-10-11 12:19:25')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (218, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""1019"",""MenuName"":""采购明细"",""MenuCode"":""1019"",""ParentCode"":""10"",""IconClass"":"""",""URL"":""/psi/purchase/edit"",""IsVisible"":""false"",""IsEnable"":""true"",""MenuSeq"":""""}],""_changed"":true}}', '2013-10-11 13:49:28')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (219, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""1019"",""MenuName"":""采购明细"",""MenuCode"":""1019"",""ParentCode"":""10"",""IconClass"":"""",""URL"":""/psi/purchase/edit"",""IsVisible"":""false"",""IsEnable"":""true"",""MenuSeq"":""""},{""_id"":""0101"",""MenuName"":""材料采购单"",""MenuCode"":""0101"",""ParentCode"":""10"",""IconClass"":""icon-application_osx_add"",""URL"":""/psi/purchase"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""1010""}],""_changed"":true}}', '2013-10-11 13:50:35')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (220, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""0101"",""MenuName"":""材料采购单"",""MenuCode"":""0101"",""ParentCode"":""10"",""IconClass"":""icon-application_osx_add"",""URL"":""/psi/purchase"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""009""}],""_changed"":true}}', '2013-10-11 13:50:51')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (221, 'admin', '管理员', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""0101"",""MenuName"":""材料采购单"",""MenuCode"":""0101"",""ParentCode"":""10"",""IconClass"":""icon-application_osx_add"",""URL"":""/psi/purchase"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""150""}],""_changed"":true}}', '2013-10-11 14:51:54')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (222, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""9950"",""MenuName"":""测试1"",""MenuCode"":""9950"",""ParentCode"":""98"",""IconClass"":""icon-application_cascade"",""URL"":""/mms/liy"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""},{""_id"":""9960"",""MenuName"":""员工测试2"",""MenuCode"":""9960"",""ParentCode"":""98"",""IconClass"":""icon-user_b"",""URL"":""/mms/staff"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""},{""_id"":""9920"",""MenuName"":""产品测试"",""MenuCode"":""9920"",""ParentCode"":""98"",""IconClass"":""icon-application_side_list"",""URL"":""/mms/product"",""IsVisible"":""true"",""IsEnable"":""true"",""MenuSeq"":""""}],""_changed"":true}}', '2013-10-22 17:00:46')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (223, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[],""updated"":[{""_id"":""0107"",""MenuName"":""采购计划"",""MenuCode"":""0107"",""ParentCode"":""01"",""IconClass"":"""",""URL"":""#"",""IsVisible"":false,""IsEnable"":false,""MenuSeq"":""1060""}],""_changed"":true}}', '2013-11-07 23:44:55')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (224, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[],""inserted"":[{""_id"":""07fe640b-bda8-4237-b46e-3364e1b45ab7"",""MenuName"":""11111"",""MenuCode"":""2222"",""ParentCode"":"""",""IconClass"":"""",""URL"":"""",""IsVisible"":""0"",""IsEnable"":""0"",""MenuSeq"":""""}],""updated"":[],""_changed"":true}}', '2013-11-07 23:45:10')
insert into sys_log(ID, UserCode, UserName, Position, Target, Type, Message, Date) values (225, 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{""list"":{""deleted"":[{""_id"":""2222"",""MenuName"":""11111"",""MenuCode"":""2222"",""ParentCode"":"""",""IconClass"":"""",""URL"":"""",""IsVisible"":false,""IsEnable"":false,""MenuSeq"":""""}],""inserted"":[],""updated"":[],""_changed"":true}}', '2013-11-07 23:45:17')

set identity_insert sys_log off
set nocount off
--=============================================================


--=============================================================
--   sys_loginHistory 2013-11-17 0:53:55
--=============================================================
set nocount on
set identity_insert sys_loginHistory on
delete from  sys_loginHistory

insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (371, 'guest', '访客', '', '58.247.109.242', '上海市', '2013-07-01 17:53:16')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (372, 'guest', '访客', '', '59.172.217.86', '湖北省武汉市', '2013-07-01 17:58:26')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (373, 'guest', '访客', '', '60.208.111.207', '山东省济南市', '2013-07-01 18:00:04')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (374, 'guest', '访客', '', '58.61.99.161', '广东省深圳市', '2013-07-01 18:06:28')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (375, 'guest', '访客', '', '180.173.186.210', '上海市', '2013-07-01 18:21:39')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (376, 'guest', '访客', '', '218.22.27.204', '安徽省合肥市', '2013-07-01 18:26:50')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (377, 'guest', '访客', '', '218.22.27.204', '安徽省合肥市', '2013-07-01 18:39:08')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (378, 'guest', '访客', '', '121.204.49.65', '福建省福州市', '2013-07-01 18:41:46')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (379, 'guest', '访客', '', '116.112.140.242', '内蒙古自治区呼和浩特市', '2013-07-01 18:48:05')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (380, 'guest', '访客', '', '124.127.49.128', '北京市', '2013-07-01 18:54:30')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (381, 'guest', '访客', '', '221.227.46.72', '江苏省无锡市', '2013-07-01 18:59:13')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (382, 'guest', '访客', '', '172.16.205.12/180.168.188.249', '上海市', '2013-07-01 19:20:46')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (383, 'guest', '访客', '', '221.227.46.72', '江苏省无锡市', '2013-07-01 19:25:11')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (384, 'guest', '访客', '', '120.90.122.13/61.164.207.39', '山西省晋中市', '2013-07-01 19:26:48')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (385, 'guest', '访客', '', '113.235.251.108', '辽宁省大连市', '2013-07-01 19:28:52')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (386, 'guest', '访客', '', '114.96.129.227', '安徽省合肥市', '2013-07-01 19:35:41')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (387, 'guest', '访客', '', '118.119.128.20', '四川省攀枝花市', '2013-07-01 19:38:50')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (388, 'guest', '访客', '', '111.192.15. 113/117.79.232.153', '广东省', '2013-07-01 19:41:37')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (389, 'guest', '访客', '', '117.40.105.122', '江西省南昌市', '2013-07-01 20:01:27')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (390, 'guest', '访客', '', '220.178.118.197', '安徽省合肥市', '2013-07-01 20:15:13')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (391, 'lhs', '刘会胜', '', '58.23.10.235', '福建省厦门市', '2013-07-01 20:30:49')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (392, 'guest', '访客', '', '218.26.228.252/61.164.174.136', '江西省九江市', '2013-07-01 20:31:19')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (393, 'guest', '访客', '', '180.99.32.178', '江苏省南京市', '2013-07-01 20:37:35')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (394, 'guest', '访客', '', '106.108.197.92', '广东省', '2013-07-01 20:39:35')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (395, 'lhs', '刘会胜', '', '58.23.10.235', '福建省厦门市', '2013-07-01 20:39:36')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (396, 'guest', '访客', '', '123.157.102.42', '浙江省衢州市', '2013-07-01 20:45:48')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (397, 'guest', '访客', '', '180.212.43.115', '天津市', '2013-07-01 21:04:03')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (398, 'guest', '访客', '', '220.190.224.189', '浙江省温州市', '2013-07-01 21:16:57')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (399, 'guest', '访客', '', '163.125.121.68', '广东省深圳市', '2013-07-01 21:21:04')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (400, 'guest', '访客', '', '180.159.148.41', '上海市', '2013-07-01 21:22:05')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (401, 'guest', '访客', '', '163.125.121.68', '广东省深圳市', '2013-07-01 21:24:11')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (402, 'guest', '访客', '', '113.120.53.96', '山东省济南市', '2013-07-01 21:24:23')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (403, 'guest', '访客', '', '180.142.73.186', '广西壮族自治区贵港市', '2013-07-01 21:30:09')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (404, 'guest', '访客', '', '111.193.193.62', '北京市', '2013-07-01 21:33:43')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (405, 'guest', '访客', '', '221.224.147.178', '江苏省苏州市', '2013-07-01 21:37:35')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (406, 'guest', '访客', '', '222.133.49.86', '山东省德州市', '2013-07-01 21:37:44')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (407, 'guest', '访客', '', '106.3.102.193/118.195.65.231', '北京市', '2013-07-01 21:45:00')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (408, 'guest', '访客', '', '119.123.137.65', '广东省深圳市', '2013-07-01 22:05:27')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (409, 'guest', '访客', '', '14.147.86.142/14.147.91.11', '广东省广州市', '2013-07-01 22:13:27')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (410, 'guest', '访客', '', '183.16.133.218', '广东省深圳市', '2013-07-01 22:19:45')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (411, 'guest', '访客', '', '101.80.222.14', '上海市', '2013-07-01 22:30:14')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (412, 'lhs', '刘会胜', 'LHS-PC', '27.159.16.26/localhost', '福建省厦门市', '2013-07-01 22:30:34')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (413, 'guest', '访客', '', '117.64.102.4', '安徽省合肥市', '2013-07-01 22:33:17')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (414, 'guest', '访客', '', '114.243.215.234', '北京市', '2013-07-01 22:43:17')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (415, 'guest', '访客', '', '171.216.172.152', '四川省成都市', '2013-07-01 22:44:44')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (416, 'guest', '访客', '', '114.243.215.234', '北京市', '2013-07-01 22:46:21')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (417, 'guest', '访客', '', '218.241.172.186', '北京市', '2013-07-01 22:46:58')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (418, 'guest', '访客', '', '171.216.172.152', '四川省成都市', '2013-07-01 22:51:08')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (419, 'guest', '访客', '', '124.200.52.3/124.202.191.143', '北京市', '2013-07-01 22:54:46')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (420, 'guest', '访客', '', '101.80.222.14', '上海市', '2013-07-01 23:02:22')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (421, 'guest', '访客', '', '101.80.222.14', '上海市', '2013-07-01 23:03:05')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (422, 'guest', '访客', '', '183.12.186.199', '广东省深圳市', '2013-07-01 23:03:47')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (423, 'guest', '访客', '', '112.65.211.82/113.107.205.99', '吉林省吉林市', '2013-07-01 23:06:26')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (424, 'guest', '访客', '', '183.12.186.199', '广东省深圳市', '2013-07-01 23:07:44')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (859, 'super', '超级管理员', '', '120.35.94.99', '福建省厦门市', '2013-07-08 17:15:39')
insert into sys_loginHistory(ID, UserCode, UserName, HostName, HostIP, LoginCity, LoginDate) values (860, 'guest', '访客', '', '1.85.44.34', '陕西省西安市', '2013-07-08 17:28:00')

set identity_insert sys_loginHistory off
set nocount off
--=============================================================


--=============================================================
--   sys_menu 2013-11-17 0:53:55
--=============================================================
set nocount on
--set identity_insert sys_menu on
delete from  sys_menu

insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('98', '0', '开发平台', '#', 'icon-image', '/common/css/icon/icon/application_osx_home.png', '60', Null, 'True', 'True', Null, Null, '刘会胜', '2013-08-31 13:46:47')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9810', '98', '代码生成', '/sys/generator', 'icon-page_code', Null, '', Null, 'True', 'True', '刘会胜', '2013-08-31 14:02:54', '刘会胜', '2013-08-31 14:02:54')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('99', '0', '系统设置', '#', 'icon-sysset', Null, '50', Null, 'True', 'True', Null, Null, 'lhs', '2013-05-17 11:06:13')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9902', '99', '菜单导航', '/sys/menu', 'icon-chart_organisation', '/common/css/icon/icon/chart_organisation.png', '210', Null, 'True', 'True', Null, Null, '访客', '2013-07-02 9:36:35')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9903', '99', '组织结构', '/sys/organize', 'icon-org', Null, '220', Null, 'True', 'True', Null, Null, 'lhs', '2013-04-27 16:56:03')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9904', '99', '角色管理', '/sys/role', 'icon-group', Null, '240', Null, 'True', 'True', Null, Null, '访客', '2013-06-25 13:19:58')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9905', '99', '用户管理', '/sys/user', 'icon-users', Null, '245', Null, 'True', 'True', Null, Null, '刘会胜', '2013-07-14 17:21:41')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9906', '99', '数据字典', '/sys/code', 'icon-book', Null, '250', Null, 'True', 'True', Null, Null, '访客', '2013-07-02 9:36:35')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9907', '99', '操作日志', '/sys/log', 'icon-error', Null, '260', Null, 'True', 'True', Null, Null, 'lhs', '2013-04-29 11:02:32')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9909', '99', '个性设置', '/sys/config', 'icon-wrench_orange', Null, '270', Null, 'True', 'False', Null, Null, '刘会胜', '2013-07-14 17:21:13')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9910', '99', '授权代码', '/sys/permission', 'icon-lock_key', Null, '230', Null, 'True', 'True', '刘会胜', '2013-07-14 17:21:13', '刘会胜', '2013-07-19 17:11:57')
insert into sys_menu(MenuCode, ParentCode, MenuName, URL, IconClass, IconURL, MenuSeq, Description, IsVisible, IsEnable, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('9911', '99', '系统参数', '/sys/parameter', 'icon-page_white_wrench', Null, '255', Null, 'True', 'True', '刘会胜', '2013-07-15 11:58:00', '刘会胜', '2013-07-19 17:11:57')

--set identity_insert sys_menu off
set nocount off
--=============================================================


--=============================================================
--   sys_organize 2013-11-17 0:53:55
--=============================================================
set nocount on
--set identity_insert sys_organize on
delete from  sys_organize

INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('04', '0', null, '厦门市电力服务公司', '', 'super', '2013-05-17 18:04:40', '访客', '2013-07-23 22:59:07');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0403', '04', '', '市场营销中心', '123', 'super', '2013-05-17 18:09:02', '超级管理员', '2013-07-11 22:34:42');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0404', '04', '', '预结算中心', '', 'super', '2013-05-17 18:09:57', '访客', '2013-07-23 10:16:45');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0406', '04', '', '厦门市电力工程有限责任公司', 'ad ', 'super', '2013-05-17 18:12:47', '访客', '2013-07-23 13:58:38');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040601', '0406', '', '办公室', '12', 'super', '2013-05-17 18:12:59', '超级管理员', '2013-07-11 22:34:47');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040602', '0406', '', '项目管理中心', '', 'super', '2013-05-17 18:13:10', '访客', '2013-07-23 10:18:53');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040603', '0406', '', '质安部', '', 'super', '2013-05-17 18:13:15', 'super', '2013-05-17 18:13:15');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040604', '0406', '', '输变电项目部', '', 'super', '2013-05-17 18:13:22', '访客', '2013-07-22 13:23:38');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040605', '0406', '', '生产技术部', '', 'super', '2013-05-17 18:13:27', 'super', '2013-05-17 18:13:27');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0407', '04', '', '厦门市电力器材有限责任公司', '', 'super', '2013-05-17 18:13:37', 'super', '2013-05-17 18:14:27');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040701', '0407', '', '生产车间', '', 'super', '2013-05-17 18:13:47', 'super', '2013-05-17 18:13:47');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0408', '04', '', '厦门市成功电力勘察设计有限公司', '', 'super', '2013-05-17 18:15:00', 'super', '2013-05-17 18:15:00');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040801', '0408', '', '系统与技经组', '', 'super', '2013-05-17 18:15:12', 'super', '2013-05-17 18:15:12');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040802', '0408', '', '配网设计组', '', 'super', '2013-05-17 18:15:19', '访客', '2013-07-22 21:56:16');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040803', '0408', '', '配电设计组', '', 'super', '2013-05-17 18:15:25', 'super', '2013-05-17 18:15:25');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040804', '0408', '', '变电设计组', '', 'super', '2013-05-17 18:15:33', 'super', '2013-05-17 18:15:33');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040805', '0408', '', '送电设计组', '', 'super', '2013-05-17 18:15:40', 'super', '2013-05-17 18:15:40');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0409', '04', '', '厦门市电力服务公司物资分公司', '', 'super', '2013-05-17 18:15:58', 'super', '2013-05-17 18:15:58');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040901', '0409', '', '采购部', '', 'super', '2013-05-17 18:16:16', 'super', '2013-05-17 18:16:16');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040902', '0409', '', '仓储部', '', 'super', '2013-05-17 18:16:23', 'super', '2013-05-17 18:16:23');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('040903', '0409', '', '经营部', '', 'super', '2013-05-17 18:16:29', 'super', '2013-05-17 18:16:29');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0410', '04', '', '南安市水泥制品厂', '', 'super', '2013-05-17 18:16:41', 'super', '2013-05-17 18:16:41');
INSERT INTO sys_organize(OrganizeCode, ParentCode, OrganizeSeq, OrganizeName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('041001', '0410', '', '生产车间', '', 'super', '2013-05-17 18:16:49', 'super', '2013-05-17 18:16:49');

--set identity_insert sys_organize off
set nocount off
--=============================================================


--=============================================================
--   sys_parameter 2013-11-17 0:53:56
--=============================================================
set nocount on
--set identity_insert sys_parameter on
delete from  sys_parameter

INSERT INTO sys_parameter(ParamCode, ParamValue, IsUserEditable, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('SYS_COPYRIGHT', 'Copyright&copy;2013 Zephyr, All Rights Reserved', '0', '版权信息', '刘会胜', '2013-07-15 15:21:19', '刘会胜', '2013-07-15 15:25:34');
INSERT INTO sys_parameter(ParamCode, ParamValue, IsUserEditable, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('SYS_NAME', '业务管理系统', '1', '系统名称', null, null, '管理员', '2013-11-18 15:32:40');
INSERT INTO sys_parameter(ParamCode, ParamValue, IsUserEditable, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('SYS_NAME_EN', 'Business Mangange System', '1', '系统英文名称', null, null, '管理员', '2013-11-18 15:36:08');

--set identity_insert sys_parameter off
set nocount off
--=============================================================


--=============================================================
--   sys_permission 2013-11-17 0:53:56
--=============================================================
set nocount on
--set identity_insert sys_permission on
delete from  sys_permission

insert into sys_permission(PermissionCode, PermissionName, ParentCode, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('01', '同城四季', '0', Null, Null, '刘会胜', '2013-09-07 1:00:51')
insert into sys_permission(PermissionCode, PermissionName, ParentCode, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0101', '同城四季一期', '0101', Null, Null, '访客', '2013-07-24 13:46:19')
insert into sys_permission(PermissionCode, PermissionName, ParentCode, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0102', '同城四季二期', '01', Null, Null, Null, Null)
insert into sys_permission(PermissionCode, PermissionName, ParentCode, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('02', '云顶至尊', '0', Null, Null, '访客', '2013-07-22 18:36:29')
insert into sys_permission(PermissionCode, PermissionName, ParentCode, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('0201', '云顶至尊一期', '02', Null, Null, Null, Null)

--set identity_insert sys_permission off
set nocount off
--=============================================================


--=============================================================
--   sys_role 2013-11-17 0:53:56
--=============================================================
set nocount on
--set identity_insert sys_role on
delete from  sys_role

insert into sys_role(RoleCode, RoleSeq, RoleName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('R1', '40', '经理角色', '', '刘会胜', '2013-11-16 23:53:32', '刘会胜', '2013-11-16 23:53:32')
insert into sys_role(RoleCode, RoleSeq, RoleName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('R2', '50', '业务员角色', '', '刘会胜', '2013-11-16 23:53:32', '刘会胜', '2013-11-16 23:53:32')
insert into sys_role(RoleCode, RoleSeq, RoleName, Description, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('super', '10', '超级管理员', '超级管理员', 'lhs', '2013-05-17 11:25:50', '刘会胜', '2013-11-16 23:53:46')

--set identity_insert sys_role off
set nocount off
--=============================================================


--=============================================================
--   sys_user 2013-11-17 0:53:56
--=============================================================
set nocount on
--set identity_insert sys_user on
delete from  sys_user

insert into sys_user(UserCode, UserSeq, UserName, Description, Password, RoleName, OrganizeName, ConfigJSON, IsEnable, LoginCount, LastLoginDate, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('admin', Null, '管理员', '', '81dc9bdb52d04dc20036dbd8313ed055', Null, Null, Null, 'True', 12, '2013-11-17 0:06:12', '刘会胜', '2013-10-09 16:33:47', '刘会胜', '2013-10-09 16:33:47')
insert into sys_user(UserCode, UserSeq, UserName, Description, Password, RoleName, OrganizeName, ConfigJSON, IsEnable, LoginCount, LastLoginDate, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('guest', Null, '访客', '', '81dc9bdb52d04dc20036dbd8313ed055', Null, Null, '{""theme"":""default"",""navType"":""accordion"",""gridRows"":""50""}', 'True', 1207, '2013-11-07 12:01:04', '颜荣华', '2013-06-25 13:15:57', '颜荣华', '2013-06-25 13:15:57')
insert into sys_user(UserCode, UserSeq, UserName, Description, Password, RoleName, OrganizeName, ConfigJSON, IsEnable, LoginCount, LastLoginDate, CreatePerson, CreateDate, UpdatePerson, UpdateDate) values ('super', '1', '超级管理员', Null, '81dc9bdb52d04dc20036dbd8313ed055', Null, Null, '{""theme"":""default"",""navType"":""accordion"",""gridRows"":""20""}', 'True', 56, '2013-11-16 23:59:14', Null, Null, Null, Null)

--set identity_insert sys_user off
set nocount off
--=============================================================


--=============================================================
--   sys_userOrganizeMap 2013-11-17 0:53:56
--=============================================================
set nocount on
set identity_insert sys_userOrganizeMap on
delete from  sys_userOrganizeMap


set identity_insert sys_userOrganizeMap off
set nocount off
--=============================================================


--=============================================================
--   sys_userRoleMap 2013-11-17 0:53:56
--=============================================================
set nocount on
set identity_insert sys_userRoleMap on
delete from  sys_userRoleMap

insert into sys_userRoleMap(ID, UserCode, RoleCode) values (274, 'super', 'super')
insert into sys_userRoleMap(ID, UserCode, RoleCode) values (310, 'admin', 'super')

set identity_insert sys_userRoleMap off
set nocount off
--=============================================================


--=============================================================
--   sys_userSetting 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_userSetting on
delete from  sys_userSetting

insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (9, 'guest', 'theme', Null, 'default', Null)
insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (10, 'guest', 'navigation', Null, 'accordion', Null)
insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (11, 'guest', 'gridrows', Null, '30', Null)
insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (17, 'super', 'theme', Null, 'gray', Null)
insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (18, 'super', 'navigation', Null, 'accordion', Null)
insert into sys_userSetting(ID, UserCode, SettingCode, SettingName, SettingValue, Description) values (19, 'super', 'gridrows', Null, '20', Null)

set identity_insert sys_userSetting off
set nocount off
--=============================================================


--=============================================================
--   sys_menuButtonMap 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_menuButtonMap on
delete from  sys_menuButtonMap


set identity_insert sys_menuButtonMap off
set nocount off
--=============================================================


--=============================================================
--   sys_organizeRoleMap 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_organizeRoleMap on
delete from  sys_organizeRoleMap


set identity_insert sys_organizeRoleMap off
set nocount off
--=============================================================


--=============================================================
--   sys_roleMenuButtonMap 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_roleMenuButtonMap on
delete from  sys_roleMenuButtonMap


set identity_insert sys_roleMenuButtonMap off
set nocount off
--=============================================================


--=============================================================
--   sys_roleMenuColumnMap 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_roleMenuColumnMap on
delete from  sys_roleMenuColumnMap


set identity_insert sys_roleMenuColumnMap off
set nocount off
--=============================================================


--=============================================================
--   sys_roleMenuMap 2013-11-17 0:53:57
--=============================================================
set nocount on
set identity_insert sys_roleMenuMap on
delete from  sys_roleMenuMap

insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7424, 'super', '99')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7425, 'super', '9902')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7426, 'super', '9903')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7427, 'super', '9910')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7428, 'super', '9904')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7429, 'super', '9905')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7430, 'super', '9906')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7431, 'super', '9911')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7432, 'super', '9907')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7433, 'super', '98')
insert into sys_roleMenuMap(ID, RoleCode, MenuCode) values (7434, 'super', '9810')

set identity_insert sys_roleMenuMap off
set nocount off
--=============================================================


--=============================================================
--   sys_rolePermissionMap 2013-11-17 0:53:58
--=============================================================
set nocount on
set identity_insert sys_rolePermissionMap on
delete from  sys_rolePermissionMap

insert into sys_rolePermissionMap(ID, RoleCode, PermissionCode, IsDefault) values (134, 'super', '0102', 'False')

set identity_insert sys_rolePermissionMap off
set nocount off
--=============================================================";

            return scriptData;
        }
        #endregion
    }
}