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
            ICompute newOne = new DoubleValues(20, 20, OperationType.Addition);

            //Act
            decimal actual = newOne.ComputeIt();

            //Assert
            Assert.That(actual, Is.EqualTo(40));
        }

        [Test]
        public void SubtractionTest()
        {
            decimal actual = Subtraction.Execute(50, 20);
            Assert.That(actual, Is.EqualTo(30));
        }

        [Test]
        public void MultiplicationTest()
        {
            decimal actual = Multiplication.Execute(10, 20);
            Assert.That(actual, Is.EqualTo(200));
        }

        [Test]
        public void DivisionTest()
        {
            decimal actual = Division.Execute(20, 2);
            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void ErrorTest()
        {
            Assert.That(() => Division.Execute(20, 0), Throws.TypeOf<DivideByZeroException>());
        }
    }
}