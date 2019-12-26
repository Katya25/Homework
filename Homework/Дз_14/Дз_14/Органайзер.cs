using System;
using System.Collections.Generic;
using System.Text;

namespace Дз_14
{
    class paper
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Density { get; set; }        //плотность
        public string Text { get; set; }
        public bool squared { get; set; }      //В клетку?

        public void Print()
        {
            Console.WriteLine($"I have some text: \" {Text}\"");
        }
    }

    class notebook : paper           //тетрадь
    {
        public int pages { get; set; }
        public string Brand { get; set; }
        public bool HasCoverArt { get; set; }       //Есть рисунок на обложке?
    }
    class notepad : paper            //блокнот
    {
        public bool HasDrawingsOnThePages { get; set; }         //Рисунки на страницах
    }

    class diary : notepad            //Дневник
    {
        public string Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
    }

}
