using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class FileManager
    {
        public abstract ListDrivers Load(string filename);
        public abstract void Save(string filename, ListDrivers ldriver);

    }
}
