using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Palio : ICarro
    {
        public  void ExibirInfo()
        {
            Console.WriteLine("Modelo: Palio \n Fabricante: Fiat");

        }
    }
}
