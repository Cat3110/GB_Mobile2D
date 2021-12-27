using _Root.Scripts.Car;
using _Root.Scripts.Profile;
using _Root.Scripts.Tools;

namespace _Root.Scripts.Game
{
    internal class GameController : BaseController
    {
        public GameController(ProfilePlayer profilePlayer)
        {
            var carController = new CarController();
            AddController(carController);
        }
    }
}