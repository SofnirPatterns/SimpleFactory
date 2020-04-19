using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PauseButton : Button
    {
        public PauseButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Pause video...");
        }
    }
}
