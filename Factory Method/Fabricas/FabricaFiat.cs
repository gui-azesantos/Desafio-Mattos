using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Fabricas
{
    public class FabricaFiat : IFabricaDeCarro
    {
        ICarro IFabricaDeCarro.criarCarro()
        {
            return new Palio();
        }
    }
}
