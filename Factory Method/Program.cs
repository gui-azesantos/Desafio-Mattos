using Factory_Method.Fabricas;
using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
			IFabricaDeCarro fabrica = new FabricaFiat();
			ICarro carro = fabrica.criarCarro();
			carro.ExibirInfo();
			Console.WriteLine();

			fabrica = new FabricaVolks();
			carro = fabrica.criarCarro();
			carro.ExibirInfo();
			Console.WriteLine();

			fabrica = new FabricaFord();
			carro = fabrica.criarCarro();
			carro.ExibirInfo();
			Console.WriteLine();

			fabrica = new FabricaChevrolet();
			carro = fabrica.criarCarro();
			carro.ExibirInfo();
			Console.WriteLine();
		}
    }
	//Referência
	//BRIZENO, Marcos. Mão na massa: Factory Method. Marcos Brizeno, 2011. Disponível em: <https://brizeno.wordpress.com/2011/09/17/mao-na-massa-factory-method/>.
	//Acesso em: 27 de jan. de 2020.
}
