using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();

            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            ISalary[] getSalaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            projectManager.Work(workers);
            projectManager.Eat(eats);
            projectManager.GetSalary(getSalaries);
        }
    }
}
