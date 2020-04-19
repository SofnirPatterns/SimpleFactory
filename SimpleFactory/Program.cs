using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Button> buttons = new List<Button>();

            ButtonFactory buttonFactory = new ButtonFactory();
            buttons.Add(buttonFactory.CreateButton(Enums.ButtonType.Play));
            buttons.Add(buttonFactory.CreateButton(Enums.ButtonType.Stop));
            buttons.Add(buttonFactory.CreateButton(Enums.ButtonType.Pause));

            foreach (Button button in buttons)
            {
                button.Display();
                Console.WriteLine(button.ConsoleKey.ToString());
                Console.WriteLine();
            }                        

            while (true)
            {                
                if (Console.KeyAvailable)
                {
                    ConsoleKey consoleKey = Console.ReadKey(true).Key;

                    foreach (Button button in buttons)
                    {
                        if (consoleKey == button.ConsoleKey)
                        {
                            button.OnClick();
                        }
                    }
                }
            }            
        }
    }
}
