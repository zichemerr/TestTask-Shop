using UnityEngine;

namespace Project.OfferSystem
{
    public class SpriteLoader
    {
        public Sprite Load(string spriteId)
        {
            return Resources.Load<Sprite>($"Sprites/{spriteId}");
        }
    }
}
