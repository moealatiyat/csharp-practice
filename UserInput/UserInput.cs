class UserInput{
    public void GreetUser(){
        Console.Write("Enter your name fine sir: ");
        string name= Console.ReadLine();
        Console.WriteLine("Welcome: " + name);
    }
    public static void Main(string[] args){
        UserInput hello=new UserInput();
        hello.GreetUser();
    }
}