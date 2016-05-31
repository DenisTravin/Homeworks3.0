using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// Exeption call's if element don't standing in list
    /// </summary>
    [Serializable]
    public class LackOfHashException : ApplicationException
    {
        public LackOfHashException() { }
        public LackOfHashException(string message) : base(message) { }
        public LackOfHashException(string message, Exception inner) : base(message, inner) { }
        protected LackOfHashException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
