package dao;

import model.Departamento;

import java.sql.SQLException;

public interface DepartamentoDao {
	 void create(Departamento departamento);
	 Departamento read(String codDepartamento) throws SQLException;
	 void update(Departamento departamento, String mombre);
	 void delete(String codDepartamento);
}
