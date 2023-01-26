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
public class Cliente extends Persona {
    private String telefono;

    public Cliente(String nombre, int edad, String telefono){
        super(nombre,edad);
        //setNombre(nombre);
        this.telefono=telefono;
        //setEdad(edad);
    }
    
    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
    
    public void mostrar(){
//        System.out.println("Nombre: " + getNombre() + "\n"+
//                "Edad: " + getEdad()  + "\n" +
//                "Telefono: " + telefono);    
        super.mostrar();
        System.out.println("Telefono: " + telefono);    
    }
    
}
