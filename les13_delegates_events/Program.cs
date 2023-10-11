using les13_delegates_events;
using System.ComponentModel;

string action = "click";

MyButton myButton = new MyButton() { Color = "red", Width = 2, Height = 3, Text = "My Button" };
Observer observer = new Observer();

myButton.OnClickMyButton += observer.DoubleClicked;
myButton.OnClickMyButton += observer.ButtonInfo;
myButton.OnClickMyButton += observer.WelcomeString;

myButton.Click(action);