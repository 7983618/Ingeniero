package dao;

import model.Departamento;

public interface DepartamentoDao {
	 void create(Departamento departamento);
	 Departamento read(String codDepartamento);
	 void update(Departamento departamento);
	 void delete(String codDepartamento);
}
