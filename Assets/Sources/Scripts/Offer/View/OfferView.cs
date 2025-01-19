using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.OfferSystem
{
    public class OfferView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;
        [SerializeField] private ResourceView[] _resourceView;
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _price;
        [SerializeField] private TMP_Text _fakePrice;
        [SerializeField] private GameObject _discount;
        [SerializeField] private TMP_Text _discountAmount;
        [SerializeField] private Button _button;

        public event Action<OfferView> Clicked;

        public void Init()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            Clicked?.Invoke(this);
        }

        public void Draw(Offer offer)
        {
            _title.text = offer.Title;
            _description.text = offer.Description;
            _image.sprite = offer.Sprite;

            for (int i = 0; i < _resourceView.Length; i++)
            {
                if (offer.Resources.Length > i)
                {
                    _resourceView[i].Draw(offer.Resources[i]);
                }
                else
                {
                    _resourceView[i].Hide();
                }
            }

            _discount.SetActive(true);
            _price.text = $"{offer.Price}$";
            _fakePrice.text = $"{offer.FakePrice}";
            _discountAmount.text = $"{offer.Discount:P}";
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
