--DBMS name:MS SQL2008 R2
--DBname:DbDemandUpV2
--Created on:     2017/03/25 13:46:32 
--username:ZXC
--password:123456

--*******************单位代码表*************--
create table unitNumber(
unitID varchar(255) not null,--单位组织代码
unitName varchar(255) not null,--单位名称吧
primary key(unitID)
)
--*******************登录用户表*************--
create table UserTable(
userID nvarchar(30) not null,--工号&登录账号
userTypeName nvarchar(30) not null,--用户类型(注册用户 部门审核员 形式审核员 超级管理)
unitID nvarchar(50) not null,--单位编号
userPwd nvarchar(30) not null,--登录密码
userName nvarchar(30) not null,--员工姓名
perID nvarchar(30) not null,--身份证号码
primary key(userID),
foreign key(userTypeName) references UserType(userTypeName),
foreign key(unitID) references unitNumber(unitID),
)
insert into UserTable values ('123','123456','孟泽','130724','管理员');
insert into UserTable (userID,userName,userPwd) values ('12378','孟泽','4578')
select * from UserTable;
update UserTable set userName='李洋',userPwd='2' where userID='221';

delete from UserTable where userName='张晓晨';
drop table UserTable;
select * from xueke where Code like '__00000'

--******************用户角色表*************************--
--drop table UserType;
create table UserType(
userTypeName nvarchar(30) not null,--用户类型(注册用户 管理员 超级管理)
primary key(userTypeName),
)
insert into UserType values ('注册用户');
insert into UserType values ('形式审核员');
insert into UserType values ('部门审核员');
insert into UserType values ('超级管理员');
select * from UserType;

--*******************单位表*************--
--drop table unitTable;
create table unitTable(--除主键外全可空
userID nvarchar(30) not null,--登录账号
unitID nvarchar(50) not null,--单位组织机构代码
unitDepartment nvarchar(50),--归口管理部门（可空）
unitAddress nvarchar(100) not null,--单位地址
unitCity nvarchar(50) not null,--所在地域
unitURL nvarchar(50),--网址(可空)
unitEmail nvarchar(50) not null,--电子信箱
unitLPeople nvarchar(50) not null,--法人代表
unitZipCode nvarchar(50),--邮政编码(可空)
unitContactPeople nvarchar(50) not null,--联系人
unitPhone nvarchar(50),--联系电话(可空)
unitMPhone nvarchar(50) not null,--联系手机
unitFax nvarchar(50),--传真号码(可空)
unitAttribute nvarchar(50) not null,--机构属性
unitIntroduce nvarchar(500) not null,--单位简介
primary key(unitID),
foreign key(unitID) references unitNumber(unitID),
foreign key(userID) references userTable(userID),
);
insert into unitTable values (
'K12345',
'1245',
'河北省中华田园有限公司',
'',
'北二环东路158号',
'石家庄',
'www.123.com',
'12345678@huyaya.com',
'张全蛋',
'123456',
'张全蛋',
'03111324568',
'123456789877',
'123456789',
'农业',
'呵呵哈哈哈'
)
delete from unit where unitID='LD20124578'
select * from unit 

select * from Xueke where Code like '__00000'

--*******************基础研究技术需求信息表 *************--

drop table demand;
create table demand(
demandID nvarchar(30) not null,--需求编号
unitID nvarchar(50) not null,--单位组织机构代码
unitAttribute nvarchar(50) not null,--机构属性
unitIntroduce nvarchar(500) not null,--单位简介
demandName nvarchar(30) not null,--需求名称
demandStart int not null,--需求起始年限
demandEnd int not null,--需求终止年限
demandMain nvarchar(500) not null,--需求概述主要问题
demandKey nvarchar(500) not null,--需求概述技术关键
demandTarget nvarchar(500) not null,--需求概述预期目标
demandKeyWord1 nvarchar(30) not null,--关键词01
demandKeyWord2 nvarchar(30),--关键词02(可空)
demandKeyWord3 nvarchar(30),--关键词03(可空)
demandKeyWord4 nvarchar(30),--关键词04(可空)
demandKeyWord5 nvarchar(30),--关键词05(可空)
demandLoan nvarchar(30),--需求投资总额(万元)(可空)
demandResearchMode nvarchar(50) not null,--技术需求解决方式
demandCooperationUnit nvarchar(50),--意向合作单位(可空)
demandTechnology nvarchar(50) not null,--科技活动类型
demandClass3 nvarchar(50),--学科分类三级(---基础研究----)
demandDomain nvarchar(50),--技术所属领域(---非基础研究----)
demandEconomicClass3 nvarchar(50),--技术应用行业三级(国民经济分类)(---非基础研究----)
unitstaffID1 nvarchar(30),--形式审核人员(可空)
unitstaffID2 nvarchar(30),--业务审核人员(可空)
demandState nvarchar(30) not null,--审核状态(未审核,未通过,形式审核通过,部门审核通过)
Auditopinion nvarchar(500),--审核意见
Auditdepartment nvarchar(50),--审核部门
primary key(demandID),
foreign key(unitID) references unitTable(unitID),
)
select * from Requirement where unitID='250'and (demandState1='保存' or demandState2='未审核');

select * from Requirement
select * from Requirement where unitID='250' and demandID='2016122900001';
delete from Requirement

insert into Requirement values (
'20161206001',
'LD20124578',
'河北省中华田园有限公司',
'',
'北二环东路158号',
'石家庄',
'www.123.com',
'12345678@huyaya.com',
'张全蛋',
'123456',
'张全蛋',
'03111324568',
'123456789877',
'123456789',
'农业',
'呵呵哈哈哈',
'大气治理',
'2015',
'2018',
'治理大气污染',
'PM2.5的成因',
'实现空气质量为良至少每年300天',
'大气污染',
'',
'',
'',
'',
'500万',
'独立研究',
'',
'基础研究',
'大气环境',
'',
'',
'齐大胜',
'提交',
'未审核'
)
--*********************学科分类表************************--
--drop table Xueke;
create table Xueke(
xuekeID nvarchar(30) not null,--id
Code nvarchar(30) not null,--代码
Title nvarchar(30) not null,--名称
primary key(xuekeID),
)
select * from Xueke
select * from Xueke where Code like '__00000'
delete from Xueke where Code='Code'

--*********************国民经济分类表************************--
--drop table Guomin
create table Guomin(
guominID nvarchar(30) not null,--id
Code nvarchar(30) not null,--代码
Title nvarchar(30) not null,--名称
primary key(guominID),
)
select * from Guomin
delete from Guomin where Code='Code'
select * from Guomin
select * from Xueke where Code like '__00000'