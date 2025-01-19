using System;

namespace Project.Starting
{
    public class StartingController
    {
        private StartingModel _model;
        private StartingView _view;

        public event Action Started;
        public int StartingCount => _model.Value;

        public StartingController(StartingModel model, StartingView view)
        {
            _model = model;
            _view = view;
        }

        public void Init()
        {
            _view.ValueChanged += OnValueChanged;
            _view.Clicked += OnClicked;
            _view.Init();
        }

        public void Dispose()
        {
            _view.ValueChanged -= OnValueChanged;
            _view.Clicked -= OnClicked;
        }

        private void OnValueChanged(string text)
        {
            _model.Load(text);
        }

        private void OnClicked()
        {
            _view.Hide();
            Started?.Invoke();
        }
    }
}