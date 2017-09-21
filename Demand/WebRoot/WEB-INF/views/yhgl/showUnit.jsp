<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>

<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>

<title>My JSP 'unitInf.jsp' starting page</title>

<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="expires" content="0">
<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
<meta http-equiv="description" content="This is my page">
<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
<script type="text/javascript">
	function back() {
		var url = "UsersManage-userList";
		window.location.href = url;
	}
</script>
<style type="text/css">
.zishu
{
	font-size:20px;
	color:#F00;
}
.full{
width:98%;
height:100%;
font-size:20px;
}
.nfull{
width:50%;
height:100%;
font-size:20px;
}
option.afull{
width:100%;
height:100%;
font-size:20px;
}
table {
	border-collapse: collapse;
	border: none;
	margin: 0px auto;
	width: 1300px;
	font-size:20px;
}

span{
color:#ff0000;
font-size:20px;
}

th, td {
	border: solid #333 1px;
	height: 25px;
	font-size:20px;
}

div {
	text-align: center;
}
	* {margin:0px; padding:0px;}
	em{
		color:#3F0;
		}
body { font-family:Verdana; font-size:20px; margin:0;}
#container {margin:0 auto; width:910px;}
#header { height:206px; background:#6cf; margin-bottom:5px;}
#menu { height:20px; background:lightgray; margin-bottom:5px;}
#mainContent { height:500px; margin-bottom:5px;}
#content { margin:0 245px !important; margin:0 245px; height:500px;background-image:url(images/1.jpg);}
#footer { height:40px; background:lightgray;}
.textBox{
	width:100%;
	height:150px;
	font-size:20px;
}
.bt
{
	width:100px;height:30px;color:#000;font-size:20px;
}
</style>
</head>
<body bgcolor="#FFFFFF">
	<center>
		<h4>单位信息</h4>
		<table>
			<tr>
				<td>单位组织代码：</td>
				<td colspan="4"><s:property value="unitId" /></td>
			</tr>
			<tr>
				<td>机构全称</td>
				<td><s:property value="unitNumber.unitName" /></td>
				<td>
				归口管理部门
				</td>
				<td colspan="2"><s:property value="unitDepartment" /></td>
			</tr>
			<tr>
				<td><span class="xing">*</span>通讯地址</td>
				<td><s:property value="unitAddress" /></td>
				<td><span class="xing">*</span>所在地域</td>
				<td colspan="2"><s:property value="unitCity" /></td>
			</tr>
			<tr>
				<td>网 址</td>
				<td><s:property value="unitUrl" /></td>
				<td><span class="xing">*</span>电子信箱</td>
				<td colspan="2"><s:property value="unitEmail" /></td>
			</tr>
			<tr>
				<td><span class="xing">*</span>法人代表</td>
				<td><s:property value="unitLegalPeople" /></td>
				<td>邮政编码</td>
				<td colspan="2"><s:property value="unitZipCode" /></td>
			</tr>
			<tr>
				<td rowspan="2"><span class="xing">*</span>联系人</td>
				<td rowspan="2"><s:property value="unitContactPeople" /></td>
				<td><span class="xing">*</span>电话</td>
				<td>1.固定：<s:property value="unitPhone" /></td>
				<td>2.移动；<s:property value="unitMobilePhone" /></td>
			<tr>
				<td>传真</td>
				<td colspan="2"><s:property value="unitFax" /></td>
			</tr>
			</tr>
			<tr>
				<td><span class="xing">*</span>机构属性</td>
				<td colspan="4"><s:property value="unitAttribute" /></td>
			</tr>
			<tr>
				<td colspan="5"><span class="xing">*</span>机构简介（主要包括基本情况、现有研究基础等，限500字以内）</td>
			</tr>
			<tr>
				<td colspan="5" height="150px"><s:property
						value="unitIntroduce" /></td>
			</tr>
		</table>
		<form action="UsersManage-userList" method="post">
		<input type="submit" value="返回">
		</from>

	</center>
</body>
</html>
