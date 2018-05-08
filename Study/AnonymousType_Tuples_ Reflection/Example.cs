using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.AnonymousType_Tuples__Reflection
{
    public class Example
    {

        public static void RunOutput()
        {
            // anonymous type; tuples; casting; reflection

            // tuples
            Tuple<string, int> dataTuple = GetDataTuple("name tuple");
            Console.WriteLine(dataTuple.Item1.ToString());


            // anonymous type
            var dataObject = Cast(GetDataOject("name anonymous types"), new { Name = "", Id = 0 });

            Console.WriteLine(dataObject.Name);
            object any = GetDataOject("any name");

            Type type = any.GetType();
            Person dataClass = new Person()
            {
                Name = type.GetProperty("Name")?.GetValue(any, null) as string,
                Id = (int)type.GetProperty("Id")?.GetValue(any, null)
            };
            Console.WriteLine(dataClass.Name + ": " + dataClass.Id);
            Console.ReadLine();
        }

        static Tuple<string, int> GetDataTuple(string name)
        {
            Tuple<string, int> myTuple = Tuple.Create<string, int>(name, 1);
            return myTuple;
        }

        static object GetDataOject(string name)
        {
            return new { Name = name, Id = 1 };
        }

        static T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }

        public class Person
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
    }
}
