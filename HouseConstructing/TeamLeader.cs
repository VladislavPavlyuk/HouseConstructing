using System;
using static HouseConstruction.Construction;

namespace HouseConstruction
{
    class TeamLeader : IWorker
    {
        public TeamLeader() { }

        public TeamLeader(string name, string occupation, int salary)
        {
            FullName = name;
            Occupation = occupation;
            Salary = salary;
        }

        public void Act()
        {
            try
            {
                Console.Write("\n" + Occupations[1] + " : ");

                //Console.WriteLine("\n{0}\t{1}\t{2}\t" + Salary, Occupation, FullName);

                Report();

            }
            catch (Exception)
            {              
                throw;
            }
        }

        public void Report()
        {
            Console.WriteLine("Прогресс - " + CurrentProgress + " % !");
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
