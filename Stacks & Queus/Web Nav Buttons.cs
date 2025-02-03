using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NavigationButtons
    {
        private string _currentPage = null;
        private Stack<string> _BackStack = new Stack<string>();
        private Stack<string> _FrowardStack = new Stack<string>();

        //Test
        public NavigationButtons()
        {
            _BackStack.Push("url1");
            _BackStack.Push("url2");
            _BackStack.Push("url3");
        }
        public void ClickBackButton()
        {
            if (_BackStack.Count > 1)
            {
                string pagePopped = _BackStack.Pop();
                _FrowardStack.Push(pagePopped);
                _currentPage = _BackStack.Count > 0 ? _BackStack.Peek() : null;

            }
            Console.WriteLine($"Current page is {_currentPage}");
        }
        public void ClickFrontButton()
        {
            if (_FrowardStack.Count > 0)
            {
                string pagePopped = _FrowardStack.Pop();
                _BackStack.Push(pagePopped);
                _currentPage = _BackStack.Count > 0 ? _BackStack.Peek() : null;

            }
            Console.WriteLine($"Current page is {_currentPage}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NavigationButtons navigationButton = new NavigationButtons();
            int choice = 0;

            while (true)
            {
                Console.WriteLine("Choose 1 or 2");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: navigationButton.ClickBackButton(); break;
                    case 2: navigationButton.ClickFrontButton(); break;
                }
            }

        }
    }
}
