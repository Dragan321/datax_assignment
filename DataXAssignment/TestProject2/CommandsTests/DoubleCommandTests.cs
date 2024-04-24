using DataXAssignment.Commands;
using DataXAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTests.CommandsTests
{
    public class DoubleCommandTests
    {
        [Fact]
        public void Execute_ShouldDoubleResult()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(1);
            var doubleCommand = new DoubleCommand();

            // Act
            doubleCommand.Execute(resultCalculator);

            // Assert
            Assert.Equal(2, resultCalculator.Result);
        }

        [Fact]
        public void Undo_ShouldHalveResult()
        {
            // Arrange
            var resultCalculator = new ResultCalculator(2);
            var doubleCommand = new DoubleCommand();

            // Act
            doubleCommand.Undo(resultCalculator);

            // Assert
            Assert.Equal(1, resultCalculator.Result);
        }
    }
}
