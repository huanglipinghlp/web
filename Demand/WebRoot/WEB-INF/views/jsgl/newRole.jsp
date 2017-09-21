<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'NewRole.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body>
  <br><br>
  <center>
  <form name="homeForm"  method="post" action ="PermisAction-saveNewRole">            
 <table>
 	<tr>
 		<td>角色名称：</td>
 		<td><input type="text" id="userTypeName"name="userTypeName"></td>
 	</tr>
 </table> <br><br> 
		<input type ="submit" value ="保存" onclick="RoleSubmit()">
 </form>
 </center>
  </body>
  <script type="text/javascript">
  function RoleSubmit()
  {
  	var p1 = document.getElementById('userTypeName').value;
  	if(p1==""||p1==null)
  		{
  			alert("角色名字不能为空！");
  			return false;
  		}
  	else
  		{
  			alert("保存成功！");
  			return true;
  		}
  		
  }
  </script>
</html>
