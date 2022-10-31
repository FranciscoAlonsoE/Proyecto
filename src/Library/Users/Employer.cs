namespace Library;

public class Employer : User{
    public Employer(string name, string phoneNum, string address, int Id)
        : base (name, phoneNum, address, Id)
        {
            
        }

    public List<Offer> BrowseOffers()
    {
        List<Offer> result = new List<Offer>();
        return result;
    }

    public void Hire(int id)
    {

        //UserController.GetInstance().RegisterEmployer(this.name, this.phoneNum, this.address);
        WorkController.GetInstance().AddWork(OfferController.GetInstance().GetOffer(id), this);

    }
}
