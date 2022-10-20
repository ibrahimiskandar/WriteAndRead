using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\\Users\\acer\\Desktop\\Text\\text.txt";
            //Console.WriteLine("methodu daxil edin:\n");
            //Console.WriteLine("1.Write:");
            //Console.WriteLine("2.Read:");
            //int option = Convert.ToInt32(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Daxil edilecek deyisen sayini daxil edin:");
            //        int n = Convert.ToInt32(Console.ReadLine());
            //        string[] input = new string[n];
            //        Console.WriteLine("Deyisenleri daxil edin");
            //        for (int i = 0; i < input.Length; i++)
            //        {
            //            input[i] = Convert.ToString(Console.ReadLine());
            //        }
            //        WriteFile(input);
            //        break;
            //    case 2:
            //        ReadFile();
            //        break;
            //    default:
            //        break;
            //}

            //void WriteFile(string[] lines)
            //{
            //    try
            //    {
            //        if (File.Exists(path))
            //        {
            //            using (StreamWriter sr = new StreamWriter(path, true))
            //            {
            //                foreach (string line in lines)
            //                {
            //                    if (!line.Contains("Second"))
            //                    {
            //                        sr.WriteLineAsync(line);
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            using (StreamWriter sr = new StreamWriter(path))
            //            {

            //                foreach (string line in lines)
            //                {
            //                    if (!line.Contains("Second"))
            //                    {
            //                        sr.WriteLineAsync(line);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("The file could not be read:");
            //        Console.WriteLine(e.Message);
            //    }
            //    Console.ReadKey();
            //}


            //void ReadFile()
            //{
            //    try
            //    {
            //        using (StreamReader sr = new StreamReader(path))
            //        {
            //            string line;

            //            while ((line = sr.ReadLine()) != null)
            //            {
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("The file could not be read:");
            //        Console.WriteLine(e.Message);
            //    }
            //    Console.ReadKey();
            //}

            GFG obj = new GFG(50);

            obj--;

            obj.Display();
        }
    }
}

