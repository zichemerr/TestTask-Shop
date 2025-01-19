using UnityEngine;

namespace Project.OfferSystem
{
    [CreateAssetMenu(fileName = "Offer")]
    public class OfferContainer : ScriptableObject
    {
        [field: SerializeField] public Offer Offer { get; private set; }
    }
}
