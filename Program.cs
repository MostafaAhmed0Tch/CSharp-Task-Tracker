using System.Net.Http.Headers;

namespace task_traker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskindex=0;

        static void Main(string[] args)
        {
 

            Console.WriteLine("Welcome to my task tracker ");

            while (true) {
                Console.WriteLine("\n===== TASK TRACKER =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. Mark Task Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "1":
                        // add taske 

                        AddTask();
                        Console.WriteLine("task added ");
                        break;
                    case "2":
                        ViewTask();
                        // viooo taske 
                        break;
                    case "3":
                        // mark  taske 
                        markcomplet();
                        break;
                    case "4":
                        // remve  taske 
                        deleteTske();
                        break;
                    case "5":

                        Environment.Exit(0);
                        // exit  taske 
                        break;

                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("enter task title  ");
            string taskadd = Console.ReadLine();

            tasks[taskindex] = taskadd;
            taskindex++;

        }

        private static void ViewTask()
        {
            Console.WriteLine(" task  Liste  ");
            for (int i = 0; i < taskindex; i++)
            {
                Console.WriteLine($"{i+1}  Task title \t: {tasks[i]}");

            }
        }


        private static void markcomplet()
        {
            Console.WriteLine("Enter task number ");
           string taskNumber=  Console.ReadLine();
            int taskID = Convert.ToInt32(taskNumber);


            tasks[taskID] = tasks[taskID] + "Completed ";
        }

        private static void deleteTske()
        {
            Console.WriteLine("Enter task number ");
           string taskNumber=  Console.ReadLine();
            int taskID = Convert.ToInt32(taskNumber);


            tasks[taskID] = string .Empty;
        }

    }
}
