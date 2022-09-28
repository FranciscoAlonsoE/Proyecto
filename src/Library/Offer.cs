namespace Library{
    public class Offer
    {
        public string category {get; set;}
        public int price {get; set;}
        public string description {get; set;}
        public Worker worker {get;set;}
        public Offer(string category, int price, string description, Worker worker)
        {
            this.category=category;
            this.price=price;
            this.description=description;
            this.worker=worker;
        }
    }
}