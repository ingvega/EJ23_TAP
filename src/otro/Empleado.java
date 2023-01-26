/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package otro;
import diagnostico.Persona;
/**
 *
 * @author paveg
 */
public class Empleado extends Persona {
    private float sueldoBruto;

    public float getSueldoBruto() {
        return sueldoBruto;
    }

    public void setSueldoBruto(float sueldoBruto) {
        this.sueldoBruto = sueldoBruto;
    }
    
    
    public Empleado(){
        super(null,0);
    }
    
    public float calcularSueldoNeto(){
        return sueldoBruto*.95f;
    }
    
    public void mostrar(){
        System.out.println(getNombre());
    }
}
