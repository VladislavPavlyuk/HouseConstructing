using System;
using System.Numerics;
using System.Xml.Linq;
using static HouseConstruction.Construction;

namespace HouseConstruction
{
    class Worker : IWorker
    {

        public Worker() { }

        public Worker(string name, string occupation, int salary)
        {
            FullName = name;
            Occupation = occupation;
            Salary = salary;
        }

        public void Act()
        {
            try
            {
                Console.WriteLine("\n{0}\t{1}\t{2}\t" + Salary, Occupation, FullName);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Print()
        {
            Console.WriteLine("\n{0} \t {1} \t {2}", FullName, Occupation, Salary);
        }

        public string FullName
        {
            set => _fullName = value;

            get => _fullName;
        }

        public int Salary
        {
            set => _salary = value;

            get => _salary;
        }

        public string Occupation
        {
            set => _occupation = value;

            get => _occupation;
        }
    }
}
