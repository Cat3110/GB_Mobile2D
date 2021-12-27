using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _Root.Scripts.UI
{
    internal class MainMenuView : BaseController 
    {
        [SerializeField]
        private Button _buttonStart;
          
        public void Init(UnityAction startGame) => _buttonStart.onClick.AddListener(startGame);

        protected void OnDestroy() => _buttonStart.onClick.RemoveAllListeners();
        
    }
}