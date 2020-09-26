namespace IC
{
    /// <summary>
    /// Basic pin of an IC
    /// </summary>
    public class Pin
    {
        /// <summary>
        /// Pin label 
        /// </summary>
        /// <value>string used to match with datasheets</value>
        public string Label { get; private set; }

        /// <summary>
        /// Type of Pin
        /// </summary>
        /// <value>identifies the role of that pin, input, output, vcc, etc</value>
        public PinType PinType { get; private set; }

        /// <summary>
        /// Value on that pin in volts
        /// </summary>
        /// <value>be it input or output, what is the voltage on that pin</value>
        public double Value { get; private set; }
    }

    public enum PinType
    {
        Input,
        Output,
        InputOutput,
        VCC,
        Ground,
        Other
    }
}