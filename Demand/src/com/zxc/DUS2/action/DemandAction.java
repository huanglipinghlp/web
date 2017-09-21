package com.zxc.DUS2.action;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.UnsupportedEncodingException;
import java.sql.Date;
import java.util.List;
import java.util.Map;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionContext;
import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Demand;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.service.DemandService;
import com.zxc.DUS2.service.UnitService;
import com.zxc.DUS2.service.UserService;

public class DemandAction extends ActionSupport implements RequestAware,
		ModelDriven<Demand>, Preparable
{
	private Demand model;
	private Map<String, Object> request;
	private UnitService unitService;
	private DemandService demandService;
	private String demandId;
	private UserService userService;
	private InputStream inputStream;
	public String addDemand()
	{
		
		Unit unit = unitService.getMyUnit();
		request.put("unit", unit);
		// System.out.println("20170502"+unit.getUnitAddress());
		return "demandAdd";
	}

	public void prepareAddDemand()
	{
		model = new Demand();
	}

	public String save()
	{
		Unit unit = unitService.getMyUnit();
		model.setUnit(unit);
		demandService.saveNew(model);
		return "save";
	}

	public void prepareSave()
	{
		model = new Demand();
	}
	
	public String saveE()
	{
		demandService.saveNew(model);
		return "save";
	}

	public void prepareSaveE()
	{
		model = demandService.getD(demandId);
	}

	public String myDemand()
	{
		Unit unit = unitService.getMyUnit();
		String unitID = unit.getUnitId();
		request.put("demands", demandService.getMyDemands(unitID));
		return "demandsList";
	}

	public String selectDemand()
	{
		return "selDemand";
	}
	
	public String search() throws IOException
	{
		String searchCon =new String( getParam("searchCon").getBytes("ISO-8859-1"),"UTF-8");//接收条件
		//System.out.println("!!!!!!!!!!!!!!!!!!!!!!"+searchCon);
		List<Demand> demands =demandService.getData(searchCon);
		request.put("demands", demands);
		return "success";
	}

	public String search1() throws IOException
	{
		String name =new String( getParam("name").getBytes("ISO-8859-1"),"UTF-8");//接收条件
		System.out.println(name);
		//System.out.println("!!!!!!!!!!!!!!!!!!!!!!"+searchCon);
		List<Demand> demands =demandService.getData1(name);
		request.put("demands", demands);
		return "selectdemand";
	}
	private String getParam(String key)
	{
		return ServletActionContext.getRequest().getParameter(key);
	}

	public String select()
	{
		String institutionName = new String();
		institutionName = getParam("institutionName");
		// System.out.println("机构名称:"+institutionName);
		String technology = new String();
		technology = getParam("technology");
		// System.out.println("技术需求名称:"+technology);
		String department = new String();
		department = getParam("department");
		// System.out.println("管理部门："+department);
		String centralized = new String();
		centralized = getParam("centralized");
		// System.out.println("归口管理部门："+centralized);
		String location = new String();
		location = getParam("location");
		// System.out.println("所在地域："+location);
		String zt = new String();
		zt = getParam("zt");
		// System.out.println("状态:"+zt);
		String cooperation = new String();
		cooperation = getParam("cooperation");
		// System.out.println("技术需求解决方式："+cooperation);
		String researchType = new String();
		researchType = getParam("researchType");
		// System.out.println("科技活动类型："+researchType);
		String attributes = new String();
		attributes = getParam("attributes");
		// System.out.println("机构属性："+attributes);
		/**/
		if (institutionName != null && institutionName != "")
		{
			System.out.println("机构名称:" + institutionName);
		}
		if (technology != null && technology != "")
		{
			System.out.println("技术需求名称:" + technology);
		}
		if (department != null && department != "")
		{
			System.out.println("管理部门：" + department);
		}
		if (centralized != null && centralized != "")
		{
			System.out.println("归口管理部门：" + centralized);
		}
		if (location != null && location != "'")
		{
			System.out.println("所在地域：" + location);
		}
		if (zt != null && zt != "")
		{
			System.out.println("状态:" + zt);
		}
		if (cooperation != null && cooperation != "")
		{
			System.out.println("技术需求解决方式：" + cooperation);
		}
		if (researchType != null && researchType != "")
		{
			System.out.println("科技活动类型：" + researchType);
		}
		if (attributes != null && attributes != "")
		{
			System.out.println("机构属性：" + attributes);
		}
		List<Demand> requirements = demandService.querySomeRequirements(
				institutionName, technology, department, centralized, location,
				zt, cooperation, researchType, attributes);
		Map request = (Map) ActionContext.getContext().get("request");
		request.put("requirements", requirements);
		return null;
	}
	
	public String show()
	{
		return "show";
	}
	public void prepareShow()
	{
		String id = getParam("demandId");
		model=demandService.getD(id);
	}
	public String edit()
	{
		return "demandAdd2";
	}
	public void prepareEdit()
	{
		model=demandService.getD(demandId);
	}
	public String delete()
	{
		try
		{
			demandService.delDemand(demandId);

			inputStream = new ByteArrayInputStream("1".getBytes("UTF-8"));
		} catch (Exception e)
		{
			e.printStackTrace();
			try
			{
				inputStream = new ByteArrayInputStream("0".getBytes("UTF-8"));
			} catch (UnsupportedEncodingException e1)
			{
				e1.printStackTrace();
			}
		}
		return "delete";
	}
	//需求审核
	//形式审核
	public String formatAuditJu()
	{
		//装载
		request.put("demands", demandService.getForDemand());
		return "forAuditList";
	}
	public String forAuShow()
	{
		return "forAuShow";
	}
	public void prepareForAuShow()
	{
		model=demandService.getD(demandId);
	}
	public String formatAudit()
	{
		String demandState = getParam("demandState");
		System.out.println(demandState);
		String auditdepartment = getParam("auditdepartment");
		if(auditdepartment!=null)
			model.setAuditdepartment(auditdepartment);
		model.setDemandState(demandState);
		User u=userService.getMyUser();
		model.setUnitstaffId1(u.getUserID());
		demandService.saveNew(model);
		return "formatAudit";
	}
	public void prepareFormatAudit()
	{
		model=demandService.getD(demandId);
	}
	//业务审核
	public String departmentAuditJu()
	{
		Unit unit = unitService.getMyUnit();
		String dep=unit.getUnitNumber().getUnitName();
		request.put("demands", demandService.getDeDemand(dep));
		return "deAuditList";
	}
	public String deAuShow()
	{
		return "deAuShow";
	}
	public void prepareDeAuShow()
	{
		model=demandService.getD(demandId);
	}
	public String deAudit()
	{
		String demandState = getParam("demandState");
		System.out.println(demandState);
		String auditopinion = getParam("auditopinion");
		if(auditopinion!=null)
			model.setAuditopinion(auditopinion);
		model.setDemandState(demandState);
		User u=userService.getMyUser();
		model.setUnitstaffId2(u.getUserID());
		demandService.saveNew(model);
		return "deAudit";
	}
	public void prepareDeAudit()
	{
		model=demandService.getD(demandId);
	}
	
	
	///****************************
	public UnitService getUnitService()
	{
		return unitService;
	}

	public void setUnitService(UnitService unitService)
	{
		this.unitService = unitService;
	}

	public DemandService getDemandService()
	{
		return demandService;
	}

	public void setDemandService(DemandService demandService)
	{
		this.demandService = demandService;
	}


	public String getDemandId()
	{
		return demandId;
	}

	public void setDemandId(String demandId)
	{
		this.demandId = demandId;
	}

	/* / */
	@Override
	public void prepare() throws Exception
	{
	}

	@Override
	public Demand getModel()
	{
		// TODO Auto-generated method stub
		return model;
	}

	@Override
	public void setRequest(Map<String, Object> arg0)
	{
		// TODO Auto-generated method stub
		this.request = arg0;
	}

	public UserService getUserService()
	{
		return userService;
	}

	public void setUserService(UserService userService)
	{
		this.userService = userService;
	}

	public InputStream getInputStream()
	{
		return inputStream;
	}

	public void setInputStream(InputStream inputStream)
	{
		this.inputStream = inputStream;
	}
	
}
