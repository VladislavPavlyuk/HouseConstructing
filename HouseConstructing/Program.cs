/*Реализовать программу “Строительство дома”
- Классы
    o House (Дом), Basement(Фундамент), Walls(Стены), Door(Дверь), Window(Окно), Roof(Крыша);
    o Team(Бригада строителей), Worker(Строитель), TeamLeader(Бригадир).
- Интерфейсы
    o IWorker, IPart.
Все части дома должны реализовать интерфейс IPart (Часть дома). Для рабочих и бригадира предоставляется базовый интерфейс IWorker (Рабочий).
Бригада строителей(Team) строит дом(House). Дом состоит из фундамента (Basement), стен(Wall), окон(Window), дверей(Door), крыши(Part).
В соответствии с проектом дом состоит из одного фундамента, четырёх стен, одной двери, четырёх окон и одной крыши.
Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента. Каждый строитель не знает заранее на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу.
Если в игру вступает бригадир (TeamLeader), то он не строит, а формирует отчёт о том, что уже построено и какая часть р аботы выполнена.
В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома”*/

using System;


namespace HouseConstruction
{
    class Construction
    {     
        static public int _basementCost;
        static public int _wallCost;
        static public int _doorCost;
        static public int _windowCost;
        static public int _roofCost;

        static public string _fullName;
        static public int _salary;
        static public int _salaryBase;
        static public string _occupation;

        static public string _partTitle;
        static public int _cost;
        static public int _progress;
        static public int _currentProgress;

        //static public enum Parts { Фундамент, Стены, Дверь, Окно, Крыша, Дом}
        static public readonly string[] PartName = { "Фундамент", "Стены", "Дверь", "Окна", "Крыша", "Дом" };
        static public readonly int[] ProgressWeight = { 25, 25, 5, 20, 25};
        static public readonly int[] PartCosts = { _basementCost, _wallCost, _doorCost, _windowCost, _roofCost };

        //public enum Occupations { Строитель, Бригадир, Бригада }
        static public readonly string[] Occupations = { "Строитель", "Бригадир" };

        //public enum Names { Аскольд, Дир, Олег, Игорь, Ольга, Святослав, Ярополк,  Владимир, Святополк, Ярослав, Изяслав, Всеслав, Всеволод }
        static public string[] Names = { "Аскольд", "Дир" , "Олег" }; //, "Игорь", "Ольга", "Святослав", "Ярополк", "Владимир", "Святополк", "Ярослав", "Изяслав", "Всеслав", "Всеволод" };

        public Construction() { }

        public Construction(int basementCost, int wallCost, int doorCost, int windowCost, int roofCost, int salaryBase)
        {
            _basementCost = basementCost;
            _wallCost = wallCost;
            _doorCost = doorCost;
            _windowCost = windowCost;
            _roofCost = roofCost;
            _salaryBase = salaryBase;
        }

        static public int CurrentProgress
        {
            set => _currentProgress = value;

            get => _currentProgress;
        }

        
        public Team DevelopTeam(Team t)
        {
            t.Act();

            return t;
        }

        public TeamLeader Report(TeamLeader t)
        {
            t.Act();

            return t;
        }

        public Basement ConstructBasement(Basement o)
        {
            o.Act();
            return o;
        }
        public Walls ConstructWalls(Walls o)
        {
            o.Act();
            return o;
        }
        public Door ConstructDoor(Door o)
        {
            o.Act();
            return o;
        }
        public Window ConstructWindow(Window o)
        {
            o.Act();
            return o;
        }
        public Roof ConstructRoof(Roof o)
        {
            o.Act();
            return o;
        }
        public House ConstructHouse(House o)
        {
            o.Act();
            return o;
        }

    }

    class MainClass
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("\tСТРОЙКА :\n");

            Construction house = new Construction(5000, 4000, 1000, 4000, 5000, 500);

            house.DevelopTeam(new Team()).Develop();
            house.Report(new TeamLeader());
            Console.ReadKey();

            house.ConstructBasement(new Basement());
            house.Report(new TeamLeader());
            Console.ReadKey();

            if (house.ConstructBasement(new Basement()).Progress != 0)
            house.ConstructWalls(new Walls());
            house.Report(new TeamLeader());
            Console.ReadKey();

            if (house.ConstructWalls(new Walls()).Progress != 0)
            house.ConstructDoor(new Door());
            house.Report(new TeamLeader());
            Console.ReadKey();

            if (house.ConstructDoor(new Door()).Progress != 0)
            house.ConstructWindow(new Window());
            house.Report(new TeamLeader());
            Console.ReadKey();

            if (house.ConstructWindow(new Window()).Progress != 0)
            house.ConstructRoof(new Roof());
            house.Report(new TeamLeader());
            Console.ReadKey();

            if (house.ConstructRoof(new Roof()).Progress != 0)
            house.ConstructHouse(new House());
            house.Report(new TeamLeader());
            Console.ReadKey();

        }
    }
}
