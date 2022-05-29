using System;
using System.Collections.Generic;

namespace OnlineQuiz
{
    class Test
    {
        Quiz q = new Quiz();
        static void Main(string[] args)
        {
                Console.WriteLine("\n\n-------------------------------------------------------------------------------------------------->>> Welcome to Online Quiz.... <<<------------------------------------------------------------------------------");
                SortedList<string, string> logindetails = new SortedList<string, string>();
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t Login ID :  ");
                string login = Console.ReadLine();
                
                login = login.ToLower();
                if (login == "admin")
                {
                    Console.WriteLine("where you want to add questions.\n1.java\n2.csharp\n3.html");
                    string subject = Console.ReadLine();
                    Console.WriteLine("How many questions do you want to add?");
                    int no_que = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < no_que; i++)
                    {

                        Console.WriteLine("Enter question- ");
                        string que = Console.ReadLine();
                        Console.WriteLine("Enter Options of Answer(4)");
                        string[] answer = new string[4];
                        for (int j = 0; j < 4; j++)
                        {
                            answer[j] = Console.ReadLine();
                        }
                        Console.WriteLine("Correct answer");
                        string correct = Console.ReadLine();
                        switch (subject)
                        {
                            case "java":
                            {
                                Quiz.java.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach(Questions q in Quiz.java)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                            case "csharp":
                            {
                                Quiz.csharp.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach (Questions q in Quiz.csharp)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                            case "html":
                            {
                                Quiz.html.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach (Questions q in Quiz.html)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                        }
                    }
                }
                else
                { 
                    Console.WriteLine($"------------------------------------------------------------------------------------------------->>>Welcome to MCQ Quiz {login.ToUpper()} <<<-----------------------------------------------------------------------------");
                    Console.WriteLine("\n\t >> There will be a total of 20 questions");
                    Console.WriteLine("\n\t >> You will be given 4 options and you have to press a, b ,c or d for the" +
                                      "\n\t    right option");
                    Console.WriteLine("\n\t >> Each question will carry 1 point");
                    Console.WriteLine("\n\t >> You will be asked questions continuously.");
                    Console.WriteLine("\n\t >> There is no negative marking for wrong answer");

                    Console.WriteLine("\n\n ******************************************************************************************* BEST OF LUCK *******************************************************************************************************\n\n");
                    Boolean loop = true;
                    int marks = 0;
                    while (loop)
                    {
                        Console.WriteLine("\n\tTopics for MCQ Quiz:\n\t1.java\n\t2.csharp\n\t3.html");
                        int topic = Convert.ToInt32(Console.ReadLine());
                       
                        switch (topic)
                        {
                            case 1:
                            {
                                foreach (Questions o in Quiz.java)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    ans = ans.ToUpper();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..\n\n\n\n");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");
                            }
                            break;

                            case 2:
                            {
                                foreach (Questions o in Quiz.csharp)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }

                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");

                            }
                            break;
                            case 3:
                            {
                                foreach (Questions o in Quiz.html)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }

                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");
                            }
                            break;
                        }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\n"); Console.WriteLine("Do you want to give another Quiz Test???(Y/N)");
                        string str = Console.ReadLine();
                        str = str.ToUpper();
                        if (str == "n" || str == "N")
                        loop = false;
                    }

                
                }
        }
    }
}
