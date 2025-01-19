using Random = UnityEngine.Random;

namespace Project.OfferSystem
{
    public class OfferCollection
    {
        private OfferContainer[] _offerContainer;

        public OfferCollection(OfferContainer[] offerContainer)
        {
            _offerContainer = offerContainer;
        }

        public Offer GetRandomOffer()
        {
            int index = Random.Range(0, _offerContainer.Length);
            return _offerContainer[index].Offer;
        }
    }
}
