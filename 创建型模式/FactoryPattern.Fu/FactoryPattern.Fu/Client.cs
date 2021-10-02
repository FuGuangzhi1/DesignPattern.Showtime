using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Fu
{
   public class Client
    {
        public void Main()
        {
            Console.WriteLine($"具体创建者 {nameof(ConcreteCreator1)}");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("-------------");

            Console.WriteLine($"具体创建者 {nameof(ConcreteCreator2)}");
            ClientCode(new ConcreteCreator2());
        }

         void ClientCode(Creator creator)
        {
            Console.WriteLine(creator.SomeOperation());
        }
    }
}
