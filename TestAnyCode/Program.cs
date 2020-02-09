using System;

namespace TestAnyCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var itemTypeName = "assignment";

            if (!char.IsUpper(itemTypeName[0]))
            {
                itemTypeName = itemTypeName[0].ToString().ToUpper() + itemTypeName.Substring(1);
            }

            Console.WriteLine(itemTypeName);
        }
    }
}
