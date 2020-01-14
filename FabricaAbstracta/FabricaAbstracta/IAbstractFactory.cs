using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    
}
