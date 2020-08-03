using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PanelSim.Abstractions
{
    /// <summary>
    /// IPanel, is the interface defining panel behavior 
    /// </summary>
    interface IPanel
    {
        /// <summary>
        /// an array of possible input controllers
        /// </summary>
        public IController[] ControllerArray { get; set; }

        /// <summary>
        /// an array of possible indicators
        /// </summary>
        public IController[] IndicatorArray { get; }

        /// <summary>
        /// Panel Label
        /// </summary>
        public string Label { get; set; }

        // TODO: Define layout 
    }
}
