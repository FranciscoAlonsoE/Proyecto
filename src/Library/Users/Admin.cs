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

    private List<Offer> offerList {get; set;} = new List<Offer>();
    private List<User> userList {get; set;}= new List<User>();
    private int IdOffer =0;
    public int getIdOffer(){
        return this.IdOffer;
    }
    

    public void AddOffer(string category, int price, string description, Worker maker ){
        
        Offer myOffer= new Offer(category, price, description, maker, this.getIdOffer()  );
        this.offerList.Add(myOffer);
        this.IdOffer =+1;

    }
    


    public void RemoveOffer(Offer myOffer){

    }

    public void AddUser(Offer myOffer){
        this.offerList.Add(myOffer);
    }

    public void RemoveUser(Offer myOffer){

    }

    public void Match(){

    }

 }