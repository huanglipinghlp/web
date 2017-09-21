<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="s" uri="/struts-tags" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<script type="text/javascript" src="script/jquery-1.4.js"></script>
<script type="text/javascript">
	
function reSetPwd()
{
	var rlt = confirm("用户密码会被重置为123456，是否继续？");
    if(rlt == true)
    {
    	alert("重置成功！");
        return true;
    }
    else
    {
        return false;
    }
}
	
</script>
</head>
<body>
	<center>
	<h4>用户管理</h4>
	
	<s:if test="#request.users == null || #request.users.size() == 0">
		没有任何用户信息
	</s:if>
	<s:else>
		<table border="1" cellpadding="10" cellspacing="0">
			<tr>
				<td>用户账户</td>
				<td>用户角色</td>
				<td>所属单位</td>
				<td>用户姓名</td>
				<td>身份证号</td>
				<td colspan="2">操作</td>
			</tr>
			<s:iterator value="#request.users">
				<tr>
					<td>${userID }</td>
					<td>${userType.userTypeName }</td>
					<td>${unitNumber.unitName }</td>
					<td>${userName }</td>
					<td>${perId }</td>
					<td>
						<a href="UsersManage-showUnit?userID=${userID }" >单位详情</a>
					</td>
					<td>
						<a href="UsersManage-pwdReset?userID=${userID }" class="reset"onclick="return reSetPwd()">密码重置</a>
						<input type="hidden" value="${userName }"/>
					</td>
				</tr>
			</s:iterator>
		</table>
	</s:else>
		</center>
</body>
</html>