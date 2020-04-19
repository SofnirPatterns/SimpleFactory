using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class PlayButton : Button
    {
        public PlayButton(string text, ConsoleKey consoleKey) : base(text, consoleKey)
        {
        }

        public override void OnClick()
        {                                 
            Console.WriteLine("Play Video...");
        }
    }
}
