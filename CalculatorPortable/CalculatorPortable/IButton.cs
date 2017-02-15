using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPortable
{
    public interface IButton
    {
        
        event EventHandler Click;

        string ButtonContent { get; set; }

        string BtnId { get; }

    }
}
