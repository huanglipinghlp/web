<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<title>My JSP 'searchRequirement.jsp' starting page</title>

<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="expires" content="0">
<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
<meta http-equiv="description" content="This is my page">
<c:set value="${pageContext.request.contextPath}" var="path" scope="page" />
<script type="text/javaScript" src="${path}/script/jquery-1.4.js"></script>
<style type="text/css">
a {
	text-decoration: none
}
/*一级行业的样式*/
.mins {
	
}

.plus {
	
}
/*二级行业的样式*/
.mins2 {
	
}

.plus2 {
	
}

td {
	valign: top;
}
</style>
<script type="text/javascript" src="../js/jquery-1.4.js"></script>
<script type='text/javascript'>
	function clickT(id) {
		var ele = document.getElementById("w");
		if (ele.checked) {
			alert();
		}
	}
</script>
</head>

<body>
	<table>
		<tr>
			<td>
				<table border="0" id="conditionTable" width="1020px">
					<tr>
						<td rowspan="1" valign="top">
							<table id="addDel">
								<tr>
									<td><a id="addCondition" href="javascript:void(0);">+</a>
										<a id="delCondition" href="javascript:void(0);">-</a>
									</td>
								</tr>
							</table>
						</td>
						<td valign="top">
							<table border="0" id="conditionTable1">
								<tr id="1">
									<td><select name="condition1" id="conditionName1">
											<option value="0,机构全称">机构全称</option>
											<option value="0,归口管理部门">归口管理部门</option>
											<option value="0,所在地域">所在地域</option>
											<option value="0,法人代表">法人代表</option>
											<option value="0,联系人">联系人</option>
											<option value="0,机构属性">机构属性</option>
											<option value="0,技术需求名称">技术需求名称</option>
											<option value="0,技术需求所属领域">技术需求所属领域</option>

									</select>&nbsp;<input type="text" id="conditionValue1">&nbsp;<select
										name="searchMethod1" id="searchMethod1">
											<option value="精确">精确</option>
											<option value="模糊">模糊</option>
									</select>
									</td>
								</tr>
							</table>
						</td>
						<span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
						<td valign="top">
							<table border="0" id="conditionTable2">
								<tr id="2">
									<td><select name="bool2" id="bool2">
											<option value="0">并且</option>
											<option value="1">或者</option>
											<option value="2">不含</option>
									</select> <select name="condition2" id="conditionName2">
											<option value="机构全称">机构全称</option>
											<option value="归口管理部门">归口管理部门</option>
											<option value="所在地域">所在地域</option>
											<option value="法人代表">法人代表</option>
											<option value="联系人">联系人</option>
											<option value="机构属性">机构属性</option>
											<option value="技术需求名称">技术需求名称</option>
											<option value="技术需求所属领域">技术需求所属领域</option>
									</select>&nbsp;<input type="text" id="conditionValue2">&nbsp;<select
										name="searchMethod2" id="searchMethod2">
											<option value="精确">精确</option>
											<option value="模糊">模糊</option>
									</select>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			<td>
		</tr>
		<tr>
			<td>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<button id="searchButton">查询</button> <a id="searchLink"
				target="res"></a>
			</td>
		</tr>
		<tr>
			<td><iframe id="res" name="res" frameborder="0" marginheight="0"  width="100%" height="100%" 
					marginwidth="0" onLoad="iFrameHeight()"> </iframe>
			</td>
		</tr>
	</table>
</body>
<script type="text/javascript" language="javascript">
	function iFrameHeight() {
		var ifm = document.getElementById("res");
		var subWeb = document.frames ? document.frames["res"].document
				: ifm.contentDocument;
		if (ifm != null && subWeb != null) {
			ifm.height = subWeb.body.scrollHeight;
			ifm.width = subWeb.body.scrollWidth;
		}
	}
</script>
<script type="text/javascript">
	$(function() {
		onReady();
	});
	//记录检索条件行数的
	var rowIndex = 3;
	//点击新增按钮新增一行
	$("#addCondition")
			.click(
					function() {
						//alert("按钮已点击");
						//克隆第一行并将其追加到表格的尾部
						//$("tr:eq(1)").clone().appendTo("#conditionTable");
						//点击的次数是奇数就在左边的表添加一行
						if (rowIndex > 8) {
							alert("最多可添加8个查询条件");
						} else {
							var appendStr = "<tr id='"+rowIndex+"'><td><select id='bool"+rowIndex+"'><option value='0'>并且</option><option value='1'>或者</option><option value='2'>不含</option></select>&nbsp;<select id='conditionName"+rowIndex+"'><option value='机构全称'>机构全称</option><option value='归口管理部门'>归口管理部门</option><option value='所在地域'>所在地域</option><option value='法人代表'>法人代表</option><option value='联系人'>联系人</option><option value='机构属性'>机构属性</option><option value='技术需求名称'>技术需求名称</option><option value='技术需求所属领域'>技术需求所属领域</option></select>&nbsp;<input type='text' id='conditionValue"+rowIndex+"'>&nbsp;<select id='searchMethod"+rowIndex+"'><option value='精确'>精确</option><option value='模糊'>模糊</option></select></td></tr>";
							if (rowIndex % 2 == 1) {
								$("#conditionTable1").append(appendStr);
							} else {
								$("#conditionTable2").append(appendStr);
							}
							rowIndex++;
						}
					});
	//点击删除按钮删除一行

	$("#delCondition").click(function() {
		//最少要保留前两行
		//alert(rowIndex);
		if (rowIndex > 3) {
			$("#" + (rowIndex - 1)).remove();
			rowIndex--;
		} else {
			alert("至少保留两个查询条件");
		}
	});
	$("select[id^='conditionName']")
			.live(
					'change',
					function() {
						var tiaojian = $(this).val();
						if (tiaojian == "归口管理部门" || tiaojian == "0,归口管理部门") {
							var tex = $(this).next(":input");
							var id = $(this).next(":input").attr('id');
							//创建节点
							var eleStr = "<select id='"+id+"'><option select value=''>-----请选择----</option>"
									+ "<option  value='   '>           </option>"
									+ "<option  value='邯郸市科技局'>邯郸市科技局</option>"
									+ "<option  value='邢台市科技局'>邢台市科技局</option>"
									+ "<option  value='石家庄市科技局'>石家庄市科技局</option>"
									+ "<option  value='保定市科技局'>保定市科技局</option>"
									+ "<option  value='张家口市科技局'>张家口市科技局</option>"
									+ "<option  value='承德市科技局'>承德市科技局</option>"
									+ "<option  value='秦皇岛市科技局'>秦皇岛市科技局</option>"
									+ "<option  value='唐山市科技局'>唐山市科技局</option>"
									+ "<option  value='廊坊市科技局'>廊坊市科技局</option>"
									+ "<option  value='沧州市科技局'>沧州市科技局</option>"
									+ "<option  value='衡水市科技局'>衡水市科技局</option>"
									+ "<option  value='省科技厅'>省科技厅</option>"
									+ "<option  value='省财政厅'>省财政厅</option>"
									+ "<option  value='省工业和信息化厅'>省工业和信息化厅</option>"
									+ "<option  value='省住房和城乡建设厅'>省住房和城乡建设厅</option>"
									+ "<option  value='省水利厅'>省水利厅</option>"
									+ "<option  value='省计生委'>省计生委</option>"
									+ "<option  value='省食品药品监督管理局'>省食品药品监督管理局</option>"
									+ "<option  value='省质量技术监督局'>省质量技术监督局</option>"
									+ "<option  value='省环保厅'>省环保厅</option>"
									+ "<option  value='省卫生厅'>省卫生厅</option>"
									+ "<option  value='省农业厅'>省农业厅</option>"
									+ "<option  value='省教育厅'>省教育厅</option>"
									+ "<option  value='省林业厅'>省林业厅</option>"
									+ "<option  value='省中小企业局'>省中小企业局</option>"
									+ "<option  value='省交通厅'>省交通厅</option>"
									+ "<option  value='省国防科技工业局'>省国防科技工业局</option>"
									+ "<option  value='省审计厅'>省审计厅</option>"
									+ "<option  value='省文化厅'>省文化厅</option>"
									+ "<option  value='省统计局'>省统计局</option>"
									+ "<option  value='省公安厅'>省公安厅</option>"
									+ "<option  value='省人力资源和社会保障厅'>省人力资源和社会保障厅</option>"
									+ "<option  value='省体育局'>省体育局</option>"
									+ "<option  value='省国土资源厅'>省国土资源厅</option>"
									+ "<option  value='省科学院'>省科学院</option>"
									+ "<option  value='省农科院'>省农科院</option>"
									+ "<option  value='省社会科学院'>省社会科学院</option>"
									+ "<option  value='省气象局'>省气象局</option>"
									+ "<option  value='省地震局'>省地震局</option>"
									+ "<option  value='省民政厅'>省民政厅</option>"
									+ "<option  value='省委宣传部'>省委宣传部</option>"
									+ "<option  value='省委组织部'>省委组织部</option>"
									+ "<option  value='省供销合作社'>省供销合作社 </option>"
									+ "<option  value='省广播电视局'>省广播电视局</option>"
									+ "<option  value='省委办公厅'>省委办公厅</option>"
									+ "<option  value='省政府研究室'>省政府研究室</option>"
									+ "<option  value='省盐务局'>省盐务局</option>"
									+ "<option  value='省档案局'>省档案局</option>"
									+ "<option  value='省物价局'>省物价局</option>"
									+ "<option  value='省人民政府外事办公室'>省人民政府外事办公室</option>"
									+ "<option  value='省政府办公厅'>省政府办公厅</option>"
									+ "<option  value='省信访局'>省信访局</option>"
									+ "<option  value='省妇联'>省妇联</option>"
									+ "<option  value='省法院'>省法院</option>"
									+ "<option  value='省检察院'>省检察院</option>"
									+ "<option  value='省商务厅'>省商务厅</option>"
									+ "<option  value='省发改委'>省发改委</option>"
									+ "<option  value='省国资委'>省国资委</option>"
									+ "<option  value='辛集市科技局'>辛集市科技局</option>"
									+ "<option  value='定州市科技局'>定州市科技局</option>"
									+ "<option  value='省安全生产监督管理局'>省安全生产监督管理局</option>"
									+ "<option  value='省国家安全厅'>省国家安全厅</option>"
									+ "<option  value='省中医药管理局'>省中医药管理局</option>"
									+ "<option  value='河北出入境检验检疫局'>河北出入境检验检疫局</option>"
									+ "<option  value='省科协'>省科协</option>"
									+ "<option  value='河北钢铁集团有限公司'>河北钢铁集团有限公司</option>"
									+ "<option  value='石家庄国家高新技术产业开发区'>石家庄国家高新技术产业开发区</option>"
									+ "<option  value='保定国家高新技术产业开发区'>保定国家高新技术产业开发区</option>"
									+ "<option  value='省总工会'>省总工会</option>"
									+ "<option  value='省旅游局'>省旅游局</option>"
									+ "<option  value='省新闻出版广电局'>省新闻出版广电局</option>"
									+ "<option  value='省社科联'>省社科联</option>"
									+ "<option  value='团省委'>团省委</option>"
									+ "<option  value='省司法厅'>省司法厅</option>"
									+ "<option  value='唐山国家高新技术产业开发区'>唐山国家高新技术产业开发区</option>"
									+ "<option  value='燕郊国家高新技术产业开发区'>燕郊国家高新技术产业开发区</option>"
									+ "<option  value='河北行政学院'>河北行政学院</option>"
									+ "<option  value='河北省机构编制委员会办公室'>河北省机构编制委员会办公室</option>"
									+ "<option  value='省政府法制办'>省政府法制办</option>"
									+ "<option  value='中共河北省委党校'>中共河北省委党校</option>"
									+ "<option  value='省工商行政管理局'>省工商行政管理局</option>"
									+ "<option  value='承德国家高新技术产业开发区'>承德国家高新技术产业开发区</option></select>";
							tex.replaceWith(eleStr);
						} else if (tiaojian == "所在地域" || tiaojian == "0,所在地域") {
							var tex = $(this).next(":input");
							var id = $(this).next(":input").attr('id');
							//创建节点
							var eleStr = "<select id='"+id+"'><option select value=''>-----请选择----</option>"
									+ "<option select value='   '></option>"
									+ "<option  value='石家庄市'>石家庄市</option>"
									+ "<option  value='唐山市'>唐山市</option>"
									+ "<option  value='秦皇岛市'>秦皇岛市</option>"
									+ "<option  value='邯郸市'>邯郸市</option>"
									+ "<option  value='邢台市'>邢台市</option>"
									+ "<option  value='保定市'>保定市</option>"
									+ "<option  value='张家口市'>张家口市</option>"
									+ "<option  value='承德市'>承德市</option>"
									+ "<option  value='沧州市'>沧州市</option>"
									+ "<option  value='廊坊市'>廊坊市</option>"
									+ "<option  value='衡水市'>衡水市</option>"
									+ "<option  value='定州市'>定州市</option>"
									+ "<option  value='辛集市'>辛集市</option>"
									+ "<option  value='其他（河北工大）'>其他（河北工大）</option></select>";
							tex.replaceWith(eleStr);
						} else {
							var tex = $(this).next();
							var id = $(this).next(":input").attr('id');
							var eleStr = "<input id='"+id+"' type='text'>";
							tex.replaceWith(eleStr);
						}
					});
	//点击查询按钮要执行的事件
	//为了能够使用<iframe>的效果   点击这个按钮的时候触发超链接的点击事件
	$("#searchButton")
			.click(
					function() {
						//保存检索条件的字符串
						var searchCon = "";
						//第一个查询条件没有逻辑变量，所以要特殊处理
						searchCon += $("#conditionName1").val() + ","
								+ $("#conditionValue1").val() + ","
								+ $("#searchMethod1").val() + ";";
						for ( var i = 2; i < rowIndex; i++) {
							searchCon += $("#bool" + i).val() + ","
									+ $("#conditionName" + i).val() + ","
									+ $("#conditionValue" + i).val() + ","
									+ $("#searchMethod" + i).val() + ";";
						}
						//alert(industry+"\n"+searchCon);
						//$("#searchLink").link = "http://www.baidu.com";
						//动态设置超链接的href
						document.getElementById("searchLink").href = "DemandAction-search?searchCon="
								+ searchCon;
						//触发超链接的点击事件
						document.getElementById("searchLink").click();
					});

	//动态设置iframe的大小
	function changeFrameHeight(code) {
		var ifm = document.getElementById("res");
		ifm.height = document.documentElement.clientHeight;
	}

	window.onresize = function() {
		changeFrameHeight();
	};
</script>
</html>
