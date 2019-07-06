using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            // 类A的构造无传参
            object obj = assembly.CreateInstance("DemoReflection.A"); //类的完全限定名（即包括命名空间）
            // 类A的构造有传参
            // 传参类型是int，但传入int，不会报错
            object[] parameters3 = new object[1];
            parameters3[0] = 123;
            object obj3 = assembly.CreateInstance("DemoReflection.A",
                true, System.Reflection.BindingFlags.Default, null, parameters3, null, null);// 创建类的实例
            // 传参类型是int，但传入string，会报错
            object[] parameters2 = new object[1];
            parameters2[0] = "123";
            object obj2 = assembly.CreateInstance("DemoReflection.A", 
                true, System.Reflection.BindingFlags.Default, null, parameters2, null, null);// 创建类的实例
        }
    }
}
