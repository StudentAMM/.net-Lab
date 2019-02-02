using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    [Serializable]
    public class CarOwner:IComparable<CarOwner>
     {
        [NonSerialized] public int id;
        public string FullName { get; set; }
        public TypeCar TypeLicense { get; set; }
        public String ModelCar { get; set; }   
        public TypeCar TypeCar { get; set; }
        public int CarNumber { get; set;}
        public DateTime CarDate { get; set; }

        public string[] ToRows()
        {
            string[] row = { FullName, TypeLicense.ToString() , ModelCar, TypeCar.ToString(), CarNumber.ToString(), CarDate.ToString()};
            return row;
        }
        public static bool operator !=(CarOwner co1, CarOwner co2)
        {
            return co1.id != co2.id;
        }
        public static bool operator ==(CarOwner co1, CarOwner co2)
        {
            return co1.id == co2.id;
        }

        public override bool Equals(object obj)
        {
            return this == (obj as CarOwner);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(CarOwner other)
        {
            return this.FullName.CompareTo(other.FullName);
        }

        public bool IsCanDrive()
        {
            if (TypeLicense == TypeCar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
