using System;
using Hierarquia_Lineu.Domains;

namespace Hierarquia_Lineu
{
    class Program
    {
        static void Main(string[] args)
        {
            var omano = new HomoSapiens();
            Console.WriteLine(omano.GetDescricao());
        }
    }
}
