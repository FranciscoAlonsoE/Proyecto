namespace Library;

public abstract class User{

  
    private string name {get; set;}
    private string phoneNum {get; set;}
    private string address {get; set;}
    private List<Review> reviewList {get; set;}

    public User(string name, string phoneNum, string address){
        this.name=name;
        this.phoneNum=phoneNum;
        this.address=address;
          this.reviewList = new List<Review>();
    }
       public static void MakeOffer(Offer Offer){
        Offer offer = Offer;
        
    }

    public void MakeReview(Employer employer){

    }

    public int getReputation(){
        int rep = 0;
        
        return rep;
    }
}