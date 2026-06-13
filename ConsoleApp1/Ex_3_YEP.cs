using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Ex_3_YEP
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------\n" +
            "| Exercise #3 / Year-End Project |\n" +
            "----------------------------------\n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            List<string> PhraseОfPraise = new List<string>();
            PhraseОfPraise.Add("Продуктът е отличен.");
            PhraseОfPraise.Add("Това е страхотен продукт.");
            PhraseОfPraise.Add("Постоянно ползвам този продукт.");
            PhraseОfPraise.Add("Това е най-добрият продукт от тази категория.");
            List<string> PraiseworthyEvents = new List<string>();
            PraiseworthyEvents.Add("Чувствам добре.");
            PraiseworthyEvents.Add("Успях да се променя.");
            PraiseworthyEvents.Add("Спечелих! Случи се чудо!");
            PraiseworthyEvents.Add("Не мога да повярвам, но успях да превъзмогна себе си.");
            PraiseworthyEvents.Add("Опитайте и вие. Аз съм много доволна.");
            List<string> FirstName = new List<string>();
            FirstName.Add("Калина");
            FirstName.Add("Гергана");
            FirstName.Add("Стела");
            FirstName.Add("Елена");
            FirstName.Add("Катя");
            List<string> SecondName = new List<string>();
            SecondName.Add("Иванова");
            SecondName.Add("Петрова");
            SecondName.Add("Кирова");
            List<string> Cities = new List<string>();
            Cities.Add("София");
            Cities.Add("Варна");
            Cities.Add("Русе");
            Cities.Add("Бургас");
            Cities.Add("Карлово");
            Cities.Add("Сопот");
            Random rnd = new Random();
            int[] MaxLenght = new int[7];
            Console.WriteLine($"{PhraseОfPraise[rnd.Next(PhraseОfPraise.Count)]}, {PraiseworthyEvents[rnd.Next(PraiseworthyEvents.Count)]}, {FirstName[rnd.Next(FirstName.Count)]} {SecondName[rnd.Next(SecondName.Count)]}, {Cities[rnd.Next(Cities.Count)]}.");
            Console.ResetColor();
        }
    }
}