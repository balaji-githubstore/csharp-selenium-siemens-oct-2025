using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{

    interface IWebDriver123
    {
        //public abstract --> by default all methods are public and abstract
        void Quit();
        public abstract string GetTitle();


    }

    class ChromeDriver : IWebDriver123
    {
        public string GetTitle()
        {
            return "title";
        }

        public void Quit()
        {
            Console.WriteLine("close chrome");
        }

        public void newChroem()
        {

        }
    }


    class EdgeDriver1 : IWebDriver123
    {
        public string GetTitle()
        {
            return "hello";
        }

        public void Quit()
        {
            Console.WriteLine("close edge");
        }
    }




    public class Demo7Abstraction
    {
        static void Main(string[] args)
        {
            IWebDriver123 driver=new EdgeDriver1();

            driver.Quit();

          //driver.
        }
    }
}
