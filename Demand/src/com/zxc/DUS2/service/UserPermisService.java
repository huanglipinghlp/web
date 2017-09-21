package com.zxc.DUS2.service;

import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.ServletActionContext;

import com.zxc.DUS2.dao.*;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserPermis;
import com.zxc.DUS2.entities.UserType;

public class UserPermisService
{
	private UserDao userDao;
	private UserPermisDao userPermisDao;
	private UserTypeDao userTypeDao;

	// 获取用户的权限
	public List<UserPermis> getUserPermisList()
	{
		HttpServletRequest request;
		request = ServletActionContext.getRequest();
		User user = (User) request.getSession().getAttribute("User");
		String userID = user.getUserID();
		// System.out.println("由Service查到的id:"+userID);
		// 1.由用户ID查询用户的角色
		String userType = userDao.getUserType(userID);
		// System.out.println("由Service查到的type:"+userType);
		// 2.查询角色对应的权限，返回一个列表值
		return userPermisDao.getPermis(userType);
	}

	// 获取角色的权限集合
	public List<UserPermis> getPermisList(String ut)
	{
		return userPermisDao.getPermis(ut);
	}

	// 新增角色
	public void saveNewUserType(String userTypeName)
	{
		UserType userType = new UserType();
		userType.setUserTypeName(userTypeName);
		userTypeDao.save(userType);
	}

	public List<UserType> getAllUserType()
	{
		return userTypeDao.getAllType();
	}
	public void permitSetDel(String usertypeName,String permitName)
	{
		userPermisDao.delPermit(usertypeName, permitName);
	}
	public void permitSetNewPermit(String usertypeName,String permitName)
	{
		//这里应该判断一下！！
		if(userPermisDao.findPermit(usertypeName, permitName)==false)
		{
			userPermisDao.insertPermit(usertypeName, permitName);
		}
		
	}
	// SET GET方法

	public UserDao getUserDao()
	{
		return userDao;
	}

	public void setUserDao(UserDao userDao)
	{
		this.userDao = userDao;
	}

	public UserPermisDao getUserPermisDao()
	{
		return userPermisDao;
	}

	public void setUserPermisDao(UserPermisDao userPermisDao)
	{
		this.userPermisDao = userPermisDao;
	}

	public UserTypeDao getUserTypeDao()
	{
		return userTypeDao;
	}

	public void setUserTypeDao(UserTypeDao userTypeDao)
	{
		this.userTypeDao = userTypeDao;
	}

}
