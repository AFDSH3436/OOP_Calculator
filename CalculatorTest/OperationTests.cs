using CalculatorOperations.Operations;
using CalculatorOperations.Computation;
using NUnit.Framework;
using System;

namespace CalculatorTest
{
    public class OperationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(20, 20, OperationType.Addition);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 40;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SubtractionTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(50, 20, OperationType.Subtraction);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 30;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MultiplicationTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(10, 20, OperationType.Multiplication);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 200;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(20, 2, OperationType.Division);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 10;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionByZeroErrorTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(20, 0, OperationType.Division);

            //Act and Assert
            Assert.That(() => newOne.ComputeIt(), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void PowerTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(100, 2, OperationType.Power);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 10000;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ModulusTest()
        {
            //Arrange
            ICompute newOne = new DoubleValue(11, 2, OperationType.Modulus);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 1;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SquareRootTest()
        {
            //Arrange
            ICompute newOne = new SingleValue(400, OperationType.SquareRoot);

            //Act
            decimal actual = newOne.ComputeIt();
            decimal expected = 20;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}