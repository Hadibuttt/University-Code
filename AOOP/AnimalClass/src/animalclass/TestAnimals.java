package animalclass;

public class TestAnimals {

    public static void main(String[] args) {
        Fish d = new Fish();
        Cat c = new Cat("Fluffy");
        AnimalClass a = new Fish();
        AnimalClass e = new spider();
        Pet p = new Cat();
        
        System.out.println("CALLING METHODS USING OBJECTS:");
        System.out.println("The Fish: ");
        d.walks();
        a.getlegs();
        a.eats();
        System.out.println("The Spider: ");
        e.walks();
        e.eats();
        e.getlegs();
        System.out.println("The Cat: ");
        p.getName();
        p.play();
        
        System.out.println("NOW WE HAVE CASTING:");
        System.out.println("The Spider: ");
        ((spider)e).getlegs();
        ((spider)e).eats();
        System.out.println("The Cat: "); 
        ((Cat)p).play();
        ((Cat)c).getlegs();
        System.out.println("The Fish: ");
        ((Fish)a).getlegs();
        ((Fish)a).eats();
        
        
        
    }
    
}
