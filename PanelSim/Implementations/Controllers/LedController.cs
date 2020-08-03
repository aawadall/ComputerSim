using PanelSim.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PanelSim.Implementations.Controllers
{
    public class LedController : IController
    {
        public IControllerState State { get; private set; }

        public ControllerType Type => ControllerType.LED;

        public string Label { get; private set; }

        public LedColor Color { get; private set; }
        public LedController(string label, LedColor ledColor = LedColor.Amber)
        {
            Label = label;
            Color = ledColor;
            State = new LedState(false);
        }

        public void SetState(LedState ledState) => State = ledState;
        public void SetState(bool state)
        {
            ((LedState)State).SetState(state); 
        }
    }

    public enum LedColor
    {
        Red,
        Green,
        Amber,
        White
    }
}
