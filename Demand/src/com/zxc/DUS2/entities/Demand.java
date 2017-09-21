package com.zxc.DUS2.entities;

/**
 * Demand entity. @author MyEclipse Persistence Tools
 */

public class Demand implements java.io.Serializable
{

	// Fields

	private String demandId;
	private Unit unit;
	private String demandName;
	private Integer demandStart;
	private Integer demandEnd;
	private String demandMain;
	private String demandKey;
	private String demandTarget;
	private String demandKeyWord1;
	private String demandKeyWord2;
	private String demandKeyWord3;
	private String demandKeyWord4;
	private String demandKeyWord5;
	private String demandLoan;
	private String demandResearchMode;
	private String demandCooperationUnit;
	private String demandTechnology;
	private String demandClass3;
	private String demandDomain;
	private String demandEconomicClass3;
	private String unitstaffId1;
	private String unitstaffId2;
	private String demandState;
	private String auditopinion;
	private String auditdepartment;

	// Constructors

	/** default constructor */
	public Demand()
	{
	}

	/** minimal constructor */
	public Demand(String demandId, Unit unit, String demandName,
			Integer demandStart, Integer demandEnd, String demandMain,
			String demandKey, String demandTarget, String demandKeyWord1,
			String demandResearchMode, String demandTechnology,
			String demandState)
	{
		this.demandId = demandId;
		this.unit = unit;
		this.demandName = demandName;
		this.demandStart = demandStart;
		this.demandEnd = demandEnd;
		this.demandMain = demandMain;
		this.demandKey = demandKey;
		this.demandTarget = demandTarget;
		this.demandKeyWord1 = demandKeyWord1;
		this.demandResearchMode = demandResearchMode;
		this.demandTechnology = demandTechnology;
		this.demandState = demandState;
	}

	/** full constructor */
	public Demand(String demandId, Unit unit, String demandName,
			Integer demandStart, Integer demandEnd, String demandMain,
			String demandKey, String demandTarget, String demandKeyWord1,
			String demandKeyWord2, String demandKeyWord3,
			String demandKeyWord4, String demandKeyWord5, String demandLoan,
			String demandResearchMode, String demandCooperationUnit,
			String demandTechnology, String demandClass3, String demandDomain,
			String demandEconomicClass3, String unitstaffId1,
			String unitstaffId2, String demandState, String auditopinion,
			String auditdepartment)
	{
		this.demandId = demandId;
		this.unit = unit;
		this.demandName = demandName;
		this.demandStart = demandStart;
		this.demandEnd = demandEnd;
		this.demandMain = demandMain;
		this.demandKey = demandKey;
		this.demandTarget = demandTarget;
		this.demandKeyWord1 = demandKeyWord1;
		this.demandKeyWord2 = demandKeyWord2;
		this.demandKeyWord3 = demandKeyWord3;
		this.demandKeyWord4 = demandKeyWord4;
		this.demandKeyWord5 = demandKeyWord5;
		this.demandLoan = demandLoan;
		this.demandResearchMode = demandResearchMode;
		this.demandCooperationUnit = demandCooperationUnit;
		this.demandTechnology = demandTechnology;
		this.demandClass3 = demandClass3;
		this.demandDomain = demandDomain;
		this.demandEconomicClass3 = demandEconomicClass3;
		this.unitstaffId1 = unitstaffId1;
		this.unitstaffId2 = unitstaffId2;
		this.demandState = demandState;
		this.auditopinion = auditopinion;
		this.auditdepartment = auditdepartment;
	}

	// Property accessors

	public String getDemandId()
	{
		return this.demandId;
	}

	public void setDemandId(String demandId)
	{
		this.demandId = demandId;
	}

	public Unit getUnit()
	{
		return this.unit;
	}

	public void setUnit(Unit unit)
	{
		this.unit = unit;
	}

	public String getDemandName()
	{
		return this.demandName;
	}

	public void setDemandName(String demandName)
	{
		this.demandName = demandName;
	}

	public Integer getDemandStart()
	{
		return this.demandStart;
	}

	public void setDemandStart(Integer demandStart)
	{
		this.demandStart = demandStart;
	}

	public Integer getDemandEnd()
	{
		return this.demandEnd;
	}

	public void setDemandEnd(Integer demandEnd)
	{
		this.demandEnd = demandEnd;
	}

	public String getDemandMain()
	{
		return this.demandMain;
	}

	public void setDemandMain(String demandMain)
	{
		this.demandMain = demandMain;
	}

	public String getDemandKey()
	{
		return this.demandKey;
	}

	public void setDemandKey(String demandKey)
	{
		this.demandKey = demandKey;
	}

	public String getDemandTarget()
	{
		return this.demandTarget;
	}

	public void setDemandTarget(String demandTarget)
	{
		this.demandTarget = demandTarget;
	}

	public String getDemandKeyWord1()
	{
		return this.demandKeyWord1;
	}

	public void setDemandKeyWord1(String demandKeyWord1)
	{
		this.demandKeyWord1 = demandKeyWord1;
	}

	public String getDemandKeyWord2()
	{
		return this.demandKeyWord2;
	}

	public void setDemandKeyWord2(String demandKeyWord2)
	{
		this.demandKeyWord2 = demandKeyWord2;
	}

	public String getDemandKeyWord3()
	{
		return this.demandKeyWord3;
	}

	public void setDemandKeyWord3(String demandKeyWord3)
	{
		this.demandKeyWord3 = demandKeyWord3;
	}

	public String getDemandKeyWord4()
	{
		return this.demandKeyWord4;
	}

	public void setDemandKeyWord4(String demandKeyWord4)
	{
		this.demandKeyWord4 = demandKeyWord4;
	}

	public String getDemandKeyWord5()
	{
		return this.demandKeyWord5;
	}

	public void setDemandKeyWord5(String demandKeyWord5)
	{
		this.demandKeyWord5 = demandKeyWord5;
	}

	public String getDemandLoan()
	{
		return this.demandLoan;
	}

	public void setDemandLoan(String demandLoan)
	{
		this.demandLoan = demandLoan;
	}

	public String getDemandResearchMode()
	{
		return this.demandResearchMode;
	}

	public void setDemandResearchMode(String demandResearchMode)
	{
		this.demandResearchMode = demandResearchMode;
	}

	public String getDemandCooperationUnit()
	{
		return this.demandCooperationUnit;
	}

	public void setDemandCooperationUnit(String demandCooperationUnit)
	{
		this.demandCooperationUnit = demandCooperationUnit;
	}

	public String getDemandTechnology()
	{
		return this.demandTechnology;
	}

	public void setDemandTechnology(String demandTechnology)
	{
		this.demandTechnology = demandTechnology;
	}

	public String getDemandClass3()
	{
		return this.demandClass3;
	}

	public void setDemandClass3(String demandClass3)
	{
		this.demandClass3 = demandClass3;
	}

	public String getDemandDomain()
	{
		return this.demandDomain;
	}

	public void setDemandDomain(String demandDomain)
	{
		this.demandDomain = demandDomain;
	}

	public String getDemandEconomicClass3()
	{
		return this.demandEconomicClass3;
	}

	public void setDemandEconomicClass3(String demandEconomicClass3)
	{
		this.demandEconomicClass3 = demandEconomicClass3;
	}

	public String getUnitstaffId1()
	{
		return this.unitstaffId1;
	}

	public void setUnitstaffId1(String unitstaffId1)
	{
		this.unitstaffId1 = unitstaffId1;
	}

	public String getUnitstaffId2()
	{
		return this.unitstaffId2;
	}

	public void setUnitstaffId2(String unitstaffId2)
	{
		this.unitstaffId2 = unitstaffId2;
	}

	public String getDemandState()
	{
		return this.demandState;
	}

	public void setDemandState(String demandState)
	{
		this.demandState = demandState;
	}

	public String getAuditopinion()
	{
		return this.auditopinion;
	}

	public void setAuditopinion(String auditopinion)
	{
		this.auditopinion = auditopinion;
	}

	public String getAuditdepartment()
	{
		return this.auditdepartment;
	}

	public void setAuditdepartment(String auditdepartment)
	{
		this.auditdepartment = auditdepartment;
	}

}