using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
   public class TaskList 
    {
        public virtual int GeneralTime()
        {
            return 0;
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Populate your tasks in Format: Task Name, Priority (1=High, 2=Medium, 3=Low), Complexity (1=High, 2=Medium, 3=Low)");


            for (int a = 0; a < 10; a++) 
            { 
            Console.WriteLine("Task Name is");
            string TN = Console.ReadLine();
            Console.WriteLine("Populate Priority 1; 2 or 3 (1=High, 2=Medium, 3=Low)");
            string Pr = Console.ReadLine();
            Console.WriteLine("Populate Complexity 1; 2 or 3 (1=High, 2=Medium, 3=Low)");
            string Com = Console.ReadLine();

            if ((TN != null) && (Pr != null) && ((Pr == "1") || (Pr == "2") || (Pr == "3")) && (Com != null) && ((Com == "1") || (Com == "2") || (Com == "3")))
                {
                TaskList TaskEntity = new Class1();
                List<Class1> tasks = new List<Class1>
                    { new Class1 { TaskName = TN, Priority = Pr, Complexity = Com } };


                TN = null;
                Pr = null;
                Com = null;
                int i = 0;

                List<Class1> tasks2 = new List<Class1>();
                tasks2 = ListReturn(tasks);



                    foreach (Class1 task in tasks2)
               {
                  Console.WriteLine($"---Task Description- Task: {task.TaskName}, Priority:{task.Priority}, Complexity:{task.Complexity}");

                       }

                  Console.WriteLine("\nGeneral Time: " + TaskEntity.GeneralTime());
                  Console.WriteLine("\nCapacity: {0}", tasks2.Capacity);
                  Console.WriteLine("\nCount: {0}", tasks2.Count);


                  break;
            }
            else
            {
                Console.WriteLine("Wrong input, try again");
            }
            }
        }


        static public List<Class1> ListReturn(List<Class1> temp)
        {

           Console.WriteLine("Click Enter to proceed");
           var cki = Console.ReadKey();


            do
            {
                
                Console.Write("\n--- You pressed ");
                Console.WriteLine(cki.Key.ToString());
                //Console.WriteLine(cki.Key);
                string key1 = cki.Key.ToString();
                //Console.Write("\n--- You pressed ");
                Console.WriteLine(cki.Key.ToString());
                Console.Write("\n Continue the task list creation ");

                for (int i = 1; i < 10; i++)

                {
                    Console.WriteLine("\n Task Name is");
                    string TN = Console.ReadLine();
                    Console.WriteLine("Populate Priority 1; 2 or 3 (1=High, 2=Medium, 3=Low)");
                    string Pr = Console.ReadLine();
                    Console.WriteLine("Populate Complexity 1; 2 or 3 (1=High, 2=Medium, 3=Low)");
                    string Com = Console.ReadLine();

                    if ((TN != null) && (Pr != null) && ((Pr == "1") || (Pr == "2") || (Pr == "3")) && (Com != null) && ((Com == "1") || (Com == "2") || (Com == "3")) && (key1 != "Escape"))
                    {
                        temp.Insert(i, new Class1 { TaskName = TN, Priority = Pr, Complexity = Com });
                        Console.WriteLine("Press Escape (Esc) to complete the list OR any other character to continue");
                        cki = Console.ReadKey();
                        break;
                        //return temp;
                    }
                    else if ((TN == null) || (Pr == null) || ((Pr != "1") && (Pr != "2") && (Pr != "3")) || (Com == null) || ((Com != "1") && (Com != "2") && (Com != "3")) && (key1 != "Escape"))
                    {
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Press Escape (Esc) to complete the list OR any other character to continue");
                        cki = Console.ReadKey();
                        break;
                        //  return temp;
                    }
                    else
                    {
                        return temp;
                    
                    }


                }

            } while (cki.Key != ConsoleKey.Escape);
            return temp;
          
        }




    }

    }

