namespace Library{
    public class Offer
    {
        public Offer(int id, Category category, double price, string description, Worker worker)
        {
            this.id = id;
            this.category = category;
            this.price = price;
            this.description = description;
            this.worker = worker;
            string status = "Open";
        }

        public int id {get;}
        public Category category {get;}
        public double price {get;}
        public string description {get;}
        public Worker worker {get;}
        public string status {get; set;}

    }
}