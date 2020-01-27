using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Fabricas
{
    class FabricaVolks : IFabricaDeCarro
    {
        ICarro IFabricaDeCarro.criarCarro()
        {
            return new Gol();
        }
    }
}
