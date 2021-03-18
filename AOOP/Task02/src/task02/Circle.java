
package task02;


public class Circle implements GeometricObject {
    
    public int radius;
    public int perimeter;
    public int area;
    public double percent = radius/100;
    public void setradius(int r){
        this.radius= r;
    }
    
    public void getradius(){
        System.out.println("the radius is: " + radius);
    }

    @Override
    public void getPerimeter(){
        System.out.println("The perimeter is: " + 2 * 3.14 * radius);
    }
    
    @Override 
    public void getArea(){
        System.out.println("The Area is: " + 3.14 * radius * 2);
    }
    
}
