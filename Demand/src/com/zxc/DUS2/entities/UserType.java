package com.zxc.DUS2.entities;

import java.util.HashSet;
import java.util.Set;

/**
 * UserType entity. @author MyEclipse Persistence Tools
 */

public class UserType implements java.io.Serializable
{

	// Fields

	private String userTypeName;
	private Set users = new HashSet(0);

	// Constructors

	/** default constructor */
	public UserType()
	{
	}

	/** minimal constructor */
	public UserType(String userTypeName)
	{
		this.userTypeName = userTypeName;
	}

	/** full constructor */
	public UserType(String userTypeName, Set users)
	{
		this.userTypeName = userTypeName;
		this.users = users;
	}

	// Property accessors

	public String getUserTypeName()
	{
		return this.userTypeName;
	}

	public void setUserTypeName(String userTypeName)
	{
		this.userTypeName = userTypeName;
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