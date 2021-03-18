
package task02;
import java.util.Scanner;
/**
 *
 * @author root
 */
public class Task02 {
    public void TestCircle(){
    Circle c = new Circle();
    c.setradius(5);
    c.getPerimeter();
    c.getArea();
}
    public void TestResizableCircle(){
        ResizableCircle r = new ResizableCircle();
        System.out.print("What percent size of circle you want to resize?");
        Scanner input = new Scanner(System.in);
        r.resize(input.nextInt());
    }
    
    public static void main(String[] args) {
        Task02 t = new Task02();
        t.TestCircle();
        Task02 e = new Task02();
        e.TestResizableCircle();
    }
    
}
