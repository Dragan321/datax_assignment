using Cocona;
using DataXAssignment;
using DataXAssignment.Commands;
using Spectre.Console;

//this version uses Cococna package which adds type safety to the arguments and easy way to document
//command line arguments and allows for cleaner and more concise code  
CoconaApp.Run(
    //assunming number can be decimal
    ([Argument(Description = "Inital number value")] double initialValue) =>
    {
        //AnsiConsole is part of spectre.console package,
        //allows for an easy way to customize text allowing better readability
        AnsiConsole.MarkupLine($"[blue]Selected value is {initialValue}[/]");
        ResultCalculator resultCalculator = new ResultCalculator(initialValue);

        while(true)
        {
            //SelectionPrompt is also a of spectre.console package which allows creation of tui as a select component for
            //better user experience and is less error prone
            var selectedCommand = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please select one of the following commands")
                .PageSize(6)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(new[] {
                    "Increment -- increases result value by 1", 
                    "Decrement -- decreases result value by 1",
                    "Double -- doubles the result value",
                    "Random Add -- changes result by random number",
                    "Undo -- reverts the most recent command that is not an undo and was not yet undone",
                    "Exit"
                }));

            switch (selectedCommand)
            {
                case "Increment -- increases result value by 1":
                    resultCalculator.ExecuteCommand(new IncrementCommand());
                    AnsiConsole.MarkupLine($"[green]Result after the Increment operation is: {resultCalculator.Result}[/]");
                    break;
                case "Decrement -- decreases result value by 1":
                    resultCalculator.ExecuteCommand(new DecrementCommand());
                    AnsiConsole.MarkupLine($"[green]Result after the Decrement operation is: {resultCalculator.Result}[/]");
                    break;
                case "Double -- doubles the result value":
                    resultCalculator.ExecuteCommand(new DoubleCommand());
                    AnsiConsole.MarkupLine($"[green]Result after the Double operation is: {resultCalculator.Result}[/]");
                    break;
                case "Random Add -- changes result by random number":
                    resultCalculator.ExecuteCommand(new RandomAddCommand());
                    AnsiConsole.MarkupLine($"[green]Result after the Random Add operation is: {resultCalculator.Result}[/]");
                    break;
                case "Undo -- reverts the most recent command that is not an undo and was not yet undone":
                    resultCalculator.Undo();
                    AnsiConsole.MarkupLine($"[green]Result after the Undo operation is: {resultCalculator.Result}[/]");
                    break;

                //assuming user neds a way to terminate the app
                case "Exit":
                    AnsiConsole.MarkupLine($"[green]Program sucessfully terminated[/]");
                    new ExitCommand().Execute();
                    break;
                default:
                    AnsiConsole.MarkupLine($"[red]Invalid command[/]");
                    break;
            }
            

        }





    }
);
