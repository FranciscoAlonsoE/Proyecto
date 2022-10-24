using System;
namespace Library;

public class Admin 
 {
    public static Admin s;
    private Admin (){}
    public static Admin AdminGetInstance(){
        if (s==null){
            s = new Admin();
        }
        return s;

    }

    


    //private List<Offer> offerList {get; set;} = new List<Offer>();
    private List<User> userList {get; set;}= new List<User>();
    
    

    

    public void AddUser(User newUser){
        this.userList.Add(newUser);
    }

    public void RemoveUser(Offer myOffer){

    }

    public void Match(){

    }

 }