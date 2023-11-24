using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _27
{
    class Car
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car( 2 ,"волга",  new DateTime(2023, 10, 06), "Алексей Алексей", -25)
        };

        public int Number { get; set; }
        public string NameCar { get; set; }
        public DateTime DateService { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }


        public Car(int number, string namecar, DateTime dateservice, string fio, int age)
        {
            Number = number;
            NameCar = namecar;
            DateService = dateservice;
            FIO = fio;
            Age = age;
        }

        public static void CheckNumber(int number)
        {
            if (number < 0)
            {
                MessageBox.Show("Номер не может быть пустым");
            }
        }
        public static void CheckNameCar(string namecar)
        {
            if (string.IsNullOrEmpty(namecar))
            {
                MessageBox.Show("Название машины не может быть пустым");
            }
        }
        public static void CheckDateService(DateTime dateservice)
        {
            if (dateservice < DateTime.Now)
            {
                MessageBox.Show("Нельзя записаться на дату,которая уже была");
            }
        }
        public static void CheckFIO(string fio)
        {
            if (string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Нельзя записаться на дату,которая уже была");
            }
        }
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                MessageBox.Show("Нельзя записаться несовершеннолетнему");
            }
        }
    }
}
