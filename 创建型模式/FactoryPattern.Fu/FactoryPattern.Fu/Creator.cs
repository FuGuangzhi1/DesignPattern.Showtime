using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Fu
{
    /// <summary>
    /// 抽象类Creator（中文：创建者）
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// 抽象方法 返回一个接口IProduct
        /// </summary>
        /// <returns></returns>
        public abstract IProduct FactoryMethod();

        /// <summary>
        /// 一些操作的方法
        /// </summary>
        /// <returns></returns>
        public string SomeOperation()
        {
            IProduct product = FactoryMethod(); //获得当前继承该抽象类实现抽象方法的实例
            string result = product.Operation();
            return result;
        }
    }
}
