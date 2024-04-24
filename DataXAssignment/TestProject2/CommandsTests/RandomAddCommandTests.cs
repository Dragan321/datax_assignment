using DataXAssignment.Commands;
using DataXAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTests.CommandsTests
{
    public class RandomAddCommandTests
    {
        [Fact]
        public void Execute_ShouldAddRandomNumberToResult()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(1);
            var randomAddCommand = new RandomAddCommand();

            // Act
            randomAddCommand.Execute(resultCalculator);

            // Assert
            // Since the result is unpredictable due to the randomness
            // we can only verify that it's not the initial value
            Assert.NotEqual(1, resultCalculator.Result);
        }

        [Fact]
        public void Undo_ShouldSubtractRandomNumberFromResult()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(1);
            var randomAddCommand = new RandomAddCommand();

            // Execute the command
            double initialResult = resultCalculator.Result;
            randomAddCommand.Execute(resultCalculator);

            // Act
            randomAddCommand.Undo(resultCalculator);

            // Assert
            Assert.Equal(initialResult, resultCalculator.Result);
        }
    }
}
