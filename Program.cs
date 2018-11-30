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

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Brandon\\Desktop\\newTestResults.txt"))
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
                    childProc.Read(">");
                    childProc.WriteLine("C:");
                    childProc.WriteLine("cd \\Users\\Brandon\\Desktop\\chatbot-rnn-master");
                    childProc.Read(">");

                    childProc.WriteLine("python chatbot.py");
                    //wait for program startup
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));

                    string[] inputs = {
                        //7
                        "hello!!!",     //greetings
                        "What's up?",    //greetings/ cultural sayings
                        "It's a problem, but I have bigger fish to fry.", //cultural sayings
                        "What have you been up to lately?", //personal questions
                        "How are you?",     //personal questions
                        "What is your name?",    //personal questions
                        "Who is the president of the U.S.?",     //factual questions
                        "What is two plus two?", //factual questions
                        "What color is the sky?",   //factual but more open to interpretation
                        "Let's talk about dogs.",   //directing converation flow
                        "Do you have any dogs?",    //personal questions
                        "How many dogs do you have?",   //personal questions/ contextual questions(answer dependent on last answer)
                        "What is your favorite breed of dog?",  //personal, contextual questions
                        "Do you like poodles?", //personal, contextual questions (answer dependent on last answer)

                        //8
                        "--topn 0",     //topn parameter adjustment boundary test
                        "--topn -1",    //topn parameter adjustment boundary test
                        "--topn 1",     //topn parameter adjustment boundary test
                        "--topn 999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999" +
                        "9999999999999999999999999999999999999999999999999999999999999999", 
                        //topn parameter adjustment boundary test
                        "Breakfast procuring nay end happiness allowance assurance frankness. Met simplicity nor difficulty unreserved who. Entreaties mr conviction dissimilar me astonished estimating cultivated. On no applauded exquisite my additions. Pronounce add boy estimable nay suspected. You sudden nay elinor thirty esteem temper. Quiet leave shy you gay off asked large style." +
                        "Arrival entered an if drawing request.How daughters not promotion few knowledge contented.Yet winter law behind number stairs garret excuse. Minuter we natural conduct gravity if pointed oh no. Am immediate unwilling of attempted admitting disposing it. Handsome opinions on am at it ladyship." +
                        "An country demesne message it.Bachelor domestic extended doubtful as concerns at.Morning prudent removal an letters by. On could my in order never it.Or excited certain sixteen it to parties colonel. Depending conveying direction has led immediate. Law gate her well bed life feet seen rent.On nature or no except it sussex." +
                        "By an outlived insisted procured improved am.Paid hill fine ten now love even leaf. Supplied feelings mr of dissuade recurred no it offering honoured. Am of of in collecting devonshire favourable excellence. Her sixteen end ashamed cottage yet reached get hearing invited. Resources ourselves sweetness ye do no perfectly. Warmly warmth six one any wisdom.Family giving is pulled beauty chatty highly no.Blessing appetite domestic did mrs judgment rendered entirely. Highly indeed had garden not." +
                        "He do subjects prepared bachelor juvenile ye oh.He feelings removing informed he as ignorant we prepared. Evening do forming observe spirits is in. Country hearted be of justice sending. On so they as with room cold ye.Be call four my went mean. Celebrated if remarkably especially an. Going eat set she books found met aware. " +
                        "Remember outweigh do he desirous no cheerful.Do of doors water ye guest. We if prosperous comparison middletons at.Park we in lose like at no. An so to preferred convinced distrusts he determine. In musical me my placing clothes comfort pleased hearing.Any residence you satisfied and rapturous certainty two. Procured outweigh as outlived so so. On in bringing graceful proposal blessing of marriage outlived.Son rent face our loud near." +
                        "Friendship contrasted solicitude insipidity in introduced literature it.He seemed denote except as oppose do spring my. Between any may mention evening age shortly can ability regular.He shortly sixteen of colonel colonel evening cordial to.Although jointure an my of mistress servants am weddings.Age why the therefore education unfeeling for arranging.Above again money own scale maids ham least led.Returned settling produced strongly ecstatic use yourself way.Repulsive extremity enjoyment she perceived nor." +
                        "Lose john poor same it case do year we. Full how way even the sigh.Extremely nor furniture fat questions now provision incommode preserved.Our side fail find like now. Discovered travelling for insensible partiality unpleasing impossible she.Sudden up my excuse to suffer ladies though or.Bachelor possible marianne directly confined relation as on he." +
                        "Another journey chamber way yet females man.Way extensive and dejection get delivered deficient sincerity gentleman age.Too end instrument possession contrasted motionless.Calling offence six joy feeling.Coming merits and was talent enough far.Sir joy northward sportsmen education.Discovery incommode earnestly no he commanded if.Put still any about manor heard." +
                        "Supplied directly pleasant we ignorant ecstatic of jointure so if.These spoke house of we. Ask put yet excuse person see change.Do inhabiting no stimulated unpleasing of admiration he. Enquire explain another he in brandon enjoyed be service. Given mrs she first china.Table party no or trees an while it since.On oh celebrated at be announcing dissimilar insipidity. Ham marked engage oppose cousin ask add yet." ,
                         //number of words boundary test
                        "How much wood could a woodchuck chuck if a woodchuck could chuck wood?",     //riddles
                        "Do you prefer red or blue?",    //choices
                        "Who was a better candidate? Trump or Clinton?",     //choices, opinions, multi-part questions
                        "What's more chill? Sports cars, Touchscreen TVs, or dolphins?", //cultural sayings, choices, opinions, multi-part questions
                        "Do you like cats? Do you like dogs? Which one do you prefer?", //multi-part questions, choices
                        "Cupcakes are sweet, but I'm not sure how to feel about them... What do you think?", //contextual questions, multi-part questions
                        "If three people get on a bus and then one person gets off the bus, how many people are on the bus?", //contextual questions, multi-part questions
                        "--reset",  //what happens if you keep resetting?
                        "--reset",
                        "--reset",
                        "--reset",
                        "--reset",
                        "--reset",

                        //9
                        "hello? What you do,!",     //strange grammar
                        "favorite color what is?",    //strange grammar
                        "What, is, your, favorite, color?", //strange grammar
                        "How. are. you.", //strange grammar
                        "Which way is North South?",     //impossible questions
                        "hElLO. wHAT Is YoUr NAmE?",    //strange grammar
                        "Who was the best American president that never became president?", //impossible questions
                        "How              are                you     today?", //strange grammar
                        "Nicetomeetyou.Whatdoyoulike?",   //strange grammar
                        "What happens when an unstoppable object hits an unmovable object?",   //impossible questions, riddles
                        "!!!!!!!Wow", //strange grammar

                        //11
                         "Which do you prefer(one or two)?", //understanding of (at least somewhat) properly used non-alphabetical characters- parens
                        "Which do you prefer- one or two?", //understanding of (at least somewhat )properly used non-alphabetical characters- dash
                        "Which do you prefer: one or two?", //understanding of (at least somewhat) properly used non-alphabetical characters- colon
                        "Go eat, John.", //understanding of commas- not "Go eat John."
                        "That is cool?", //understanding of question marks- not "That is cool."
                        "What do you think of green & blue?", //understanding of ampersand
                        "Is this weird/ strange or just interesting/ intriguing?", //understanding of slash
                        "Hi.            How are you? Where have       you   been?", //How are spaces handled- ignored or interpreted?
                    
                        //10
                        "qwertyuiop.",
                        "O//|\\O",
                        "<.><.,>,.,<..>>>>>,<><",
                        "Hello! @#$%^&*gadsdfvhkjhlkjdhjkyd kfrivcxvb gfjhkh",
                        "ffffffff8{[jjjjjjjjjjj]}",
                    };


                    for(int i = 0; i < inputs.Length; i++)
                    {

                        string input = inputs[i];
                        childProc.WriteLine(input);
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
                        output += childProc.Read("") + "\n";
                        if(i < 10 || i > 12) // the tests after test 8 are a sequence, testing the memory of the chatbot between lines
                            childProc.WriteLine("--reset");
                    }

                    //10
                    //test 6-- what if the string is made only of ">" characters, and Forward_with_mask ignores the whole string?
                    childProc.WriteLine(">>>>>>>>>>>>");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output += childProc.Read("") + "\n";
                    childProc.WriteLine("--reset");

                    //test 7-- What happens if relevance is less than or equal to zero and topn 
                    //is greater than zero, causing both if statements to be true?
                    childProc.WriteLine("--relevance -1");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("--topn 2");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("Hello");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output += childProc.Read("") + "\n";
                    childProc.WriteLine("--reset");


                    //test 8-- relevance and newRelevance both equal 0
                    childProc.WriteLine("--relevance 0.0");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("--relevance 0.0");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("Hello");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output += childProc.Read("") + "\n";
                    childProc.WriteLine("--reset");

                    //test 9-- newRelevance equals relevance
                    childProc.WriteLine("--relevance 1.3");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("--relevance 1.3");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("Hello");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output += childProc.Read("") + "\n";
                    childProc.WriteLine("--reset");

                    //test 10-- division by zero(temparature) in Scale_prediction?
                    childProc.WriteLine("--temperature 0");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    childProc.WriteLine("Hello");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output += childProc.Read("") + "\n";
                    childProc.WriteLine("--reset");

                    return output;
                }
            }
        }
    }
}