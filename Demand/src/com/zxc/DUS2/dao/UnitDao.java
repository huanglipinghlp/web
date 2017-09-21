package com.zxc.DUS2.dao;

import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.ServletActionContext;
import org.hibernate.Query;

import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.User;

public class UnitDao extends BaseDao
{
	public Unit select(String userID){
		String hql = "FROM Unit d LEFT OUTER JOIN FETCH d.unitNumber " +
				"LEFT OUTER JOIN FETCH d.user where d.user.userID = '"+userID+"'";
		Query query = getSession().createQuery(hql);
		Unit unit = (Unit) query.uniqueResult();
		return unit;
	}
	//删除对象
	public void delUnit(String unitID)
	{
		String hql = "DELETE FROM Unit de WHERE de.unitID = ?";
		getSession().createQuery(hql).setString(0, unitID).executeUpdate();
	}
	//保存或修改对象
	public void saveOrUpdate(Unit de)
	{
		getSession().saveOrUpdate(de);
	}
	public void save(Unit de)
	{
		getSession().save(de);
	}
	public void setMyUnit(String userID)
	{// 在缓存中保存unit对象
		
		Unit unit=this.select(userID);
		HttpServletRequest request;
		request = ServletActionContext.getRequest();
		request.getSession().setAttribute("Unit", unit);
	}
	public Unit getMyUnit()
	{
		// 取出session的ID，
		HttpServletRequest request;
		request = ServletActionContext.getRequest();
		Unit unit = (Unit) request.getSession().getAttribute("Unit");
		return unit;
	}
}
