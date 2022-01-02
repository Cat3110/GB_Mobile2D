using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _Root.Scripts.UI
{
    internal class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonBack;
          
        public void Init(UnityAction action) => _buttonBack.onClick.AddListener(action);

        protected void OnDestroy() => _buttonBack.onClick.RemoveAllListeners();
    }
}