namespace Library
{
    public class OfferController
    {
        public static OfferController s;
        private OfferController (){}
        public static OfferController GetInstance()
        {
            if (s==null)
            {
                s = new OfferController();
            }
            return s;
        }

        private List<Offer> allOffers = new List<Offer>();
        private int idCounter = 1;

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

        public void RemoveOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    allOffers.Remove(offer);
                }
                break;
            }
        }

        public void OpenOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "Open";
                }
                break;
            }
        }
        public void ProgressOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "InProgress";
                }
                break;
            }
        }
        public void CloseOffer(int offerId)
        {
            foreach (Offer offer in allOffers)
            {
                if (offer.id == offerId)
                {
                    offer.status = "Closed";
                }
                break;
            }
        }

        public List<Offer> GetAllOffers()
        {
            return allOffers;
        }

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