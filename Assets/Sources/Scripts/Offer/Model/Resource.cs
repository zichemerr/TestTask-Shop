using System;
using UnityEngine;

namespace Project.OfferSystem
{
    [Serializable]
    public class Resource
    {
        [field: SerializeField] public Sprite Sprite {  get; private set; }
        [field: SerializeField] public int Count { get; private set; }
    }
}
