namespace Library;

public class Admin{
    private List<Offer> offerList {get; set;} = new List<Offer>();
    private List<User> userList {get; set;}= new List<User>();


    public void AddOffer(Offer myOffer){
        this.offerList.Add(myOffer);
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
