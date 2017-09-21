package com.zxc.DUS2.service;

import com.zxc.DUS2.dao.UnitDao;
import com.zxc.DUS2.entities.Unit;

public class UnitService
{
	private UnitDao unitDao;
	public void setUnitDao(UnitDao unitDao)
	{
		this.unitDao = unitDao;
	}
	public void saveOrUpdate(Unit unit)
	{
		unitDao.saveOrUpdate(unit);
	}
	public Unit getMyUnit()
	{

		//Unit unit=unitDao.getMyUnit();
		//System.out.println("测试数据:"+unit.getUnitId());
		
		//return unit;
		return unitDao.getMyUnit();
	}
	public Unit getUnitById(String userID)
	{
		return unitDao.select(userID);
	}
	
}
