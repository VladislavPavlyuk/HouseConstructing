using System;
using System.Collections;
using static HouseConstruction.Construction;

namespace HouseConstruction
{
    class Team : IWorker
    {
        ArrayList team;

        public Team ()
        {
            team = new ArrayList ();
        }

        public void Develop()
        {
            try
            {
                Random rnd = new();

                

                int teamleader = RandomNumber(Names.Length);

                for (int i = 0; i < Names.Length; i++)
                {
                    if (i == teamleader)
                    {
                        TeamLeader leader = new TeamLeader(Names[i], Occupations[1], _salaryBase * 3);

                        team.Add(leader);
                    }
                    else
                    {
                        Worker w = new Worker(Names[i], Occupations[0], _salaryBase * 2);
                    
                        team.Add(w);
                    }
                }

                //PrintTeam();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void PrintTeam()
        {
            try
            {
                Console.Write("\n БРИГАДА : ");

                foreach (Worker temp in team)
                {
                    temp.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int RandomNumber(int num)
        {
            Random rnd = new Random();
            return rnd.Next(0, num);
        }

        public void Act()
        {
            try
            {
                //Console.WriteLine("\n{0}\t{1}\t{2}\t" + Salary, Occupation, FullName);

            }
            catch (Exception)
            {

                throw;
            }
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
