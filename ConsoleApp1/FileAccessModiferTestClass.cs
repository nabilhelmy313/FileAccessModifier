using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// the file access modifier is make it visible in its file only
    /// </summary>
    file  class FileAccessModiferTestClass
    {
        public void ConsoleMethodToSee()
        {
            Console.WriteLine("From Class Wtih  File Access modifier");
        }
    }

    public class PrintConsoleClass
    {
        void ConsoleMessage()
        {
            FileAccessModiferTestClass fileAccess=new ();
            fileAccess.ConsoleMethodToSee();
        }
    }
}
