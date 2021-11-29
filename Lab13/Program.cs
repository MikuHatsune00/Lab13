using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Multibuilding multibuilding = new Multibuilding("Санкт-Петербург, Невский пр.1", 100, 150, 600, 60);
            Building building1 = new Building("Санкт-Петербург, Невский пр.2", 300, 300,20);
            building1.Print();
            multibuilding.Print();
            Console.ReadKey();


        }
        class Building
        {
            public string address;
            int _length ;
            int _width;
            int _height;

            public int length { set
                { if (value < 1 || value > 1000)
                        Console.WriteLine("Длина от 1 до 1000 м");
                    else
                        _length = value;
                }
                get { return _length; }
            }

            public int width
            {
                set
                {
                    if (value < 1 || value > 1000)
                        Console.WriteLine("Ширина от 1 до 1000 м");
                    else
                        _width = value;
                }
                get { return _width; }
            }

            
            public int height
            {
                set
                {
                    if (value < 1 || value > 500)
                        Console.WriteLine("Высота от 1 до 500 м");
                    else
                        _height = value;
                }
                get { return _height; }
            }

            public Building(string Address, int L, int B, int H)
            {
                address = Address;
                length = L;
                width = B;
                height = H;
            }
            public Building()
            { }
            public void Print()

            {
                Console.WriteLine("Адрес объекта: {0}", address);
                Console.WriteLine("Длина объекта: {0}", length);
                Console.WriteLine("Ширина объекта: {0}", width);
                Console.WriteLine("Высота объекта: {0}", height);

            }
        }
        class Multibuilding : Building
        {
            int _floors;
            public int floors
            {
                set
                {
                    if (value < 1 || value > 60)
                        Console.WriteLine("Количество этажей от 1 до 60");
                    else
                        _floors = value;
                }
                get { return _floors; }
            }

            public Multibuilding(string Address, int L, int B, int H, int Floors)
                
            {
                address = Address;
                length = L;
                width = B;
                height = H;
                floors = Floors;

            }
            public new void Print()
            {
                base.Print();
                Console.WriteLine("Этажность объекта: {0}", floors);
            }
        }



    }
}
