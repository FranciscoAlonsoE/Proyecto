namespace Library {

public class Worker : User {
    public Worker(string name, string phoneNum, string address)
    : base(name, phoneNum, address)
    {    
    }
    public void MakeOffer(Category category, int price, string description){
       Worker thisWorker = new Worker(this.name, this.phoneNum, this.address); 
       Offer newOffer = new Offer(1, category, price, description, thisWorker);
    }
}

}