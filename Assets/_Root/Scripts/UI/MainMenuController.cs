using _Root.Scripts.Profile;
using _Root.Scripts.Tools;
using UnityEngine;


namespace _Root.Scripts.UI
{
    internal class MainMenuController : BaseController
    {
        private readonly ResourcePath _viewPath = new ResourcePath("Prefabs/mainMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly MainMenuView _view;
        
        public MainMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(StartGame);
        }

        private MainMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_viewPath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObjects(objectView);
            
            return objectView.GetComponent<MainMenuView>();
        }

        private void StartGame() => _profilePlayer.State.Value = GameState.Game;
        
    }
}