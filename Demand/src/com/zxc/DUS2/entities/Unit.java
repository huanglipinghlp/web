package com.zxc.DUS2.entities;

import java.util.HashSet;
import java.util.Set;

/**
 * Unit entity. @author MyEclipse Persistence Tools
 */

public class Unit implements java.io.Serializable
{

	// Fields

	private String unitId;
	private User user;
	private UnitNumber unitNumber;
	private String unitDepartment;
	private String unitAddress;
	private String unitCity;
	private String unitUrl;
	private String unitEmail;
	private String unitLegalPeople;
	private String unitZipCode;
	private String unitContactPeople;
	private String unitPhone;
	private String unitMobilePhone;
	private String unitFax;
	private String unitAttribute;
	private String unitIntroduce;
	private Set demands = new HashSet(0);

	// Constructors

	/** default constructor */
	public Unit()
	{
	}

	/** minimal constructor */
	public Unit(String unitId, User user, UnitNumber unitNumber,
			String unitAddress, String unitCity, String unitEmail,
			String unitLegalPeople, String unitContactPeople,
			String unitMobilePhone, String unitAttribute, String unitIntroduce)
	{
		this.unitId = unitId;
		this.user = user;
		this.unitNumber = unitNumber;
		this.unitAddress = unitAddress;
		this.unitCity = unitCity;
		this.unitEmail = unitEmail;
		this.unitLegalPeople = unitLegalPeople;
		this.unitContactPeople = unitContactPeople;
		this.unitMobilePhone = unitMobilePhone;
		this.unitAttribute = unitAttribute;
		this.unitIntroduce = unitIntroduce;
	}

	/** full constructor */
	public Unit(String unitId, User user, UnitNumber unitNumber,
			String unitDepartment, String unitAddress, String unitCity,
			String unitUrl, String unitEmail, String unitLegalPeople,
			String unitZipCode, String unitContactPeople, String unitPhone,
			String unitMobilePhone, String unitFax, String unitAttribute,
			String unitIntroduce, Set demands)
	{
		this.unitId = unitId;
		this.user = user;
		this.unitNumber = unitNumber;
		this.unitDepartment = unitDepartment;
		this.unitAddress = unitAddress;
		this.unitCity = unitCity;
		this.unitUrl = unitUrl;
		this.unitEmail = unitEmail;
		this.unitLegalPeople = unitLegalPeople;
		this.unitZipCode = unitZipCode;
		this.unitContactPeople = unitContactPeople;
		this.unitPhone = unitPhone;
		this.unitMobilePhone = unitMobilePhone;
		this.unitFax = unitFax;
		this.unitAttribute = unitAttribute;
		this.unitIntroduce = unitIntroduce;
		this.demands = demands;
	}
	
	/*自定义构造器*/
	public Unit(String unitId, User user, UnitNumber unitNumber,
			String unitDepartment, String unitAddress, String unitCity,
			String unitUrl, String unitEmail, String unitLegalPeople,
			String unitZipCode, String unitContactPeople, String unitPhone,
			String unitMobilePhone, String unitFax, String unitAttribute,
			String unitIntroduce)
	{
		super();
		this.unitId = unitId;
		this.user = user;
		this.unitNumber = unitNumber;
		this.unitDepartment = unitDepartment;
		this.unitAddress = unitAddress;
		this.unitCity = unitCity;
		this.unitUrl = unitUrl;
		this.unitEmail = unitEmail;
		this.unitLegalPeople = unitLegalPeople;
		this.unitZipCode = unitZipCode;
		this.unitContactPeople = unitContactPeople;
		this.unitPhone = unitPhone;
		this.unitMobilePhone = unitMobilePhone;
		this.unitFax = unitFax;
		this.unitAttribute = unitAttribute;
		this.unitIntroduce = unitIntroduce;
	}
	
	
	// Property accessors
	
	public Unit(User user, UnitNumber unitNumber)
	{
		super();
		this.user = user;
		this.unitNumber = unitNumber;
	}

	public String getUnitId()
	{
		return this.unitId;
	}

	public void setUnitId(String unitId)
	{
		this.unitId = unitId;
	}

	public User getuser()
	{
		return this.user;
	}

	public void setuser(User user)
	{
		this.user = user;
	}

	public UnitNumber getUnitNumber()
	{
		return this.unitNumber;
	}

	public void setUnitNumber(UnitNumber unitNumber)
	{
		this.unitNumber = unitNumber;
	}

	public String getUnitDepartment()
	{
		return this.unitDepartment;
	}

	public void setUnitDepartment(String unitDepartment)
	{
		this.unitDepartment = unitDepartment;
	}

	public String getUnitAddress()
	{
		return this.unitAddress;
	}

	public void setUnitAddress(String unitAddress)
	{
		this.unitAddress = unitAddress;
	}

	public String getUnitCity()
	{
		return this.unitCity;
	}

	public void setUnitCity(String unitCity)
	{
		this.unitCity = unitCity;
	}

	public String getUnitUrl()
	{
		return this.unitUrl;
	}

	public void setUnitUrl(String unitUrl)
	{
		this.unitUrl = unitUrl;
	}

	public String getUnitEmail()
	{
		return this.unitEmail;
	}

	public void setUnitEmail(String unitEmail)
	{
		this.unitEmail = unitEmail;
	}

	public String getUnitLegalPeople()
	{
		return this.unitLegalPeople;
	}

	public void setUnitLegalPeople(String unitLegalPeople)
	{
		this.unitLegalPeople = unitLegalPeople;
	}

	public String getUnitZipCode()
	{
		return this.unitZipCode;
	}

	public void setUnitZipCode(String unitZipCode)
	{
		this.unitZipCode = unitZipCode;
	}

	public String getUnitContactPeople()
	{
		return this.unitContactPeople;
	}

	public void setUnitContactPeople(String unitContactPeople)
	{
		this.unitContactPeople = unitContactPeople;
	}

	public String getUnitPhone()
	{
		return this.unitPhone;
	}

	public void setUnitPhone(String unitPhone)
	{
		this.unitPhone = unitPhone;
	}

	public String getUnitMobilePhone()
	{
		return this.unitMobilePhone;
	}

	public void setUnitMobilePhone(String unitMobilePhone)
	{
		this.unitMobilePhone = unitMobilePhone;
	}

	public String getUnitFax()
	{
		return this.unitFax;
	}

	public void setUnitFax(String unitFax)
	{
		this.unitFax = unitFax;
	}

	public String getUnitAttribute()
	{
		return this.unitAttribute;
	}

	public void setUnitAttribute(String unitAttribute)
	{
		this.unitAttribute = unitAttribute;
	}

	public String getUnitIntroduce()
	{
		return this.unitIntroduce;
	}

	public void setUnitIntroduce(String unitIntroduce)
	{
		this.unitIntroduce = unitIntroduce;
	}

	public Set getDemands()
	{
		return this.demands;
	}

	public void setDemands(Set demands)
	{
		this.demands = demands;
	}

}