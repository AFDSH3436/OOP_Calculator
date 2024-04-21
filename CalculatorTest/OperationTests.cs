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
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(30, 25, OperationType.Addition);
            decimal expected = 55;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SubtractionTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(50, 25, OperationType.Subtraction);
            decimal expected = 25;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MultiplicationTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(100, 200, OperationType.Multiplication);
            decimal expected = 20000;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(200, 10, OperationType.Division);
            decimal expected = 20;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionByZeroErrorTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act and Assert
            Assert.That(() => newOne.ComputeIt(20, 0, OperationType.Division), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void PowerTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(11, 2, OperationType.Power);
            decimal expected = 121;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ModulusTest()
        {
            //Arrange
            IDoubleValueCompute newOne = new DoubleValue();

            //Act
            decimal actual = newOne.ComputeIt(21, 2, OperationType.Modulus);
            decimal expected = 1;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SquareRootTest()
        {
            //Arrange
            ISingleValueCompute newOne = new SingleValue();

            //Act
            decimal actual = newOne.ComputeIt(4, OperationType.SquareRoot);
            decimal expected = 2;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}