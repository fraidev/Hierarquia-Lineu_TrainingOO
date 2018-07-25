using System;
using Hierarquia_Lineu.Domains;

namespace Hierarquia_Lineu
{
    class Program
    {
        static void Main(string[] args)
        {
            var humano = new HomoSapiens();
            var cao = new CanisFamiliaris();
            var mosca = new MuscaDomestica();
            
            
            Console.WriteLine(cao.GetDescricao());
        }
    }
}
