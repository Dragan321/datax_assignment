using DataXAssignment;
using DataXAssignment.Commands;

namespace AssignmentTests.CommandsTests
{
    public class IncrementCommandTests
    {
        [Fact]
        public void Execute_ShouldIncreaseResultByOne()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(0);
            var incrementCommand = new IncrementCommand();

            // Act
            incrementCommand.Execute(resultCalculator);

            // Assert
            Assert.Equal(1, resultCalculator.Result);
        }

        [Fact]
        public void Undo_ShouldDecreaseResultByOne()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(1);
            var incrementCommand = new IncrementCommand();

            // Act
            incrementCommand.Undo(resultCalculator);

            // Assert
            Assert.Equal(0, resultCalculator.Result);
        }
    }
}
