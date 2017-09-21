//关键字从左到右按顺序填写校验**********************************************************************************
function on_keyword1()
{
	if(homeForm.demandKeyWord1.value==""||homeForm.demandKeyWord1.value==null)
	{
		alert("第一个关键字为空，请按顺序填写！");
		homeForm.demandKeyWord1.focus();
		return false;
	}
	else
		return true;
}
function on_keyword2()
{
	if(homeForm.demandKeyWord1.value=="")
	{
		alert("第一个关键字为空，请按顺序填写！");
		homeForm.demandKeyWord1.focus();
		return false;
	}
	else
	{
		if(homeForm.demandKeyWord2.value=="")
		{
			alert("第二个关键字为空，请按顺序填写！");
			homeForm.demandKeyWord2.focus();
			return false;
		}
		else
			return true;
	}
}
function on_keyword3()
{
	if(homeForm.demandKeyWord1.value=="")
	{
		alert("第一个关键字为空，请按顺序填写！");
		homeForm.demandKeyWord1.focus();
		return false;
	}
	else
	{
		if(homeForm.demandKeyWord2.value=="")
		{
			alert("第二个关键字为空，请按顺序填写！");
			homeForm.Keyword2.focus();
			return false;
		}
		else
		{
			if(homeForm.demandKeyWord3.value=="")
			{
				alert("第三个关键字为空，请按顺序填写！");
				homeForm.demandKeyWord3.focus();
				return false;
			}
			else
				return true;
		}
	}
}
function on_keyword4()
{
	if(homeForm.demandKeyWord1.value=="")
	{
		alert("第一个关键字为空，请按顺序填写！");
		homeForm.Keyword1.focus();
		return false;
	}
	else
	{
		if(homeForm.demandKeyWord2.value=="")
		{
			alert("第二个关键字为空，请按顺序填写！");
			homeForm.demandKeyWord2.focus();
			return false;
		}
		else
		{
			if(homeForm.demandKeyWord3.value=="")
			{
				alert("第三个关键字为空，请按顺序填写！");
				homeForm.demandKeyWord3.focus();
				return false;
			}
			else
			{
				if(homeForm.demandKeyWord4.value=="")
				{
					alert("第四个关键字为空，请按顺序填写！");
					homeForm.demandKeyWord4.focus();
					return false;
				}
				else
					return true;
			}
		}
	}
}
//需求时限验证***********************************************************************
function YearYanzheng()
{
	var a = document.getElementById('demandStart').value; 
	var b = document.getElementById('demandEnd').value;
	if(a>b)
	{
		alert("请确保起始年份小于等于终止年份！");
        document.getElementById("demandStart").focus();
        return false;
	}
	else
	{
   	    return true;
	}
}
//数值验证**************************************************************************************************
 function shuzi()    
{    
 var plansum = document.getElementById('demandLoan').value;    
 var pattern =/^(([1-9]\d{0,9})|0)(\.\d{1,2})?$/;    
 flag = pattern.test(plansum);    
 if(flag)    
 {
   	 return true;    
 }    
 else    
 {
	 alert("请输入数字数值！");
	 document.getElementById("demandLoan").focus();
	 return false;    
 }    
} 

//隐藏或不可编辑***********************************************************************************************
function on_test()
{
	document.getElementById("b").disabled=true;
    document.getElementById("c").disabled=true;
    document.getElementById("a").disabled=false;
    //document.getElementById("b").style.display="none";
    //document.getElementById("c").style.display="none";
    //document.getElementById("a").style.display="block";
}
function change()
{
	document.getElementById("b").disabled=false;
    document.getElementById("c").disabled=false;
    document.getElementById("a").disabled=true;
    //document.getElementById("b").style.display="block";
    //document.getElementById("c").style.display="block";
    //document.getElementById("a").style.display="none";
}
function editon_test()
{
	var obj = document.getElementById("demandTechnology");
	if(obj=="基础研究")
	{
		document.getElementById("b").disabled=true;
	    document.getElementById("c").disabled=true;
	    document.getElementById("a").disabled=false;
		
	}
	else
	{
		document.getElementById("b").disabled=false;
	    document.getElementById("c").disabled=false;
	    document.getElementById("a").disabled=true;
	}
}

//提交校验***********************************************************************************************
function checkinfo()
{
	if(homeForm.demandName.value=="")
	{
		alert("技术需求名称不能为空！");
		homeForm.demandName.focus();
		return false;
	}
	if(homeForm.demandMain.value=="")
	{
		alert("主要问题不能为空！");
		homeForm.demandMain.focus();
		return false;
	}
	if(homeForm.demandKey.value=="")
	{
		alert("技术关键不能为空！");
		homeForm.demandKey.focus();
		return false;
	}
	if(homeForm.demandTarget.value=="")
	{
		alert("预期目标不能为空！");
		homeForm.demandTarget.focus();
		return false;
	}
	if(homeForm.demandKeyWord1.value=="")
	{
		alert("关键字不能为空！");
		homeForm.demandKeyWord1.focus();
		return false;
	}
	if(homeForm.demandLoan.value=="")
	{
		alert("拟投入资金总额不能为空！");
		homeForm.demandLoan.focus();
		return false;
	}
	if(homeForm.demandResearchMode.value=="")
	{
		alert("技术需求解决方式不能为空！");
		homeForm.demandResearchMode.focus();
		return false;
	}
	if(homeForm.demandTechnology.value=="")
	{
		alert("科技活动类型不能为空！");
		homeForm.demandTechnology.focus();
		return false;
	}
	else
	{
		alert("需求信息审核后不能修改！确定提交吗？");
		document.getElementById("submitType").value="提交";
		homeForm.submit();
	}
}
function checkinfo1()
{
	document.getElementById("submitType").value="保存";
	homeForm.submit();
}
//离开页面的弹窗提醒************************************
function checkLeave(){
	event.returnValue="离开当前页面会导致丢失未保存的数据。";
}

$(function() {
	// 加载页面显示字数
	var zishu = $("#reqJGJJ").val().length;
	$("#jgjjNum").html(zishu);
	var zishu = $("#reqJSXQGS").val().length;
	$("#jsxqgsNum").html(zishu);
	var zishu = $("#reqJSXQGS1").val().length;
	$("#jsxqgs1Num").html(zishu);
	var zishu = $("#reqJSXQGS2").val().length;
	$("#jsxqgs2Num").html(zishu);
	// 只要用户输入非数字,就把非数字退掉
	// 起始需求年份
	$("#reqQSXQNF").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
	// 截止需求年份
	$("#reqJZXQNF").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
	// 固定电话
	$("#reqGDDH").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
	// 移动电话
	$("#reqYDDH").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
	// 传真
	$("#reqCZ").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
	// 投资总金额
	$("#reqJHZTZ").keyup(function() { // keyup事件处理
		$(this).val($(this).val().replace(/[^0-9.]/g, ''))
	}).bind("paste", function() { // CTR+V事件处理
		$(this).val($(this).val().replace(/\D|^0/g, ''))
	}).css("ime-mode", "disabled"); // CSS设置输入法不可用
});
/* **************************************************************************网址判定 */
function reqWZ() {
	var strUrl = /http(s)?:\/\/([\w-]+\.)+[\w-]+(\/[\w- .\/?%&=]*)?/;// 网址
	var reqDWWZ = document.getElementById("reqDWWZ");
	if (!strUrl.test(reqDWWZ.value)) {
		reqDWWZ.style.backgroundColor = 'red';
		document.getElementById("btnbcbtj").disabled = true;
	} else {
		reqDWWZ.style.backgroundColor = 'white';
		document.getElementById("btnbcbtj").disabled = false;
	}
}
/* **************************************************************************邮箱判定 */
function reqYX() {
	var strReg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;// 判定邮箱是否正确
	var reqDZYX = document.getElementById("reqDZYX");
	if (!strReg.test(reqDZYX.value)) {
		reqDZYX.style.backgroundColor = 'red';
		document.getElementById("btnbcbtj").disabled = true;
	} else {
		reqDZYX.style.backgroundColor = 'white';
		document.getElementById("btnbcbtj").disabled = false;
	}
}
/* **************************************************************************手机判定 */
function reqSJ() {
	var re = /^[0-9]{11}$/;
	var reqYDDH = document.getElementById("reqYDDH");
	if (!re.test(reqYDDH.value)) {
		reqYDDH.style.backgroundColor = 'red';
		document.getElementById("btnbcbtj").disabled = true;
	} else {
		reqYDDH.style.backgroundColor = 'white';
		document.getElementById("btnbcbtj").disabled = false;
	}
}
/* *******************************************************************实时显示机构简介的字数 */
function showJGJJ() {
	var maxl = 500;
	var count1 = 0;
	var textIIntro = document.getElementById("reqJGJJ").value;
	var lenIIntro = textIIntro.length;
	for (var i = 0; i < lenIIntro; i++) {
		var enter1 = textIIntro.substr(i, 1);
		if (enter1 == "\n") {
			count1++;
		}
	}
	lenIIntro -= count1;
	var showIIntro = lenIIntro;
	if (showIIntro > maxl) {
		document.getElementById("reqJGJJ").value = document
				.getElementById("reqJGJJ").value.substr(0, maxl - 1);
	}
	document.getElementById("jgjjNum").innerHTML = showIIntro;
}
/* ****************************************************************************年限判定 */
$(function() {
	$("#reqQSXQNF").blur(function() {
		var nowYear = new Date().getFullYear();
		var reqQSXQNF = $("#reqQSXQNF").val();
		if (reqQSXQNF < nowYear) {
			$("#reqQSXQNF").css("background", "#FF0000");
			$("#btnbcbtj").attr("disabled", true);
		} else {
			$("#reqQSXQNF").css("background", "#FFFFFF");
			$("#btnbcbtj").attr("disabled", false);
		}
	})
	$("#reqJZXQNF").blur(function() {
		var nowYear = new Date().getFullYear();
		var reqQSXQNF = $("#reqQSXQNF").val();
		var reqJZXQNF = $("#reqJZXQNF").val();
		if (reqQSXQNF > reqJZXQNF || reqJZXQNF < nowYear) {
			$("#reqJZXQNF").css("background", "#FF0000");
			$("#btnbcbtj").attr("disabled", true);
		} else {
			$("#reqJZXQNF").css("background", "#FFFFFF");
			$("#btnbcbtj").attr("disabled", false);
		}
	})
})
/* *******************************************************************实时显示技术概述的字数 */
function showJSXQGS() {
	var maxl = 500;
	var count1 = 0;
	var textIIntro = document.getElementById("reqJSXQGS").value;
	var lenIIntro = textIIntro.length;
	for (var i = 0; i < lenIIntro; i++) {
		var enter1 = textIIntro.substr(i, 1);
		if (enter1 == "\n") {
			count1++;
		}
	}
	lenIIntro -= count1;
	var showIIntro = lenIIntro;
	if (showIIntro > maxl) {
		document.getElementById("reqJSXQGS").value = document
				.getElementById("reqJSXQGS").value.substr(0, maxl - 1);
	}
	document.getElementById("jsxqgsNum").innerHTML = showIIntro;
}
function showJSXQGS1() {
	var maxl = 500;
	var count1 = 0;
	var textIIntro = document.getElementById("reqJSXQGS1").value;
	var lenIIntro = textIIntro.length;
	for (var i = 0; i < lenIIntro; i++) {
		var enter1 = textIIntro.substr(i, 1);
		if (enter1 == "\n") {
			count1++;
		}
	}
	lenIIntro -= count1;
	var showIIntro = lenIIntro;
	if (showIIntro > maxl) {
		document.getElementById("reqJSXQGS1").value = document
				.getElementById("reqJSXQGS1").value.substr(0, maxl - 1);
	}
	document.getElementById("jsxqgs1Num").innerHTML = showIIntro;
}
function showJSXQGS2() {
	var maxl = 500;
	var count1 = 0;
	var textIIntro = document.getElementById("reqJSXQGS2").value;
	var lenIIntro = textIIntro.length;
	for (var i = 0; i < lenIIntro; i++) {
		var enter1 = textIIntro.substr(i, 1);
		if (enter1 == "\n") {
			count1++;
		}
	}
	lenIIntro -= count1;
	var showIIntro = lenIIntro;
	if (showIIntro > maxl) {
		document.getElementById("reqJSXQGS2").value = document
				.getElementById("reqJSXQGS2").value.substr(0, maxl - 1);
	}
	document.getElementById("jsxqgs2Num").innerHTML = showIIntro;
}
/* *********************************************************************五个关键字逐个输入 */
function key1() {
	var reqGJZ1 = document.getElementById("reqGJZ1").value;

	if (reqGJZ1 != "") {
		document.getElementById("reqGJZ2").readOnly = false;
		document.getElementById("reqGJZ2").style.backgroundColor = "White";
	} else {
		document.getElementById("reqGJZ2").value = "";
		document.getElementById("reqGJZ2").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ2").readOnly = true;
		document.getElementById("reqGJZ3").value = "";
		document.getElementById("reqGJZ3").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ3").readOnly = true;
		document.getElementById("reqGJZ4").value = "";
		document.getElementById("reqGJZ4").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ4").readOnly = true;
		document.getElementById("reqGJZ5").value = "";
		document.getElementById("reqGJZ5").style.backgroundColor = 'LightGrey';
		document.getElementById("reqGJZ5").readOnly = true;
	}
}
function key2() {
	var reqGJZ2 = document.getElementById("reqGJZ2").value;

	if (reqGJZ2 != "") {
		document.getElementById("reqGJZ3").readOnly = false;
		document.getElementById("reqGJZ3").style.backgroundColor = "White";
	} else {
		document.getElementById("reqGJZ3").value = "";
		document.getElementById("reqGJZ3").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ3").readOnly = true;
		document.getElementById("reqGJZ4").value = "";
		document.getElementById("reqGJZ4").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ4").readOnly = true;
		document.getElementById("reqGJZ5").value = "";
		document.getElementById("reqGJZ5").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ5").readOnly = true;
	}
}
function key3() {
	var reqGJZ3 = document.getElementById("reqGJZ3").value;

	if (reqGJZ3 != "") {
		document.getElementById("reqGJZ4").readOnly = false;
		document.getElementById("reqGJZ4").style.backgroundColor = "White";
	} else {
		document.getElementById("reqGJZ4").value = "";
		document.getElementById("reqGJZ4").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ4").readOnly = true;
		document.getElementById("reqGJZ5").value = "";
		document.getElementById("reqGJZ5").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ5").readOnly = true;
	}
}
function key4() {
	var reqGJZ4 = document.getElementById("reqGJZ4").value;

	if (reqGJZ4 != "") {
		document.getElementById("reqGJZ5").readOnly = false;
		document.getElementById("reqGJZ5").style.backgroundColor = "White";
	} else {
		document.getElementById("reqGJZ5").value = "";
		document.getElementById("reqGJZ5").style.backgroundColor = "LightGrey";
		document.getElementById("reqGJZ5").readOnly = true;
	}
}
$(function() {
	/* ***************************************************************页面加载关键字背景色 */
	if ($("#reqGJZ1").val() != "") {
		$("#reqGJZ1").css('backgroundColor', '#FFFFFF');
	}
	if ($("#reqGJZ2").val() != "") {
		$("#reqGJZ2").css('backgroundColor', '#FFFFFF');
	}
	if ($("#reqGJZ3").val() != "") {
		$("#reqGJZ3").css('backgroundColor', '#FFFFFF');
	}
	if ($("#reqGJZ4").val() != "") {
		$("#reqGJZ4").css('backgroundColor', '#FFFFFF');
	}
	if ($("#reqGJZ5").val() != "") {
		$("#reqGJZ5").css('backgroundColor', '#FFFFFF');
	}
	/* ***************************************************************页面加载时合作研发 */
	var reqJSXQHZMS = $("input[name=reqJSXQHZMS]");
	if (reqJSXQHZMS[2].checked) {
		$("#hzdw").css('display', 'table-row');
	}
	/* *******************************************************************页面加载时基础研究 */
	var reqYJLXS = $("input[name=reqYJLX]");
	if (reqYJLXS[0].checked) {
		$("#q1").css('display', 'table-row');
		$("#w1").css('display', 'none');
		$("#w2").css('display', 'none');
	} else if (reqYJLXS[1].checked || reqYJLXS[2].checked
			|| reqYJLXS[3].checked || reqYJLXS[4].checked
			|| reqYJLXS[5].checked) {
		$("#w1").css('display', 'table-row');
		$("#w2").css('display', 'table-row');
		$("#q1").css('display', 'none');
	}
	var reqXQJSSSLYS = $("input[name=reqXQJSSSLY]");
	if (reqXQJSSSLYS[9].checked) {
		$("#qtjsms").css('display', 'table-row');
	} else {
		$("#qtjsms").css('display', 'none');
	}
	/* *******************************************************************基础研究选择改变 */
	$("input[name=reqYJLX]").change(function() {
		var reqYJLXS = $("input[name=reqYJLX]");
		if (reqYJLXS[0].checked) {
			$("#q1").css('display', 'table-row');
			$("#w1").css('display', 'none');
			$("#w2").css('display', 'none');
		} else if (!reqYJLXS[0].checked) {
			$("#w1").css('display', 'table-row');
			$("#w2").css('display', 'table-row');
			$("#q1").css('display', 'none');
		}
	})
	/* *********************************************************************合作意向单位改变 */
	$("input[name=reqJSXQHZMS]").change(function() {
		var reqJSXQHZMSS = $("input[name=reqJSXQHZMS]");
		if (reqJSXQHZMSS[2].checked) {
			$("#hzdw").css('display', 'table-row');
		} else {
			$("#hzdw").css('display', 'none');
		}

	})
	/* **********************************************************************其他技术（注明） */
	$("input[name=reqXQJSSSLY]").click(function() {
		var reqXQJSSSLYS = $("input[name=reqXQJSSSLY]");
		if (reqXQJSSSLYS[9].checked) {
			$("#qtjsms").css('display', 'table-row');
		} else {
			$("#qtjsms").css('display', 'none');
		}
	})
	/* **********************************************************************回显三级下拉单 */
})
/* ***********************************************************************保存验证 */
function Check1() {
	var reqTXDZ = $("#reqTXDZ").val();
	var reqDZYX = $("#reqDZYX").val();
	var reqFRDB = $("#reqFRDB").val();
	var reqLXR = $("#reqLXR").val();
	var reqYDDH = $("#reqYDDH").val();
	var reqJGJJ = $("#reqJGJJ").val();
	var reqJSXQMC = $("#reqJSXQMC").val();
	var reqQSXQNF = $("#reqQSXQNF").val();
	var reqJSXQGS = $("#reqJSXQGS").val();
	var reqGJZ1 = $("#reqGJZ1").val();
	var reqJSXQGS = $("#reqJSXQGS").val();
	if ($("#area option:selected").val() == -1) {
		alert("请选择所在地域");
		return false;
	}
	var reqXQJSSSLY = $("input[name=reqXQJSSSLY]");
	var reqYJLXS = $("input[name=reqYJLX]");
	if (reqYJLXS[0].checked) {
		if ($("#reqXKFL1 option:selected").val() == "") {
			alert("请选择学科分类");
			return false;
		}
	} else {
		var ssly = 0;
		for (var i = 0; i < reqXQJSSSLY.length; i++) {
			if (reqXQJSSSLY[i].checked) {
				ssly = 1;
			}
		}
		if (ssly == 0) {
			alert("请选择需求技术所属领域");
			return false;
		}
		if ($("#reqXQJSYYHY1 option:selected").val() == "") {
			alert("请选择需求技术应用行业");
			return false;
		}
	}

	// 机构属性
	var reqJGSX = $("input[name=reqJGSX]");
	var jssx = 0;
	for (var i = 0; i < reqJGSX.length; i++) {
		if (reqJGSX[i].checked) {
			jssx = 1;
		}
	}
	if (jssx == 0) {
		alert("请选择机构属性");
		return false;
	}
	// 技术需求解决方式
	var reqJSXQHZMS = $("input[name=reqJSXQHZMS]");
	var jsxqhzms = 0;
	for (var i = 0; i < reqJSXQHZMS.length; i++) {
		if (reqJSXQHZMS[i].checked) {
			jsxqhzms = 1;
		}
	}
	if (jsxqhzms == 0) {
		alert("请选择技术需求解决方式 ");
		return false;
	}
	if (reqTXDZ == "" || reqDZYX == "" || reqFRDB == "" || reqLXR == ""
			|| reqYDDH == "" || reqJGJJ == "" || reqJSXQMC == ""
			|| reqQSXQNF == "" || reqJZXQNF == "" || reqGJZ1 == ""
			|| reqJSXQGS == "") {
		alert("带 * 的为必填内容");
		return false;
	} else {
		var sure = confirm(" 确定保存吗?保存后可以修改！");
		if (sure == true) {
			return true;
		} else {
			return false;
		}
	}
}
/* ***********************************************************************提交验证 */
function Check2() {
	var reqTXDZ = $("#reqTXDZ").val();
	var reqDZYX = $("#reqDZYX").val();
	var reqFRDB = $("#reqFRDB").val();
	var reqLXR = $("#reqLXR").val();
	var reqYDDH = $("#reqYDDH").val();
	var reqJGJJ = $("#reqJGJJ").val();
	var reqJSXQMC = $("#reqJSXQMC").val();
	var reqQSXQNF = $("#reqQSXQNF").val();
	var reqJSXQGS = $("#reqJSXQGS").val();
	var reqGJZ1 = $("#reqGJZ1").val();
	var reqJSXQGS = $("#reqJSXQGS").val();
	if ($("#area option:selected").val() == -1) {
		alert("请选择所在地域");
		return false;
	}
	var reqXQJSSSLY = $("input[name=reqXQJSSSLY]");
	var reqYJLXS = $("input[name=reqYJLX]");
	if (reqYJLXS[0].checked) {
		if ($("#reqXKFL1 option:selected").val() == "") {
			alert("请选择学科分类");
			return false;
		}
	} else {
		var ssly = 0;
		for (var i = 0; i < reqXQJSSSLY.length; i++) {
			if (reqXQJSSSLY[i].checked) {
				ssly = 1;
			}
		}
		if (ssly == 0) {
			alert("请选择需求技术所属领域");
			return false;
		}
		if ($("#reqXQJSYYHY1 option:selected").val() == "") {
			alert("请选择需求技术应用行业");
			return false;
		}
	}

	// 机构属性
	var reqJGSX = $("input[name=reqJGSX]");
	var jssx = 0;
	for (var i = 0; i < reqJGSX.length; i++) {
		if (reqJGSX[i].checked) {
			jssx = 1;
		}
	}
	if (jssx == 0) {
		alert("请选择机构属性");
		return false;
	}
	// 技术需求解决方式
	var reqJSXQHZMS = $("input[name=reqJSXQHZMS]");
	var jsxqhzms = 0;
	for (var i = 0; i < reqJSXQHZMS.length; i++) {
		if (reqJSXQHZMS[i].checked) {
			jsxqhzms = 1;
		}
	}
	if (jsxqhzms == 0) {
		alert("请选择技术需求解决方式 ");
		return false;
	}
	if (reqTXDZ == "" || reqDZYX == "" || reqFRDB == "" || reqLXR == ""
			|| reqYDDH == "" || reqJGJJ == "" || reqJSXQMC == ""
			|| reqQSXQNF == "" || reqJZXQNF == "" || reqGJZ1 == ""
			|| reqJSXQGS == "") {
		alert("带 * 的为必填内容");
		return false;
	} else {
		var sure = confirm("需求信息审核后不能修改！ 确定提交吗?");
		if (sure == true) {
			return true;
		} else {
			return false;
		}
	}
}