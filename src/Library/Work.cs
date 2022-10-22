namespace Library;

public class Work{

  
    private Offer offer;
    private Employer employer;
    private DateTime date;
    private int id;

    public int getId(){
        return this.id;
    }

    public Offer getOffer(){
        return this.offer;
    }

    public Employer getEmployer(){
        return this.employer;
    }

    public DateTime getDate(){
        return this.date;
    }

    public Work(Offer offer, Employer employer, int id){
        this.offer = offer;
        this.employer = employer;
        this.date = DateTime.Now;
        this.id = id;
    }

}