package com.zxc.DUS2.dao;

import java.util.List;

import com.zxc.DUS2.entities.UnitNumber;

public class UnitNumberDao extends BaseDao
{
	public List<UnitNumber> getUnitNumber(String unitId)
	{
		String hql = "FROM UnitNumber d where d.unitId = '"
				+ unitId + "'";
		return getSession().createQuery(hql).list();
	}
	public List<UnitNumber> getAllUnitNumber()
	{
		String hql = "FROM UnitNumber";
		return getSession().createQuery(hql).list();
	}
	// 插入对象

	// 删除对象
	public void delUnitNumber(String unitId)
	{
		String hql = "DELETE FROM UnitNumber de WHERE de.unitId = ?";
		getSession().createQuery(hql).setString(0, unitId)
				.executeUpdate();
	}

	// 保存或修改对象
	public void saveOrUpdate(UnitNumber de)
	{
		getSession().saveOrUpdate(de);
	}// 保存或修改对象

	public void save(UnitNumber de)
	{
		getSession().save(de);
	}
}
