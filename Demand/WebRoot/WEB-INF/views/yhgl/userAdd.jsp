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
<script type="text/javascript">
	function addSubmit() {
		alert("添加成功！");
		return true;
	}
</script>
</head>

<body bgcolor="#FFFFFF">

	<center>
		<h4>账户信息</h4>
		<s:form action="RegisterAction-userAddSave" method="post">
			<table>
				<tr>
					<td>登录账户</td>
					<td><s:textfield name="userID">
						</s:textfield></td>
				</tr>
				<tr>
					<td>登录密码</td>
					<td><s:textfield name="userPwd">
						</s:textfield></td>
				</tr>
				<tr>
					<td>角色类型</td>
					<td><s:select list="#request.usertypes" listKey="userTypeName"
							listValue="userTypeName" name="userType.userTypeName"></s:select>
					</td>
				</tr>
				<tr>
					<td>所属单位</td>
					<td><s:select list="#request.unitNums" listKey="unitId"
							listValue="unitName" name="unitNumber.unitId"></s:select></td>
				</tr>
				<tr>
					<td>用户姓名</td>
					<td><s:textfield name="userName">
						</s:textfield></td>
				</tr>
				<tr>
					<td>身份证号</td>
					<td><s:textfield name="perId">
						</s:textfield></td>
				</tr>
			</table>
			<s:submit value="修改并保存" click="addSubmit()"></s:submit>
		</s:form>
	</center>

</body>
</html>
