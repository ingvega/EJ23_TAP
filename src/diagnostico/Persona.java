/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package diagnostico;

/**
 *
 * @author paveg
 */
public class Persona {
    private String nombre;
    private int edad;
    
    //public Persona(){}
    
    public Persona(String nombre, int edad){
        this.nombre=nombre;
        this.edad=edad;
    }
    
    public int getEdad(){
        return edad;
    }
    
    public void setEdad(int edad){
        if(edad>=0 && edad<=120){
            this.edad=edad;
        }
    }

    protected String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    public void mostrar(){
        System.out.println("Nombre: " + nombre + "\n"+
                "Edad: " + edad);    
    }
    
}
