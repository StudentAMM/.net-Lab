using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Car
{
    class BinManager : FileManager
    {
        public override ListDrivers Load(string filename)
        {
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<CarOwner> co = (List<CarOwner>)formatter.Deserialize(stream);
                ListDrivers ld = new ListDrivers(co);
                return ld;
            }
        }

        public override void Save(string filename, ListDrivers ldriver)
        {
            using (Stream stream = File.Create(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, ldriver.GetList());

            }
        }
    }
}
