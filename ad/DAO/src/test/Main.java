package test;

import dao.DepartamentoDao;
import dao.DepartamentoDaoImpl;
import model.Departamento;

import java.sql.SQLException;
import java.util.Scanner;

public class Main {
    static DepartamentoDao departamentoDao = new DepartamentoDaoImpl();
    public static void main(String args[]) throws SQLException {
		Departamento departamento = crearDepartamento();
        actualizarDepartamento(departamento);
        leerDepartamento(departamento);
        borrarDepartamento(departamento);

	}
    public static Departamento crearDepartamento() {


        Departamento departamento = new Departamento();
        departamento.setNombreDpto("Clase 2DAM");
        departamento.setCodDepto("2DAM");
        departamento.setCodDirector("31.840.269");
        departamento.setCiudad("Murcia");

        departamentoDao.create(departamento);

        System.out.println("CREACIÓN");
        System.out.println(departamento.toString());
        esperar();

        return  departamento;
    }
    public static void actualizarDepartamento(Departamento departamento) {
        departamentoDao.update(departamento, "Clase Modificada");

        System.out.println("ACTUALIZADO CAMPO");
    }

    public static void leerDepartamento(Departamento departamento) throws SQLException {
        System.out.printf("LEER DEPARTAMENTO YA MODIFICADO");
        System.out.println(departamentoDao.read(departamento.getCodDepto()).toString());
        esperar();
    }

    public static void borrarDepartamento(Departamento departamento) {
        System.out.println("BORRAR DEPARTAMENTO");
        departamentoDao.delete(departamento.getCodDepto());
    }

    public static void esperar() {
        System.out.printf("PULSE ENTER PARA CONTINUAR");
        new Scanner(System.in).nextLine();
    }
}
