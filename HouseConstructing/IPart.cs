using System;
using System.Threading.Tasks;


namespace HouseConstruction
{
   internal interface IPart
   {
        public void AddProgress(int progress);

        public int Cost { get; set; }
 
        public int Progress { get; set; }

        public string PartTitle { get; set; }
   }
}
