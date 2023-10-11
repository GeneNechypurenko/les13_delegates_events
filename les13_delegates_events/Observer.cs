using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace les13_delegates_events
{
    internal class Observer
    {
        public void DoubleClicked(string action, MyButton myButton)
        {
            Console.WriteLine("Double clicked");
        }
        public void ButtonInfo(string action, MyButton myButton)
        {
            Console.WriteLine($"button: {myButton.Text}\ncolor: {myButton.Color}\nwidth: {myButton.Width}\nheight: {myButton.Height}");
        }
        public void WelcomeString(string action, MyButton myButton)
        {
            Console.WriteLine("Hello User");
        }
    }
}
