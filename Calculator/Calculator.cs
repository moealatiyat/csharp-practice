class Calculator
{
    static int num1;
    static int num2;

    public int Add(int a, int b){
        num1=a;
        num2=b;

        return a+b;
    }
    public void Main(string[] args){
        num1=10;
        num2=15;
        Calculator calc = new Calculator();
        int result = calc.Add(num1,num2);
        Console.WriteLine("The sum of the 2 numbers is: " + result);
    }
}