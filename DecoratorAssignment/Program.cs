namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there




    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"Description: {espresso.GetDescription()}\nCost: ${espresso.Cost()}");

            // Order a Darkroste coffee with Milk and Whip
            Beverage darkroste = new Darkroste();
            darkroste = new Milk(darkroste);
            darkroste = new Whip(darkroste);
            Console.WriteLine($"Description: {darkroste.GetDescription()}\nCost: ${darkroste.Cost()}");

            // Order a Decaf coffee with Mocha and Soy
            Beverage decaf = new Decaf();
            decaf = new Mocha(decaf);
            decaf = new Soy(decaf);
            Console.WriteLine($"Description: {decaf.GetDescription()}\nCost: ${decaf.Cost()}");

            


        }

    }
}