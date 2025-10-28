package Model;

import java.sql.Timestamp;

public class Empleado {
    private int codigo;
    private String nombre;
    private String sexo;
    private Timestamp nacimiento;
    private Timestamp incorporacion;
    private double salario;
    private double comision;
    private String cargo;
    private String codigoJefe;
    private String codigoDepartamento;

    public Empleado(int codigo, String nombre, String sexo, Timestamp nacimiento, Timestamp incorporacion, double salario, double comision, String cargo, String codigoJefe, String codigoDepartamento) {
        this.codigo = codigo;
        this.nombre = nombre;
        this.sexo = sexo;
        this.nacimiento = nacimiento;
        this.incorporacion = incorporacion;
        this.salario = salario;
        this.comision = comision;
        this.cargo = cargo;
        this.codigoJefe = codigoJefe;
        this.codigoDepartamento = codigoDepartamento;
    }

    public int getCodigo() {
        return codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public String getSexo() {
        return sexo;
    }

    public Timestamp getNacimiento() {
        return nacimiento;
    }

    public Timestamp getIncorporacion() {
        return incorporacion;
    }

    public double getSalario() {
        return salario;
    }

    public double getComision() {
        return comision;
    }

    public String getCargo() {
        return cargo;
    }

    public String getCodigoJefe() {
        return codigoJefe;
    }

    public String getCodigoDepartamento() {
        return codigoDepartamento;
    }
}
