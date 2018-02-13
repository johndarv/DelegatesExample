using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    delegate void ButtonPushHandler();

    class BigRedButton
    {
        private ButtonPushHandler onButtonPush;

        public void RegisterHandler(ButtonPushHandler handler)
        {
            this.onButtonPush = handler;
        }

        public void Push()
        {
            this.onButtonPush();
        }
    }

    class BigMassiveRocket
    {
        public void Launch()
        {
            Console.WriteLine($"Launching Big Massive Rocket!!!");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            BigMassiveRocket rocket = new BigMassiveRocket();
            BigRedButton button = new BigRedButton();

            button.RegisterHandler(rocket.Launch);

            string userInput = string.Empty;

            while (userInput != "q")
            {
                if (userInput == "push")
                {
                    button.Push();
                }

                userInput = Console.ReadLine();
            }
        }
    }
}