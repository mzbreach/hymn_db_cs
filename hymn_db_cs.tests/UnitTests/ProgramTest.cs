using HymnDbCS;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HymnDbCS.tests.UnitTests
{
    public class ProgramTest
    {
        [Fact]
        public void testFunction1_NegativeInput_MinusOneReturn()
        {
            // Arrange
            int a = -2;

            // Act
            int actual = Program.testFunction1(a);

            // Assert
            Assert.Equal(-1, actual);

        }

        [Fact]
        public void testFunction1_ZeroInput_MinusOneReturn()
        {
            // Arrange
            int a = 0;

            // Act
            int actual = Program.testFunction1(a);

            // Assert
            Assert.Equal(-1, actual);

        }

        [Fact]
        public void testFunction1_PositiveInput_SameOutput()
        {
            // Arrange
            int a = 4;

            // Act
            int actual = Program.testFunction1(a);

            // Assert
            Assert.Equal(a, actual);

        }
    }
}