using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploCafeteria
{
    /// <summary>
    /// Interface Café: diferencia o produto principal das decorações
    /// </summary>
    public interface ICafé
    {
        string ObterDescrição();
        Decimal ObterPreço();
    }
}
