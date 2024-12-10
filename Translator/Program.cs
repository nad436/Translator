using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Привіт!\nЦе перекладач\nБудь ласка напиши слово слово щоб його переклад на англійській");
            string word = Console.ReadLine();
            word = word.ToLower();
            switch (word)
            {
                case "привіт":
                    Console.WriteLine("hello");
                    break;
                case "допобачення":
                    Console.WriteLine("goodbye");
                    break;
                case "дякую":
                    Console.WriteLine("thanks");
                    break;
                case "програмування":
                    Console.WriteLine("programming");
                    break;
                case "мовчання":
                    Console.WriteLine("silence");
                    break;
                case "душа":
                    Console.WriteLine("soul");
                    break;
                case "темний":
                    Console.WriteLine("dark");
                    break;
                default:
                    Console.WriteLine("Вибач, але ти не можеш перевести це");
                    break;
            }
        }
    }
}
