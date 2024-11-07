using GeometricProgressionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometricProgressionTests
{
    [TestClass]
    public class GeometricProgressionTest
    {
        [TestMethod]
        public void Addition()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(2, 3);
            GeometricProgression progression2 = new GeometricProgression(4, 3);
            double expectedInitialElement = 6;
            double expectedRatio = 3;

            // Act
            IGeometricProgression result = progression1 + progression2;

            // Assert
            Assert.IsTrue(result.InitialElement == expectedInitialElement);
            Assert.IsTrue(result.Ratio == expectedRatio);
        }

        [TestMethod]
        public void Substraction()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(7, 3);
            GeometricProgression progression2 = new GeometricProgression(3, 3);
            double expectedInitialElement = 4;
            double expectedRatio = 3;

            // Act
            IGeometricProgression result = progression1 - progression2;

            // Assert
            Assert.IsTrue(result.InitialElement == expectedInitialElement);
            Assert.IsTrue(result.Ratio == expectedRatio);
        }

        [TestMethod]
        public void Multiplying()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(1, 3);
            double number = 4;
            double expectedInitialElement = 4;
            double expectedRatio = 3;

            // Act
            IGeometricProgression result = progression1 * number;

            // Assert
            Assert.IsTrue(result.InitialElement == expectedInitialElement);
            Assert.IsTrue(result.Ratio == expectedRatio);
        }

        [TestMethod]
        public void EqualityOperator()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(3, 3);
            GeometricProgression progression2 = new GeometricProgression(3, 3);

            // Act & Assert
            Assert.IsTrue(progression1 == progression2);
        }

        [TestMethod]
        public void InequalityOperator()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(3, 3);
            GeometricProgression progression2 = new GeometricProgression(4, 3);

            // Act & Assert
            Assert.IsTrue(progression1 != progression2);
        }

        [TestMethod]
        public void GreaterOrEqualOperator()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(5, 3);
            GeometricProgression progression2 = new GeometricProgression(3, 3);

            // Act & Assert
            Assert.IsTrue(progression1 >= progression2);
        }

        [TestMethod]
        public void LessOrEqualOperator()
        {
            // Arrange
            GeometricProgression progression1 = new GeometricProgression(2, 3);
            GeometricProgression progression2 = new GeometricProgression(3, 3);

            // Act & Assert
            Assert.IsTrue(progression1 <= progression2);
        }

        [TestMethod]
        public void ExplicitConversionToDouble()
        {
            // Arrange
            GeometricProgression progression = new GeometricProgression(6.5, 3);
            double expected = 6.5;

            // Act
            double result = (double)progression;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ImplicitConversion()
        {
            // Arrange
            double initialElement = 7.5;
            double expectedRatio = 1;

            // Act
            GeometricProgression progression = initialElement;

            // Assert
            Assert.AreEqual(initialElement, progression.InitialElement);
            Assert.AreEqual(expectedRatio, progression.Ratio);
        }

        [TestMethod]
        public void GetElement_GetNElementOfProgression_CorrectElement()
        {
            // Arrange
            IGeometricProgression progression1 = new GeometricProgression(2, 3);
            int index = 3;

            double expected = 18;

            // Act
            double result = progression1.GetElement(index);

            // Assert
            Assert.IsTrue(result == expected);
        }

    }
}

