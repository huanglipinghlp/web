package com.zxc.DUS2.action;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Unit;
import com.zxc.DUS2.entities.UnitNumber;
import com.zxc.DUS2.entities.User;
import com.zxc.DUS2.entities.UserType;
import com.zxc.DUS2.service.RegisterService;

public class RegisterAction extends ActionSupport implements RequestAware,
		ModelDriven<User>, Preparable
{
	private String userID;
	private UserType userType;
	private String userPwd;
	private String userName;
	private String perID;

	private String unitID;
	private String unitName;
	private String unitDepartment;
	private String unitAddress;
	private String unitCity;
	private String unitURL;
	private String unitEmail;
	private String unitLegalPeople;
	private String unitZipCode;
	private String unitContactPeople;
	private String unitPhone;
	private String unitMobilePhone;
	private String unitFax;
	private String unitAttribute;
	private String unitIntroduce;
	private String errorMess;
	
	private User model;

	private Map<String, Object> request;
	/* service */
	private RegisterService registerService;
	
	public String commonRegist()
	{
		// 先取外键
		userType = registerService.getUserTypeByRole("注册用户");
		try
		{
			// 实例化UnitNumber
			UnitNumber unitNumber = new UnitNumber(unitID, unitName);
			// 实例化User
			User user = new User(userID, userType, unitNumber, userPwd,
					userName, perID);

			// 实例化Unit
			Unit unit = new Unit(unitID, user, unitNumber, unitDepartment,
					unitAddress, unitCity, unitURL, unitEmail, unitLegalPeople,
					unitZipCode, unitContactPeople, unitPhone, unitMobilePhone,
					unitFax, unitAttribute, unitIntroduce);
			registerService.commonRegist(unitNumber, user, unit);
		} catch (Exception e)
		{
			System.out.println(e);
			setErrorMess(e.toString());
			return "error";
		}
		return "success";
	}

	// 注册的ajax验证
	public String registValidation() throws IOException
	{
		HttpServletRequest request = ServletActionContext.getRequest();
		String rUnitID = request.getParameter("unitID");
		String rUserID = request.getParameter("userID");
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setContentType("text/html; charset=UTF-8");
		PrintWriter out = response.getWriter();
		String data = "sussess";
		if (registerService.repeatUnit(rUnitID))
		{
			data = "repeatUnit";
		} else if (registerService.repeatUser(rUserID))
		{
			data = "repeatUser";
		}

		out.print(data);
		return null;
	}

	public String register()
	{
		return "register";
	}

	public String userAdd()
	{
		request.put("usertypes", registerService.getAllUserType());
		request.put("unitNums", registerService.getAllUnitNumber());
		return "userAddView";
	}

	public void prepareUserAdd()
	{
	}
	public String userAddSave()
	{
		Unit unit =new Unit();
		unit.setuser(model);
		unit.setUnitId(model.getUnitNumber().getUnitId());
		registerService.seniorRegist(model, unit);
		return "saveSuccess";
	}
	public void prepareUserAddSave()
	{
		model =new User();
	}
	/* GET SET */

	public String getErrorMess()
	{
		return errorMess;
	}

	public String getUserID()
	{
		return userID;
	}

	public void setUserID(String userID)
	{
		this.userID = userID;
	}

	public UserType getUserType()
	{
		return userType;
	}

	public void setUserType(UserType userType)
	{
		this.userType = userType;
	}

	public String getUserPwd()
	{
		return userPwd;
	}

	public void setUserPwd(String userPwd)
	{
		this.userPwd = userPwd;
	}

	public String getUserName()
	{
		return userName;
	}

	public void setUserName(String userName)
	{
		this.userName = userName;
	}

	public String getPerID()
	{
		return perID;
	}

	public void setPerID(String perID)
	{
		this.perID = perID;
	}

	public String getUnitID()
	{
		return unitID;
	}

	public void setUnitID(String unitID)
	{
		this.unitID = unitID;
	}

	public String getUnitName()
	{
		return unitName;
	}

	public void setUnitName(String unitName)
	{
		this.unitName = unitName;
	}

	public String getUnitDepartment()
	{
		return unitDepartment;
	}

	public void setUnitDepartment(String unitDepartment)
	{
		this.unitDepartment = unitDepartment;
	}

	public String getUnitAddress()
	{
		return unitAddress;
	}

	public void setUnitAddress(String unitAddress)
	{
		this.unitAddress = unitAddress;
	}

	public String getUnitCity()
	{
		return unitCity;
	}

	public void setUnitCity(String unitCity)
	{
		this.unitCity = unitCity;
	}

	public String getUnitURL()
	{
		return unitURL;
	}

	public void setUnitURL(String unitURL)
	{
		this.unitURL = unitURL;
	}

	public String getUnitEmail()
	{
		return unitEmail;
	}

	public void setUnitEmail(String unitEmail)
	{
		this.unitEmail = unitEmail;
	}

	public String getUnitLegalPeople()
	{
		return unitLegalPeople;
	}

	public void setUnitLegalPeople(String unitLegalPeople)
	{
		this.unitLegalPeople = unitLegalPeople;
	}

	public String getUnitZipCode()
	{
		return unitZipCode;
	}

	public void setUnitZipCode(String unitZipCode)
	{
		this.unitZipCode = unitZipCode;
	}

	public String getUnitContactPeople()
	{
		return unitContactPeople;
	}

	public void setUnitContactPeople(String unitContactPeople)
	{
		this.unitContactPeople = unitContactPeople;
	}

	public String getUnitPhone()
	{
		return unitPhone;
	}

	public void setUnitPhone(String unitPhone)
	{
		this.unitPhone = unitPhone;
	}

	public String getUnitMobilePhone()
	{
		return unitMobilePhone;
	}

	public void setUnitMobilePhone(String unitMobilePhone)
	{
		this.unitMobilePhone = unitMobilePhone;
	}

	public String getUnitFax()
	{
		return unitFax;
	}

	public void setUnitFax(String unitFax)
	{
		this.unitFax = unitFax;
	}

	public String getUnitAttribute()
	{
		return unitAttribute;
	}

	public void setUnitAttribute(String unitAttribute)
	{
		this.unitAttribute = unitAttribute;
	}

	public String getUnitIntroduce()
	{
		return unitIntroduce;
	}

	public void setUnitIntroduce(String unitIntroduce)
	{
		this.unitIntroduce = unitIntroduce;
	}

	public void setErrorMess(String errorMess)
	{
		this.errorMess = errorMess;
	}

	public RegisterService getRegisterService()
	{
		return registerService;
	}

	public void setRegisterService(RegisterService registerService)
	{
		this.registerService = registerService;
	}

	@Override
	public void prepare() throws Exception
	{
		// TODO Auto-generated method stub
		
	}

	@Override
	public User getModel()
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

}
