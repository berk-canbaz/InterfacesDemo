using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici Yemeğe Çıktı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici Maaşı Ödendi");
        }

        public void Work()
        {
            Console.WriteLine("Yönetici Mesaiye Başladı");
        }
    }
}
