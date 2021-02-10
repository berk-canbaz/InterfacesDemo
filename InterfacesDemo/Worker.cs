using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Personel Yemeğe Çıktı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Personel Maaşı Ödendi");
        }

        public void Work()
        {
            Console.WriteLine("Personel Mesaiye Başladı");
        }
    }
}
