using C;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Carro
    {
    

        public static void Main(string[] args)
        {
            Automovel01 carro01 = new Automovel01();
            Automovel01 carro02 = new Automovel01();

            Console.WriteLine(carro01.nome);
            Console.WriteLine(carro01.modelo);
            Console.WriteLine(carro01.fabricante);
            Console.WriteLine(carro01.ano);
            Console.WriteLine(carro01.cor);
            Console.WriteLine(carro02.nome);
            Console.WriteLine(carro02.modelo);
            Console.WriteLine(carro02.fabricante);
            Console.WriteLine(carro02.ano);
            Console.WriteLine(carro02.cor);
        }
    }
}
