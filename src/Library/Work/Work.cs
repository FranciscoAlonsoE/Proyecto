namespace Library;

public class Work{

  
    private Offer offer;
    private Worker worker;
    private DateTime date;
    private int id;

    public int getId(){
        return this.id;
    }

    public Offer getOffer(){
        return this.offer;
    }

    public Worker getWorker(){
        return this.worker;
    }

    public DateTime getDate(){
        return this.date;
    }

    public Work(Offer offer, Worker worker, int id){
        this.offer = offer;
        this.worker = worker;
        this.date = DateTime.Now;
        this.id = id;
    }

}