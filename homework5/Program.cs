using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)//当输入两个参数时
            {
                int l = Convert.ToInt32(args[0]);
                int h = Convert.ToInt32(args[1]);
                for (int i = 0; i < h; i++)//梯形算法
                {
                    for (int j = 0; j <= h - 1 - i; j++)//输入空格
                        Console.Write(" ");
                    for (int k = 1; k <= l + 2 * i; k++)//输入星号
                        Console.Write("*"); Console.WriteLine();
                }
            }
            else//当输入的参数不为两个时
            {
                Console.WriteLine("请输入两个命令行参数作为梯形的上底和高");//提示重新输入两个参数
            }
        }
    }
}
