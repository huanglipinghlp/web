<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="s" uri="/struts-tags" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%> 
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<c:set value="${pageContext.request.contextPath}" var="path" scope="page" />
<script type="text/javaScript" src="${path}/script/jquery-1.4.js"></script>
<script type="text/javaScript">
$(function(){
	 $(".Delete").click(function(){
		var name = $(this).next(":input").val();
		var flag = confirm("确定要删除"+ name +"的记录吗？");
		

		if(flag){
			var $tr = $(this).parent().parent();
			//删除, 使用 ajax 的方式
			var url = this.href;
			var args = {"time":new Date()};			
			$.post(url, args, function(data){
				//若 data 的返回值为 1, 则提示 删除成功, 且把当前行删除
				if(data == "1"){
					alert("删除成功!");
					$tr.remove();
				}else{
					//若 data 的返回值不是 1, 提示删除失败. 
					alert("删除失败!");
				}
			});	
		}
		return false; 
	});
});

</script>
</head>
<body>
	<center>
	<h4>需求管理</h4>
	
	<s:if test="#request.demands == null || #request.demands.size() == 0">
		没有任何需求信息
	</s:if>
	<s:else>
		<table border="1" cellpadding="10" cellspacing="0">
			<tr>
				<td align="center" width="130">技术需求编号</td>
			<td align="center" width="130">技术需求名称</td>
			<td align="center" width="400">关键字</td>
			<td align="center" width="100">状态</td>	
			<td align="center" width="200">操作</td>
			</tr>
			<s:iterator value="#request.demands">
				<tr>
					<td>${demandId }</td>
					<td>${demandName }</td>
					<td>${demandKeyWord1 }&nbsp;&nbsp;&nbsp;
					${demandKeyWord2 }&nbsp;&nbsp;&nbsp;
					${demandKeyWord3 }&nbsp;&nbsp;&nbsp;
					${demandKeyWord4 }&nbsp;&nbsp;&nbsp;
					${demandKeyWord5 }</td>
					<td>${demandState}</td>
					<td>
						<a href="DemandAction-show?demandId=${demandId }" >详情</a>
					&nbsp;&nbsp;||&nbsp;&nbsp;
						<a href="DemandAction-edit?demandId=${demandId }">编辑</a>
					&nbsp;&nbsp;||&nbsp;&nbsp;
					<a href="DemandAction-delete?demandId=${demandId }" class="Delete" onclick="return reSetPwd()">删除</a>
						<input type="hidden" value="${demandName }"/>
					</td>
				</tr>
			</s:iterator>
		</table>
	</s:else>
		</center>
</body>
</html>