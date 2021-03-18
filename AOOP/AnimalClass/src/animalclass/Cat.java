package animalclass;

public class Cat extends AnimalClass implements Pet {
    public String Name;
    Cat(String nam){
        setlegs(4);
        this.Name= nam;
    }
    Cat(){
        this("Fluffy");
    }
    //Constructor
    @Override
    public void getName(){
        System.out.println("Cat name is : " + Name);
    }
    @Override
    public void setName(String nam){
        this.Name=nam;
    }
     @Override
    public void play(){
        System.out.println("Cat plays with ball");
    }
     @Override
    public void eats(){
        System.out.println("Cat eats Fish");
    }@Override
    
    public void walks(){
        System.out.println("Cat walks with legs: " + legs );
    }
}
