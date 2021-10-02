using System;

namespace FactoryPattern.Fu
{
    internal class Program
    {
        /// <summary>
        /// 设计模式之工厂模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //工厂模式（Factory Pattern）是 C# 中最常用的设计模式之一。
            //这种类型的设计模式属于创建型模式，它提供了一种创建对象的最佳方式。
            Console.WriteLine("Hello FactoryPattern!");
            Console.WriteLine("---------------------");
            new Client().Main();
        }

    }
}
