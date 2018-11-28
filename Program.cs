using Cbonnell.DotNetExpect;
using System;
using System.Collections.Generic;
using System.IO;



namespace ExpectTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Brandon\\Desktop\\testResults.txt"))
            {
                chatbotTest aChatbotTest = new chatbotTest();
                sw.WriteLine("-----------");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("-----------");
                sw.WriteLine(aChatbotTest.RunTests());
                sw.WriteLine("----------------------------------------------------------\n");
            }

        }
        public class chatbotTest
        {
            public string RunTests()
            {
                string output = "";

                using (ChildProcess childProc = new ChildProcess("C:\\WINDOWS\\system32\\cmd.exe"))
                {
                    //navigate to and start the program
                    //System.Diagnostics.Debug.WriteLine(
                    childProc.Read(">");
                    childProc.WriteLine("C:");
                    childProc.WriteLine("cd \\Users\\Brandon\\Desktop\\chatbot-rnn-master");
                    //System.Diagnostics.Debug.WriteLine(
                    childProc.Read(">");

                    childProc.WriteLine("python chatbot.py");
                    //wait for program startup
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
                    //childProc.WriteLine(childProc.Read(""));

                    string[] inputs = {"hello!!!", "test 2", "What is your name?"};

                    //test 1

                    for(int i = 0; i < inputs.Length; i++)
                    {
                        string input = inputs[i];
                        childProc.WriteLine(input);
                        //output += "Input " + i + ": " + input + "\n";
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
                        output += childProc.Read("") + "\n";
                        childProc.WriteLine("--reset");
                    }
                    
                    return output;
                }
            }
        }
    }
}