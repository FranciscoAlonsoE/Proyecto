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

    public void Hire(Offer offer)
    {
        Employer thisEmployer = new Employer(this.name, this.phoneNum, this.address);
        Work WorkHired = new Work(offer, thisEmployer, 1);
    }
}
