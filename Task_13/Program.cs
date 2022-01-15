using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            MultiBuilding multiBuilding = new MultiBuilding();
            Console.WriteLine(building.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();

        }

        public class Building
        {
            public string Address { get; set; }
            public int A { get; set; }
            public int B { get; set; }
            public int H { get; set; }

            public Building()
            {
                this.Address = "Шоссейная д.61";
                this.A = 50;
                this.B = 100;
                this.H = 20;

            }
            public string Print()
            {
                return string.Format("Адрес: {0}, Длина: {1}, Ширина: {2}, Высота: {3}.", Address, A, B, H);
            }
        }
        sealed class MultiBuilding : Building
        {
            public int E { get; set; }
            public MultiBuilding() : base()
            {
                this.Address = "Шоссейная д.70";
                this.A = 100;
                this.B = 200;
                this.H = 50;
                this.E = 12;
            }
            public string Print()
            {
                return string.Format("Адрес: {0}, Длина: {1}, Ширина: {2}, Высота: {3}, Этажей: {4}", Address, A, B, H, E);
            }
        }
    }
}
