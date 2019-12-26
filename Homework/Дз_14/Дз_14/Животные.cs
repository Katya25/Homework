using System;
using System.Collections.Generic;
using System.Text;

namespace Дз_14
{
    class Animals
    {
        public readonly string TypeOfFood = "heterotrophic nutrition";      //Тип питания - гетеротрофный
        public readonly bool HasCellWall = false;       //Наличие клеточной стенки
        public string breeding { get; set; }
        public double height { get; set; }
        public string Habitat { get; set; }   //среда обитания
        public bool ManyСells { get; set; }

        public void Eat()
        {
            Console.WriteLine("I can eat:)");
        }
        public void Breath()
        {
            Console.WriteLine("I can breathe");
        }
        public void Grow()
        {
            Console.WriteLine("i can grow");
        }

    }
    class Unicellular : Animals   //Одноклеточные
    {
        public readonly bool MotionOrganoids = true;        //органоиды движения
        public void SayUnicellular()
        {
            Console.WriteLine("I have only one cell! I'm Unicellular");
        }
    }
    class multicellular : Animals  //Многоклеточные
    {
        public string WhatLimbs { get; set; }      //Какие конечности
        public bool HasSkeleton { get; set; }
        public bool HasBlood { get; set; }

    }
    class birds : multicellular
    {
        public void Kar()
        {
            Console.WriteLine("Kar!!!!!");
        }
        public void Fly()
        {
            Console.WriteLine("Kar Kar Kar (the bird wanted to say that it can fly)");
        }
    }
    class mammals : multicellular
    {
        public bool HasTail { get; set; }
        public bool HasSpine { get; set; }      //позвоночник
        public string Gender { get; set; }
        public bool IsHungry { get; set; }
    }

    class People : mammals
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("I can speak");
        }
    }
    class Dogs : mammals
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Hav()
        {
            Console.WriteLine("Hav hav hav");
        }
    }

   
}
