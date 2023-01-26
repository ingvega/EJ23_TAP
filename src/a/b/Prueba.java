/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package a.b;

import otro.Empleado;

/**
 *
 * @author paveg
 */
public class Prueba {
    public static void main(String[] args) {
        Empleado e=new Empleado();
        e.setSueldoBruto(1000);
        e.setNombre("Juan Perez");
        
        diagnostico.Cliente c=new diagnostico.Cliente("Roberto Medina",19,"1234567890");
        
        System.out.println("Empleado " + e.getNombre());
        System.out.println("Cliente ");
        c.mostrar();
        
    }
}
