<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="s" uri="/struts-tags" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<script type="text/javascript" src="script/jquery-1.4.js"></script>
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
			<td align="center" width="500">关键字</td>
			<td align="center" width="100">状态</td>	
			<td align="center" width="100">操作</td>
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
						<a href="DemandAction-deAuShow?demandId=${demandId }" >业务审核</a>
					</td>
				</tr>
			</s:iterator>
		</table>
	</s:else>
		</center>
</body>
</html>