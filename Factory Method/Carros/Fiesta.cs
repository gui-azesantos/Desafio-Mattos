using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Fiesta: ICarro
    {
        public  void ExibirInfo()
        {
            Console.WriteLine("Modelo: Fiesta \n Fabricante: Ford");

        }
    }
}
