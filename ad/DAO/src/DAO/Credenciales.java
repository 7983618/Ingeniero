package DAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class Credenciales {
    private static Connection con;

    public static String getLink() {
        return "jdbc:mysql://localhost/empleados_departamentos";
    }

    public static String getUser() {
        return "root";
    }

    public static String getPassword() {
        return "1234";
    }

    public static Connection getConnection() throws SQLException {
        if (con == null) {
            con = DriverManager.getConnection(getLink(), getUser(), getPassword());
            PreparedStatement ps = con.prepareStatement("USE empleados_departamentos;");
            ps.executeUpdate();
        }
        return con;
    }
}
