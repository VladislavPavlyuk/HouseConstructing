using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseConstruction.Construction;

namespace HouseConstruction
{
    internal class House : IPart
    {
        public void Act()
        {

            try
            {
                if (CurrentProgress == 100) PrintHouse();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void PrintHouse()
        {

                string home = @"
            ░░░░░▄▄▄▄▄░░░░▄██▄░░░░░░░░░░░░░
            ░░░░░▀████░▄███▀▀██▄▄░░░░░░░░░░
            ░░░░░░███████▀░▄▄░▀███▄░░░░░░░░
            ░░░░░░█████▀░▄████▄░▀███▄░░░░░░
            ░░░░▄███▀░░▄███▀▀███▄░▀███▄▄░░░
            ░░▄███▀░▄▄████░░░░████▄░░▀███▄░
            ▄███▀░▄████████▄▄███████▄▄░▀██▄
            ▀▀░░▄██████████████████████░░▀▀
            ░░░░████▀▀▀▀▀▀▀███▀▀▀▀▀▀▀██░░░░
            ░░░░████░██░██░███░██░██░██░░░░
            ░░░░████░▄▄░▄▄░███░██░██░██░░░░
            ░░░░████░▀▀░▀▀░███▄▄▄▄▄▄▄██░░░░
            ░░░░████░██░██░████████████░░░░
            ░░░▄████▄▄▄▄▄▄▄████████████▄░░░
            ░░░█████████████████████████░░░
            ░░░█████████████████████████░░░";

                Console.WriteLine(home);
            
        }

        
        public void AddProgress(int progress)
        {
            _currentProgress += progress;
        }

        public int Cost
        {
            set => _cost = value;

            get => _cost;
        }

        public int Progress
        {
            set => _progress = value;

            get => _progress;
        }

        public string PartTitle
        {
            set => _partTitle = value;

            get => _partTitle;
        }
    }
}
