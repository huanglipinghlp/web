package com.zxc.DUS2.entities;

import java.util.HashSet;
import java.util.Set;

/**
 * UserTable entity. @author MyEclipse Persistence Tools
 */

public class User implements java.io.Serializable
{

	// Fields

	private String userID;
	private UserType userType;
	private UnitNumber unitNumber;
	private String userPwd;
	private String userName;
	private String perId;
	private Set units = new HashSet(0);

	// Constructors

	/** default constructor */
	public User()
	{
	}

	/** minimal constructor */
	public User(String userID, UserType userType, UnitNumber unitNumber,
			String userPwd, String userName, String perId)
	{
		this.userID = userID;
		this.userType = userType;
		this.unitNumber = unitNumber;
		this.userPwd = userPwd;
		this.userName = userName;
		this.perId = perId;
	}

	/** full constructor */
	public User(String userID, UserType userType, UnitNumber unitNumber,
			String userPwd, String userName, String perId, Set units)
	{
		this.userID = userID;
		this.userType = userType;
		this.unitNumber = unitNumber;
		this.userPwd = userPwd;
		this.userName = userName;
		this.perId = perId;
		this.units = units;
	}

	// Property accessors

	public String getUserID()
	{
		return this.userID;
	}

	public void setUserID(String userID)
	{
		this.userID = userID;
	}

	public UserType getUserType()
	{
		return this.userType;
	}

	public void setUserType(UserType userType)
	{
		this.userType = userType;
	}

	public UnitNumber getUnitNumber()
	{
		return this.unitNumber;
	}

	public void setUnitNumber(UnitNumber unitNumber)
	{
		this.unitNumber = unitNumber;
	}

	public String getUserPwd()
	{
		return this.userPwd;
	}

	public void setUserPwd(String userPwd)
	{
		this.userPwd = userPwd;
	}

	public String getUserName()
	{
		return this.userName;
	}

	public void setUserName(String userName)
	{
		this.userName = userName;
	}

	public String getPerId()
	{
		return this.perId;
	}

	public void setPerId(String perId)
	{
		this.perId = perId;
	}

	public Set getUnits()
	{
		return this.units;
	}

	public void setUnits(Set units)
	{
		this.units = units;
	}

}