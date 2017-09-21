--DBMS name:MS SQL2008 R2
--DBname:DbDemandUpV2
--Created on:     2017/03/25 13:46:32 
--username:ZXC
--password:123456

--*******************��λ�����*************--
create table unitNumber(
unitID varchar(255) not null,--��λ��֯����
unitName varchar(255) not null,--��λ���ư�
primary key(unitID)
)
--*******************��¼�û���*************--
create table UserTable(
userID nvarchar(30) not null,--����&��¼�˺�
userTypeName nvarchar(30) not null,--�û�����(ע���û� �������Ա ��ʽ���Ա ��������)
unitID nvarchar(50) not null,--��λ���
userPwd nvarchar(30) not null,--��¼����
userName nvarchar(30) not null,--Ա������
perID nvarchar(30) not null,--���֤����
primary key(userID),
foreign key(userTypeName) references UserType(userTypeName),
foreign key(unitID) references unitNumber(unitID),
)
insert into UserTable values ('123','123456','����','130724','����Ա');
insert into UserTable (userID,userName,userPwd) values ('12378','����','4578')
select * from UserTable;
update UserTable set userName='����',userPwd='2' where userID='221';

delete from UserTable where userName='������';
drop table UserTable;
select * from xueke where Code like '__00000'

--******************�û���ɫ��*************************--
--drop table UserType;
create table UserType(
userTypeName nvarchar(30) not null,--�û�����(ע���û� ����Ա ��������)
primary key(userTypeName),
)
insert into UserType values ('ע���û�');
insert into UserType values ('��ʽ���Ա');
insert into UserType values ('�������Ա');
insert into UserType values ('��������Ա');
select * from UserType;

--*******************��λ��*************--
--drop table unitTable;
create table unitTable(--��������ȫ�ɿ�
userID nvarchar(30) not null,--��¼�˺�
unitID nvarchar(50) not null,--��λ��֯��������
unitDepartment nvarchar(50),--��ڹ����ţ��ɿգ�
unitAddress nvarchar(100) not null,--��λ��ַ
unitCity nvarchar(50) not null,--���ڵ���
unitURL nvarchar(50),--��ַ(�ɿ�)
unitEmail nvarchar(50) not null,--��������
unitLPeople nvarchar(50) not null,--���˴���
unitZipCode nvarchar(50),--��������(�ɿ�)
unitContactPeople nvarchar(50) not null,--��ϵ��
unitPhone nvarchar(50),--��ϵ�绰(�ɿ�)
unitMPhone nvarchar(50) not null,--��ϵ�ֻ�
unitFax nvarchar(50),--�������(�ɿ�)
unitAttribute nvarchar(50) not null,--��������
unitIntroduce nvarchar(500) not null,--��λ���
primary key(unitID),
foreign key(unitID) references unitNumber(unitID),
foreign key(userID) references userTable(userID),
);
insert into unitTable values (
'K12345',
'1245',
'�ӱ�ʡ�л���԰���޹�˾',
'',
'��������·158��',
'ʯ��ׯ',
'www.123.com',
'12345678@huyaya.com',
'��ȫ��',
'123456',
'��ȫ��',
'03111324568',
'123456789877',
'123456789',
'ũҵ',
'�Ǻǹ�����'
)
delete from unit where unitID='LD20124578'
select * from unit 

select * from Xueke where Code like '__00000'

--*******************�����о�����������Ϣ�� *************--

drop table demand;
create table demand(
demandID nvarchar(30) not null,--������
unitID nvarchar(50) not null,--��λ��֯��������
unitAttribute nvarchar(50) not null,--��������
unitIntroduce nvarchar(500) not null,--��λ���
demandName nvarchar(30) not null,--��������
demandStart int not null,--������ʼ����
demandEnd int not null,--������ֹ����
demandMain nvarchar(500) not null,--���������Ҫ����
demandKey nvarchar(500) not null,--������������ؼ�
demandTarget nvarchar(500) not null,--�������Ԥ��Ŀ��
demandKeyWord1 nvarchar(30) not null,--�ؼ���01
demandKeyWord2 nvarchar(30),--�ؼ���02(�ɿ�)
demandKeyWord3 nvarchar(30),--�ؼ���03(�ɿ�)
demandKeyWord4 nvarchar(30),--�ؼ���04(�ɿ�)
demandKeyWord5 nvarchar(30),--�ؼ���05(�ɿ�)
demandLoan nvarchar(30),--����Ͷ���ܶ�(��Ԫ)(�ɿ�)
demandResearchMode nvarchar(50) not null,--������������ʽ
demandCooperationUnit nvarchar(50),--���������λ(�ɿ�)
demandTechnology nvarchar(50) not null,--�Ƽ������
demandClass3 nvarchar(50),--ѧ�Ʒ�������(---�����о�----)
demandDomain nvarchar(50),--������������(---�ǻ����о�----)
demandEconomicClass3 nvarchar(50),--����Ӧ����ҵ����(���񾭼÷���)(---�ǻ����о�----)
unitstaffID1 nvarchar(30),--��ʽ�����Ա(�ɿ�)
unitstaffID2 nvarchar(30),--ҵ�������Ա(�ɿ�)
demandState nvarchar(30) not null,--���״̬(δ���,δͨ��,��ʽ���ͨ��,�������ͨ��)
Auditopinion nvarchar(500),--������
Auditdepartment nvarchar(50),--��˲���
primary key(demandID),
foreign key(unitID) references unitTable(unitID),
)
select * from Requirement where unitID='250'and (demandState1='����' or demandState2='δ���');

select * from Requirement
select * from Requirement where unitID='250' and demandID='2016122900001';
delete from Requirement

insert into Requirement values (
'20161206001',
'LD20124578',
'�ӱ�ʡ�л���԰���޹�˾',
'',
'��������·158��',
'ʯ��ׯ',
'www.123.com',
'12345678@huyaya.com',
'��ȫ��',
'123456',
'��ȫ��',
'03111324568',
'123456789877',
'123456789',
'ũҵ',
'�Ǻǹ�����',
'��������',
'2015',
'2018',
'���������Ⱦ',
'PM2.5�ĳ���',
'ʵ�ֿ�������Ϊ������ÿ��300��',
'������Ⱦ',
'',
'',
'',
'',
'500��',
'�����о�',
'',
'�����о�',
'��������',
'',
'',
'���ʤ',
'�ύ',
'δ���'
)
--*********************ѧ�Ʒ����************************--
--drop table Xueke;
create table Xueke(
xuekeID nvarchar(30) not null,--id
Code nvarchar(30) not null,--����
Title nvarchar(30) not null,--����
primary key(xuekeID),
)
select * from Xueke
select * from Xueke where Code like '__00000'
delete from Xueke where Code='Code'

--*********************���񾭼÷����************************--
--drop table Guomin
create table Guomin(
guominID nvarchar(30) not null,--id
Code nvarchar(30) not null,--����
Title nvarchar(30) not null,--����
primary key(guominID),
)
select * from Guomin
delete from Guomin where Code='Code'
select * from Guomin
select * from Xueke where Code like '__00000'