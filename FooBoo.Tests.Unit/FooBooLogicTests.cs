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
    }
}