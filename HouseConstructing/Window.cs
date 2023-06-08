using System;
using static HouseConstruction.Construction;

namespace HouseConstruction
{
    class Window : IPart
    {
        public void Act()
        {
            try
            {
                Progress = ProgressWeight[3];

                PartTitle = PartName[3];

                Cost = PartCosts[3];

                AddProgress(Progress);

                Console.Write("\n" + PartTitle + " установлено!");
            }
            catch (Exception)
            {
                throw;
            }

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
