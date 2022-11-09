using System.Xml.Schema;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int number)
        {
            if (number % 3 == 0)
            {
                return "Foo";
            }
            else if (number % 5 == 0)
            {
                return "Bar";
            }
            else if (number % 7 == 0)
            {
                return "Qix";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}