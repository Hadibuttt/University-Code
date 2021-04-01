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
public class exceptionsubclass extends exceptionclass {
    int data2;
    
    exceptionsubclass()
    {
        this.data1=data1;
        this.data2=data2;
    }
    
    public void setdata2(int data1, int data2)
    {
        this.data1=data1;
        this.data2=data2;
    }
    public void getdata2()
    {
        System.out.println("Data1 is "+data1);
        System.out.println("Data2 is "+data2);
    }
    
    public void check()
    {
 
        if (data1==10&&data2==15)
        {
            System.out.println("Method Executed");
        }       
        else
        {
            throw new IllegalArgumentException();
        }
    }
    
}
