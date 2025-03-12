using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    public delegate void OnClick(string message);

    // Button class
    public class Button
    {
        public event OnClick Click;

        public void ClickButton()
        {
            Console.WriteLine("Button clicked!");

            if (Click != null)
            {
                Click("Button was clicked!");
            }
        }
    }

    public class ButtonHandler
    {
        public void HandleClick(string message)
        {
            Console.WriteLine($"ButtonHandler received: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Button button = new Button();

            ButtonHandler handler = new ButtonHandler();

            button.Click += handler.HandleClick;

            button.ClickButton();

            button.Click -= handler.HandleClick;

            button.ClickButton();
        }
    }
}
