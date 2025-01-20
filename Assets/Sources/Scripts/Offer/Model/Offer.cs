using System;
using UnityEngine;

namespace Project.OfferSystem
{
    [Serializable]
    public class Offer
    {
        [field: SerializeField] public string Title { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        [field: SerializeField] public Resource[] Resources { get; private set; }
        [field: SerializeField] public string SpriteId { get; private set; }
        [field: SerializeField] public float Price { get; private set; }
        [field: SerializeField, Range(0, 1)] public float Discount { get; private set; }

        public float FakePrice => Price * (1 + Discount);
    }
}
