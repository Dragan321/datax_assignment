

namespace DataXAssignment
{
    public sealed class ResultCalculator
    {
        public double Result { get; set; }
        public Stack<ICommand> commandHistory = new Stack<ICommand>();

        public ResultCalculator(double initialValue)
        {
            Result = initialValue;
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute(this);
            commandHistory.Push(command);
        }

        public void Undo()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo(this);
            }
            else
            {
                Console.WriteLine("Nothing left to undo");
            }
        }

    }
}
