/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package task02;

/**
 *
 * @author root
 */
public class ResizableCircle extends Circle implements Resizable{
     
     
    @Override
    public void resize(int percent){
        System.out.println("The resized circle is: " + percent + "%");
    }
    
}
