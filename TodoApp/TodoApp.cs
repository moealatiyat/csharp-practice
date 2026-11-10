public class TodoApp{

    public static string[] tasks = new string [10];

    public static int tasksCount = 0;

    public static void AddTask(){
        Console.Write("Enter a Task: ");
        string? inputTask = Console.ReadLine();
        
        tasks[tasksCount]= inputTask;

        tasksCount++;
    }

    public static void ViewTasks(){
        for(int i=0; i<tasksCount; i++){
            Console.WriteLine(tasks[i]);
        }
    }

    public static void CompleteTask(){
        ViewTasks();
        Console.Write("Enter a task to complete: ");
        int complete  = int.Parse(Console.ReadLine()) - 1;
        tasks[complete] = tasks[complete] + " (completed)";
        Console.WriteLine("Good Job! Task was Checked off");
    }

    public static void Main(string[] args){
        bool running = true;
        while(running){
            Console.WriteLine("1. Add Task\n 2. View Task\n 3. Complete Task\n 4. Exit");
            string? choice=Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

}