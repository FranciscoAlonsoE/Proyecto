using System.Globalization;
namespace Library
{
    public class OfferManager
    {
        private Dictionary<int, Offer> offerDictionary = new Dictionary<int, Offer>();
        
        private int idCounter = 0;

        public void AddOffer(string category, int price, string description, Worker maker)
        {
            Offer myOffer= new Offer(category, price, description, maker);
            if (!offerDictionary.ContainsValue(myOffer))
            {
                idCounter += 1;
                offerDictionary.Add(idCounter, myOffer);
            }
            else
            {
                myOffer = null;
            }
        }

        public Dictionary<int, Offer> GetOffers()
        {
            return offerDictionary;
        }


        
        










        //public void AddOffer(string category, int price, string description, Worker maker)

        /*
        public void AddOffer(string category, int price, string description, Worker maker)
        {
            Offer myOffer= new Offer(category, price, description, maker, this.getIdOffer());
            this.offerList.Add(new Tuple<string, Offer>("Abierta", myOffer));
            this.IdOffer =+1;
        }
    
        public void RemoveOffer(Offer myOffer)
        {
            foreach (Tuple<string, Offer> stateAndOffer in offerList)
            {
                if (stateAndOffer.Item2 == myOffer)
                {
                    offerList.Remove(stateAndOffer);
                    break;
                }
            }
        }

        public void ChangeState(string newState, Offer myOffer)
        {
            foreach (Tuple<string, Offer> stateAndOffer in offerList)
            {
                if (stateAndOffer.Item2 == myOffer)
                {
                    stateAndOffer
                    break;
                }
            }

        }
        */

        
        //(string state, Offer offer) stateOffer = ("Available", myOffer);
    }
}