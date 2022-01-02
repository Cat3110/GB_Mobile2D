using _Root.Scripts.Profile;
using _Root.Scripts.Transport;
using UnityEngine;


namespace _Root.Scripts
{
    internal class EntryPoint : MonoBehaviour
    {
        private const GameState InitialGameState = GameState.MainMenu;
        private const float CarSpeed = 5f;

       private TransportType TransportType = TransportType.Car;
        
        [SerializeField] private Transform _placeForUI;

        private MainController _mainController; 
        
        private void Awake()
        {
            var profilePlayer = new ProfilePlayer(InitialGameState, TransportType, CarSpeed);
            _mainController = new MainController(_placeForUI, profilePlayer);
        }

        private void OnDestroy()
        {
            _mainController?.Dispose();
        }
    }
}
