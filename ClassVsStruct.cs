using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    public class PointClass
    {
        public int X;
        public int Y;
    }
    public struct PointStruct
    {
        public int X;
        public int Y;
    }
    public class ClassVsStruct
    {
        public static void Method()
        {
            Console.WriteLine("Class: Reference type");
            PointClass pClass1 = new PointClass();
            pClass1.X = 10;
            pClass1.Y = 20;
            PointClass pClass2 = pClass1;
            pClass2.X = 90;
            Console.WriteLine($"X value of class 1: {pClass1.X}");
            Console.WriteLine($"X value of class 2: {pClass2.X}");

            Console.WriteLine();

            Console.WriteLine("Struct: Value type");
            PointStruct pStruct1 = new PointStruct();
            pStruct1.X = 30;
            pStruct1.Y = 40;
            PointStruct pStruct2 = pStruct1;
            pStruct2.X = 99;
            Console.WriteLine($"X value of struct 1: {pStruct1.X}");
            Console.WriteLine($"X value of struct 2: {pStruct2.X}");
        }
    }
}
