using Cbonnell.DotNetExpect;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ExpectTest
{
    [TestClass]
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<String>();

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
                output.Add("hello");
                // Wait for the root shell prompt to appear
                //childProc.Read("#");

                // Wait until the root shell prompt appears and return the directory contents
                output.Add(childProc.Read(""));


            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Brandon\\Desktop\\ExpectTest\\testResults.text"))
            {
                sw.WriteLine(DateTime.Now);
                foreach (string testinfo in output)
                {
                    sw.WriteLine(testinfo);
                }
            }

        }
    }
}
