using Calculator;

while(true){

    string userInput = Display();

    try
    {
        int convertedUserInput = Int32.Parse(userInput);
        if (convertedUserInput == 6)
        {
            break;
        }
        Decision(convertedUserInput);


    }
    catch
    {
        //TODO break down errors from specific to general
        Console.WriteLine("Please enter just the number that corresponds to your choice.");
    }

  



}

static string Display()
{
    Console.WriteLine("\n1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Access Calculator History");
    Console.WriteLine("6. Exit");

    Console.WriteLine("Enter the number that corresponds to what you would like to do: (eg: 3");
    string userInput = Console.ReadLine();
    return userInput;
}


static void Decision(int convertedUserInput)
{
    switch (convertedUserInput)
    {
        //case 1:
        //    Calculator.Calculator.Addition(5,4);
        //    break;
        //case 2:
        //    Calculator.Calculator.Subtraction();
        //    break;
        //case 3:
        //    Calculator.Calculator.Multiplication();
        //    break;
        //case 4:
        //    Calculator.Calculator.Division();
        //    break;
        case 5:
            break;
        default:
            Console.WriteLine("Please enter a number corresponding to the choices.");
            break;
     }
}