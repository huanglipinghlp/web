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
<style type="text/css">
table {
	border-collapse: collapse;
	margin: 0 auto;
	width: 900px;
}

table,th,td {
	border: 1px solid black;
}

td {
	height: 40px;
}

input { /* background: none transparent scroll repeat 0% 0%; */
	width: 99.5%;
	height: 40px;
}

div {
	text-align: center
}

span {
	color: red;
	position: relative;
	bottom: -2px;
}

.btn {
	width: 120px;
	height: 30px;
	font-size: 16px;
	background-color: DeepSkyBlue;
	color: white;
}

.redio {
	
}
</style>
</head>

<body bgcolor="#FFFFFF">
	<center>
		<h4>单位信息</h4>
		<s:form action="UnitInfAction-unitInfSet" method="post">
			<table>
				<tr>
					<td><span class="xing">*</span>机构全称</td>
					<td><s:textfield name="unitNumber.unitName" disabled="true">
						</s:textfield></td>
					<td>
						<!-- <font color="#ff0000"> -->归口管理部门<!-- </font> -->
					</td>
					<td colspan="2"><s:textfield name="unitDepartment" disabled="true">
						</s:textfield>
					</td>
				</tr>
				<tr>
					<td><span class="xing">*</span>通讯地址</td>
					<td><s:textfield name="unitAddress">
						</s:textfield>
					</td>
					<td><span class="xing">*</span>所在地域</td>
					<td colspan="2"><select align="center" name="unitCity">
            			<option  value="石家庄市">石家庄市</option> 
						<option  value="唐山市">唐山市</option> 
						<option  value="秦皇岛市">秦皇岛市</option> 
						<option  value="邯郸市">邯郸市</option> 
						<option  value="邢台市">邢台市</option> 
						<option  value="保定市">保定市</option> 
						<option  value="张家口市">张家口市</option> 
						<option  value="承德市">承德市</option> 
						<option  value="沧州市">沧州市</option> 
						<option  value="廊坊市">廊坊市</option> 
						<option  value="衡水市">衡水市</option> 
						<option  value="定州市">定州市</option> 
						<option  value="辛集市">辛集市</option> 
						<option  value="河北工大">其他（河北工大）</option></select></td>
				</tr>
				<tr>
					<td>网 址</td>
					<td><s:textfield name="unitUrl">
						</s:textfield>
					</td>
					<td><span class="xing">*</span>电子信箱</td>
					<td colspan="2"><s:textfield name="unitEmail">
						</s:textfield></td>
				</tr>
				<tr>
					<td><span class="xing">*</span>法人代表</td>
					<td><s:textfield name="unitLegalPeople">
						</s:textfield>
					</td>
					<td>邮政编码</td>
					<td colspan="2"><s:textfield name="unitZipCode">
						</s:textfield></td>
				</tr>
				<tr>
					<td rowspan="2"><span class="xing">*</span>联系人</td>
					<td rowspan="2"><s:textfield name="unitContactPeople">
						</s:textfield>
					</td>
					<td><span class="xing">*</span>电话</td>
					<td>1.固定：&nbsp;&nbsp;<s:textfield name="unitPhone">
						</s:textfield>&nbsp;&nbsp; 2.手机：&nbsp;&nbsp;<s:textfield name="unitMobilePhone">
						</s:textfield>
					</td>
				</tr>
				<tr>
					<td>传真</td>
					<td colspan="3"><s:textfield name="unitFax">
						</s:textfield></td>
				</tr>

				<tr>
					<td><span class="xing">*</span>机构属性</td>
					<td colspan="3"><s:radio name="unitAttribute" id="reqJGSX"
							style="width:10px; height:10px;"
							list="#{'企业':'企业','高等院校':'高等院校','研究机构':'研究机构','其它':'其它'}" />
					</td>
				</tr>
				<tr>
					<td colspan="4"><span class="xing">*</span>机构简介（主要包括基本情况、现有研究基础等，限500字以内）</td>
				</tr>
				<tr>
					<td colspan="4" class="textBox"><s:textfield
							name="unitIntroduce">
						</s:textfield>
					</td>
				</tr>
			</table>
			<input type="submit" value="修改并保存" class="btn" />
		</s:form>
	</center>
</body>
</html>
