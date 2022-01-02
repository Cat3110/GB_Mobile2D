using _Root.Scripts.Transport;
using _Root.Scripts.Tools;

namespace _Root.Scripts.Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> State;
        public readonly TransportModel TransportModel;
        public readonly TransportType TransportType;

        public ProfilePlayer(GameState initialState, TransportType transportType, float speed)
        {
            State = new SubscriptionProperty<GameState>();
            State.Value = initialState;

            TransportType = transportType;
            TransportModel = new TransportModel(speed);
        }
    }
}