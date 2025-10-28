package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import model.Departamento;

public class DepartamentoDaoImpl implements DepartamentoDao {

	private static final String SQL_INSERT = 
			"INSERT INTO departamentos" +
			"(codDepto, nombreDpto, ciudad, codDirector)" + 
			"VALUES(?, ?, ?, ?);";
	
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
		// TODO Auto-generated method stub
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
