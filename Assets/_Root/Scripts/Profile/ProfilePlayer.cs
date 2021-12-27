using _Root.Scripts.Car;
using _Root.Scripts.Tools;

namespace _Root.Scripts.Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> State;
        public readonly CarModel CarModel;

        public ProfilePlayer(GameState state, float speed)
        {
            State = new SubscriptionProperty<GameState>
            {
                Value = state
            };

            CarModel = new CarModel(speed);
        }
    }
}