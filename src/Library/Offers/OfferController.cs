namespace Library
{
    /// <summary>
    /// Clase de servicio que maneja las ofertas
    /// </summary>
    public class OfferController
    {
        public static OfferController s;
        private OfferController (){}

        /// <summary>
        /// Método para poder usar el patrón de Singleton y acceder a la instancia de OfferController
        /// </summary>
        /// <returns>Instancia de OfferController</returns>
        public static OfferController GetInstance()
        {
            if (s==null)
            {
                s = new OfferController();
            }
            return s;
        }

        /// <summary>
        /// Lista que contiene todas las ofertas creadas
        /// </summary>
        /// <typeparam name="Offer">Ofertas para guardar en la lista</typeparam>
        /// <returns>Lista de ofertas</returns>
        private List<Offer> allOffers = new List<Offer>();

        /// <summary>
        /// Contador para asignarles un ID a las ofertas
        /// </summary>
        private int idCounter = 1;

        /// <summary>
        /// Responsable de crear ofertas y añadirlas a la lista global
        /// </summary>
        /// <param name="category">Categoría a la que pertenece la oferta</param>
        /// <param name="price">Precio para contratar este servicio</param>
        /// <param name="description">Descripción de la oferta</param>
        /// <param name="maker">Autor de la oferta</param>
        public void AddOffer(Category category, double price, string description, Worker maker)
        {
            Offer newOffer= new Offer(idCounter, category, price, description, maker);
            if (!allOffers.Contains(newOffer))
            {
                allOffers.Add(newOffer);
                idCounter += 1;
            }
            else
            {
                newOffer = null;
            }
        }

        /// <summary>
        /// Remueve una oferta de la lista global
        /// </summary>
        /// <param name="offerId">Valor numérico identificador de la oferta</param>
        public void RemoveOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    allOffers.Remove(offer);
                    break;
                }
            }
        }

        /// <summary>
        /// Método para acceder a una oferta según su id
        /// </summary>
        /// <param name="offerId">Valor numérico de id de la oferta</param>
        /// <returns>Oferta deseada u oferta nula</returns>
        public Offer GetOffer(int offerId)
        {
            Offer offerNull = null;
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    return offer;
                }
            }
            return offerNull;
        }
        
        /// <summary>
        /// Cambia el estado de una oferta a "abierta"
        /// </summary>
        /// <param name="offerId">Valor numérico identificador de la oferta</param>
        public void OpenOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "Open";
                    break;
                }
            }
        }
        /// <summary>
        /// Cambia el estado de una oferta a "en progreso"
        /// </summary>
        /// <param name="offerId">Valor numérico identificador de la oferta</param>
        public void ProgressOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "InProgress";
                    break;
                }   
            }
        }
        /// <summary>
        /// Cambia el estado de una oferta a "cerrada"
        /// </summary>
        /// <param name="offerId">Valor numérico identificador de la oferta</param>
        public void CloseOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "Closed";
                    break;
                }
            }
        }

        /// <summary>
        /// Método para acceder a la lista global de ofertas
        /// </summary>
        /// <returns>Lista de ofertas</returns>
        public List<Offer> GetAllOffers()
        {
            return allOffers;
        }

        /// <summary>
        /// Filtra ofertas segun categoría
        /// </summary>
        /// <param name="category">Categoría para filtrar</param>
        /// <returns>Lista de ofertas ya filtrada</returns>
        public List<Offer> SortByCategory(Category category)
        {
            List<Offer> offerList = new List<Offer>();
            foreach (Offer offer in allOffers)
            {
                if (offer.category == category)
                {
                    offerList.Add(offer);
                }
            }
            return offerList;
        }

        /// <summary>
        /// Filtra ofertas segun su autor
        /// </summary>
        /// <param name="worker">Trabajador por el cual filtrar</param>
        /// <returns>Lista de ofertas ya filtrada</returns>
        public List<Offer> SortByWorker(Worker worker)
        {
            List<Offer> offerList = new List<Offer>();
            foreach (Offer offer in allOffers)
            {
                if (offer.worker == worker)
                {
                    offerList.Add(offer);
                }
            }
            return offerList;
        }       
    }
}