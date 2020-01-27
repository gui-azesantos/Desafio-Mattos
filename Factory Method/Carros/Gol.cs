using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Gol : ICarro
    {
        public  void ExibirInfo()
        {
            Console.WriteLine("Modelo:Gol \n Fabricante: Volkswagem");

        }
    }
}
