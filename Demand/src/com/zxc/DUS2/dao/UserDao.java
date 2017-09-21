package com.zxc.DUS2.dao;

import java.util.List;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.SessionAware;
import com.zxc.DUS2.entities.*;

public class UserDao extends BaseDao
{
	public User select(String userID)
	{

		String hql = "FROM User u where u.userID = '" + userID + "'";
		List<User> list = null;
		list = getSession().createQuery(hql).list();
		return list.get(0);

	}
	public List<User> getAll()
	{
		String hql = "FROM User u LEFT OUTER JOIN FETCH u.userType LEFT OUTER JOIN FETCH u.unitNumber";
		return getSession().createQuery(hql).list();
	}

	public String Login(String userID)
	{
		// System.out.println("UserDao:");
		/*
		 * System.out.println(user.getId()+":qqq"); session.put("ID",
		 * user.getId());//将登录用户的ID存在session中 //已放置在action中
		 */
		User user = select(userID);
		return user.getUserPwd();
	}

	public String getID(String userID)
	{
		User user = select(userID);
		return user.getUserID();
	}

	public String getUserType(String userID)
	{
		User user = select(userID);
		return user.getUserType().getUserTypeName();
	}

	public void setMyUser(String userID)
	{// 在缓存中保存user对象
		User user = select(userID);
		HttpServletRequest request;
		request = ServletActionContext.getRequest();
		request.getSession().setAttribute("User", user);
	}

	public User getMyUser()
	{
		// 取出session的ID，
		HttpServletRequest request;
		request = ServletActionContext.getRequest();
		User user = (User) request.getSession().getAttribute("User");
		return user;
	}

	// 删除对象
	public void delUser(String userID)
	{

		String hql = "DELETE FROM User u WHERE u.userID = ?";
		getSession().createQuery(hql).setString(0, userID).executeUpdate();
	}

	// 保存或更改
	public void saveOrUpdate(User user)
	{
		getSession().saveOrUpdate(user);
	}

	// 保存或更改
	public void save(User user)
	{
		getSession().save(user);
	}
}
