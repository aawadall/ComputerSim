using System.Runtime.CompilerServices;

namespace PanelSim.Abstractions
{
    /// <summary>
    /// Abstract controller 
    /// </summary>
    public interface IController
    {
        public IControllerState State { get; }
        public ControllerType Type { get; }
        public string Label { get; }
    }

    public enum ControllerType
    {
        LED,
        Button,
        Toggle,
        Dial,
        Display,
        Analog,
        Lock
    }
}