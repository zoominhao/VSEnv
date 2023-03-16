using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test = "tt/RA/ddd/44";
            test.Replace("\\", "/").Replace("\\", "/");
            int index = test.LastIndexOf("RA/");
            if(index != -1)
            {
                int newIndex = index + 3;
                string sub = test.Substring(newIndex);
                if((sub.Contains("/") && sub.LastIndexOf("/") == sub.Length - 1) || !sub.Contains("/"))
                {
                    Console.WriteLine("Root Dir Create!");
                }
            }
        }
    }
}