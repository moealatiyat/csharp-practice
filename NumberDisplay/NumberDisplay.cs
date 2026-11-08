class NumberDisplay
{
 public void displaynums()
    {
        for(int i= 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }   
    public static void Main(string[] args)
    {
        NumberDisplay num = new NumberDisplay();
        num.displaynums();
    }
}