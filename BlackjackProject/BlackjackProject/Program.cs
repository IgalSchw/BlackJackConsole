using BlackJackProjectLogic;
using System;

namespace BlackjackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Casino casino = new Casino();
            casino.Open();
            casino.WelcomePlayers();
            casino.Operate();
            casino.Close();
        }
    }
}
