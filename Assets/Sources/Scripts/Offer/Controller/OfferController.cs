namespace Project.OfferSystem
{
    public class OfferController
    { 
        private OfferCollection _offerCollection;
        private OfferCreator _offerCreator;
        private OfferView[] _offerViews;
        private OfferCollectionView _offerCollectionView;

        public OfferController(OfferCollection offerCollection, OfferCreator offerCreator, OfferCollectionView offerCollectionView)
        {
            _offerCollection = offerCollection;
            _offerCreator = offerCreator;
            _offerCollectionView = offerCollectionView;
        }

        public void Init()
        {
            _offerViews = _offerCreator.Create(_offerCollectionView.OfferViewParent);

            foreach (var offerView in _offerViews)
            {
                offerView.Init();
                offerView.Clicked += OnClicked;
                offerView.Draw(_offerCollection.GetRandomOffer());
            }
        }

        public void Dispose()
        {
            foreach (var offerView in _offerViews)
            {
                offerView.Clicked -= OnClicked;
            }
        }

        private void OnClicked(OfferView offerView)
        {
            offerView.Hide();
        }
    }
}
