package com.zxc.DUS2.action;

import java.util.List;
import java.util.Map;

import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.UnitNumber;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.service.UnitService;

public class UnitInfAction extends ActionSupport implements RequestAware,
		ModelDriven<Unit>, Preparable
{

	private Map<String, Object> request;
	private Unit model;
	private UnitService unitService;

	public String unitInf()
	{
		return "unitInfView";
	}

	public void prepareUnitInf()
	{
		model =unitService.getMyUnit();
		
	}

	public String unitInfSet()
	{
		unitService.saveOrUpdate(model);
		return "unitInfView";
	}

	public String prepareUserInfSet()
	{
		return null;
	}

	@Override
	public void prepare() throws Exception
	{
		// TODO Auto-generated method stub

	}

	@Override
	public Unit getModel()
	{
		return model;
	}

	@Override
	public void setRequest(Map<String, Object> arg0)
	{
		this.request = arg0;

	}

	public UnitService getUnitService()
	{
		return unitService;
	}

	public void setUnitService(UnitService unitService)
	{
		this.unitService = unitService;
	}

}
