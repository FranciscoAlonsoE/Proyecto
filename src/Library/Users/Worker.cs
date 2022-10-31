namespace Library {

public class Worker : User {
    public Worker(string name, string phoneNum, string address, int Id)
    : base(name, phoneNum, address, Id)
    {    
    }
    public void MakeOffer(Category category, int price, string description){
       Worker thisWorker = new Worker(this.name, this.phoneNum, this.address,1); 
       Offer newOffer = new Offer(1, category, price, description, thisWorker);
    }
}

}