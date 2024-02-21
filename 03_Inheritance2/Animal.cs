using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance2
{
    internal class Animal
    {
        // Bu sınıf en genel ortak özelliklerin bulunduğu bir sınıf

        // Constuructor/Yapıcı metot
        public Animal()
        {
            // Sadece bilgi verecek
            Console.WriteLine($"Ortak özelliklerin bulunduğu sınıf : Tipi :{typeof(Animal)}\n\n");
        }

        #region Properties
        private int _footCount;
        private int _age;
        private DateTime _birthDate;
        private List<HealthCare> _healthCareHistory;
        private double _weight;

        public int FootCount
        { get => _footCount; set => _footCount = value; }
        public int Age
        { get => _age; set => _age = value; }
        public DateTime BirthDate
        { get => _birthDate; set => _birthDate = value; }
        public List<HealthCare> HealthCareHistory
        { get => _healthCareHistory; set => _healthCareHistory = value; }
        public double Weight
        { get => _weight; set => _weight = value; }

        #endregion


        #region Methods/Functions
        public void Eat()
        {
            Console.WriteLine("Hayvanlar yer...\n\n");
        }

        public int Run(int minute, int distance, out int cal)
        {
            int _result;

            _result = minute * distance;

            cal = _result / 100;

            return _result;
        }

        public TimeSpan Rest(DateTime beginDate, DateTime endDate)
        {
            TimeSpan _result;

            _result = endDate.Subtract(beginDate);

            return _result;

        }

        #endregion



        private string _animalInfo;

        public string AnimalInfo
        {
            get
            {
                string _result;

                StringBuilder _sb = new StringBuilder();

                _sb.Append($"FootCount : {_footCount}\n");
                _sb.Append($"Age : {_age}\n");
                _sb.Append($"BirthDate : {_birthDate}\n");
                _sb.Append($"Weight : {_weight}\n");
                _sb.Append($"Health Care History :" + $"{GetHealthCareHistory(HealthCareHistory)}\n\n");

                _result = _sb.ToString();
                return _result;

            }

        }

        private string GetHealthCareHistory(List<HealthCare> HealtCareHistory)
        {
            string _result;

            StringBuilder _str = new StringBuilder();

            foreach (HealthCare item in HealthCareHistory)
            {
                _str.Append($"{item.Date.ToString("yyyy-MM-dd")} - {item.Notes}");
                _str.Append(";");
            }

            _result = _str.ToString();

            return _result;


        }
    }
}
