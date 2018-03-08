using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 诗词集合;

namespace 唐诗宋词
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1="唐诗宋词，你更喜欢哪一种呢？";
            string str2 = "A.唐诗";
            string str3 = "B.宋词";
            Console.WriteLine(str1+'\n'+str2+' '+str3);
            char str4 = char.Parse(Console.ReadLine());
            A a = new A();
            B b = new B();
            switch(str4)
            {
                case 'A': a.TangShi(); break;
                case 'B': b.SongCi(); break;
                default: Console.WriteLine("输入错误！"); break;
            }
            Console.ReadLine();
        }
    }
}
namespace 诗词集合
{
    class A
    {
        public void TangShi()
        {
            string str1 = "草";
            string str2 = "(白居易)";
            string str3 = "离离原上草，一岁一枯荣。";
            string str4 = "野火烧不尽，春风吹又生。";
            Console.WriteLine(" "+" "+str1+str2+'\n'+str3+'\n'+str4);
            Console.ReadLine();
        }
    }
    class B
    {
        public void SongCi()
        {
            string str1 = "水调歌头";
            string str2 = "(苏东坡)";
            string str3 = "明月几时有，把酒问青天，不知天上宫阙，今夕是何年。";
            Console.WriteLine(" "+" "+str1+str2+'\n'+str3);
            Console.ReadLine();
        }
    }
}
