using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public abstract class Button
    {
        public string Text { get; set; }
        private StringBuilder ButtonWidget= new StringBuilder();
        public ConsoleKey ConsoleKey { get; set; }

        public Button(string text, ConsoleKey consoleKey)
        {            
            Text = text;
            ConsoleKey = consoleKey;

            if (!String.IsNullOrEmpty(text))
            {
                CreateWidget();
            }
        }

        public abstract void OnClick();

        public void Display()
        {
            Console.WriteLine(ButtonWidget);
        }

        private void CreateWidget()
        {
            AddHorizontalLine();
            ButtonWidget.Append($"\n|{Text}|\n");
            AddHorizontalLine();
        }

        private void AddHorizontalLine()
        {               
            ButtonWidget.Append('-', Text.Length + 2);
        }
    }
}
