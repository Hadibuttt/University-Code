/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exceptioneebk992;

/**
 *
 * @author student
 */
public class Exceptioneebk992 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        exceptionsubclass obj=new exceptionsubclass();
        try
        {
            obj.setdata2(10, 15);
            obj.getdata2();
            obj.check();
        }
        catch(IllegalArgumentException e)
        {
            System.out.println("wrong values entered"+e);
        }
    }
    
}
