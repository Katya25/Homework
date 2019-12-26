using System;
/*1. Создайте класс AbstractHandler. 
В теле класса создать методы void Open(), void Create(), void Change(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть 
методы открытия, создания, редактирования, сохранения определенного формата документа.*/
namespace Дз_19_1
{
    abstract class AbstractHandler 
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save(); 
    }
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML файл изменен");
        }
        public override void Create()
        {
            Console.WriteLine("XML файл создан");
        }
        public override void Open()
        {
            Console.WriteLine("XML файл открыт");
        }
        public override void Save()
        {
            Console.WriteLine("XML файл сохранен");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT файл изменен");
        }
        public override void Create()
        {
            Console.WriteLine("TXT файл создан");
        }
        public override void Open()
        {
            Console.WriteLine("TXT файл открыт");
        }
        public override void Save()
        {
            Console.WriteLine("TXT файл сохранен");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC файл изменен");
        }
        public override void Create()
        {
            Console.WriteLine("DOC файл создан");
        }
        public override void Open()
        {
            Console.WriteLine("DOC файл открыт");
        }
        public override void Save()
        {
            Console.WriteLine("DOC файл сохранен");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой файл?(TXT, XML, DOC)");
            string str = Console.ReadLine();
            switch (str)
            {
                case "TXT":
                    TXTHandler txtHander = new TXTHandler();
                        txtHander.Create();
                        txtHander.Open();
                        txtHander.Change();
                        txtHander.Save();                  
                    break;
                case "XML":
                    XMLHandler xmlHander = new XMLHandler();
                        xmlHander.Create();
                        xmlHander.Open();
                        xmlHander.Change();
                        xmlHander.Save();
                    break;
                case "DOC":
                    DOCHandler docHander = new DOCHandler();
                        docHander.Create();
                        docHander.Open();
                        docHander.Change();
                        docHander.Save();
                    break;
                default:
                    Console.WriteLine("Такой формат не поддерживается");
                    break;
            }
            

        }
    }
}
