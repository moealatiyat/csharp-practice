public class Program
{
    public static void Main(string[] args)
    {
     Dog myDog = new Dog();
     myDog.makeSound();
     myDog.Eat();   
     Cat myCat = new Cat();
     myCat.makeSound();
     myCat.Eat();

     List<Animal> animals = new List<Animal> { new Dog(), new Cat() };
     foreach(Animal a in animals)
        {
            a.makeSound();
        }


     
    }
}

public interface IAnimal
{
    void Eat();
}
public class Animal : IAnimal
{
    public virtual void makeSound()
    {
        Console.WriteLine("A sound");
    }
    public virtual void Eat()
    {
        System.Console.WriteLine("nom");
    }
}
public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Bark");
    }
    public override void Eat()
    {
        System.Console.WriteLine("The Dog is eating");
    }
}

public class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Meow");
    }
    public override void Eat()
    {
        System.Console.WriteLine("The Cat is eating");
    }
}



