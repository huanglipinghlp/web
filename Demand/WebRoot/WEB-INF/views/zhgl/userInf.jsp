<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>

<%@ taglib prefix="s" uri="/struts-tags"%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<title>My JSP 'userInf.jsp' starting page</title>

<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="expires" content="0">
<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
<meta http-equiv="description" content="This is my page">
<style type="text/css">
</style>
</head>

<body bgcolor="#FFFFFF">

	<center>
		<h4>账户信息</h4>
		<s:form action="UserInfAction-userInfSet" method="post">
			<table>
				<tr>
					<td>登录账户</td>
					<td><s:textfield name="userID">
						</s:textfield>
					</td>
				</tr>
				<tr>
					<td>角色类型</td>
					<td><s:textfield name="userType.userTypeName" label="角色类型"
							disabled="true"></s:textfield>
					</td>
				</tr>
				<tr>
					<td>用户姓名</td>
					<td><s:textfield name="userName" label="用户姓名">
						</s:textfield>
					</td>
				</tr>
				<tr>
					<td>身份证号</td>
					<td><s:textfield name="perId" label="身份证号">
						</s:textfield>
					</td>
				</tr>
				<tr>

					<td><s:submit value="修改并保存"></s:submit></td>
				</tr>
			</table>
		</s:form>
	</center>

</body>
</html>
