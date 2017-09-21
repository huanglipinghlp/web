package com.zxc.DUS2.dao;

import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.criterion.DetachedCriteria;
import org.hibernate.criterion.Restrictions;

import com.zxc.DUS2.entities.Demand;

public class DemandDao extends BaseDao
{
	public Demand getDemand(String demandId)
	{
		String hql = "FROM Demand d LEFT OUTER JOIN FETCH d.unit LEFT OUTER JOIN FETCH d.unit.unitNumber where d.demandId = '" + demandId + "'";
		List<Demand> list=getSession().createQuery(hql).list();
		if(list.size()>0)
			return list.get(0);
		else
			return null;
	}

	// 删除对象
	public void delDemand(String demandId)
	{
		String hql = "DELETE FROM Demand de WHERE de.demandId = ?";
		getSession().createQuery(hql).setString(0, demandId).executeUpdate();
	}

	// 保存或修改对象
	public void saveOrUpdate(Demand de)
	{
		getSession().saveOrUpdate(de);
	}

	public List<Demand> getMyDemand(String unitID)
	{
		String hql = "FROM Demand d LEFT OUTER JOIN FETCH d.unit where d.unit.unitId='"
				+ unitID + "'";
		return getSession().createQuery(hql).list();
	}
	public List<Demand> getByHql(String hql)
	{
		List<Demand> list=getSession().createQuery(hql).list();
		if(list.size()>0)
			return list;
		else
			return null;
	}

	public List<Demand> getSelectDemand(String institutionName,
			String technology, String department, String centralized,
			String location, String zt, String cooperation,
			String researchType, String attributes)
	{
		DetachedCriteria dc = DetachedCriteria.forClass(Demand.class);
		if (institutionName != null && institutionName != "")
		{
			//dc.add(Restrictions.eq("institutionName", institutionName));
			dc.add(Restrictions.like("institutionName","%"+ institutionName+"%"));
			System.out.println("机构名称:"+institutionName);
		}
		if (technology != null && technology != "")
		{
			System.out.println("技术需求名称:" + technology);
			dc.add(Restrictions.like("technology", "%"+ technology+"%"));
		}
		if (department != null && department != "")
		{
			dc.add(Restrictions.eq("department", department));
			System.out.println("管理部门：" + department);
		}
		if (centralized != null && centralized != "")
		{
			dc.add(Restrictions.eq("centralized", centralized));
			System.out.println("归口管理部门：" + centralized);
		}
		if (location != null && location != "")
		{
			dc.add(Restrictions.eq("location", location));
			System.out.println("所在地域：" + location);
		}
		if (zt != null && zt != "")
		{
			dc.add(Restrictions.eq("zt", zt));
			System.out.println("状态:" + zt);
		}
		if (cooperation != null && cooperation != "")
		{
			dc.add(Restrictions.eq("cooperation", cooperation));
			System.out.println("技术需求解决方式：" + cooperation);
		}
		if (researchType != null && researchType != "")
		{
			dc.add(Restrictions.eq("researchType", researchType));
			System.out.println("科技活动类型：" + researchType);
		}
		if (attributes != null && attributes != "")
		{
			dc.add(Restrictions.eq("attributes", attributes));
			System.out.println("机构属性：" + attributes);
		}
		Criteria c = dc.getExecutableCriteria(this.getSession());
		List<Demand> list = c.list();
		return list;
	}
}
