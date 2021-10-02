using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Fu
{
    /// <summary>
    /// 定义一个接口IProduct（中文:产品）
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// 未实现的方法Operation（中文:操作）
        /// 就是这个IProduct有啥用
        /// </summary>
        /// <returns></returns>
        string Operation();
    }
}
