using System;

namespace NullableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Person("Money", "Yu");
            var len = GetMiddleNameLength(money);
            Console.WriteLine(len);
        }

        static int GetMiddleNameLength(Person person)
        {
            var middle = person.MiddleName;
            return middle.Length;
        }
    }
}
