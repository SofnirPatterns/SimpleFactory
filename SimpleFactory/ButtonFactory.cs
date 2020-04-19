using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class ButtonFactory
    {
        public Button CreateButton(Enums.ButtonType buttonType)
        {
            switch (buttonType)
            {
                case Enums.ButtonType.Play:
                    return new PlayButton("Play", ConsoleKey.Enter);
                case Enums.ButtonType.Stop:
                    return new StopButton("Stop", ConsoleKey.Escape);
                case Enums.ButtonType.Pause:
                    return new PauseButton("Pause", ConsoleKey.Spacebar);
                default:
                    return null;
            }            
        }
    }
}
