package com.zxc.DUS2.action;


import java.io.PrintWriter;
import java.util.Map;

import javax.security.auth.message.callback.PrivateKeyCallback.Request;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.SessionAware;

import com.google.gson.Gson;
import com.opensymphony.xwork2.ActionSupport;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.service.*;

/**
 * 用户登录Action
 * @version 1.0
 * @author z
 *
 */

@SuppressWarnings("serial")
public class UserAction extends ActionSupport implements SessionAware{
    
    //Struts2中Map类型的session
    private Map<String, Object> session;
    //接收客户端传来的用户名、密码、验证码
    
    private String userID;
    private String userPwd;
    private String errorMess;
    private UserService userService;
    /**
     * 用户登录
     * @return String
     */
    public String login(){
        
    	boolean b;
		b = userService.login(userID, userPwd);
		//System.out.println("action里的bool值："+b);
		if(b){
			System.out.println("密码正确！");
		}else{
			System.out.println("密码错误！");
			setErrorMess("用户名或密码输入错误！");
			return "error";
		}
        return "success";
    }
    public String quitSystem()
	{
    	HttpServletRequest request;
		request = ServletActionContext.getRequest();
		request.getSession().removeAttribute("Unit");
		request.getSession().removeAttribute("User");
		return "loginhome";
	}
    //获取用户名
    public String getName() throws Exception
    {		
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		
		User user = userService.getMyUser();
//		Gson gson = new Gson();
//		String json = gson.toJson(user.getUserName());
//		System.out.println(json);
		String userName=user.getUserName();
		out.print(userName);
		return null;
	}
	//判断验证码
    public String securityCodeJudge() throws Exception
    {	
    	String serverCode = (String)session.get("SESSION_SECURITY_CODE");
    	HttpServletRequest request=ServletActionContext.getRequest();
    	String securityCode=request.getParameter("randCode");
    	String userName=request.getParameter("userName");
    	String userPassword=request.getParameter("userPassword");
        //System.out.println("服务端获取到的！"+serverCode);
        System.out.println("客户端传来的！"+securityCode);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		String data ="sussess";
		if(!serverCode.equals(securityCode)){
        	data="errorRandCode";
        }
		else
		{
			boolean b;
			b = userService.login(userName, userPassword);
			if(!b)
				data="errorName";
		 } 
		out.print(data);
		return null;
	}
	public String getID(String username){
		return userService.getID(username);
	}
	
    public String getUserID()
	{
		return userID;
	}

	public void setUserID(String userID)
	{
		this.userID = userID;
	}

	public String getUserPwd()
	{
		return userPwd;
	}

	public void setUserPwd(String userPwd)
	{
		this.userPwd = userPwd;
	}

	public void setSession(Map<String, Object> session) {
        this.session = session;
    }
    

	public String getErrorMess()
	{
		return errorMess;
	}

	public void setErrorMess(String errorMess)
	{
		this.errorMess = errorMess;
	}

	public UserService getUserService()
	{
		return userService;
	}

	public void setUserService(UserService userService)
	{
		this.userService = userService;
	}
    
}