<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
  <head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge" charset=utf-8/>
<title>用户注册</title>


<!--[if lt IE 9]>
<script src="js/html5shiv.js"></script>
<![endif]-->

<link href="../register/css/normalize.css" rel="stylesheet"/>
<link href="../register/css/jquery-ui.css" rel="stylesheet"/>
<link href="../register/css/jquery.idealforms.min.css" rel="stylesheet" media="screen"/>

<style type="text/css">
body{font:normal 15px/1.5 Arial, Helvetica, Free Sans, sans-serif;color: #222;background:url(pattern.png);overflow-y:scroll;padding:60px 0 0 0;}
#registForm{width:755px;margin:0 auto;border:1px solid #ccc;padding:3em;border-radius:3px;box-shadow:0 0 2px rgba(0,0,0,.2);}
#comments{width:350px;height:100px;}
#unitIntroduce{width:400px;height:200px;}
</style>

</head>

 <body>
 <div class="row">

  <div class="eightcol last">

    <!-- Begin Form -->
<h1 align="center" style="color:red">用户注册</h1>

    <form id="registForm"action="RegisterAction-commonRegist"  method="post" target="_parent">

        <section name="第一步，账号注册：">
 <div><label>登录账号:</label><input id="userID" name="userID" type="text"/></div>
          <div><label>账户密码:</label><input id="userPwd" name="userPwd" type="password"/></div>
          <div><label>密码验证:</label><input id="userPwd2" name="userPwd2" type="password"/></div>
          <div><label>真实姓名:</label><input id="userName" name="userName"  type="text"/></div>
          <div><label>身份证号码:</label><input id="perID" name="perID" multiple type="text"/></div>
        </section>

        <section name="第二步,绑定单位">
          <div id="languages">
          	<div><label>单位名称：</label><input id="unitName"name="unitName" type="text" ></div>
      		<div><label>机构代码：</label><input id="unitID" name="unitID" type="text"/></div>
			<div><label>所在地域：</label><select align="center" name="unitCity">
            			<option  value="石家庄市">石家庄市</option> 
						<option  value="唐山市">唐山市</option> 
						<option  value="秦皇岛市">秦皇岛市</option> 
						<option  value="邯郸市">邯郸市</option> 
						<option  value="邢台市">邢台市</option> 
						<option  value="保定市">保定市</option> 
						<option  value="张家口市">张家口市</option> 
						<option  value="承德市">承德市</option> 
						<option  value="沧州市">沧州市</option> 
						<option  value="廊坊市">廊坊市</option> 
						<option  value="衡水市">衡水市</option> 
						<option  value="定州市">定州市</option> 
						<option  value="辛集市">辛集市</option> 
						<option  value="河北工大">其他（河北工大）</option></select></div> 
			<div><label>单位地址：</label><input id="unitAddress" name="unitAddress" type="text"/></div>
			<div><label>网址：</label><input id="unitURL"name="unitURL" type="text" ></div> 
			<div><label>电子信箱：</label><input id="unitEmail" name="unitEmail" type="text"/></div>
			<div><label>法人代表：</label><input id="unitLegalPeople"name="unitLegalPeople" type="text" ></div>    
			<div><label>邮政编码：</label><input id="unitZipCode" name="unitZipCode" type="text"/></div>
			<div><label>联系人：</label><input id="unitContactPeople"name="unitContactPeople" type="text" ></div>
			<div><label>联系电话：</label><input id="unitPhone" name="unitPhone" type="text"/></div>
			<div><label>手机：</label><input id="unitMobilePhone"name="unitMobilePhone" type="text" ></div>    
			<div><label>传真：</label><input id="unitFax" name="unitFax" type="text"/></div>
			
			            
          </div>
        </section>

        <section name="第三步,单位简介">
        	<div><label>机构属性：</label>
        			<label><input type="radio" id="unitAttribute"name="unitAttribute"checked="checked" value="企业">企业</label>
				    <label><input type="radio"id="unitAttribute"name="unitAttribute" value="高等院校">高等院校 </label>
				    <label><input type="radio" id="unitAttribute"name="unitAttribute" value="研究机构">研究机构</label>
				    <label><input type="radio" id="unitAttribute"name="unitAttribute" value="其他">其他</label></div>
			 <div><label>归口管理部门：</label><select align="center" id="unitDepartment" name="unitDepartment">
            			<option  value="">           </option> 
						<option  value="邯郸市科技局">邯郸市科技局</option> 
						<option  value="邢台市科技局">邢台市科技局</option> 
						<option  value="石家庄市科技局">石家庄市科技局</option> 
						<option  value="保定市科技局">保定市科技局</option> 
						<option  value="张家口市科技局">张家口市科技局</option> 
						<option  value="承德市科技局">承德市科技局</option> 
						<option  value="秦皇岛市科技局">秦皇岛市科技局</option> 
						<option  value="唐山市科技局">唐山市科技局</option> 
						<option  value="廊坊市科技局">廊坊市科技局</option> 
						<option  value="沧州市科技局">沧州市科技局</option> 
						<option  value="衡水市科技局">衡水市科技局</option> 
						<option  value="省科技厅">省科技厅</option> 
						<option  value="省财政厅">省财政厅</option> 
						<option  value="省工业和信息化厅">省工业和信息化厅</option> 
						<option  value="省住房和城乡建设厅">省住房和城乡建设厅</option> 
						<option  value="省水利厅">省水利厅</option> 
						<option  value="省计生委">省计生委</option> 
						<option  value="省食品药品监督管理局">省食品药品监督管理局</option> 
						<option  value="省质量技术监督局">省质量技术监督局</option> 
						<option  value="省环保厅">省环保厅</option>
                        <option  value="省卫生厅">省卫生厅</option> 
		      			<option  value="省农业厅">省农业厅</option> 
						<option  value="省教育厅">省教育厅</option> 
						<option  value="省林业厅">省林业厅</option> 
						<option  value="省中小企业局">省中小企业局</option> 
						<option  value="省交通厅">省交通厅</option> 
						<option  value="省国防科技工业局">省国防科技工业局</option> 
						<option  value="省审计厅">省审计厅</option> 
						<option  value="省文化厅">省文化厅</option> 
						<option  value="省统计局">省统计局</option>  
						<option  value="省公安厅">省公安厅</option> 
		      			<option  value="省人力资源和社会保障厅">省人力资源和社会保障厅</option> 
						<option  value="省体育局">省体育局</option> 
						<option  value="省国土资源厅">省国土资源厅</option> 
						<option  value="省科学院">省科学院</option> 
						<option  value="省农科院">省农科院</option> 
						<option  value="省社会科学院">省社会科学院</option> 
						<option  value="省气象局">省气象局</option> 
						<option  value="省地震局">省地震局</option> 
						<option  value="省民政厅">省民政厅</option> 
						<option  value="省委宣传部">省委宣传部</option> 
		      			<option  value="省委组织部">省委组织部</option> 
						<option  value="省供销合作社">省供销合作社 </option> 
						<option  value="省广播电视局">省广播电视局</option> 
						<option  value="省委办公厅">省委办公厅</option> 
						<option  value="省政府研究室">省政府研究室</option> 
						<option  value="省盐务局">省盐务局</option> 
						<option  value="省档案局">省档案局</option> 
						<option  value="省物价局">省物价局</option> 
						<option  value="省人民政府外事办公室">省人民政府外事办公室</option>
						<option  value="省政府办公厅">省政府办公厅</option> 
		      			<option  value="省信访局">省信访局</option> 
						<option  value="省妇联">省妇联</option> 
						<option  value="省法院">省法院</option> 
						<option  value="省检察院">省检察院</option> 
						<option  value="省商务厅">省商务厅</option> 
						<option  value="省发改委">省发改委</option> 
						<option  value="省国资委">省国资委</option> 
						<option  value="辛集市科技局">辛集市科技局</option> 
						<option  value="定州市科技局">定州市科技局</option>
						<option  value="省安全生产监督管理局">省安全生产监督管理局</option> 
		      			<option  value="省国家安全厅">省国家安全厅</option> 
						<option  value="省中医药管理局">省中医药管理局</option> 
						<option  value="河北出入境检验检疫局">河北出入境检验检疫局</option> 
						<option  value="省科协">省科协</option> 
						<option  value="河北钢铁集团有限公司">河北钢铁集团有限公司</option> 
						<option  value="石家庄国家高新技术产业开发区">石家庄国家高新技术产业开发区</option> 
						<option  value="保定国家高新技术产业开发区">保定国家高新技术产业开发区</option> 
						<option  value="省总工会">省总工会</option> 
						<option  value="省旅游局">省旅游局</option>
						<option  value="省新闻出版广电局">省新闻出版广电局</option> 
		      			<option  value="省社科联">省社科联</option> 
						<option  value="团省委">团省委</option> 
						<option  value="省司法厅">省司法厅</option> 
						<option  value="唐山国家高新技术产业开发区">唐山国家高新技术产业开发区</option> 
						<option  value="燕郊国家高新技术产业开发区">燕郊国家高新技术产业开发区</option> 
						<option  value="河北行政学院">河北行政学院</option> 
						<option  value="河北省机构编制委员会办公室">河北省机构编制委员会办公室</option> 
						<option  value="省政府法制办">省政府法制办</option> 
						<option  value="中共河北省委党校">中共河北省委党校</option>
						<option  value="省工商行政管理局">省工商行政管理局</option> 
		      			<option  value="承德国家高新技术产业开发区">承德国家高新技术产业开发区</option></select></div>   
            
          <div><label>机构简介：</label><textarea id="unitIntroduce"name="unitIntroduce" rows="5" cols="100"></textarea></div>
      </section>

      <div><hr/></div>

      <div>
        <button id="submit_click" type="submit">提交</button>
        <button id="reset" type="button">重置</button>
      </div>

    </form>

    <!-- End Form -->

  </div>

</div>


<script type="text/javascript" src="../register/js/jquery-1.8.2.min.js"></script>
<script type="text/javascript" src="../register/js/jquery-ui.min.js"></script>
<script type="text/javascript" src="../register/js/jquery.idealforms.js"></script>
<!-- jquery.idealforms.jsde的800行左右 -->
<script type="text/javascript"> 
/*$(function()
	{
		$("#submit_click").click(function()
		{
			alert("1");
			var theform=document.registForm;
			alert("2");
			var userID = document.getElementById("userID");
			var userPwd = document.getElementById("userPwd");
			var userPwd2 = document.getElementById("userPwd2");
			var unitID = document.getElementById("unitID");
			alert("3");
			if (userPwd.value != userPwd2.value){
				alert("两次输入的密码不一致！");
				userPwd.value="";
				userPwd2.value="";
				document.getElementById("userPwd").focus();
			}
			alert("4");
			$.ajax(
				{
					url : "RegisterAction-registValidation",
            		type : "post",
            		dataType : "text",
					data:{
						userID:$.trim($("input[id=userID]").val()),
						unitID:$.trim($("input[id=unitID]").val())
						},
					success: function(dataBack)
					{
						if(dataBack=="repeatUnit")
						{
							alert("该单位已注册！");
							unitID.value = "";
							document.getElementById("unitID").focus();
						}
						else if(dataBack=="repeatUser")
						{
							alert("该账户已存在！");
							userID.value = "";
							document.getElementById("userID").focus();
						}
						else
						{
							theform.submit();
						}
					},
					error : function(XMLHttpRequest, textStatus, errorThrown)
					{
						alert("XMLHttpRequest.status:"+XMLHttpRequest.status);
						alert("XMLHttpRequest.readyState:"+XMLHttpRequest.readyState);
						alert("textStatus:"+textStatus);
						alert("请检查网络连接！");
					}
				});
		});
	});*/
var options = {

	onFail: function(){
		alert( '还有'+$myform.getInvalid().length +'项必填项未填写，不能提交.' )
	},

	inputs: {
		'userID': {
			filters: 'required username',
			data: {
			//ajax: { url:'validate.php' }
			}
		},
		'userPwd': {
			filters: 'required pass',
		},
		'userPwd2': {
			filters: 'required pass',
		},
		'userName': {
			filters: 'required',
			data: { },
		},
		'perID': {
			filters: 'required',
			data: { },
		},
		'unitName': {
			filters: 'required',
			data: { },
		},
		'unitID': {
			filters: 'required',
			data: { },
		},
		'unitCity': {
			filters: 'required',
			data: { },
		},
		'unitAddress': {
			filters: 'required',
			data: { },
		},
		'unitURL': {
			filters: 'required url',
			data: { },
		},
		'unitEmail': {
			filters: 'required email',
			data: { },
		},
		'unitLegalPeople': {
			filters: 'required',
			data: { },
		},
		'unitZipCode': {
			filters: 'required zip',
			data: { },
		},
		'unitContactPeople': {
			filters: 'required',
			data: { },
		},
		'unitMobilePhone': {
			filters: 'required phone',
			data: { },
		},
		'unitFax': {
			filters: 'required number',
			data: { },
		},
		'unitIntroduce': {
			filters: 'required',
			data: { },
		},
		'langs[]': {
			filters: 'min max',
			data: { min: 2, max: 3 },
			errors: {
				min: 'Check at least <strong>2</strong> options.',
				max: 'No more than <strong>3</strong> options allowed.'
			}
		}
	}
	
};

var $myform = $('#registForm').idealforms(options).data('idealforms');

$('#reset').click(function(){
	$myform.reset().fresh().focusFirst()
});

$myform.focusFirst();
</script>
  </body>
</html>
