using UnityEngine;

namespace Project.OfferSystem
{
    public class OfferCollectionView : MonoBehaviour
    {
        [SerializeField] private Transform _offerViewParent;

        public Transform OfferViewParent => _offerViewParent;
    }
}
