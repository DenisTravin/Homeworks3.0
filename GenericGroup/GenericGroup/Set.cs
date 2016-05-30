using System.Collections.Generic;

namespace GenericSetNamespace
{
    /// <summary>
    /// generic group realisation class
    /// </summary>
    /// <typeparam name="T">type of group elements</typeparam>
    public class GenericSet<T>
    {
        /// <summary>
        /// generic group list
        /// </summary>
        private List<T> set = new List<T>();

        public List<T> SetProperty
        {
            get { return set; }
        }


        /// <summary>
        /// add element to group
        /// </summary>
        /// <param name="newElementValue">adding element value</param>
        public void AddElement(T newElementValue)
        {
            if (!set.Contains(newElementValue))
            {
                set.Add(newElementValue);
            }
        }

        /// <summary>
        /// delete element from group
        /// </summary>
        /// <param name="delElementValue">deleting element value</param>
        /// <returns>does element deleted?</returns>
        public bool DeleteElement(T delElementValue)
        {
            return set.Remove(delElementValue);
        }

        /// <summary>
        /// check element contains in group
        /// </summary>
        /// <param name="contElementValue">checking element value</param>
        /// <returns>does element in group?</returns>
        public bool ElementContains(T contElementValue)
        {
            return set.Contains(contElementValue);
        }

        /// <summary>
        /// combine 2 groups
        /// </summary>
        /// <param name="inputGroup">input group</param>
        /// <returns>combined group</returns>
        public GenericSet<T> SetCombo(GenericSet<T> inputGroup)
        {
            GenericSet<T> comboGroup = new GenericSet<T>();
            
            foreach (T elementValue in set)
            {
                comboGroup.AddElement(elementValue);
            }

            foreach (T elementValue in inputGroup.set)
            {
                comboGroup.AddElement(elementValue);
            }

            return comboGroup;
        }

        /// <summary>
        /// cross 2 group
        /// </summary>
        /// <param name="inputGroup">input group</param>
        /// <returns>crossed group</returns>
        public GenericSet<T> SetCross(GenericSet<T> inputGroup)
        {
            GenericSet<T> crossGroup = new GenericSet<T>();

            foreach (T elementValue in inputGroup.set)
            {
                if (set.Contains(elementValue))
                {
                    crossGroup.AddElement(elementValue);
                }
            }

            return crossGroup;
        }
    }
}
