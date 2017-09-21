package com.zxc.DUS2.entities;

import java.util.HashSet;
import java.util.Set;

/**
 * UnitNumber entity. @author MyEclipse Persistence Tools
 */

public class UnitNumber implements java.io.Serializable
{

	// Fields

	private String unitId;
	private String unitName;
	private Set units = new HashSet(0);
	private Set users = new HashSet(0);

	// Constructors

	/** default constructor */
	public UnitNumber()
	{
	}

	/** minimal constructor */
	public UnitNumber(String unitId, String unitName)
	{
		this.unitId = unitId;
		this.unitName = unitName;
	}

	/** full constructor */
	public UnitNumber(String unitId, String unitName, Set units, Set users)
	{
		this.unitId = unitId;
		this.unitName = unitName;
		this.units = units;
		this.users = users;
	}

	// Property accessors

	public String getUnitId()
	{
		return this.unitId;
	}

	public void setUnitId(String unitId)
	{
		this.unitId = unitId;
	}

	public String getUnitName()
	{
		return this.unitName;
	}

	public void setUnitName(String unitName)
	{
		this.unitName = unitName;
	}

	public Set getUnits()
	{
		return this.units;
	}

	public void setUnits(Set units)
	{
		this.units = units;
	}

	public Set getusers()
	{
		return this.users;
	}

	public void setusers(Set users)
	{
		this.users = users;
	}

}