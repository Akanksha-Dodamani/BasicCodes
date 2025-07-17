using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    internal class BoxingUnboxing
    {
        public static void BoxUnboxMethod()
        {
            string sentence = "Hello";
            Object BoxedObj = sentence;
            Console.Write("Boxed sentence: " + BoxedObj);
            Console.WriteLine();

            string unboxedSentence = (string)BoxedObj;
            Console.Write("Unboxed sentence: " + unboxedSentence);

        }

    }
}
