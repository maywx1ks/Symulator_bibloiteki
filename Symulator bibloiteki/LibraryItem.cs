using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulator_bibloiteki
{
    internal abstract class LibraryItem
    {
        public int Id { get;  }
        public string Title { get; set; }
        public int Year { get; set; }

        public LibraryItem(int id, string title, int year) //это конструктор класса LibraryItem. Он нужен, чтобы инициализировать(задать начальные значения) свойствам объекта, когда мы его создаём.
        {
            Id = id;
            Title = title;
            Year = year;
        }
        virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Year: {Year}");
        }


    }
}
