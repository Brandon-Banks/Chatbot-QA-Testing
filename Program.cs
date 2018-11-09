using Cbonnell.DotNetExpect;
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.InputDevices;


namespace ExpectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChildProcess childProc = new ChildProcess("C:\\WINDOWS\\system32\\cmd.exe"))
            {
                System.Diagnostics.Debug.WriteLine(childProc.Read(">"));
                childProc.WriteLine("C:");
                childProc.WriteLine("cd \\Users\\Brandon\\Desktop\\chatbot-rnn-master");
                System.Diagnostics.Debug.WriteLine(childProc.Read(">"));

                childProc.WriteLine("python chatbot.py");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
                childProc.WriteLine(childProc.Read(""));

                childProc.WriteLine("hello");
                // Wait for the root shell prompt to appear
                //childProc.Read("#");

                // Wait until the root shell prompt appears and return the directory contents
                string dirContents = childProc.Read("");

                // Display the directory contents to our console
                Console.WriteLine(dirContents);
            }
        }
    }
}
