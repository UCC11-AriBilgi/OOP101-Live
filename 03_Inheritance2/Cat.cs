using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance2
{
    public enum HouseType
    {
        small,
        medium,
        big
    }

    internal class Cat : Animal // Animal sınıfından kalıtıyorum
    {
        public Cat() 
        {
            Console.WriteLine("Burası Cat sınıfı....");
        }

        private string _catHouse;

        public string CatHouse { get => _catHouse; set => _catHouse = value; }

        public double CatHousePrice(HouseType _houseType)
        {
            double _result = 0.0;

            switch (_houseType)
            {
                case HouseType.small:
                    _result = 300;
                    break;
                case HouseType.medium:
                    _result = 500;
                    break;
                case HouseType.big:
                    _result = 1000;
                    break;
                default:
                    break;
            }

            return _result;
        }

    }
}
