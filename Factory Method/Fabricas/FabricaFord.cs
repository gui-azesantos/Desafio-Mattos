using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Fabricas
{
    public class FabricaFord : IFabricaDeCarro
    {
        ICarro IFabricaDeCarro.criarCarro()
        {
            return new Fiesta();
        }
    }
}
