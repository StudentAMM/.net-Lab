using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Car
{
    public enum TypeCar
    {
        [Description("A")]
        A = 1,
        [Description("B")]
        B = 2,
        [Description("C")]
        C = 3,
        [Description("D")]
        D = 4,
        [Description("none")]
        none = 5
    }

    
}
