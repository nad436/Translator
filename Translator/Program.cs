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
           
            Console.WriteLine($"Hello!\nThis is a translator.\nPlease write an English word to get its translation in Ukrainian");
            string word = Console.ReadLine();
            word = word.ToLower();
            switch (word) 
            {
                case "hello":
                    Console.WriteLine("привіт");
                    break;
                case "goodbye":
                    Console.WriteLine("допобачення");
                    break;
                case "thanks":
                    Console.WriteLine("дякую");
                    break;
                case "programming":
                    Console.WriteLine("програмування");
                    break;
                case "silence":
                    Console.WriteLine("мовчання");
                    break;
                case "lamb":
                    Console.WriteLine("ягня");
                    break;
                default:
                    Console.WriteLine("Sorry, but you can't translate this");
                    break;
                    
            }
        }
        }
    }

