package com.zxc.DUS2.action;

import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserType;
import com.zxc.DUS2.service.UserService;

public class UserInfAction extends ActionSupport implements RequestAware,
		ModelDriven<User>, Preparable
{
	/**/
	private Map<String, Object> request;
	private User model;
	private UserService userService;
	private String newPassword;

	public String userInf()
	{ /* 菜单项跳转 */
		return "userInfView";
	}

	public void prepareUserInf()
	{/* 数据填充 */
		model = userService.getMyUser();
	}

	// 账户信息修改
	public String userInfSet()
	{
		userService.saveOrUpdate(model);
		return "userInfView";
	}

	// 修改前的数据填充
	public String prepareUserInfSet()
	{
		return null;
	}

	// 修改密码的跳转
	public String userPwInf()
	{
		return "userPwInf";
	}
	//修改密码
	public String pswSet()
	{
		User user =userService.getMyUser();
		user.setUserPwd(newPassword);
		userService.saveOrUpdate(user);
		/*model = userService.getMyUser();
		model.setUserPwd(newPassword);
		userService.saveOrUpdate(model);*/
		return "userPwInf";
	}
	@Override
	public void prepare() throws Exception
	{
	}

	@Override
	public User getModel()
	{
		return model;
	}

	@Override
	public void setRequest(Map<String, Object> arg0)
	{
		this.request = arg0;

	}

	public UserService getUserService()
	{
		return userService;
	}

	public void setUserService(UserService userService)
	{
		this.userService = userService;
	}

	public String getNewPassword()
	{
		return newPassword;
	}

	public void setNewPassword(String newPassword)
	{
		this.newPassword = newPassword;
	}

}
