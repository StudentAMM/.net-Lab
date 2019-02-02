using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Car
{
    class TxtManager: FileManager
    {
        public override ListDrivers Load(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                ListDrivers ldriver = new ListDrivers();
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    CarOwner owner = new CarOwner();
                    owner.FullName = sr.ReadLine();
                    s = sr.ReadLine();
                    switch(s)
                    {
                        case "A":
                            owner.TypeLicense = TypeCar.A;
                            break;
                        case "B":
                            owner.TypeLicense = TypeCar.B;
                            break;
                        case "C":
                            owner.TypeLicense = TypeCar.C;
                            break;
                        case "D":
                            owner.TypeLicense = TypeCar.D;
                            break;
                        default:
                            owner.TypeLicense = TypeCar.none;
                            break;
                    }
                    owner.ModelCar = sr.ReadLine();
                    s = sr.ReadLine();
                    switch (s)
                    {
                        case "A":
                            owner.TypeCar = TypeCar.A;
                            break;
                        case "B":
                            owner.TypeCar = TypeCar.B;
                            break;
                        case "C":
                            owner.TypeCar = TypeCar.C;
                            break;
                        case "D":
                            owner.TypeCar = TypeCar.D;
                            break;
                        default:
                            owner.TypeCar = TypeCar.none;
                            break;
                    }
                    owner.CarNumber = Convert.ToInt32(sr.ReadLine());
                    owner.CarDate = Convert.ToDateTime(sr.ReadLine());
                    ldriver.Add(owner);
                }
                return ldriver;
            }
        }

        public override void Save(string path, ListDrivers ldriver)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
            {
                foreach (CarOwner i in ldriver.GetList())
                {
                    sw.WriteLine();
                    sw.WriteLine(i.FullName);
                    sw.WriteLine(i.TypeLicense);
                    sw.WriteLine(i.ModelCar);
                    sw.WriteLine(i.TypeCar);
                    sw.WriteLine(i.CarNumber);
                    sw.WriteLine(i.CarDate);
                }
                sw.Close();
            }
        }          
          
    }
}
