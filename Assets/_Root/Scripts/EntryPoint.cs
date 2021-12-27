using _Root.Scripts.Profile;
using UnityEngine;


namespace _Root.Scripts
{
    internal class EntryPoint : MonoBehaviour
    {
        private const GameState InitialGameState = GameState.Start;
        private const float CarSpeed = 5f;

        [SerializeField] private Transform _placeForUI;

        private MainController _mainController; 
        
        private void Awake()
        {
            var profilePlayer = new ProfilePlayer(InitialGameState, CarSpeed);
            _mainController = new MainController(_placeForUI, profilePlayer);
        }

        private void OnDestroy()
        {
            _mainController.Dispose();
        }
    }
}
