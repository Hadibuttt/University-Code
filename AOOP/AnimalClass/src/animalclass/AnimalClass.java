package animalclass;
abstract class AnimalClass {
protected int legs;

protected AnimalClass(){
    legs = 0;
}
protected void setlegs(int l){
    this.legs = l;
}
protected void getlegs(){
    System.out.println("The legs it has: " + legs);
}
abstract void eats();
abstract void walks();
}
    
   
  
