using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class BigRedButton
    {
        private Action onButtonPush;

        public BigRedButton(Action onButtonPush)
        {
            this.onButtonPush = onButtonPush;
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
            Console.WriteLine("Launching Big Massive Rocket!!!");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            BigMassiveRocket rocket = new BigMassiveRocket();
            BigRedButton button = new BigRedButton(rocket.Launch);

            string userInput = string.Empty;

            while (userInput != "q")
            {
                if (userInput == "push")
                {
                    Action pushMethod = button.Push;

                    pushMethod();
                }

                userInput = Console.ReadLine();
            }
        }
    }
}