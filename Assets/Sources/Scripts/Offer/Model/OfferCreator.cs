using UnityEngine;

namespace Project.OfferSystem
{
    public class OfferCreator
    {
        private OfferView _prefab;
        private int _count;

        public OfferCreator(OfferView prefab, int count)
        {
            _prefab = prefab;
            _count = count;
        }

        public OfferView[] Create(Transform parent)
        {
            OfferView[] offerViews = new OfferView[_count];

            for (int i = 0; i < _count; i++)
            {
                offerViews[i] = GameObject.Instantiate(_prefab, parent);
            }

            return offerViews;
        }
    }
}
