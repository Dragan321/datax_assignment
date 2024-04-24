using DataXAssignment;
using DataXAssignment.Commands;

double initialValue;

if (args.Length != 1 || !double.TryParse(args[0],out initialValue))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please provide a single numeric argument.");
    Console.ResetColor();
    return;
}

Console.WriteLine($"Selected value is {initialValue}");
ResultCalculator resultCalculator = new ResultCalculator(initialValue);
    

while (true)
{
    //assuming history is kept
    //Console.Clear();
    Console.WriteLine("\nCommand list");
    Console.WriteLine("\tIncrement -- increases result value by 1");
    Console.WriteLine("\tDecrement -- decreases result value by 1");
    Console.WriteLine("\tDouble -- doubles the result value");
    Console.WriteLine("\tRandAdd -- changes result by random number");
    Console.WriteLine("\tUndo -- reverts the most recent command that is not an undo and was not yet undone");
    Console.WriteLine("\tExit\n");
    Console.Write("Please type in one of the following commands to execute appropriate operation: ");
    var input = Console.ReadLine();

    //removing case sensitivity
    switch (input?.ToLower())
    {
        case "increment":
            resultCalculator.ExecuteCommand(new IncrementCommand());
            Console.WriteLine($"Result after the Increment operation is: {resultCalculator.Result}");
            break;
        case "decrement":
            resultCalculator.ExecuteCommand(new DecrementCommand());
            Console.WriteLine($"Result after the Decrement operation is: {resultCalculator.Result}");
            break;
        case "double":
            resultCalculator.ExecuteCommand(new DoubleCommand());
            Console.WriteLine($"Result after the Double operation is: {resultCalculator.Result}");
            break;
        case "randadd":
            resultCalculator.ExecuteCommand(new RandomAddCommand());
            Console.WriteLine($"Result after the Random Add operation is: {resultCalculator.Result}");
            break;
        case "undo":
            resultCalculator.Undo();
            Console.WriteLine($"Result after the Undo operation is: {resultCalculator.Result}");
            break;

        //assuming user neds a way to terminate the app
        case "exit":
            Console.WriteLine("Program sucessfully terminated");
            new ExitCommand().Execute();
            break;
        default:
            Console.WriteLine("Invalid command");
            break;
    }


}


return;

