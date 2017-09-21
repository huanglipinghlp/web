package com.zxc.DUS2.dao;
import java.util.List;

import com.zxc.DUS2.entities.*;
public class UserPermisDao extends BaseDao
{
	@SuppressWarnings("null")
	public List<UserPermis> getPermis(String userTypeName){
		//System.out.println("开始执行DAO");
		String hql = "FROM UserPermis up where up.userTypeName = '"+userTypeName+"'";
		List<UserPermis> list=getSession().createQuery(hql).list();
		//System.out.println("第一条权限："+list1.get(0).getPermission());
		return list;
	}
	public void delPermit(String usertypeName,String permitName)
	{
		String hql = "FROM UserPermis up where " +
				"up.userTypeName = '"+usertypeName+"' " +
				"and up.permission = '"+permitName+"'";
		List<UserPermis> list=getSession().createQuery(hql).list();
		if(list.size()>0)
		{
			UserPermis u =list.get(0);
			getSession().delete(u);
		}
		
	}
	public boolean findPermit(String usertypeName,String permitName)
	{
		String hql = "FROM UserPermis up where " +
				"up.userTypeName = '"+usertypeName+"' " +
				"and up.permission = '"+permitName+"'";
		List<UserPermis> list=getSession().createQuery(hql).list();
		if(list.size()>0)
			return true;
		else
			return false;
	}
	public void insertPermit(String usertypeName,String permitName)
	{
		UserPermis u =new UserPermis();
		u.setUserTypeName(usertypeName);
		u.setPermission(permitName);
		
		getSession().save(u);
	}
}
