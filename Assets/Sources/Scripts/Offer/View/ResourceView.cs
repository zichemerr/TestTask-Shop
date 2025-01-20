using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.OfferSystem
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _amount;

        public void Draw(Resource resource)
        {
            gameObject.SetActive(true);
            _image.sprite = new SpriteLoader().Load(resource.SpriteId);
            _amount.text = resource.Count.ToString();
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
