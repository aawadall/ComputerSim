
using System.Collections.Generic;
using Akka.Actor;

namespace IC
{
    /// <summary>
    /// Abstract definition of an IC
    /// </summary>
    public abstract class BaseIC : ReceiveActor 
    {
        /// <summary>
        /// name of this IC
        /// </summary>
        /// <value></value>
        public string Name { get; private set; }

        /// <summary>
        /// family of that IC
        /// </summary>
        /// <value></value>
        public string Family { get; private set; }

        /// <summary>
        /// list of pins on that ic 
        /// </summary>
        /// <value></value>
        public List<Pin> Pins { get; private set; }
    }
}