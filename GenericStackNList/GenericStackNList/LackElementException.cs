using System;

namespace GenericStackNList
{
    /// <summary>
    /// Exeption call's if element don't standing in list
    /// </summary>
    [Serializable]
    public class LackElementException : ApplicationException
    {
        public LackElementException() { }
        public LackElementException(string message) : base(message) { }
        public LackElementException(string message, Exception inner) : base(message, inner) { }
        protected LackElementException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
