package com.zxc.DUS2.service;

import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;

import com.zxc.DUS2.dao.DemandDao;
import com.zxc.DUS2.entities.Demand;

public class DemandService
{
	private DemandDao demandDao;

	public DemandDao getDemandDao()
	{
		return demandDao;
	}

	public void setDemandDao(DemandDao demandDao)
	{
		this.demandDao = demandDao;
	}

	public void saveNew(Demand d)
	{
		demandDao.saveOrUpdate(d);
	}

	public Demand getD(String id)
	{
		return demandDao.getDemand(id);
	}
	public void delDemand(String id)
	{
		demandDao.delDemand(id);
	}

	public List<Demand> getMyDemands(String unitID)
	{
		return demandDao.getMyDemand(unitID);
	}

	public List<Demand> querySomeRequirements(String institutionName,
			String technology, String department, String centralized,
			String location, String zt, String cooperation,
			String researchType, String attributes)
	{
		return demandDao.getSelectDemand(institutionName, technology,
				department, centralized, location, zt, cooperation,
				researchType, attributes);
	}
	public List<Demand> getForDemand()
	{
		String hql = "FROM Demand d LEFT OUTER JOIN FETCH d.unit where d.demandState='提交'";
		return demandDao.getByHql(hql);
	}
	public List<Demand> getDeDemand(String department)
	{
		String hql = "FROM Demand d LEFT OUTER JOIN FETCH d.unit where d.demandState='形式审核通过'" +
				" and d.auditdepartment='"+ department + "'";
		return demandDao.getByHql(hql);
	}
	public List<Demand> getData(String searchCon)
	{
		// TODO Auto-generated method stub
		// 根据选择的查询条件拼装出对应的字符串
		String hql = getHql(searchCon);
		return demandDao.getByHql(hql);
	}
	public List<Demand> getData1(String name)
	{
		// TODO Auto-generated method stub
		// 根据选择的查询条件拼装出对应的字符串
		String hql = "FROM Demand d where d.demandClass3 = '"+name+"'";
		return demandDao.getByHql(hql);
	}
	

	// 根据传过来的行业编号和查询条件来拼接hql语句
	public String getHql(String searchCon)
	{
		String hql = "from Demand d LEFT OUTER JOIN FETCH d.unit LEFT OUTER JOIN FETCH d.unit.unitNumber where ";
		// 根据查询条件来拼装 前台传过来的数据格式为 机构全称,1,精确;0,机构全称,1,精确;
		// 保存查询条件的数组 这里为什么要定义成final类型的呢
		// @SuppressWarnings("serial")
		Map<String, String> conditionNameMap = new HashMap<String, String>();
		conditionNameMap.put("机构全称", "unit.unitNumber.unitName");
		conditionNameMap.put("归口管理部门", "unit.unitDepartment");
		conditionNameMap.put("所在地域", "unit.unitCity");
		conditionNameMap.put("法人代表", "unit.unitLegalPeople");
		conditionNameMap.put("联系人", "unit.unitContactPeople");
		conditionNameMap.put("机构属性", "unit.unitAttribute");
		conditionNameMap.put("技术需求名称", "demandName");
		conditionNameMap.put("技术需求所属领域 ", "demandEconomicClass3");
		// 先把每一项拆分出来 前台传递过来的字符串为 机构全称,1,精确;0,机构全称,1,精确;
		String[] searchArray = searchCon.substring(0, searchCon.length() - 1)
				.split(";");
		// 第一项不能加and
		// 在第一项的内部进行拆分
		String[] itemF = searchArray[0].split(",");
		// 遍历HashMap的固定格式
		Iterator itF = conditionNameMap.entrySet().iterator();
		while (itF.hasNext())
		{
			Entry cNameEntry = (Entry) itF.next();
			String key = cNameEntry.getKey().toString();
			// 查询字段匹配
			if (key.equals(itemF[1]))
			{
				String value = cNameEntry.getValue().toString();
				// 精确查询
				if ("精确".equals(itemF[3]))
				{
					// and
					if ("0".equals(itemF[0]))
					{
						hql += "d." + value + " = '" + itemF[2] + "' ";
					}
					// or
					else if ("1".equals(itemF[0]))
					{
						hql += "d." + value + " = '" + itemF[2] + "' ";
					}
					// 不等于
					else if ("2".equals(itemF[0]))
					{
						hql += "d." + value + " <> '" + itemF[2]
								+ "' ";
					}
				}
				// 模糊查询
				else
				{
					// and
					if ("0".equals(itemF[0]))
					{
						hql += "d." + value + " like '%" + itemF[2]
								+ "%' ";
					}
					// or
					else if ("1".equals(itemF[0]))
					{
						hql += "d." + value + " like '%" + itemF[2]
								+ "%' ";
					}
					// 不等于
					else if ("2".equals(itemF[0]))
					{
						hql += "d." + value + " like '%" + itemF[2]
								+ "%' ";
					}
				}
			}
		}
		
		for (int i = 1; i < searchArray.length; i++)
		{
			// 在每一项的内部进行拆分
			String[] item = searchArray[i].split(",");
			// 遍历HashMap的固定格式
			Iterator it = conditionNameMap.entrySet().iterator();
			while (it.hasNext())
			{
				Entry cNameEntry = (Entry) it.next();
				String key = cNameEntry.getKey().toString();
				// 查询字段匹配
				if (key.equals(item[1]))
				{
					String value = cNameEntry.getValue().toString();
					// 精确查询
					if ("精确".equals(item[3]))
					{
						// and
						if ("0".equals(item[0]))
						{
							hql += "and d." + value + " = '" + item[2]
									+ "' ";
						}
						// or
						else if ("1".equals(item[0]))
						{
							hql += "or d." + value + " = '" + item[2]
									+ "' ";
						}
						// 不等于
						else if ("2".equals(item[0]))
						{
							hql += "and d." + value + " <> '" + item[2]
									+ "' ";
						}
					}
					// 模糊查询
					else
					{
						// and
						if ("0".equals(item[0]))
						{
							hql += "and d." + value + " like '%"
									+ item[2] + "%' ";
						}
						// or
						else if ("1".equals(item[0]))
						{
							hql += "or d." + value + " like '%" + item[2]
									+ "%' ";
						}
						// 不等于
						else if ("2".equals(item[0]))
						{
							hql += "and d." + value + " like '%"
									+ item[2] + "%' ";
						}
					}
				}
			}
		}
		System.out.println("使用查询条件拼装后的hql语句为" + hql);
		return hql;
	}
}
