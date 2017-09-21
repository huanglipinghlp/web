package com.zxc.DUS2.service;

import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.ServletActionContext;

import com.zxc.DUS2.dao.UnitDao;
import com.zxc.DUS2.dao.UnitNumberDao;
import com.zxc.DUS2.dao.UserDao;
import com.zxc.DUS2.dao.UserTypeDao;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.UnitNumber;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserType;

public class UserService {

	private UserDao userDao;
	private UnitDao unitDao;
	private UserTypeDao userTypeDao;
	private UnitNumberDao unitNumberDao;
	public void setUserDao(UserDao userDao) {
		this.userDao = userDao;
	}
	public String saveOrUpdate(User user)
	{
		userDao.saveOrUpdate(user);
		return null;
	}
	public boolean login(String userID,String userPwd){
//		System.out.println("UserService:");
		String pws = userDao.Login(userID);
		if(pws.equals(userPwd))
		{
			//在缓存中存一个user对象
			userDao.setMyUser(userID);
			//在缓存中存一个unit对象
			unitDao.setMyUnit(userID);
			//Unit unit=unitDao.getMyUnit();
			//System.out.println("4556258258252:"+unit.getUnitLegalPeople());
			return true;
		}
		else
		{
			return false;
		}		
	}
	public User getUserByID(String userID)
	{
		return userDao.select(userID);
	}
	public String getID(String userID){
		return userDao.getID(userID);
	}
	
	public User getMyUser(){
		return userDao.getMyUser();
	}

	public void setUnitDao(UnitDao unitDao)
	{
		this.unitDao = unitDao;
	}
	public List<User> gelAllUser()
	{
		return userDao.getAll();
	}
	
}
