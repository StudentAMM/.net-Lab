using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{

    public class ListDrivers
    {
        public ListDrivers(List<CarOwner> co)
        {
            ListDriver = co;
        }
        private List<CarOwner> ListDriver { get; set; }

        public CarOwner this[int index]
        {
            get { return ListDriver[index]; }
            set { ListDriver[index] = value; }
        }



        public void Edit(int ind, CarOwner own)
        {
            ListDriver[ind] = own;
        }
        public void RemoveInd(int ind)
        {
            ListDriver.RemoveAt(ind);
        }

        public CarOwner Ind (int ind)
        {
            return ListDriver[ind];
        }
        public void Add(CarOwner co)
        {
            ListDriver.Add(co);
        }

        public List<CarOwner> GetList (){ return ListDriver; }
        public void Edit(CarOwner co)
        {
            int i = ListDriver.IndexOf(co);
            ListDriver[i] = co;
        }

        public void Delete(CarOwner co)
        {
            ListDriver.Remove(co);
        }
        public ListDrivers()
        {
            ListDriver = new List<CarOwner>();
        }
        

        public ListDrivers ListDriveCar(ModDrive a)
        {
            ListDrivers ResList = new ListDrivers();
            switch (a)
            {
                case ModDrive.Yes:
                    foreach (CarOwner co in ListDriver)
                    {
                        if (co.IsCanDrive())
                        {
                            ResList.ListDriver.Add(co);
                        }
                    }
                    return ResList;
                case ModDrive.No:
                    foreach (CarOwner co in ListDriver)
                    {
                        if (!co.IsCanDrive())
                        {
                            ResList.ListDriver.Add(co);
                        }
                    }
                    return ResList;
                case ModDrive.All:
                    foreach (CarOwner co in ListDriver)
                        ResList.ListDriver.Add(co);
                    return ResList;
                default:
                    return ResList;
            }
            
        }

        public void Cleare()
        {
            ListDriver.Clear();
        }
    }
}
