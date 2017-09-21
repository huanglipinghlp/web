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
		$(document).ready(function() {
			getFirst_xq('demandEconomicClass1');
			getFirst_xk('demandClass1');
		});
	</script>
	<script type="text/javascript">
		$(function() {
			$("#btnbcbtj").click(function() {
				$("#demandState").val("保存");
			});
			$("#btntj").click(function() {
				$("#demandState").val("提交");
			});
		});
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
<body bgcolor="#FFFFFF" onbeforeunload="checkLeave()">
	<center>
		<h2>河北省重大技术需求征集表</h2>
		<table>
			<tr>
				<td><span class="xing">*</span>机构全称</td>
				<td colspan="2"><s:property value="#request.unit.unitNumber.unitName" /></td>
				<td>
					<!-- <font color="#ff0000"> -->归口管理部门<!-- </font> --></td>
				<td colspan="2"><s:property
						value="#request.unit.unitDepartment" /></td>
			</tr>
			<tr>
				<td><span class="xing">*</span>通讯地址</td>
				<td colspan="2"><s:property value="#request.unit.unitAddress" /></td>
				<td><span class="xing">*</span>所在地域</td>
				<td colspan="2"><s:property value="#request.unit.unitCity" />
				</td>
			</tr>
			<tr>
				<td>网 址</td>
				<td colspan="2"><s:property value="unitUrl" /></td>
				<td><span class="xing">*</span>电子信箱</td>
				<td colspan="2"><s:property value="#request.unit.unitEmail" />
				</td>
			</tr>
			<tr>
				<td><span class="xing">*</span>法人代表</td>
				<td colspan="2"><s:property value="#request.unit.unitLegalPeople" /></td>
				<td>邮政编码</td>
				<td colspan="2"><s:property value="#request.unit.unitZipCode" />
				</td>
			</tr>
			<tr>
				<td rowspan="2"><span class="xing">*</span>联系人</td>
				<td rowspan="2" colspan="2"><s:property
						value="#request.unit.unitContactPeople" /></td>
				<td><span class="xing">*</span>电话</td>
				<td>1.固定：&nbsp;&nbsp;<s:property
						value="#request.unit.unitPhone" />&nbsp;&nbsp; 2.手机：&nbsp;&nbsp;<s:property
						value="#request.unit.unitMobilePhone" /></td>
			</tr>
			<tr>
				<td>传真</td>
				<td colspan="2"><s:property value="#request.unit.unitFax" /></td>
			</tr>

			<tr>
				<td><span class="xing">*</span>机构属性</td>
				<td colspan="5" ><s:property value="#request.unit.unitAttribute" />
				</td>
			</tr>
			<tr>
				<td colspan="6"><span class="xing">*</span>机构简介（主要包括基本情况、现有研究基础等，限500字以内）</td>
			</tr>
			<tr>
				<td colspan="6" class="textBox"><s:property
						value="#request.unit.unitIntroduce" /></td>
			</tr>
		</table>
		<s:form action="DemandAction-save" method="post">
			<s:hidden name="demandState" id="demandState" />
			<table>
				<tr>
					<td><span class="xing">*</span>技术需求名称</td>
					<td colspan="2"><s:textfield name="demandName" style="width:100%; height:30px;"></s:textfield>
					</td>
					<td><span class="xing">*</span>需求时限</td>
					<td colspan="2"><s:textfield name="demandStart"
							id="demandStart" style="width:80px" placeholder="例如:2017" /><span>1年至
					</span>
					<s:textfield name="demandEnd" id="demandEnd" style="width:80px"
							placeholder="例如:2020" /><span>年</span>
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
						style="color: black">/500</span> <s:textarea
							onkeyup="showJSXQGS()" cols="107" rows="5" id="reqJSXQGS"
							name="demandMain" /></td>
				</tr>
				<tr>
					<td colspan="6">2、技术关键（所需的关键技术、主要指标，限500字以内）</td>
				</tr>
				<tr>
					<td  colspan="6"><span id="jsxqgs1Num">0</span><span style="color: black">/500</span>
						<s:textarea onkeyup="showJSXQGS1()" cols="107" rows="4"
							id="reqJSXQGS1" name="demandKey" />
					</td>
				</tr>
				<tr>
					<td colspan="6">3、预期目标（技术创新性、经济社会效益，限500字以内）</td>
				</tr>
				<tr>
					<td  colspan="6"><span id="jsxqgs2Num">0</span><span style="color: black">/500</span>
						<s:textarea onkeyup="showJSXQGS2()" cols="107" rows="4"
							id="reqJSXQGS2" name="demandTarget" />
					</td>
				</tr>
				<tr>
					<td style="width: 120px; height: 50px;"><span class="xing">*</span>
						关键字：(1-5个)</td>
					<td colspan="5" style="border-top: none; height: 45px;"><s:textfield
							name="demandKeyWord1" class="gjz1"></s:textfield>&nbsp; <s:textfield
							name="demandKeyWord2" onfocus="on_keyword1()" class="gjz1"></s:textfield>&nbsp;
						<s:textfield name="demandKeyWord3" onfocus="on_keyword2()"
							class="gjz1"></s:textfield>&nbsp; <s:textfield
							name="demandKeyWord4" onfocus="on_keyword3()" class="gjz1"></s:textfield>&nbsp;
						<s:textfield name="demandKeyWord5" onfocus="on_keyword4()"
							class="gjz1"></s:textfield>
					</td>
				</tr>
				<tr>
					<td style="height: 40px;">拟投入资金总额</td>
					<td colspan="5"><s:textfield name="demandLoan"
							onblur="shuzi()"></s:textfield> 万元</td>
				</tr>
				<tr>
					<td rowspan="2" style="height: 40px;"><span class="xing">*</span>技术需求解决方式</td>
					<td colspan="5"><s:radio name="demandResearchMode"
							style="width:10px; height:10px;"
							list="#{'独立研发':'独立研发','委托研发':'委托研发 ','合作研发':'合作研发','其它':'其它'}"></s:radio>
					</td>
				</tr>
				<tr>
					<td colspan="5">合作意向单位（选填）<s:textfield
							style="width:70%; height:30px;" name="demandCooperationUnit"></s:textfield>
					</td>
				</tr>
				<tr>
					<td><span class="xing">*</span>科技活动类型</td>
					<td colspan="5"><s:radio name="demandTechnology"
							id="demandTechnology" style="width:10px; height:10px;"
							list="#{'基础研究':'基础研究','应用研究':'应用研究','试验发展':'试验发展',
				'研究发展与成果应用':'研究发展与成果应用','技术推广与科技服务':'技术推广与科技服务',
				'生产性活动':'生产性活动'}" />

					</td>

				</tr>
				<tr name="a" id="a">
					<td>学科分类</td>
					<td colspan="5">（限基础研究填写） <select name="demandClass1"
						id="demandClass1" onchange="changefirst_xk()">
					</select> <select name="demandClass2" id="demandClass2"
						onchange="changesecond_xk()">
					</select> <select name="demandClass3" id="demandClass3">
					</select>
					</td>
				</tr>
				<tr name="b" id="b">
					<td>需求技术所属领域（非基础研究填写）</td>
					<td colspan="5"><s:checkboxlist name="demandDomain"
							id="reqXQJSSSLY"
							list="{'电子信息技术','光机电一体化','软件','生物制药技术','新材料及应用技术',
				'先进制造技术','现代农业技术','新能源与高校节能技术','资源与环境保护新技术','其他技术(注明)'}" />&nbsp;&nbsp;&nbsp;（可多选
					</td>
				</tr>
				<tr name="c" id="c">
					<td>需求技术应用行业（非基础研究填写）</td>
					<td colspan="5">（参见国民经济行业分类）<select
						name="demandEconomicClass1" id="demandEconomicClass1"
						onchange="changefirst_xq()">
					</select> <select name="demandEconomicClass2" id="demandEconomicClass2"
						onchange="changesecond_xq()">
					</select> <select name="demandEconomicClass3" id="demandEconomicClass3">
					</select>
					</td>
				</tr>
			</table>
			<button type="submit" id="btnbcbtj" class="btn"
				onclick="return Check1()">保存</button>
			<button type="submit" id="btntj" class="btn"
				onclick="return Check2()">提交</button>
			<button class="btn" id="cancelBtn" type="button">取消</button>
		</s:form>
	</center>
</body>
</html>
