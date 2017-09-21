<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'userPwInf.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body bgcolor="#FFFFFF"> 
<center>
  <h4>修改密码</h4>
  <form name="homeForm"  method="post" action ="UserInfAction-pswSet">            
 <table>
 	<tr>
 		<td>新密码：</td>
 		<td><input type="password" id="userPwd"name="newPassword"></td>
 	</tr>
 	<tr>
 		<td>密码确认：</td>
 		<td><input type="password" id="userPwd2"name="newPassword2"></td>
 	</tr>
 </table> <br><br> 
		<input type ="submit" value ="保存" onclick="CheckPWD()">
 </form>
</center>
  </body>
  <script type="text/javascript">
  function CheckPWD()
  {
  	var p1 = document.getElementById('userPwd').value;
  	var p2 = document.getElementById('userPwd2').value;
  	if(p1!=p2)
  		{
  			alert("两次输入的密码不一致！");
  			return false;
  		}
  	else
  		{
  			alert("修改成功！");
  			return true;
  		}
  		
  }
  </script>
</html>
