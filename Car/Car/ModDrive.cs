using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace Car
{
    public enum ModDrive
    {
        [Description("Все")]
        All = 1,
        [Description("Может")]
        Yes = 2,
        [Description("Не может")]
        No = 3
    }

}
