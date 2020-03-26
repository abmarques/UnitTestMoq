using CShp_UnitTestMoq;
using Moq;
using System;
using Xunit;

namespace CShp_XUnitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Two_Numbers()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<String>(), It.IsAny<double>(), It.IsAny<double>()))
                .Returns(("add", 7.7));

            CalcMachine calMachine = new CalcMachine(mock.Object);

            //Act
            (string operation, double result) op = calMachine.Calculate("add", 3.2, 4.5);

            //Assert
            Assert.Equal("add", op.operation);
            Assert.Equal(7.7, op.result);
        }

        [Fact]
        public void Sub_Two_Numbers()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<String>(), It.IsAny<double>(), It.IsAny<double>()))
                .Returns(("sub", -1.3));

            CalcMachine calMachine = new CalcMachine(mock.Object);

            //Act
            (string operation, double result) op = calMachine.Calculate("sub", 3.2, 4.5);

            //Assert
            Assert.Equal("sub", op.operation);
            Assert.Equal(-1.3, op.result);
        }

        [Fact]
        public void Mult_Two_Numbers()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<String>(), It.IsAny<double>(), It.IsAny<double>()))
                .Returns(("mult", 14.4));

            CalcMachine calMachine = new CalcMachine(mock.Object);

            //Act
            (string operation, double result) op = calMachine.Calculate("mult", 3.2, 4.5);

            //Assert
            Assert.Equal("mult", op.operation);
            Assert.Equal(14.4, op.result);
        }

        [Fact]
        public void Div_Two_Numbers()
        {
            //Arrange
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<String>(), It.IsAny<double>(), It.IsAny<double>()))
                .Returns(("div", 0.71));

            CalcMachine calMachine = new CalcMachine(mock.Object);

            //Act
            (string operation, double result) op = calMachine.Calculate("div", 3.2, 4.5);

            //Assert
            Assert.Equal("div", op.operation);
            Assert.Equal(0.71, op.result);
        }
    }
}
