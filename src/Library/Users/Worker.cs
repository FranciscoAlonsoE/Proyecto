namespace Library {

public class Worker : User {
    public Worker(string name, string phoneNum, string address, int Id)
    : base(name, phoneNum, address, Id)
    {    
    }

    public void MakeOffer(Category category, double price, string description){
       OfferController.GetInstance().AddOffer(category, price, description, this);

    }
}

}