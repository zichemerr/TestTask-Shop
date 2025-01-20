using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts
{
    public class TestLoader : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private string _folderName;
        [SerializeField] private string _fileName;

        private void Start()
        {
            _image.sprite = Resources.Load<Sprite>($"{_folderName}/{_fileName}");
        }
    }
}
