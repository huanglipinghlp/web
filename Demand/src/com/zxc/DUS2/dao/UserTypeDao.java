package com.zxc.DUS2.dao;

import java.util.List;

import com.zxc.DUS2.entities.UserType;

public class UserTypeDao extends BaseDao
{
	public List<UserType> getAllType(){
		String hql = "FROM UserType";
		return getSession().createQuery(hql).list();
	}
	public UserType getByName(String userTypeName)
	{
		String hql = "FROM UserType ut where ut.userTypeName='"+userTypeName+"'";
		List<UserType> list=null;
		list=getSession().createQuery(hql).list();
		return list.get(0);
	}
	public void save(UserType userType)
	{
		getSession().save(userType);
	}
}
