using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Fu
{
    /// <summary>
    /// 实现接口IProduct的 ConcreteProduct1
    /// </summary>
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "我能恰饭";
        }
    }
    /// <summary>
    /// 实现接口IProduct的 ConcreteProduct2
    /// </summary>
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "我能喝饮料";
        }
    }

}
