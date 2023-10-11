using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les13_delegates_events
{
    internal class MyButton
    {
        public string? Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Text { get; set; }

        public event Action<string, MyButton>? OnClickMyButton;
        public void Click(string action)
        {
            OnClickMyButton?.Invoke(action, this);
        }
    }
}
