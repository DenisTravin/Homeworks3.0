using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericGroup<int> twoFold = new GenericGroup<int>();
            GenericGroup<int> threeFold = new GenericGroup<int>();

            for (var i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    twoFold.AddElement(i);
                }
                if (i % 3 == 0)
                {
                    threeFold.AddElement(i);
                }
            }

            foreach (int elementValue in twoFold.ReturnGroupList())
            {
                Console.Write("{0} ", elementValue);
            }

            Console.WriteLine();

            foreach (int elementValue in threeFold.ReturnGroupList())
            {
                Console.Write("{0} ", elementValue);
            }

            GenericGroup<int> comboGroup = twoFold.GroupCombo(threeFold);
            GenericGroup<int> crossGroup = twoFold.GroupCross(threeFold);

            Console.WriteLine();

            foreach (int elementValue in comboGroup.ReturnGroupList())
            {
                Console.Write("{0} ", elementValue);
            }

            Console.WriteLine();

            foreach (int elementValue in crossGroup.ReturnGroupList())
            {
                Console.Write("{0} ", elementValue);
            }

            Console.ReadLine();
        }
    }
}
