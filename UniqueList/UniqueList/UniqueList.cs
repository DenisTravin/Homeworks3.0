using System;
using ListRealisation;
using Exceptions;

namespace UniqueListRealisation
{
    /// <summary>
    /// unique list realisation class
    /// </summary>
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
    }
}
