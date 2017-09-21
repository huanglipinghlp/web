<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@page import="java.util.Date"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Frameset//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html;charset=utf-8">
	<title>河北省重大技术需求征集系统</title> <c:set
		value="${pageContext.request.contextPath}" var="path" scope="page" />
	<script type="text/javaScript" src="${path}/script/sanji/sanji.js"></script>
	<script type="text/javaScript" src="${path}/script/sanji/sanji1.js"></script>
	<script type="text/javaScript" src="${path}/script/table.js"></script>
	<script type="text/javaScript" src="${path}/script/jquery-1.4.js"></script>

	<script type="text/javascript">
function pass()
	{
		
 		{
			var rlt = confirm("是否确认予以通过？");
		    if(rlt == true)
		    {
		    	document.getElementById("demandState").value = "业务审核通过";
				homeForm.submit();
		        
		    }
		    else
		    {
		        return false;
		    }
 		}
		
	}
	function nopass()
	{
		var rlt = confirm("是否确认不予通过？");
	    if(rlt == true)
	    {
	    	document.getElementById("demandState").value = "业务审核不通过";
			homeForm.submit();
	        
	    }
	    else
	    {
	        return false;
	    }
	}
	</script>
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


div {
	text-align: center
}

span {
	color: red;
	position: relative;
	bottom: -2px;
}

.btn {
	width: 60px;
	height: 30px;
	font-size: 16px;
	background-color: DeepSkyBlue;
	color: white;
}

.gjz {
	width: 100px;
	border: 1px solid black;
}

.gjz1 {
	width: 100px;
	border: 1px solid black;
	background-color: LightGrey;
}
</style>
</head>
<body bgcolor="#FFFFFF" >
<form action="DemandAction-deAudit" name="homeForm" id="homeForm" method="post">
	<center>
		<h2>河北省重大技术需求征集表</h2>
		<table>
			<tr>
				<td><span class="xing">*</span>机构全称</td>
				<td colspan="2"><s:property value="unit.unitNumber.unitName" /></td>
				<td>归口管理部门</td>
				<td colspan="2"><s:property
						value="unit.unitDepartment" /></td>
			</tr>
			<tr>
				<td><span class="xing">*</span>通讯地址</td>
				<td colspan="2"><s:property value="unit.unitAddress" /></td>
				<td><span class="xing">*</span>所在地域</td>
				<td colspan="2"><s:property value="unit.unitCity" />
				</td>
			</tr>
			<tr>
				<td>网 址</td>
				<td colspan="2"><s:property value="unitUrl" /></td>
				<td><span class="xing">*</span>电子信箱</td>
				<td colspan="2"><s:property value="unit.unitEmail" />
				</td>
			</tr>
			<tr>
				<td><span class="xing">*</span>法人代表</td>
				<td colspan="2"><s:property value="unit.unitLegalPeople" /></td>
				<td>邮政编码</td>
				<td colspan="2"><s:property value="unit.unitZipCode" />
				</td>
			</tr>
			<tr>
				<td rowspan="2"><span class="xing">*</span>联系人</td>
				<td rowspan="2" colspan="2"><s:property
						value="unit.unitContactPeople" /></td>
				<td><span class="xing">*</span>电话</td>
				<td>1.固定：&nbsp;&nbsp;<s:property
						value="unit.unitPhone" />&nbsp;&nbsp; 2.手机：&nbsp;&nbsp;<s:property
						value="unit.unitMobilePhone" /></td>
			</tr>
			<tr>
				<td>传真</td>
				<td colspan="2"><s:property value="unit.unitFax" /></td>
			</tr>

			<tr>
				<td><span class="xing">*</span>机构属性</td>
				<td colspan="5" ><s:property value="unit.unitAttribute" />
				</td>
			</tr>
			<tr>
				<td colspan="6"><span class="xing">*</span>机构简介（主要包括基本情况、现有研究基础等，限500字以内）</td>
			</tr>
			<tr>
				<td colspan="6" class="textBox"><s:property
						value="unit.unitIntroduce" /></td>
			</tr>
		</table>
			<table>
				<tr>
					<td><span class="xing">*</span>技术需求名称</td>
					<td colspan="2"><s:property value="demandName" />
					</td>
					<td><span class="xing">*</span>需求时限</td>
					<td colspan="2">
					<span><s:property value="demandStart" />
					</span><s:property value="demandEnd" />
					<span>年</span>
					</td>
				</tr>
				<tr>
					<td colspan="6"><span class="xing">*</span>重大科技需求概述</td>
				</tr>
				<tr>
					<td colspan="6">1、主要问题（需要解决的重大技术问题，限500字以内）</td>
				</tr>
				<tr>
					<td colspan="6"><span id="jsxqgsNum">0</span><span
						style="color: black">/500</span> <s:property value="demandMain" />
						</td>
				</tr>
				<tr>
					<td colspan="6">2、技术关键（所需的关键技术、主要指标，限500字以内）</td>
				</tr>
				<tr>
					<td  colspan="6"><s:property value="demandKey" />
					</td>
				</tr>
				<tr>
					<td colspan="6">3、预期目标（技术创新性、经济社会效益，限500字以内）</td>
				</tr>
				<tr>
					<td  colspan="6">
					<s:property value="demandTarget" />
					</td>
				</tr>
				<tr>
					<td style="width: 120px; height: 50px;"><span class="xing">*</span>
						关键字：(1-5个)</td>
					<td colspan="5" style="border-top: none; height: 45px;">
					<s:property value="demandKeyWord1" />
					<s:property value="demandKeyWord2" />
					<s:property value="demandKeyWord3" />
					<s:property value="demandKeyWord4" />
					<s:property value="demandKeyWord5" />
					</td>
				</tr>
				<tr>
					<td style="height: 40px;">拟投入资金总额</td>
					<td colspan="5">
					<s:property value="demandLoan" />万元</td>
				</tr>
				<tr>
					<td rowspan="2" style="height: 40px;"><span class="xing">*</span>技术需求解决方式</td>
					<td colspan="5">
					<s:property value="demandResearchMode" />
					</td>
				</tr>
				<tr>
					<td colspan="5">合作意向单位（选填）
					<s:property value="demandCooperationUnit" />
					</td>
				</tr>
				<tr>
					<td><span class="xing">*</span>科技活动类型</td>
					<td colspan="5">
					<s:property value="demandTechnology" />
					</td>

				</tr>
				<tr name="a" id="a">
					<td>学科分类</td>
					<td colspan="5">（限基础研究填写）
					<s:property value="demandClass3" />
					</td>
				</tr>
				<tr name="b" id="b">
					<td>需求技术所属领域（非基础研究填写）</td>
					<td colspan="5">
					<s:property value="demandDomain" />
					</td>
				</tr>
				<tr name="c" id="c">
					<td>需求技术应用行业（非基础研究填写）</td>
					<td colspan="5">（参见国民经济行业分类）
					<s:property value="demandEconomicClass3" />
					</td>
				</tr>
				<tr>
				<td >审核意见（选填）</td>
  				<td colspan="5" style="height:150px;">
   					<textarea name="auditopinion" id="auditopinion" style="width:100%;height:100%" required></textarea>
  				</td>
  					 
  				</tr>
  				<tr>
  					<td>审核结果</td>
  					<td colspan="5">
  					<INPUT TYPE="hidden"  id = "demandState" name = "demandState">
  					<INPUT TYPE="hidden"  id = "demandId" name = "demandId" value="${demandId }">
   					<INPUT TYPE="button" value="通过" onclick="pass()" style="width:100px;height:30px;color:#Black">
   					<INPUT TYPE="button" value="不通过" onclick="nopass()" style="width:100px;height:30px;color:#Black">
  					</td>  
  				</tr>
			</table>
	<form>	
	</center>
</body>
</html>
