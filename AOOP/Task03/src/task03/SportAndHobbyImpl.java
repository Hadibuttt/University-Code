/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package task03;
/**
 *
 * @author root
 */
public class SportAndHobbyImpl implements PersonInterface, SportInterface, HobbyInterface {
    String myName = "Hadi Butt";
    String sportName = "Chess";
    int cost = 20;
    String hobby = "Full Enjoying";
    int myAge = 23;
    @Override
    public void setName(String Name){
        this.myName= Name;
    }
    public void getName(){
        System.out.println("My name is: " + myName);
    }
    @Override
    public void setAge(int myAge){
        System.out.println("My age is: " + myAge);
    }
    @Override
    public void setMyFavoriteSport(String sport){
        this.sportName= sport;
    }
    @Override
    public String getMyFavoriteSport(){
        System.out.println("The sport is: "  + sportName);
        return sportName;
    }
    @Override
    public int howMuchItCostToPlayThisSport(){
        System.out.println("The cost to play this sport is: "  + "$" + myAge * cost);
        return myAge * cost;
    }
    @Override
    public String whatIsMyHobby(){
        System.out.println("My hobby is: "  + hobby);
        return hobby;
    }
    @Override
    public void setMyHobby(String h){
        this.hobby= h;
    }
    
}
