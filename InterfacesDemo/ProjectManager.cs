using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class ProjectManager
    {
        public void Work(params IWorker[] workers)
        {
            foreach (var worker in workers)
            {
                worker.Work();
            }
        }

        public void Eat(params IEat[] eats)
        {
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

        public void GetSalary(params ISalary[] getSalaries)
        {
            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }
        }
    }
}
