package com.zxc.DUS2.action;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.util.Map;

import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.service.UnitService;
import com.zxc.DUS2.service.UserService;

public class UsersManage extends ActionSupport implements RequestAware,
		ModelDriven<Unit>, Preparable
{
	private Unit model;
	private String userID;
	private Map<String, Object> request;
	private UserService userService;
	private UnitService unitService;

	// 显示所有的数据
	public String userList()
	{
		request.put("users", userService.gelAllUser());
		return "userList";
	}
	public String pwdReset() throws IOException
	{
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		try
		{
			User user = userService.getUserByID(userID);
			user.setUserPwd("123456");
			userService.saveOrUpdate(user);
			out.print("1");
		} catch (Exception e)
		{
			e.printStackTrace();
			out.print("0");
		}
		return "pswReSet";
	}

	public String showUnit()
	{
		
		return "showUnit";
	}
	public void prepareShowUnit()
	{
		if(userID!=null)
		model = unitService.getUnitById(userID);
	}
	
	/* GET SET/ */
	public Map<String, Object> getRequest()
	{
		return request;
	}

	public void setRequest(Map<String, Object> request)
	{
		this.request = request;
	}

	public UserService getUserService()
	{
		return userService;
	}

	public void setUserService(UserService userService)
	{
		this.userService = userService;
	}

	public UnitService getUnitService()
	{
		return unitService;
	}

	public void setUnitService(UnitService unitService)
	{
		this.unitService = unitService;
	}

	public String getUserID()
	{
		return userID;
	}

	public void setUserID(String userID)
	{
		this.userID = userID;
	}



	@Override
	public void prepare() throws Exception
	{
		// TODO Auto-generated method stub

	}

	@Override
	public Unit getModel()
	{
		return model;
	}

}
