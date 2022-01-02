using _Root.Scripts.Game;
using _Root.Scripts.Profile;
using _Root.Scripts.UI;
using UnityEngine;

namespace _Root.Scripts
{
    internal class MainController : BaseController
    {
        private readonly Transform _placeForUI;
        private readonly ProfilePlayer _profilePlayer;

        private MainMenuController _mainMenuController;
        private GameController _gameController;
        private SettingsMenuController _settingsMenuController;

        public MainController(Transform placeForUI, ProfilePlayer profilePlayer)
        {
            _placeForUI = placeForUI;
            _profilePlayer = profilePlayer;
            
            _profilePlayer.State.SubscribeOnChange(OnChangeGameState);
            OnChangeGameState(_profilePlayer.State.Value);
        }

        private void OnChangeGameState(GameState state)
        {
            switch (state)
            {
                case GameState.Game:
                    _mainMenuController?.Dispose();
                    _settingsMenuController?.Dispose();
                    _gameController = new GameController(_profilePlayer);
                    break;
                case GameState.MainMenu:
                    _gameController?.Dispose();
                    _settingsMenuController?.Dispose();
                    _mainMenuController = new MainMenuController(_placeForUI, _profilePlayer);
                    break;
                case GameState.Settings:
                    _gameController?.Dispose();
                    _mainMenuController?.Dispose();
                    _settingsMenuController = new SettingsMenuController(_placeForUI, _profilePlayer);
                    break;  
                default:
                    _mainMenuController?.Dispose();
                    _settingsMenuController?.Dispose();
                    _gameController?.Dispose();
                    break;
            }
        }
        
        protected override void OnDispose()
        {
            base.OnDispose();
            
            _mainMenuController?.Dispose();
            _gameController?.Dispose();
            
            _profilePlayer.State.UnsubscribeOnChange(OnChangeGameState);
        }
    }
}