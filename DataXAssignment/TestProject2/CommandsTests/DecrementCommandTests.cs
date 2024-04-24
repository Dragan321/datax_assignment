using DataXAssignment.Commands;
using DataXAssignment;

namespace AssignmentTests.CommandsTests
{
    public class DecrementCommandTests
    {
        [Fact]
        public void Execute_ShouldDecreaseResultByOne()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(1);
            var decrementCommand = new DecrementCommand();

            // Act
            decrementCommand.Execute(resultCalculator);

            // Assert
            Assert.Equal(0, resultCalculator.Result);
        }

        [Fact]
        public void Undo_ShouldIncreaseResultByOne()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(0);
            var decrementCommand = new DecrementCommand();

            // Act
            decrementCommand.Undo(resultCalculator);

            // Assert
            Assert.Equal(1, resultCalculator.Result);
        }
    }
}
