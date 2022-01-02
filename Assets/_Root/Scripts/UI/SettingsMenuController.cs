using _Root.Scripts.Profile;
using _Root.Scripts.Tools;
using UnityEngine;

namespace _Root.Scripts.UI
{
    internal class SettingsMenuController : BaseController
    {
        private readonly ResourcePath _viewPath = new ResourcePath("Prefabs/UI/SettingsMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly SettingsMenuView _view;
        
        public SettingsMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(BackToMenu);
        }

        private SettingsMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_viewPath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObjects(objectView);
            
            return objectView.GetComponent<SettingsMenuView>();
        }

        private void BackToMenu()
        {
            _profilePlayer.State.Value = GameState.MainMenu;
        } 
    }
}