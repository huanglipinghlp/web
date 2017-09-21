<%@ page contentType="text/html; charset=UTF-8" language="java"%>
<%@ taglib prefix="s" uri="/struts-tags" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>   
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>角色管理</title>
<style type="text/css">
input.full{
width:100%;
height:100%;
}
option.afull{
width:100%;
height:100%;
}
</style>
<style type="text/css">
table {
	border-collapse: collapse;
	border: none;
	margin: 0px auto;
	width: 500px;
}

span{
color:#ff0000;
}

th, td {
	border: solid #333 1px;
	height: 20px;
}

div {
	text-align: center;
}
</style>
<style type="text/css">
	* {margin:0px; padding:0px;}
	em{
		color:#3F0;
		}
body { font-family:Verdana; font-size:14px; margin:0;}
#container {margin:0 auto; width:910px;}
#header { height:206px; background:#6cf; margin-bottom:5px;}
#menu { height:20px; background:lightgray; margin-bottom:5px;}
#mainContent { height:500px; margin-bottom:5px;}
#content { margin:0 245px !important; margin:0 245px; height:500px;background-image:url(images/1.jpg);}
#footer { height:40px; background:lightgray;}
</style>
<c:set value="${pageContext.request.contextPath}" var="path" scope="page"/>
<script type="text/javaScript" src="${path}/script/jquery-1.4.js"></script>
<script type="text/javascript" >

$(function()
{//alert("4444");
	$("#role").change(
	function()
	{
	//alert("4545");
		
	document.getElementById('zhxx').checked=false;
	document.getElementById('dwxx').checked=false;
	document.getElementById('xgmm').checked=false;
	document.getElementById('yhgl').checked=false;
	document.getElementById('xzzc').checked=false;
	document.getElementById('xzyh').checked=false;
	document.getElementById('xzjs').checked=false;
	document.getElementById('jsqx').checked=false;
	document.getElementById('xssh').checked=false;
	document.getElementById('ywsh').checked=false;
	document.getElementById('xzxq').checked=false;
	document.getElementById('wdxq').checked=false;
	document.getElementById('tjcx').checked=false;
	document.getElementById('xtjs').checked=false;
	document.getElementById('bzwj').checked=false;
	document.getElementById('cjwt').checked=false;
		$.ajax({
            		url : "PermisAction-permitList",
            		type : "post",
            		dataType : "json",
            		data:{
						userTypeName:$.trim($("select[id=role]").val())
						},
            		success : function(data)
					{
						//alert(data);
						$.each(
							data,
							function(i, item)
							{
									/**/
								if(item.permission=="账户信息")
									document.getElementById('zhxx').checked=true;
								if(item.permission=="单位信息")
									document.getElementById('dwxx').checked=true;
								if(item.permission=="修改密码")
									document.getElementById('xgmm').checked=true;
								if(item.permission=="用户管理")
									document.getElementById('yhgl').checked=true;
								if(item.permission=="新增注册")
									document.getElementById('xzzc').checked=true;
								if(item.permission=="新增用户")
									document.getElementById('xzyh').checked=true;
								if(item.permission=="新增角色")
									document.getElementById('xzjs').checked=true;
								if(item.permission=="角色权限")
									document.getElementById('jsqx').checked=true;
								if(item.permission=="形式审核")
									document.getElementById('xssh').checked=true;
								if(item.permission=="业务审核")
									document.getElementById('ywsh').checked=true;
								if(item.permission=="新增需求")
									document.getElementById('xzxq').checked=true;
								if(item.permission=="我的需求")
									document.getElementById('wdxq').checked=true;
								if(item.permission=="统计查询")
									document.getElementById('tjcx').checked=true;
								if(item.permission=="系统介绍")
									document.getElementById('xtjs').checked=true;
								if(item.permission=="帮助文件")
									document.getElementById('bzwj').checked=true;
								if(item.permission=="常见问题")
									document.getElementById('cjwt').checked=true;
							}
						);
            		},
            		error : function(XMLHttpRequest, textStatus, errorThrown){
					alert("XMLHttpRequest.status:"+XMLHttpRequest.status);
					alert("XMLHttpRequest.readyState:"+XMLHttpRequest.readyState);
					alert("textStatus:"+textStatus);
					alert("请检查网络连接！");
					}
            	});
	});
});
</script>
</head>

<body>
<center>
		<h1 class="one">角色管理</h1><br/>
		<p>请选择角色:
<s:form>
        
		<s:select list="#request.usertypes" id="role"
			listKey="userTypeName" listValue="userTypeName" name="userType.userTypeName"
			label="角色类型"></s:select>
</s:form>	
<form name="homeForm"  method="post" action ="PermisAction-permitSet"  >
<table>
	<tr>
		<td align="center">权限名称</td>
		<td align="center">是否授予</td>
	</tr>
	<tr>
		<td align="center">账户信息</td>
		<td align="center"><input type="checkbox" id="zhxx" name="zhxx" value="账户信息"></td>
	</tr>
	<tr>
		<td align="center">单位信息</td>
		<td align="center"><input type="checkbox" id="dwxx" name="dwxx" value="单位信息"></input></td>
	</tr>
	<tr>
		<td align="center">修改密码</td>
		<td align="center"><input type="checkbox" id="xgmm" name="xgmm" value="修改密码"></input></td>
	</tr>
	<tr>
		<td align="center">用户管理</td>
		<td align="center"><input type="checkbox" id="yhgl" name="yhgl" value="用户管理"></input></td>
	</tr>
	<tr>
		<td align="center">新增注册</td>
		<td align="center"><input type="checkbox" id="xzzc" name="xzzc" value="新增注册"></input></td>
	</tr>
	<tr>
		<td align="center">新增用户</td>
		<td align="center"><input type="checkbox" id="xzyh" name="xzyh" value="新增用户"></input></td>
	</tr>
	<tr>
		<td align="center">新增角色</td>
		<td align="center"><input type="checkbox" id="xzjs" name="xzjs" value="新增角色"></input></td>
	</tr>
	<tr>
		<td align="center">角色权限</td>
		<td align="center"><input type="checkbox" id="jsqx" name="jsqx" value="角色权限"></input></td>
	</tr>
	<tr>
		<td align="center">形式审核</td>
		<td align="center"><input type="checkbox" id="xssh" name="xssh" value="形式审核"></input></td>
	</tr>
	<tr>
		<td align="center">业务审核</td>
		<td align="center"><input type="checkbox" id="ywsh" name="ywsh" value="业务审核"></input></td>
	</tr>
	<tr>
		<td align="center">新增需求</td>
		<td align="center"><input type="checkbox" id="xzxq" name="xzxq" value="新增需求"></input></td>
	</tr>
	<tr>
		<td align="center">我的需求</td>
		<td align="center"><input type="checkbox" id="wdxq" name="wdxq" value="我的需求"></input></td>
	</tr>
	<tr>
		<td align="center">统计查询</td>
		<td align="center"><input type="checkbox" id="tjcx" name="tjcx" value="统计查询"></input></td>
	</tr>
	<tr>
		<td align="center">系统介绍</td>
		<td align="center"><input type="checkbox" id="xtjs" name="xtjs" value="系统介绍"></input></td>
	</tr>
	<tr>
		<td align="center">帮助文件</td>
		<td align="center"><input type="checkbox" id="bzwj" name="bzwj" value="帮助文件"></input></td>
	</tr>
	<tr>
		<td align="center">常见问题</td>
		<td align="center"><input type="checkbox" id="cjwt" name="cjwt" value="常见问题"></input></td>
	</tr>
	</table><br><br>
	<input type="hidden" id="typeName" name="typeName">

          <p>  <input type ="button" name="Btsubmit"  onclick="changeSub()"value ="提交" style="width:100px;height:30px;color:#BC8F8F" ></p>
 </form>	           
</center>		    
</body>
<script type="text/javascript">
function changeSub()
{
	var typeName=document.getElementById('typeName');
	typeName.value=document.getElementById('role').value;
	homeForm.submit();
}
$.ajax({
            		url : "PermisAction-permitList",
            		type : "post",
            		dataType : "json",
            		data:{
						userTypeName:$.trim($("select[id=role]").val())
						},
            		success : function(data)
					{
						//alert("zxc");
						$.each(
							data,
							function(i, item)
							{
									/**/
								if(item.permission=="账户信息")
									document.getElementById('zhxx').checked=true;
								if(item.permission=="单位信息")
									document.getElementById('dwxx').checked=true;
								if(item.permission=="修改密码")
									document.getElementById('xgmm').checked=true;
								if(item.permission=="用户管理")
									document.getElementById('yhgl').checked=true;
								if(item.permission=="新增注册")
									document.getElementById('xzzc').checked=true;
								if(item.permission=="新增用户")
									document.getElementById('xzyh').checked=true;
								if(item.permission=="新增角色")
									document.getElementById('xzjs').checked=true;
								if(item.permission=="角色权限")
									document.getElementById('jsqx').checked=true;
								if(item.permission=="形式审核")
									document.getElementById('xssh').checked=true;
								if(item.permission=="业务审核")
									document.getElementById('ywsh').checked=true;
								if(item.permission=="新增需求")
									document.getElementById('xzxq').checked=true;
								if(item.permission=="我的需求")
									document.getElementById('wdxq').checked=true;
								if(item.permission=="统计查询")
									document.getElementById('tjcx').checked=true;
								if(item.permission=="系统介绍")
									document.getElementById('xtjs').checked=true;
								if(item.permission=="帮助文件")
									document.getElementById('bzwj').checked=true;
								if(item.permission=="常见问题")
									document.getElementById('cjwt').checked=true;
							}
						);
            		},
            		error : function(XMLHttpRequest, textStatus, errorThrown){
					alert("XMLHttpRequest.status:"+XMLHttpRequest.status);
					alert("XMLHttpRequest.readyState:"+XMLHttpRequest.readyState);
					alert("textStatus:"+textStatus);
					alert("请检查网络连接！");
					}
            	});
</script>
</html>