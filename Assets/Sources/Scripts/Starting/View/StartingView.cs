using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Starting
{
    public class StartingView : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _input;
        [SerializeField] private Button _button;

        public event Action Clicked;
        public event Action<string> ValueChanged;

        public void Init()
        {
            _button.onClick.AddListener(OnClick);
            _input.onValueChanged.AddListener(OnValueChanged);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
            _input.onValueChanged.RemoveListener(OnValueChanged);
        }

        private void OnClick()
        {
            Clicked?.Invoke();
        }

        private void OnValueChanged(string text)
        {
            ValueChanged?.Invoke(text);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}