
package animalclass;

public class spider extends AnimalClass {
    spider(){
        setlegs(8);
    }

    public void walks(){
        System.out.println("Spider eats insects");
    }
    
    @Override

    public void eats(){
        System.out.println("Spider eats insects");
    }
    
}
