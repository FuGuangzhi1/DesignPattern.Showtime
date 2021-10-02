using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Fu
{
    /// <summary>
    /// 实现抽象类Creator的 ConcreteCreator1
    /// </summary>
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
    /// <summary>
    /// 实现抽象类Creator的 ConcreteCreator2
    /// </summary>
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
