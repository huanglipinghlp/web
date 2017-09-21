package com.zxc.DUS2.entities;

/**
 * UserPermis entity. @author MyEclipse Persistence Tools
 */

public class UserPermis implements java.io.Serializable
{

	// Fields

	private String userPermisId;
	private String userTypeName;
	private String permission;

	// Constructors

	/** default constructor */
	public UserPermis()
	{
	}

	/** minimal constructor */
	public UserPermis(String userPermisId)
	{
		this.userPermisId = userPermisId;
	}

	/** full constructor */
	public UserPermis(String userPermisId, String userTypeName,
			String permission)
	{
		this.userPermisId = userPermisId;
		this.userTypeName = userTypeName;
		this.permission = permission;
	}

	// Property accessors

	public UserPermis(String userTypeName, String permission)
	{
		super();
		this.userTypeName = userTypeName;
		this.permission = permission;
	}

	public String getUserPermisId()
	{
		return this.userPermisId;
	}

	public void setUserPermisId(String userPermisId)
	{
		this.userPermisId = userPermisId;
	}

	public String getUserTypeName()
	{
		return this.userTypeName;
	}

	public void setUserTypeName(String userTypeName)
	{
		this.userTypeName = userTypeName;
	}

	public String getPermission()
	{
		return this.permission;
	}

	public void setPermission(String permission)
	{
		this.permission = permission;
	}

	@Override
	public String toString()
	{
		return "UserPermis [userPermisId=" + userPermisId + ", userTypeName="
				+ userTypeName + ", permission=" + permission + "]";
	}
	
}