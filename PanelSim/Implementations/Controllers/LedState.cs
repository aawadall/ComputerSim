using PanelSim.Abstractions;

namespace PanelSim.Implementations.Controllers
{
    public class LedState : IControllerState
    {
        public bool CurrentState { get; private set; }
        public void SetState(bool state) => CurrentState = state;

        public LedState(bool state)
        {
            CurrentState = state;
        }

        public override string ToString()
        {
            return CurrentState ? "UP" : "DOWN";
        }
    }
}