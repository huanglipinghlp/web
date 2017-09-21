package com.zxc.DUS2.service;

import java.util.List;

import com.zxc.DUS2.dao.UnitDao;
import com.zxc.DUS2.dao.UnitNumberDao;
import com.zxc.DUS2.dao.UserDao;
import com.zxc.DUS2.dao.UserTypeDao;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.UnitNumber;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserType;

public class RegisterService
{
	private UserDao userDao;
	private UnitDao unitDao;
	private UnitNumberDao unitNumberDao;
	private UserTypeDao userTypeDao;

	public String commonRegist(UnitNumber unitNum, User user, Unit unit)
	{
		// 1.在UnitNumber表里保存组织机构代码
		unitNumberDao.save(unitNum);
		// 2.在UserTable里保存用户账号信息
		userDao.save(user);
		// 3.在Unit表里保存单位信息
		unitDao.saveOrUpdate(unit);
		return null;
	}

	public UserType getUserTypeByRole(String userTypeName)
	{
		return userTypeDao.getByName(userTypeName);
	}

	// 验证是否已经存在，若存在则返回true
	public boolean repeatUser(String userID)
	{
		if (userDao.select(userID) == null)
			return false;
		else
			return true;
	}

	// 注册用户
	public void seniorRegist(User user, Unit unit)
	{

		// 1.在UserTable里保存用户账号信息
		userDao.save(user);
		// 2.在Unit表里保存单位信息
		unitDao.save(unit);
	}

	public boolean repeatUnit(String unitID)
	{
		if (unitDao.select(unitID) == null)
			return false;
		else
			return true;
	}

	public List<UserType> getAllUserType()
	{
		return userTypeDao.getAllType();
	}

	public List<UnitNumber> getAllUnitNumber()
	{
		return unitNumberDao.getAllUnitNumber();
	}

	/** GET SET **/
	public UserDao getUserDao()
	{
		return userDao;
	}

	public void setUserDao(UserDao userDao)
	{
		this.userDao = userDao;
	}

	public UnitDao getUnitDao()
	{
		return unitDao;
	}

	public void setUnitDao(UnitDao unitDao)
	{
		this.unitDao = unitDao;
	}

	public UnitNumberDao getUnitNumberDao()
	{
		return unitNumberDao;
	}

	public void setUnitNumberDao(UnitNumberDao unitNumberDao)
	{
		this.unitNumberDao = unitNumberDao;
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
