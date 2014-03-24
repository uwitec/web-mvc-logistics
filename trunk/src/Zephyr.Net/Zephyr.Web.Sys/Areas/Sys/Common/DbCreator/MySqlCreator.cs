using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zephyr.Core;
using Zephyr.Data;

namespace Zephyr.Web.Sys
{
    public class MySqlCreator : DbCreatorBase
    {
        #region 数据库类型
        public override string providerName { get { return "MySql"; } }
        #endregion

        #region 获取默认【information_schema】数据库的连接字符串
        public override string GetDefaultConnectionString()
        {
            return string.Format("server={0};uid={1};pwd={2};database={3}", server, uid, pwd, "information_schema");
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
            return string.Format("create database `{0}`;", database);
        }
        #endregion

        #region 获取数据库删除脚本
        public override string GetScriptDropDatabase()
        {
            return string.Format("drop database `{0}`;", database);
        }
        #endregion

        #region 获取切换database脚本
        public override string GetScriptUseDatabase()
        {
            return string.Format("use `{0}`;  \r\n", database);
        }
        #endregion

        #region 获取数据库表结构脚本
        public override string GetScriptCreateTable()
        {
            string scriptTable = @"
/*
Navicat MySQL Data Transfer

Source Server         : LHS-PC
Source Server Version : 50610
Source Host           : localhost:3306
Source Database       : zephyr.sys

Target Server Type    : MYSQL
Target Server Version : 50610
File Encoding         : 65001

Date: 2013-11-18 18:00:53
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `sys_button`
-- ----------------------------

CREATE TABLE `sys_button` (
  `ButtonCode` varchar(20) NOT NULL,
  `ButtonName` varchar(20) DEFAULT NULL,
  `ButtonSeq` int(11) DEFAULT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `ButtonIcon` varchar(50) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ButtonCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_codetype`
-- ----------------------------

CREATE TABLE `sys_codetype` (
  `CodeType` varchar(100) NOT NULL,
  `CodeTypeName` varchar(200) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Seq` varchar(10) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`CodeType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_code`
-- ----------------------------

CREATE TABLE `sys_code` (
  `Code` varchar(100) NOT NULL,
  `Value` varchar(200) DEFAULT NULL,
  `Text` varchar(200) DEFAULT NULL,
  `ParentCode` varchar(100) DEFAULT NULL,
  `Seq` varchar(10) DEFAULT NULL,
  `IsEnable` tinyint(1) DEFAULT NULL,
  `IsDefault` tinyint(1) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `CodeTypeName` varchar(200) DEFAULT NULL,
  `CodeType` varchar(100) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Code`),
  KEY `FK__SysCode__TypeCod__5CA1C101` (`CodeType`),
  CONSTRAINT `FK__SysCode__TypeCod__5CA1C101` FOREIGN KEY (`CodeType`) REFERENCES `sys_codetype` (`CodeType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- ----------------------------
-- Table structure for `sys_log`
-- ----------------------------

CREATE TABLE `sys_log` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserCode` varchar(20) DEFAULT NULL,
  `UserName` varchar(100) DEFAULT NULL,
  `Position` varchar(1024) DEFAULT NULL,
  `Target` varchar(255) DEFAULT NULL,
  `Type` varchar(50) DEFAULT NULL,
  `Message` longtext,
  `Date` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=237 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_loginhistory`
-- ----------------------------

CREATE TABLE `sys_loginhistory` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserCode` varchar(20) DEFAULT NULL,
  `UserName` varchar(200) DEFAULT NULL,
  `HostName` varchar(200) DEFAULT NULL,
  `HostIP` varchar(50) DEFAULT NULL,
  `LoginCity` varchar(200) DEFAULT NULL,
  `LoginDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1890 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_menu`
-- ----------------------------

CREATE TABLE `sys_menu` (
  `MenuCode` varchar(100) NOT NULL,
  `ParentCode` varchar(100) DEFAULT NULL,
  `MenuName` varchar(200) DEFAULT NULL,
  `URL` varchar(200) DEFAULT NULL,
  `IconClass` varchar(50) DEFAULT NULL,
  `IconURL` varchar(200) DEFAULT NULL,
  `MenuSeq` varchar(10) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `IsVisible` tinyint(1) DEFAULT NULL,
  `IsEnable` tinyint(1) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`MenuCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- ----------------------------
-- Table structure for `sys_menubuttonmap`
-- ----------------------------

CREATE TABLE `sys_menubuttonmap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MenuCode` varchar(100) DEFAULT NULL,
  `ButtonCode` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__sys_menuB__Butto__16CE6296` (`ButtonCode`),
  KEY `FK__sys_menuB__MenuC__17C286CF` (`MenuCode`),
  CONSTRAINT `FK__sys_menuB__Butto__16CE6296` FOREIGN KEY (`ButtonCode`) REFERENCES `sys_button` (`ButtonCode`),
  CONSTRAINT `FK__sys_menuB__MenuC__12FDD1B2` FOREIGN KEY (`MenuCode`) REFERENCES `sys_menu` (`MenuCode`),
  CONSTRAINT `FK__sys_menuB__MenuC__17C286CF` FOREIGN KEY (`MenuCode`) REFERENCES `sys_menu` (`MenuCode`)
) ENGINE=InnoDB AUTO_INCREMENT=480 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_menubuttonmap
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_organize`
-- ----------------------------

CREATE TABLE `sys_organize` (
  `OrganizeCode` varchar(100) NOT NULL,
  `ParentCode` varchar(100) DEFAULT NULL,
  `OrganizeSeq` varchar(10) DEFAULT NULL,
  `OrganizeName` varchar(200) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`OrganizeCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- ----------------------------
-- Table structure for `sys_parameter`
-- ----------------------------

CREATE TABLE `sys_parameter` (
  `ParamCode` varchar(100) NOT NULL,
  `ParamValue` varchar(200) DEFAULT NULL,
  `IsUserEditable` tinyint(1) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ParamCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
-- ----------------------------
-- Table structure for `sys_permission`
-- ----------------------------

CREATE TABLE `sys_permission` (
  `PermissionCode` varchar(100) NOT NULL,
  `PermissionName` varchar(200) DEFAULT NULL,
  `ParentCode` varchar(100) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PermissionCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_role`
-- ----------------------------

CREATE TABLE `sys_role` (
  `RoleCode` varchar(100) NOT NULL,
  `RoleSeq` varchar(10) DEFAULT NULL,
  `RoleName` varchar(200) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`RoleCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_user`
-- ----------------------------

CREATE TABLE `sys_user` (
  `UserCode` varchar(100) NOT NULL,
  `UserSeq` varchar(10) DEFAULT NULL,
  `UserName` varchar(200) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Password` varchar(40) DEFAULT NULL,
  `RoleName` varchar(1000) DEFAULT NULL,
  `OrganizeName` varchar(1000) DEFAULT NULL,
  `ConfigJSON` varchar(4000) DEFAULT NULL,
  `IsEnable` tinyint(1) DEFAULT NULL,
  `LoginCount` int(11) DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `CreatePerson` varchar(20) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `UpdatePerson` varchar(20) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`UserCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_organizerolemap`
-- ----------------------------

CREATE TABLE `sys_organizerolemap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OrganizeCode` varchar(100) NOT NULL,
  `RoleCode` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `R_38` (`OrganizeCode`),
  KEY `R_39` (`RoleCode`),
  CONSTRAINT `R_38` FOREIGN KEY (`OrganizeCode`) REFERENCES `sys_organize` (`OrganizeCode`),
  CONSTRAINT `R_39` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`)
) ENGINE=InnoDB AUTO_INCREMENT=268 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_organizerolemap
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_rolemenubuttonmap`
-- ----------------------------

CREATE TABLE `sys_rolemenubuttonmap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleCode` varchar(100) DEFAULT NULL,
  `MenuCode` varchar(100) DEFAULT NULL,
  `ButtonCode` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__sys_roleM__Butto__27F8EE98` (`ButtonCode`),
  KEY `FK__sys_roleM__MenuC__28ED12D1` (`MenuCode`),
  KEY `FK__sys_roleM__RoleC__29E1370A` (`RoleCode`),
  CONSTRAINT `FK__sys_roleM__Butto__27F8EE98` FOREIGN KEY (`ButtonCode`) REFERENCES `sys_button` (`ButtonCode`),
  CONSTRAINT `FK__sys_roleM__MenuC__28ED12D1` FOREIGN KEY (`MenuCode`) REFERENCES `sys_menu` (`MenuCode`),
  CONSTRAINT `FK__sys_roleM__RoleC__29E1370A` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`)
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_rolemenubuttonmap
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_rolemenucolumnmap`
-- ----------------------------

CREATE TABLE `sys_rolemenucolumnmap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleCode` varchar(100) DEFAULT NULL,
  `MenuCode` varchar(100) DEFAULT NULL,
  `IsReject` tinyint(1) DEFAULT NULL,
  `FieldName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__sys_roleC__MenuC__36470DEF` (`MenuCode`),
  KEY `FK__sys_roleC__RoleC__3552E9B6` (`RoleCode`),
  CONSTRAINT `FK__sys_roleC__MenuC__36470DEF` FOREIGN KEY (`MenuCode`) REFERENCES `sys_menu` (`MenuCode`),
  CONSTRAINT `FK__sys_roleC__RoleC__3552E9B6` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`)
) ENGINE=InnoDB AUTO_INCREMENT=126 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_rolemenucolumnmap
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_rolemenumap`
-- ----------------------------

CREATE TABLE `sys_rolemenumap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleCode` varchar(100) DEFAULT NULL,
  `MenuCode` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__SysRoleFu__Funct__0D7A0286` (`MenuCode`),
  KEY `FK__SysRoleFu__RoleC__0C85DE4D` (`RoleCode`),
  CONSTRAINT `FK__SysRoleFu__Funct__0D7A0286` FOREIGN KEY (`MenuCode`) REFERENCES `sys_menu` (`MenuCode`),
  CONSTRAINT `FK__SysRoleFu__RoleC__0C85DE4D` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`)
) ENGINE=InnoDB AUTO_INCREMENT=7581 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_rolepermissionmap`
-- ----------------------------

CREATE TABLE `sys_rolepermissionmap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleCode` varchar(100) DEFAULT NULL,
  `PermissionCode` varchar(100) DEFAULT NULL,
  `IsDefault` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__sys_roleA__AuthC__2EA5EC27` (`PermissionCode`),
  KEY `FK__sys_roleA__RoleC__2F9A1060` (`RoleCode`),
  CONSTRAINT `FK__sys_roleA__AuthC__2EA5EC27` FOREIGN KEY (`PermissionCode`) REFERENCES `sys_permission` (`PermissionCode`),
  CONSTRAINT `FK__sys_roleA__RoleC__2F9A1060` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`)
) ENGINE=InnoDB AUTO_INCREMENT=131 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_rolepermissionmap
-- ----------------------------
INSERT INTO `sys_rolepermissionmap` VALUES ('130', 'super', '0102', '0');

-- ----------------------------
-- Table structure for `sys_userorganizemap`
-- ----------------------------

CREATE TABLE `sys_userorganizemap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OrganizeCode` varchar(100) DEFAULT NULL,
  `UserCode` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__SysUserOr__Organ__0E6E26BF` (`OrganizeCode`),
  KEY `FK__SysUserOr__UserC__0F624AF8` (`UserCode`),
  CONSTRAINT `FK__SysUserOr__Organ__0E6E26BF` FOREIGN KEY (`OrganizeCode`) REFERENCES `sys_organize` (`OrganizeCode`),
  CONSTRAINT `FK__SysUserOr__UserC__0F624AF8` FOREIGN KEY (`UserCode`) REFERENCES `sys_user` (`UserCode`)
) ENGINE=InnoDB AUTO_INCREMENT=223 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sys_userorganizemap
-- ----------------------------

-- ----------------------------
-- Table structure for `sys_userrolemap`
-- ----------------------------

CREATE TABLE `sys_userrolemap` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserCode` varchar(100) DEFAULT NULL,
  `RoleCode` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__SysUserRo__RoleC__114A936A` (`RoleCode`),
  KEY `FK__SysUserRo__UserC__10566F31` (`UserCode`),
  CONSTRAINT `FK__SysUserRo__RoleC__114A936A` FOREIGN KEY (`RoleCode`) REFERENCES `sys_role` (`RoleCode`),
  CONSTRAINT `FK__SysUserRo__UserC__10566F31` FOREIGN KEY (`UserCode`) REFERENCES `sys_user` (`UserCode`)
) ENGINE=InnoDB AUTO_INCREMENT=300 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `sys_usersetting`
-- ----------------------------

CREATE TABLE `sys_usersetting` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserCode` varchar(100) DEFAULT NULL,
  `SettingCode` varchar(100) DEFAULT NULL,
  `SettingName` varchar(200) DEFAULT NULL,
  `SettingValue` varchar(100) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__sys_userS__UserC__32767D0B` (`UserCode`),
  CONSTRAINT `FK__sys_userS__UserC__32767D0B` FOREIGN KEY (`UserCode`) REFERENCES `sys_user` (`UserCode`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Function structure for `GetChild`
-- ----------------------------

CREATE FUNCTION `GetChild`(type VARCHAR(100),rootId VARCHAR(1000)) RETURNS varchar(2048) CHARSET utf8
BEGIN
  DECLARE sTemp VARCHAR(1000);
  DECLARE sTempChd VARCHAR(1000);

  SET sTemp = '$';
  SET sTempChd = rootId; -- cast(rootId as CHAR);
 
	if (type = 'Sys_Organize') then
		WHILE sTempChd is not null DO
			SET sTemp = concat(sTemp,',',sTempChd);
			SELECT group_concat(OrganizeCode) INTO sTempChd FROM Sys_Organize where FIND_IN_SET(ParentCode,sTempChd)>0;
		END WHILE;
	end if;
 
  RETURN sTemp;
END ";

            return scriptTable;
        }
        #endregion

        #region 获取数据库存初始数据脚本
        public override string GetScriptInsertData()
        {
            var dataScript = @"
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Records of sys_button
-- ----------------------------
INSERT INTO `sys_button` VALUES ('accredit', '授权', '9', '', 'icon-wrench_orange', null, null, '超级管理员', '2013-07-10 16:43:45');
INSERT INTO `sys_button` VALUES ('add', '新增', '1', '', 'icon-add', 'yrh', '2013-11-06 18:19:50', '颜荣华', '2013-11-06 18:19:50');
INSERT INTO `sys_button` VALUES ('audit', '审核', '10', '', 'icon-user-accept', 'yrh', '2013-11-06 18:19:50', '颜荣华', '2013-11-06 18:19:50');
INSERT INTO `sys_button` VALUES ('delete', '删除', '3', 'aa', 'icon-cross', '', null, '刘会胜', '2013-09-23 12:07:42');
INSERT INTO `sys_button` VALUES ('download', '下载', '7', '', 'icon-download', '', null, '', null);
INSERT INTO `sys_button` VALUES ('edit', '编辑', '2', '', 'icon-edit', '', null, '', null);
INSERT INTO `sys_button` VALUES ('export', '导出', '6', 'aaaaaa', 'icon-page_white_go', '', null, '刘会胜', '2013-10-24 10:02:26');
INSERT INTO `sys_button` VALUES ('inport', '导入', '11', '', 'icon-page_white_excel', '', null, '', null);
INSERT INTO `sys_button` VALUES ('print', '打印', '8', '', 'icon-printer', '', null, '', null);
INSERT INTO `sys_button` VALUES ('refresh', '刷新', '5', '', 'icon-arrow_refresh', '', null, '', null);
INSERT INTO `sys_button` VALUES ('save', '保存', '13', '', 'icon-save', '', null, '超级管理员', '2013-07-10 16:42:13');
INSERT INTO `sys_button` VALUES ('search', '查询', '4', '', 'icon-zoom', '', null, '刘会胜', '2013-10-09 15:51:40');

-- ----------------------------
-- Records of sys_codetype
-- ----------------------------
INSERT INTO `sys_codetype` VALUES ('ApprovalStatus', '审批状态', '', '19', '', null, '', null);
INSERT INTO `sys_codetype` VALUES ('BusinessType', '企业性质', '', '04', '', null, 'lhs', '2013-04-28 22:40:14');
INSERT INTO `sys_codetype` VALUES ('ContractType', '合同类型', '', '15', '', null, '', null);
INSERT INTO `sys_codetype` VALUES ('PayKind', '支付方式', '', '12', '', null, '', null);
INSERT INTO `sys_codetype` VALUES ('PayType', '付款方式', '', '18', '', null, '', null);
INSERT INTO `sys_codetype` VALUES ('Pricing', '计价方式', '', '20', '', null, '', null);
INSERT INTO `sys_codetype` VALUES ('QualificationLevel', '资质等级', '', '05', '', null, 'lhs', '2013-04-28 22:40:14');
INSERT INTO `sys_codetype` VALUES ('Sex', '性别', '', '', '', null, 'lhs', '2013-04-28 15:50:12');
INSERT INTO `sys_codetype` VALUES ('StockState', '库存状态', '', '', '', null, '', null);

-- ----------------------------
-- Records of sys_code
-- ----------------------------
INSERT INTO `sys_code` VALUES ('015', ' Public', '国有', '0', '1', '1', '0', null, '企业性质', 'BusinessType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('016', 'Private', '民营', '0', '2', '1', '0', null, '企业性质', 'BusinessType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('017', 'Personal', '私人', '0', '3', '1', '0', null, '企业性质', 'BusinessType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('018', 'Special', '特级', '0', '1', '1', '1', '12', '资质等级', 'QualificationLevel', null, null, 'lhs', '2013-05-15 11:26:25');
INSERT INTO `sys_code` VALUES ('019', 'One', '一级', '0', '2', '1', '0', null, '资质等级', 'QualificationLevel', null, null, null, null);
INSERT INTO `sys_code` VALUES ('020', 'Two', '二级', '0', '3', '1', '0', null, '资质等级', 'QualificationLevel', null, null, null, null);
INSERT INTO `sys_code` VALUES ('021', 'UnderThree', '三级及以下', '0', '4', '1', '0', null, '资质等级', 'QualificationLevel', null, null, null, null);
INSERT INTO `sys_code` VALUES ('039', 'CashCheck', '现金支票', '0', '1', '1', '0', null, '支付方式', 'PayKind', null, null, null, null);
INSERT INTO `sys_code` VALUES ('040', 'TransferCheck', '转帐支票', '0', '2', '1', '0', null, '支付方式', 'PayKind', null, null, null, null);
INSERT INTO `sys_code` VALUES ('041', 'Bill', '汇票', '0', '3', '1', '0', null, '支付方式', 'PayKind', null, null, null, null);
INSERT INTO `sys_code` VALUES ('074', 'Stock', '采购', '0', '1', '1', '0', null, '合同类型', 'ContractType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('075', 'Rent', '租赁', '0', '2', '1', '0', null, '合同类型', 'ContractType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('076', 'Other', '其他', '0', '3', '1', '0', null, '合同类型', 'ContractType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('085', 'DirectDebit', '直接付款', '0', '1', '1', '1', null, '付款方式', 'PayType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('086', 'LateDebit', '后期结算', '0', '2', '1', '0', null, '付款方式', 'PayType', null, null, null, null);
INSERT INTO `sys_code` VALUES ('087', 'Unapproved', '未审批', '0', '1', '1', '0', null, '审批状态', 'ApprovalStatus', null, null, null, null);
INSERT INTO `sys_code` VALUES ('088', 'ApprovalIn', '审批中', '0', '2', '1', '0', null, '审批状态', 'ApprovalStatus', null, null, 'lhs', '2013-01-08 16:52:25');
INSERT INTO `sys_code` VALUES ('089', 'ApprovalPass', '审批通过', '0', '3', '1', '0', null, '审批状态', 'ApprovalStatus', null, null, 'lhs', '2013-01-08 16:47:23');
INSERT INTO `sys_code` VALUES ('090', 'ApprovalUnPass', '审批未通过', '0', '4', '1', '0', null, '审批状态', 'ApprovalStatus', null, null, null, null);
INSERT INTO `sys_code` VALUES ('091', 'Batch', '批次', '0', '1', '1', '1', '', '计价方式', 'Pricing', null, null, '刘会胜', '2013-05-24 15:33:18');
INSERT INTO `sys_code` VALUES ('092', 'FIFO', '先进先出', '0', '2', '1', '0', '', '计价方式', 'Pricing', null, null, '刘会胜', '2013-05-24 15:33:18');
INSERT INTO `sys_code` VALUES ('098', '0', '安全库存', '0', '0', '1', '0', '1', '库存状态', 'StockState', null, null, 'LHS', '2013-11-13 20:59:36');
INSERT INTO `sys_code` VALUES ('099', '1', '库存即将不足', '0', '1', '1', '0', null, '库存状态', 'StockState', null, null, null, null);
INSERT INTO `sys_code` VALUES ('100', '2', '库存不足', '0', '2', '1', '0', null, '库存状态', 'StockState', null, null, null, null);
INSERT INTO `sys_code` VALUES ('101', 'man', '男', '', '', '0', '0', '', null, 'Sex', '管理员', '2013-11-18 10:18:01', '管理员', '2013-11-18 10:18:01');
INSERT INTO `sys_code` VALUES ('102', 'woman', '女', '', '', '0', '0', '', null, 'Sex', '管理员', '2013-11-18 10:18:01', '管理员', '2013-11-18 10:18:01');
INSERT INTO `sys_code` VALUES ('103', 'unknown', '春哥', '', '', '0', '0', '', null, 'Sex', '管理员', '2013-11-18 10:18:01', '管理员', '2013-11-18 10:18:01');

-- ----------------------------
-- Records of sys_log
-- ----------------------------
INSERT INTO `sys_log` VALUES ('1', 'lhs', '刘会胜', 'sys/log', '日志表', '插入', '数据1', '2012-10-10 00:00:00');
INSERT INTO `sys_log` VALUES ('3', 'lhs', '刘会胜', 'api/mms/send', '菜单数据', '修改', '{\""list\"":{\""deleted\"":[],\""inserted\"":[],\""updated\"":[{\""_id\"":\""0301\"",\""MenuName\"":\""材料收料单\"",\""MenuCode\"":\""0301\"",\""ParentCode\"":\""03\"",\""IconClass\"":\""icon-house_in\"",\""URL\"":\""/mms/receive\"",\""IsVisible\"":\""true\"",\""IsEnable\"":\""true\"",\""MenuSeq\"":\""\""}],\""_changed\"":true}}', '2013-05-01 15:05:15');

-- ----------------------------
-- Records of sys_loginhistory
-- ----------------------------
INSERT INTO `sys_loginhistory` VALUES ('866', 'guest', '访客', '', '222.71.179.22', '上海市', '2013-07-08 22:22:42');
INSERT INTO `sys_loginhistory` VALUES ('867', 'guest', '访客', '', '222.71.179.22', '上海市', '2013-07-08 22:32:44');
INSERT INTO `sys_loginhistory` VALUES ('868', 'guest', '访客', '', '171.217.235.105', '四川省成都市', '2013-07-08 22:41:23');
INSERT INTO `sys_loginhistory` VALUES ('869', 'guest', '访客', '', '219.134.248.98', '广东省深圳市', '2013-07-09 00:15:13');
INSERT INTO `sys_loginhistory` VALUES ('870', 'super', '超级管理员', '', '58.23.19.115', '福建省厦门市', '2013-07-09 08:10:13');
INSERT INTO `sys_loginhistory` VALUES ('871', 'guest', '访客', '', '117.88.225.95', '江苏省南京市', '2013-07-09 08:25:55');
INSERT INTO `sys_loginhistory` VALUES ('872', 'guest', '访客', '', '1.85.44.34', '陕西省西安市', '2013-07-09 08:44:07');
INSERT INTO `sys_loginhistory` VALUES ('873', 'guest', '访客', '', '218.79.202.133', '上海市', '2013-07-09 09:12:59');
INSERT INTO `sys_loginhistory` VALUES ('874', 'guest', '访客', '', '218.79.202.133', '上海市', '2013-07-09 09:14:09');
INSERT INTO `sys_loginhistory` VALUES ('875', 'guest', '访客', '', '61.139.124.91', '四川省成都市', '2013-07-09 09:44:56');
INSERT INTO `sys_loginhistory` VALUES ('1870', 'lhs', '', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-04 16:50:27');
INSERT INTO `sys_loginhistory` VALUES ('1871', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 00:13:48');
INSERT INTO `sys_loginhistory` VALUES ('1872', 'LHS', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 00:24:34');
INSERT INTO `sys_loginhistory` VALUES ('1873', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 09:20:19');
INSERT INTO `sys_loginhistory` VALUES ('1874', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 10:06:21');
INSERT INTO `sys_loginhistory` VALUES ('1875', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 10:16:26');
INSERT INTO `sys_loginhistory` VALUES ('1876', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 17:36:41');
INSERT INTO `sys_loginhistory` VALUES ('1877', 'yrh', '颜荣华', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 18:03:34');
INSERT INTO `sys_loginhistory` VALUES ('1878', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 18:05:53');
INSERT INTO `sys_loginhistory` VALUES ('1879', 'yrh', '颜荣华', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-06 18:06:19');
INSERT INTO `sys_loginhistory` VALUES ('1880', 'lhs', null, 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-07 09:23:00');
INSERT INTO `sys_loginhistory` VALUES ('1881', 'yrh', '颜荣华', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-07 09:27:40');
INSERT INTO `sys_loginhistory` VALUES ('1882', 'lhs', '刘会胜', 'LHS-PC', 'localhost', null, '2013-11-11 10:47:25');
INSERT INTO `sys_loginhistory` VALUES ('1883', 'yrh', '颜荣华', 'LHS-PC', 'localhost', null, '2013-11-11 10:48:50');
INSERT INTO `sys_loginhistory` VALUES ('1884', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-11 17:54:20');
INSERT INTO `sys_loginhistory` VALUES ('1885', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-11 17:59:18');
INSERT INTO `sys_loginhistory` VALUES ('1886', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-11 18:06:40');
INSERT INTO `sys_loginhistory` VALUES ('1887', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-13 21:05:51');
INSERT INTO `sys_loginhistory` VALUES ('1888', 'lhs', '刘会胜', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-18 09:57:57');
INSERT INTO `sys_loginhistory` VALUES ('1889', 'admin', '管理员', 'LHS-PC', 'localhost', '福建省厦门市', '2013-11-18 10:14:56');

-- ----------------------------
-- Records of sys_menu
-- ----------------------------
INSERT INTO `sys_menu` VALUES ('98', '0', '开发平台', '#', 'icon-image', '/common/css/icon/icon/application_osx_home.png', '60', null, '1', '1', null, null, '刘会胜', '2013-08-31 13:46:47');
INSERT INTO `sys_menu` VALUES ('9810', '98', '代码生成', '/sys/generator', 'icon-page_code', null, '', null, '1', '1', '刘会胜', '2013-08-31 14:02:54', '刘会胜', '2013-08-31 14:02:54');
INSERT INTO `sys_menu` VALUES ('99', '0', '系统设置', '#', 'icon-sysset', null, '50', null, '1', '1', null, null, 'lhs', '2013-05-17 11:06:13');
INSERT INTO `sys_menu` VALUES ('9902', '99', '菜单导航', '/sys/menu', 'icon-chart_organisation', '/common/css/icon/icon/chart_organisation.png', '210', null, '1', '1', null, null, '访客', '2013-07-02 09:36:35');
INSERT INTO `sys_menu` VALUES ('9903', '99', '组织结构', '/sys/organize', 'icon-org', null, '220', null, '1', '1', null, null, 'lhs', '2013-04-27 16:56:03');
INSERT INTO `sys_menu` VALUES ('9904', '99', '角色管理', '/sys/role', 'icon-group', null, '240', null, '1', '1', null, null, '访客', '2013-06-25 13:19:58');
INSERT INTO `sys_menu` VALUES ('9905', '99', '用户管理', '/sys/user', 'icon-users', null, '245', null, '1', '1', null, null, '刘会胜', '2013-07-14 17:21:41');
INSERT INTO `sys_menu` VALUES ('9906', '99', '数据字典', '/sys/code', 'icon-book', null, '250', null, '1', '1', null, null, '访客', '2013-07-02 09:36:35');
INSERT INTO `sys_menu` VALUES ('9907', '99', '操作日志', '/sys/log', 'icon-error', null, '260', null, '1', '1', null, null, 'lhs', '2013-04-29 11:02:32');
INSERT INTO `sys_menu` VALUES ('9909', '99', '个性设置', '/sys/config', 'icon-wrench_orange', null, '270', null, '1', '0', null, null, '刘会胜', '2013-07-14 17:21:13');
INSERT INTO `sys_menu` VALUES ('9910', '99', '授权代码', '/sys/permission', 'icon-lock_key', null, '230', null, '1', '1', '刘会胜', '2013-07-14 17:21:13', '刘会胜', '2013-07-19 17:11:57');
INSERT INTO `sys_menu` VALUES ('9911', '99', '系统参数', '/sys/parameter', 'icon-page_white_wrench', null, '255', null, '1', '1', '刘会胜', '2013-07-15 11:58:00', '刘会胜', '2013-07-19 17:11:57');

-- ----------------------------
-- Records of sys_organize
-- ----------------------------
INSERT INTO `sys_organize` VALUES ('04', '0', null, '厦门市电力服务公司', '', 'super', '2013-05-17 18:04:40', '访客', '2013-07-23 22:59:07');
INSERT INTO `sys_organize` VALUES ('0403', '04', '', '市场营销中心', '123', 'super', '2013-05-17 18:09:02', '超级管理员', '2013-07-11 22:34:42');
INSERT INTO `sys_organize` VALUES ('0404', '04', '', '预结算中心', '', 'super', '2013-05-17 18:09:57', '访客', '2013-07-23 10:16:45');
INSERT INTO `sys_organize` VALUES ('0406', '04', '', '厦门市电力工程有限责任公司', 'ad ', 'super', '2013-05-17 18:12:47', '访客', '2013-07-23 13:58:38');
INSERT INTO `sys_organize` VALUES ('040601', '0406', '', '办公室', '12', 'super', '2013-05-17 18:12:59', '超级管理员', '2013-07-11 22:34:47');
INSERT INTO `sys_organize` VALUES ('040602', '0406', '', '项目管理中心', '', 'super', '2013-05-17 18:13:10', '访客', '2013-07-23 10:18:53');
INSERT INTO `sys_organize` VALUES ('040603', '0406', '', '质安部', '', 'super', '2013-05-17 18:13:15', 'super', '2013-05-17 18:13:15');
INSERT INTO `sys_organize` VALUES ('040604', '0406', '', '输变电项目部', '', 'super', '2013-05-17 18:13:22', '访客', '2013-07-22 13:23:38');
INSERT INTO `sys_organize` VALUES ('040605', '0406', '', '生产技术部', '', 'super', '2013-05-17 18:13:27', 'super', '2013-05-17 18:13:27');
INSERT INTO `sys_organize` VALUES ('0407', '04', '', '厦门市电力器材有限责任公司', '', 'super', '2013-05-17 18:13:37', 'super', '2013-05-17 18:14:27');
INSERT INTO `sys_organize` VALUES ('040701', '0407', '', '生产车间', '', 'super', '2013-05-17 18:13:47', 'super', '2013-05-17 18:13:47');
INSERT INTO `sys_organize` VALUES ('0408', '04', '', '厦门市成功电力勘察设计有限公司', '', 'super', '2013-05-17 18:15:00', 'super', '2013-05-17 18:15:00');
INSERT INTO `sys_organize` VALUES ('040801', '0408', '', '系统与技经组', '', 'super', '2013-05-17 18:15:12', 'super', '2013-05-17 18:15:12');
INSERT INTO `sys_organize` VALUES ('040802', '0408', '', '配网设计组', '', 'super', '2013-05-17 18:15:19', '访客', '2013-07-22 21:56:16');
INSERT INTO `sys_organize` VALUES ('040803', '0408', '', '配电设计组', '', 'super', '2013-05-17 18:15:25', 'super', '2013-05-17 18:15:25');
INSERT INTO `sys_organize` VALUES ('040804', '0408', '', '变电设计组', '', 'super', '2013-05-17 18:15:33', 'super', '2013-05-17 18:15:33');
INSERT INTO `sys_organize` VALUES ('040805', '0408', '', '送电设计组', '', 'super', '2013-05-17 18:15:40', 'super', '2013-05-17 18:15:40');
INSERT INTO `sys_organize` VALUES ('0409', '04', '', '厦门市电力服务公司物资分公司', '', 'super', '2013-05-17 18:15:58', 'super', '2013-05-17 18:15:58');
INSERT INTO `sys_organize` VALUES ('040901', '0409', '', '采购部', '', 'super', '2013-05-17 18:16:16', 'super', '2013-05-17 18:16:16');
INSERT INTO `sys_organize` VALUES ('040902', '0409', '', '仓储部', '', 'super', '2013-05-17 18:16:23', 'super', '2013-05-17 18:16:23');
INSERT INTO `sys_organize` VALUES ('040903', '0409', '', '经营部', '', 'super', '2013-05-17 18:16:29', 'super', '2013-05-17 18:16:29');
INSERT INTO `sys_organize` VALUES ('0410', '04', '', '南安市水泥制品厂', '', 'super', '2013-05-17 18:16:41', 'super', '2013-05-17 18:16:41');
INSERT INTO `sys_organize` VALUES ('041001', '0410', '', '生产车间', '', 'super', '2013-05-17 18:16:49', 'super', '2013-05-17 18:16:49');
 
-- ----------------------------
-- Records of sys_parameter
-- ----------------------------
INSERT INTO `sys_parameter` VALUES ('SYS_COPYRIGHT', 'Copyright&copy;2013 Zephyr, All Rights Reserved', '0', '版权信息', '刘会胜', '2013-07-15 15:21:19', '刘会胜', '2013-07-15 15:25:34');
INSERT INTO `sys_parameter` VALUES ('SYS_NAME', '业务管理系统', '1', '系统名称', null, null, '管理员', '2013-11-18 15:32:40');
INSERT INTO `sys_parameter` VALUES ('SYS_NAME_EN', 'Business Mangange System', '1', '系统英文名称', null, null, '管理员', '2013-11-18 15:36:08');

-- ----------------------------
-- Records of sys_permission
-- ----------------------------
INSERT INTO `sys_permission` VALUES ('01', '同城四季', '0', '', null, '刘会胜', '2013-09-07 01:00:51');
INSERT INTO `sys_permission` VALUES ('0101', '同城四季一期', '0101', '', null, '访客', '2013-07-24 13:46:19');
INSERT INTO `sys_permission` VALUES ('0102', '同城四季二期', '01', '', null, '', null);
INSERT INTO `sys_permission` VALUES ('02', '云顶至尊', '0', '', null, '访客', '2013-07-22 18:36:29');
INSERT INTO `sys_permission` VALUES ('0201', '云顶至尊一期', '02', '', null, '', null);
INSERT INTO `sys_permission` VALUES ('030', '新增测试', '0', '刘会胜', '2013-09-07 01:00:35', '刘会胜', '2013-09-07 13:56:18');


-- ----------------------------
-- Records of sys_role
-- ----------------------------
INSERT INTO `sys_role` VALUES ('admin', '20', '管理员', '', '刘会胜', '2013-11-18 10:12:06', '刘会胜', '2013-11-18 10:12:06');
INSERT INTO `sys_role` VALUES ('R1', '30', '业务员角色', '', '刘会胜', '2013-11-18 10:12:06', '刘会胜', '2013-11-18 10:12:06');
INSERT INTO `sys_role` VALUES ('R2', '40', '经理角色', '', '刘会胜', '2013-11-18 10:12:30', '刘会胜', '2013-11-18 10:12:30');
INSERT INTO `sys_role` VALUES ('super', '10', '超级管理员', '超级管理员', 'lhs', '2013-05-17 11:25:50', '', '2013-07-19 21:19:49');


-- ----------------------------
-- Records of sys_user
-- ----------------------------
INSERT INTO `sys_user` VALUES ('admin', '', '管理员', '', '81dc9bdb52d04dc20036dbd8313ed055', '', '', '', null, '1', '7', '2013-11-18 10:14:56', '刘会胜', '2013-10-09 16:33:47', '刘会胜', '2013-10-09 16:33:47');
INSERT INTO `sys_user` VALUES ('super', '1', '超级管理员', '', '81dc9bdb52d04dc20036dbd8313ed055', '', '', '{\""theme\"":\""default\"",\""navType\"":\""accordion\"",\""gridRows\"":\""20\""}', null, '1', '55', '2013-08-02 18:28:10', '', null, '', null);


-- ----------------------------
-- Records of sys_rolemenumap
-- ----------------------------
INSERT INTO `sys_rolemenumap` VALUES ('7567', 'super', '99');
INSERT INTO `sys_rolemenumap` VALUES ('7568', 'super', '9902');
INSERT INTO `sys_rolemenumap` VALUES ('7569', 'super', '9903');
INSERT INTO `sys_rolemenumap` VALUES ('7570', 'super', '9910');
INSERT INTO `sys_rolemenumap` VALUES ('7571', 'super', '9904');
INSERT INTO `sys_rolemenumap` VALUES ('7572', 'super', '9905');
INSERT INTO `sys_rolemenumap` VALUES ('7573', 'super', '9906');
INSERT INTO `sys_rolemenumap` VALUES ('7574', 'super', '9911');
INSERT INTO `sys_rolemenumap` VALUES ('7575', 'super', '9907');
INSERT INTO `sys_rolemenumap` VALUES ('7576', 'super', '98');
INSERT INTO `sys_rolemenumap` VALUES ('7577', 'super', '9810');


-- ----------------------------
-- Records of sys_userrolemap
-- ----------------------------
INSERT INTO `sys_userrolemap` VALUES ('274', 'super', 'super');
INSERT INTO `sys_userrolemap` VALUES ('299', 'admin', 'super');


-- ----------------------------
-- Records of sys_usersetting
-- ----------------------------
INSERT INTO `sys_usersetting` VALUES ('17', 'super', 'theme', null, 'gray', null);
INSERT INTO `sys_usersetting` VALUES ('18', 'super', 'navigation', null, 'accordion', null);
INSERT INTO `sys_usersetting` VALUES ('19', 'super', 'gridrows', null, '20', null);
";
            return dataScript;
        }
        #endregion
    }
}