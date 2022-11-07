using NUnit.Framework;
using System;

namespace FooBoo.Tests.Unit
{    
    public class FooBooLogicTests
    {
        FooBooLogic fooBooLogic;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            fooBooLogic = new FooBooLogic();
        }

        [Test]
        public void Analyze_NotDividable_ValueOfNo()
        {
            // Arrange
            string expected = "No!";

            // Act
            string actual = fooBooLogic.Analyze(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_DividesBy3_ValueOfFoo()
        {
            // Arrange
            string expected = "Foo";

            // Act
            string actual = fooBooLogic.Analyze(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [Test]
        public void Analyze_DividesBy5_ValueOfBoo()
        {
            // Arrange
            string expected = "Boo";

            // Act
            string actual = fooBooLogic.Analyze(5);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [Test]
        public void Analyze_DividesBy3And5_ValueOfFooBoo()
        {
            // Arrange
            string expected = "FooBoo";

            // Act
            string actual = fooBooLogic.Analyze(15);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}