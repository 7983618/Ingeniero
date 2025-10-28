package dao;

public class CredentialsDB {
	public static String getConnection() {
		return "jdbc:mysql://localhost/empleados_departamentos";
	}
	
	public static String getUser() {
		return "root";
	}
	
	public static String getPassword() {
		return "1234";
	}
}
