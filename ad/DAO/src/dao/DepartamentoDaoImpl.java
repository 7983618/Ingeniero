package dao;

import java.sql.*;

import model.Departamento;

public class DepartamentoDaoImpl implements DepartamentoDao {

	private static final String SQL_INSERT = 
			"INSERT INTO departamentos" +
			"(codDepto, nombreDpto, ciudad, codDirector)" + 
			"VALUES(?, ?, ?, ?);";
    private static final String SQL_SELECT = "SELECT codDepto, nombreDpto, ciudad, codDirector FROM departamentos WHERE codDepto = ?;";
	
	@Override
	public void create(Departamento departamento) {
		
		try (Connection conexion = DriverManager.getConnection(CredentialsDB.getConnection(),
				CredentialsDB.getUser(), CredentialsDB.getPassword()); 
                PreparedStatement sentencia = conexion.prepareStatement(SQL_INSERT);) {
        	
			sentencia.setString(1, departamento.getCodDepto());
			sentencia.setString(2, departamento.getNombreDpto());
			sentencia.setString(3, departamento.getCiudad());
			sentencia.setString(4, departamento.getCodDirector());
			
			sentencia.executeUpdate();

        } catch (SQLException cn) {
            cn.printStackTrace();
        }
		
	}
	
	@Override
	public Departamento read(String codDepartamento) {
        try (Connection conexion = DriverManager.getConnection(CredentialsDB.getConnection(),
                CredentialsDB.getUser(), CredentialsDB.getPassword());
             PreparedStatement sentencia = conexion.prepareStatement(SQL_SELECT);) {

            sentencia.setString(1, codDepartamento);
            ResultSet rs = sentencia.executeQuery();
            while(rs.next()) {
                return new Departamento(rs.getString("codDepto"), rs.getString("nombreDpto"), rs.getString("ciudad"), rs.getString("codDirector"));
            }

        } catch (SQLException cn) {
            cn.printStackTrace();
        }
        return null;
	}
	
	@Override
	public void update(Departamento departamento) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void delete(String codDepartamento){
		// TODO Auto-generated method stub
		
	}	

}
