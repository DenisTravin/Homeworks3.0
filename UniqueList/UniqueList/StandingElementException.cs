using System;

namespace Exceptions
{
    /// <summary>
    /// Exeption call's if element have already standing in list
    /// </summary>
    [Serializable]
    public class StandingElementException : ApplicationException
    {
        public StandingElementException() { }
        public StandingElementException(string message) : base(message) { }
        public StandingElementException(string message, Exception inner) : base(message, inner) { }
        protected StandingElementException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
