using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Car
{
    class XmlManager : FileManager
    {
        public override ListDrivers Load(string filename)
        {
            using (Stream stream = File.Open(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CarOwner>));
                var co = (List<CarOwner>)serializer.Deserialize(stream) ;
                ListDrivers ld = new ListDrivers(co);
                return ld;
            }
        }

        public override void Save(string filename, ListDrivers ldriver)
        {
            using (Stream stream = File.Open(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CarOwner>));
                serializer.Serialize(stream, ldriver.GetList());
                stream.Close();
            }
        }
    }
}
