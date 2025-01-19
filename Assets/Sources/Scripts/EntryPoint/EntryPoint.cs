using UnityEngine;
using Project.Starting;
using Project.OfferSystem;

namespace Project.Boot
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private StartingView _startingView;
        [SerializeField] private OfferCollectionView _offerCollectionView;
        [SerializeField] private Transform _viewParent;
        [SerializeField] private OfferView _offerView;
        [SerializeField] private OfferContainer[] _offerContainers;

        private StartingController _startingController;
        private StartingModel _startingModel;
        private OfferController _offerController;
        private OfferCreator _offerCreator;
        private OfferCollection _offerCollection;

        private void Start()
        {
            _startingModel = new StartingModel();
            _startingController = new StartingController(_startingModel, _startingView);

            _startingController.Started += OnStarted;
            _startingController.Init();
        }

        private void OnDisable()
        {
            _startingController.Started -= OnStarted;
            _startingController.Dispose();
            _offerController.Dispose();
        }

        private void OnStarted()
        {
            OfferCollectionView offerCollectionView = Instantiate(_offerCollectionView, _viewParent);
            _offerCollection = new OfferCollection(_offerContainers);
            _offerCreator = new OfferCreator(_offerView, _startingController.StartingCount);
            _offerController = new OfferController(_offerCollection, _offerCreator, offerCollectionView);
            _offerController.Init();
        }
    }
}
