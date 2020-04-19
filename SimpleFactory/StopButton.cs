using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class StopButton : Button
    {
        public StopButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {
            Console.WriteLine("Stop video...");
        }
    }
}
