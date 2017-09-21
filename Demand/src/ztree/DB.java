package ztree;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.List;
import java.util.Map;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.interceptor.RequestAware;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import com.opensymphony.xwork2.Preparable;
import com.zxc.DUS2.entities.Demand;

/*
 *
 *
 */

public class DB extends ActionSupport{
	@Override
	public String execute() throws Exception {
		// TODO Auto-generated method stub
		int size = getCount();
		josn(size);
		return NONE;
	}

	private Demand model;
	private Map<String, Object> request;
	public static String db_url = "jdbc:sqlserver://localhost:1433;databaseName=Demand";
	public static String db_user = "sa";
	public static String db_password = "sql";

	// 打开链接
	public static Connection getConn() {
		Connection conn = null;
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			conn = DriverManager.getConnection(db_url, db_user, db_password);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return conn;
	}

	// 关闭连接
	public static void close(Statement state, Connection conn) {
		if (state != null) {
			try {
				state.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		if (conn != null) {
			try {
				conn.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}

	public static void close(ResultSet rs, Statement state, Connection conn) {
		if (rs != null) {
			try {
				rs.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		if (state != null) {
			try {
				state.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		if (conn != null) {
			try {
				conn.close();
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}

	public static ResultSet first() {
		Connection con = getConn();
		Statement stmt = null;
		ResultSet rs = null;
		String SQL = "select * from treexueke where pid=0";
		try {
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);
			/*
			 * while (rs.next()) { System.out.println(rs.getString(1) + ",," +
			 * rs.getString(3) + ",,," + rs.getString(4)); }
			 */
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}

	public static ResultSet second() {
		Connection con = getConn();
		Statement stmt = null;
		ResultSet rs = null;
		String SQL = "select * from treexueke where pid <> 0 and code like '%00'";
		try {
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);
			while (rs.next()) {
				System.out.println(rs.getString(1) + ",," + rs.getString(3)
						+ ",,," + rs.getString(4));
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}

	public static ResultSet third() {
		Connection con = getConn();
		Statement stmt = null;
		ResultSet rs = null;
		String SQL = "select * from treexueke where pid <> 0 and code not like '%00'";
		try {
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);
			while (rs.next()) {
				System.out.println(rs.getString(1) + ",," + rs.getString(3)
						+ ",,," + rs.getString(4));
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}

	public static ResultSet all() {
		Connection con = getConn();
		Statement stmt = null;
		ResultSet rs = null;
		String SQL = "select * from treexueke";
		try {
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;

	}

	public static int getCount() {
		Connection con = getConn();
		Statement stmt = null;
		ResultSet rs = null;
		int size = 0;
		String SQL = "select * from treexueke";
		try {
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);
			while (rs.next()) {
				size++;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		close(rs, stmt, con);
		return size;
	}

	public static void josn(int size) {
		StringBuffer josnstring = new StringBuffer();
		System.out.println(size);
		josnstring.append("[");
		ResultSet list = all();

		try {
			while (list.next()) {
				size--;
				josnstring.append("{\"id\":\"").append(list.getString(3));
				josnstring.append("\",\"pId\":\"").append(list.getString(4));
				josnstring.append("\",\"name\":\"").append(list.getString(2));
				josnstring.append("\"}");
			
				if (size > 0) {
					josnstring.append(",");
				}
			}
			josnstring.append("]");
			HttpServletResponse response = ServletActionContext.getResponse();

			response.setContentType("application/json;charset=UTF-8");
			response.setHeader("Cache-Control", "no-cache");
			response.getWriter().write(josnstring.toString());

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		int size = getCount();
		josn(size);
	}

	
}
