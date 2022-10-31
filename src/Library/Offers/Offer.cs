namespace Library{

    /// <summary>
    /// Clase entidad de las ofertas. 
    /// </summary>
    public class Offer
    {
        /// <summary>
        /// Constructor de las ofertas
        /// </summary>
        /// <param name="id">Valor numérico identificador de la oferta</param>
        /// <param name="category">Categoría a la que pertenece la oferta</param>
        /// <param name="price">Precio para contratar este servicio</param>
        /// <param name="description">Descripción de la oferta</param>
        /// <param name="worker">Autor de la oferta</param>
        public Offer(int id, Category category, double price, string description, Worker worker)
        {
            this.id = id;
            this.category = category;
            this.price = price;
            this.description = description;
            this.worker = worker;
            this.status = "Open";
        }

        public int id {get;}
        public Category category {get;}
        public double price {get;}
        public string description {get;}
        public Worker worker {get;}
        public string status {get; set;}

    }
}