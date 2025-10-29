package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class CredencialesCasa {
    public static String url = "jdbc:mysql://localhost/empleados_departamentos";
    public static String user = "root";
    public static String password = "mi_contraseña";
    public static String bd = "empleados_departamentos;";

    public static Connection connection;

    public static Connection connectionClase;

    public static Connection getConnection() throws SQLException {
        if (connection == null) {
            connection = DriverManager.getConnection(url, user, password);
            PreparedStatement preparedStatement = connection.prepareStatement("USE " + bd);
            preparedStatement.executeUpdate();
        }
        return connection;
    }

    public static Connection getConnectionClase() throws SQLException {
        if (connectionClase == null) {
            connectionClase = DriverManager.getConnection(CredentialsDB.getConnection(), CredentialsDB.getUser(), CredentialsDB.getPassword());
            PreparedStatement preparedStatement = connection.prepareStatement("USE " + bd);
            preparedStatement.executeUpdate();
        }
        return connectionClase;
    }
}
