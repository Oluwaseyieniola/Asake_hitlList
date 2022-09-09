using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asake_hitlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hitlist = new string[] { "serty, rety, pallazo, sungba" };
            


            Console.WriteLine("welcome to the asake hitlist");


            /*Console.WriteLine("what is your choice of activity on asake's hitlist today?");

           string  choice =Console.ReadLine();*/

            foreach(string str in hitlist)
            {
                Console.WriteLine("Asake's hitlist includes: " +"" + str);

                Console.WriteLine("Kindly input any song from asake you want to listen to ");

                string song = Console.ReadLine();
                Console.WriteLine("Ypu want to listen to " + " " + song);

                Console.WriteLine("This system will redirect you to a listening platform");
                string[] hit = new string[] { "serty, rety, pallazo, sungba" };
                if (hit.Contains(song))
                {
                    Console.WriteLine("derty");
                }
                else
                {
                    Console.WriteLine("please input a valid hit from asaka");
                }
            }
            
            

        }
    }
}
