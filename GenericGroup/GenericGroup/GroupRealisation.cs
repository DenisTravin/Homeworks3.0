using System.Collections.Generic;

namespace GenericGroup
{
    /// <summary>
    /// generic group realisation class
    /// </summary>
    /// <typeparam name="T">type of group elements</typeparam>
    public class GenericGroup<T>
    {
        /// <summary>
        /// generic group list
        /// </summary>
        private List<T> group = new List<T>();

        /// <summary>
        /// add element to group
        /// </summary>
        /// <param name="newElementValue">adding element value</param>
        public void AddElement(T newElementValue)
        {
            if (!group.Contains(newElementValue))
            {
                group.Add(newElementValue);
            }
        }

        /// <summary>
        /// delete element from group
        /// </summary>
        /// <param name="delElementValue">deleting element value</param>
        /// <returns>does element deleted?</returns>
        public bool DeleteElement(T delElementValue)
        {
            return group.Remove(delElementValue);
        }

        /// <summary>
        /// check element contains in group
        /// </summary>
        /// <param name="contElementValue">checking element value</param>
        /// <returns>does element in group?</returns>
        public bool ElementContains(T contElementValue)
        {
            return group.Contains(contElementValue);
        }

        /// <summary>
        /// return group list
        /// </summary>
        /// <returns>group list</returns>
        public List<T> ReturnGroupList()
        {
            return group;
        }

        /// <summary>
        /// combine 2 groups
        /// </summary>
        /// <param name="inputGroup">input group</param>
        /// <returns>combined group</returns>
        public GenericGroup<T> GroupCombo(GenericGroup<T> inputGroup)
        {
            GenericGroup<T> comboGroup = new GenericGroup<T>();
            
            foreach(T elementValue in group)
            {
                comboGroup.AddElement(elementValue);
            }

            foreach(T elementValue in inputGroup.ReturnGroupList())
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
        public GenericGroup<T> GroupCross(GenericGroup<T> inputGroup)
        {
            GenericGroup<T> crossGroup = new GenericGroup<T>();

            foreach (T elementValue in inputGroup.ReturnGroupList())
            {
                if (group.Contains(elementValue))
                {
                    crossGroup.AddElement(elementValue);
                }
            }

            return crossGroup;
        }
    }
}
