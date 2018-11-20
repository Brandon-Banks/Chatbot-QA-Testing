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
        [TestMethod]
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

                void TestMethod1()
                {
                childProc.WriteLine("hello");
                output.Add("hello");
                    // Wait for the root shell prompt to appear
                    // Wait until the root shell prompt appears and return the directory contents
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                childProc.WriteLine("--reset");
                }

                void TestMethod2()
                {
                    // Model directory to store checkpointed models
                    childProc.WriteLine("--save_dir");
                    output.Add("--save_dir");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod3()
                {
                    childProc.WriteLine("--prime");
                    output.Add("--prime");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10))
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod4()
                {
                    // Number of characters to sample
                    childProc.WriteLine("-n");
                    output.Add("-n");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod5()
                {
                    // Width of the beam for beam search, default 2
                    childProc.WriteLine("--beam_width");
                    output.Add("--beam_width");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod6()
                {
                    // sampling temperature
                    childProc.WriteLine("--temperature");
                    output.Add("--temperature");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod7()
                {
                    // At each step, choose from only this many most likely characters
                    childProc.WriteLine("--topn");
                    output.Add("--topn");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod8()
                {
                    // Amount of relevance masking
                    childProc.WriteLine("--relevance");
                    output.Add("--relevance");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod9()
                {
                    // Model state reset
                    childProc.WriteLine("--reset");
                    output.Add("--reset");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod10()
                {
                    // Test using --reset before a word
                    childProc.WriteLine("--resetmytextbox");
                    output.Add("--resetmytextbox");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod11()
                {
                    // Test --reset within a word
                    childProc.WriteLine("hello--resetworld");
                    output.Add("hello--resetworld");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod12()
                {
                    // Case Sensitivity
                    childProc.WriteLine("--REsET");
                    output.Add("--REsET");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod13()
                {
                    // Random character test
                    childProc.WriteLine("@$)%");
                    output.Add("@$)%");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod14()
                {
                    // Random char surrounding word
                    childProc.WriteLine("*rawr*");
                    output.Add("*rawr*");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod15()
                {
                    // Empty string
                    childProc.WriteLine("");
                    output.Add("");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod16()
                {
                    // Randomly Constructed Improper Sentence
                    childProc.WriteLine("Rock and roll jazz vocals");
                    output.Add("Rock and roll jazz vocals");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod17()
                {
                    // Testing understanding of model trained on
                    childProc.WriteLine("What music do you listen to?");
                    output.Add("What music do you listen to?");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod18()
                {
                    // Testing understanding of model trained on
                    childProc.WriteLine("Do you like music?");
                    output.Add("Do you like music?");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod19()
                {
                    // Improper Punctuation
                    childProc.WriteLine("... What! IS your favorite song!");
                    output.Add("... What! IS your favorite song!");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod20()
                {
                    // Improper Punctuation
                    childProc.WriteLine("!Music!");
                    output.Add("!Music!");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod21()
                {
                    // Improper Punctuation
                    childProc.WriteLine("?Yes");
                    output.Add("?Yes");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod22()
                {
                    // Different Languages
                    childProc.WriteLine("hola");
                    output.Add("hola");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod23()
                {
                    // Diff lang.
                    childProc.WriteLine("hallo");
                    output.Add("hallo");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod24()
                {
                    // diff lang
                    childProc.WriteLine("bonjour");
                    output.Add("bonjour");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod25()
                {
                    // diff lang
                    childProc.WriteLine("Prevet");
                    output.Add("Prevet");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod26()
                {
                    // dif lang
                    childProc.WriteLine("こんにちは");
                    output.Add("こんにちは");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod27()
                {
                    // dif lang
                    childProc.WriteLine("ciao");
                    output.Add("ciao");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod28()
                {
                    // dif lang
                    childProc.WriteLine("こんにちは");
                    output.Add("こんにちは");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod29()
                {
                    // Repeating words
                    childProc.WriteLine("hellohellohellohello");
                    output.Add("hellohellohellohello");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod30()
                {
                    // ALL CAPS
                    childProc.WriteLine("WELL HELLO THERE");
                    output.Add("WELL HELLO THERE");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod31()
                {
                    // multiple commands
                    childProc.WriteLine("--reset --topn");
                    output.Add("--reset --topn");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod32()
                {
                    // multiple commands
                    childProc.WriteLine("--topn --reset");
                    output.Add("--topn --reset");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod33()
                {
                    // multiple commands
                    childProc.WriteLine("--reset --reset");
                    output.Add("--reset --reset");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod34()
                {
                    // multiple commands
                    childProc.WriteLine("--beam_width --topn");
                    output.Add("--beam_width --topn");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod35()
                {
                    // multiple commands
                    childProc.WriteLine("--beam_width --beam_width");
                    output.Add("--beam_width --beam_width");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod36()
                {
                    // extended-nonsense strings
                    childProc.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                    output.Add("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod37()
                {
                    // random characters
                    childProc.WriteLine("lkasdjflkdjfalskJDglkdjsalgkjdlskgjlkfdshgaidjglkasjdglkdsjglkjsdlkjlsdakfjldkjflkdjflkajdslgkhfoghafeb");
                    output.Add("lkasdjflkdjfalskJDglkdjsalgkjdlskgjlkfdshgaidjglkasjdglkdsjglkjsdlkjlsdakfjldkjflkdjflkajdslgkhfoghafeb");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod38()
                {
                    // random special characters
                    childProc.WriteLine("!@#$%^&^%$#*(*%#$%^&_*&&^&$#^%%((^");
                    output.Add("!@#$%^&^%$#*(*%#$%^&_*&&^&$#^%%((^");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod39()
                {
                    // quotations
                    childProc.WriteLine("'How are you?' asked the man.");
                    output.Add("'How are you?' asked the man.");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }

                void TestMethod40()
                {
                    // 
                    childProc.WriteLine("sdg");
                    output.Add("");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output.Add(childProc.Read(""));
                    childProc.WriteLine("--reset");
                }
            }
            using (StreamWriter sw = new StreamWriter("D:\\ExpectTest\\testResults.text"))
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
