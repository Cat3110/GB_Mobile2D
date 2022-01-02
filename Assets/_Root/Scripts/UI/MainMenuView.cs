using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _Root.Scripts.UI
{
    internal class MainMenuView : MonoBehaviour 
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;

        public void Init(UnityAction startGame, UnityAction BackToMenu)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonSettings.onClick.AddListener(BackToMenu);
        }

        protected void OnDestroy() => _buttonStart.onClick.RemoveAllListeners();
    }
}