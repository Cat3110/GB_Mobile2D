using _Root.Scripts.Transport;
using _Root.Scripts.Profile;
using _Root.Scripts.Tools;

namespace _Root.Scripts.Game
{
    internal class GameController : BaseController
    {
        public GameController(ProfilePlayer profilePlayer)
        {
            TransportController transportController;
            
            switch (profilePlayer.TransportType)
            {
                case TransportType.Boat:
                    transportController = new BoatController();
                    break;
                case TransportType.Car:
                    transportController = new CarController();
                    break;
                default:
                    transportController = new CarController();
                    break;
            }

            AddController(transportController);
        }
    }
}