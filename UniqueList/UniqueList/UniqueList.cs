using System;
using ListRealisation;

namespace UniqueListRealisation
{
    public class UniqueList : List
    {
        /// <summary>
        /// Override List AddElement function for UnuqueList
        /// </summary>
        /// <param name="newElementNumber">Adding element value</param>
        public override void AddElement(int newElementNumber)
        {
            if (GetElementIndex(newElementNumber) == -1)
            {
                base.AddElement(newElementNumber);
            }
            else
            {
                throw new StandingElementException();
            }
        }

        /// <summary>
        /// Override List DeleteElement function for UnuqueList
        /// </summary>
        /// <param name="elementNumber">Deleting element number</param>
        /// <returns>Does element has been deleted</returns>
        public override bool DeleteElement(int elementNumber)
        {
            if (GetElementIndex(elementNumber) != -1)
            {
                return base.DeleteElement(elementNumber);
            }
            else
            {
                throw new LackElementException();
            }
        }

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
}
