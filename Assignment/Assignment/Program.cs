class Animal
{
    public virtual void MakeSound(){
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Main {
    public static void main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();

       myDog.MakeSound();
       myCat.MakeSound();
    }
}
