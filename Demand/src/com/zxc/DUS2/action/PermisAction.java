package com.zxc.DUS2.action;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import net.sf.json.JSON;
import net.sf.json.JSONArray;
import net.sf.json.JSONObject;
import net.sf.json.JSONSerializer;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;
import org.apache.struts2.interceptor.SessionAware;

import com.google.gson.Gson;
import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserPermis;
import com.zxc.DUS2.entities.UserType;
import com.zxc.DUS2.service.UserPermisService;

@SuppressWarnings("serial")
public class PermisAction extends ActionSupport implements RequestAware,
ModelDriven<UserPermis>, Preparable
{
	private UserPermisService userPermisService;
	private String userTypeName;
	private UserPermis model;
	private Map<String, Object> request;
	public void setUserPermisService(UserPermisService userPermisService)
	{
		this.userPermisService = userPermisService;
	}
	public String getPowerList() throws Exception
	{
		System.out.println("标记0");
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		List<UserPermis> power=userPermisService.getUserPermisList();
//		for (UserPermis userPermis : power)
//		{
//			System.out.println(userPermis);
//		}
		System.out.println("标记1");
		Gson gson = new Gson();
		String json = gson.toJson(power);
		out.print(json);
		//System.out.println("执行完毕");
		return null;
	}
	//跳转角色新增
	public String NewRole()
	{
		return "NewRole";
	}
	//保存新角色
	public String saveNewRole()
	{
		userPermisService.saveNewUserType(userTypeName);
		return "permitAct";
	}
	//跳转角色权限
	public String permitJump()
	{
		request.put("usertypes", userPermisService.getAllUserType());
		return "permit";
	}
	//ajax回显数据
	public String permitList() throws IOException
	{
		//System.out.println("执行开始");
		HttpServletRequest requestV=ServletActionContext.getRequest();
    	String userTypeName=requestV.getParameter("userTypeName");
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		//System.out.println("标记0"+userTypeName);
		List<UserPermis> list=userPermisService.getPermisList(userTypeName);
		//System.out.println("标记01");
//		for (UserPermis userPermis : list)
//		{
//			System.out.println(userPermis);
//		}
		//System.out.println("标记1");
		Gson gson = new Gson();
		String json = gson.toJson(list);
		out.print(json);
		//System.out.println("执行完毕");
		return null;
	}
	//权限管理
	public String permitSet()
	{
		//System.out.println("zxc");
		HttpServletRequest requestV=ServletActionContext.getRequest();
    	String typeName=requestV.getParameter("typeName");
    	
    	String zhxx=requestV.getParameter("zhxx");
    	if(zhxx==null)
    	{
    		userPermisService.permitSetDel(typeName, "账户信息");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, zhxx);
    	}
    	String dwxx=requestV.getParameter("dwxx");
    	if(dwxx==null)
    	{
    		userPermisService.permitSetDel(typeName, "单位信息");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, dwxx);
    	}
    	String xgmm=requestV.getParameter("xgmm");
    	if(xgmm==null)
    	{
    		userPermisService.permitSetDel(typeName, "修改密码");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xgmm);
    	}
    	String yhgl=requestV.getParameter("yhgl");
    	if(yhgl==null)
    	{
    		userPermisService.permitSetDel(typeName, "用户管理");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, yhgl);
    	}
    	
    	String xzzc=requestV.getParameter("xzzc");
    	if(xzzc==null)
    	{
    		userPermisService.permitSetDel(typeName, "新增注册");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xzzc);
    	}
    	String xzyh=requestV.getParameter("xzyh");
    	if(xzyh==null)
    	{
    		userPermisService.permitSetDel(typeName, "新增用户");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xzyh);
    	}
    	String xzjs=requestV.getParameter("xzjs");
    	if(xzjs==null)
    	{
    		userPermisService.permitSetDel(typeName, "新增角色");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xzjs);
    	}
    	String jsqx=requestV.getParameter("jsqx");
    	if(jsqx==null)
    	{
    		userPermisService.permitSetDel(typeName, "角色权限");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, jsqx);
    	}
    	String xssh=requestV.getParameter("xssh");
    	if(xssh==null)
    	{
    		userPermisService.permitSetDel(typeName, "形式审核");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xssh);
    	}
    	String ywsh=requestV.getParameter("ywsh");
    	if(ywsh==null)
    	{
    		userPermisService.permitSetDel(typeName, "业务审核");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, ywsh);
    	}
    	String xzxq=requestV.getParameter("xzxq");
    	if(xzxq==null)
    	{
    		userPermisService.permitSetDel(typeName, "新增需求");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xzxq);
    	}
    	String wdxq=requestV.getParameter("wdxq");
    	if(wdxq==null)
    	{
    		userPermisService.permitSetDel(typeName, "我的需求");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, wdxq);
    	}
    	String tjcx=requestV.getParameter("tjcx");
    	if(tjcx==null)
    	{
    		userPermisService.permitSetDel(typeName, "统计查询");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, tjcx);
    	}
    	String xtjs=requestV.getParameter("xtjs");
    	if(xtjs==null)
    	{
    		userPermisService.permitSetDel(typeName, "系统介绍");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, xtjs);
    	}
    	String bzwj=requestV.getParameter("bzwj");
    	if(bzwj==null)
    	{
    		userPermisService.permitSetDel(typeName, "帮助文件");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, bzwj);
    	}
    	String cjwt=requestV.getParameter("cjwt");
    	if(cjwt==null)
    	{
    		userPermisService.permitSetDel(typeName, "常见问题");
    	}
    	else
    	{
    		userPermisService.permitSetNewPermit(typeName, cjwt);
    	}
    	
    	//System.out.println("zhxx....."+zhxx);
		return "permitAct";
	}
	//GETSET
	public String getUserTypeName()
	{
		return userTypeName;
	}
	public void setUserTypeName(String userTypeName)
	{
		this.userTypeName = userTypeName;
	}
	@Override
	public void prepare() throws Exception
	{
	}
	@Override
	public UserPermis getModel()
	{
		// TODO Auto-generated method stub
		return model;
	}
	@Override
	public void setRequest(Map<String, Object> arg0)
	{
		// TODO Auto-generated method stub
		this.request=arg0;
	}
	
}
