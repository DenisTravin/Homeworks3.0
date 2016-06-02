using System;

namespace ParsingTree
{
    /// <summary>
    /// lack of operation exception class
    /// </summary>
    [Serializable]
    public class LackOfOperationexception : ApplicationException
    {
        public LackOfOperationexception() { }
        public LackOfOperationexception(string message) : base(message) { }
        public LackOfOperationexception(string message, Exception inner) : base(message, inner) { }
        protected LackOfOperationexception(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
