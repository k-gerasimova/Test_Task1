using System;
using Task1;

namespace UTest
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TriangleSquare_3and4and5_6returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Figure t = new Figure(a, b, c);
            double actual = t.Square();
            Assert.AreEqual(expected, actual);
            
        }


        [TestMethod]
        public void CircleSquare_3_28returned()
        {
            double r = 3;
            double expected = Math.PI * 9;
            Figure t = new Figure(r);
            double actual = t.Square();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CircleSquare_notExist()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure(-1));
        }

        [TestMethod]
        public void Triangle_2and4and8_notExist()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure(2,4,8));
        }


        [TestMethod]
        public void Triangle_0and0and0_notExist()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure(0, 0, 0));
        }

        [TestMethod]
        public void Triangle_5and5and10_notExist()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure(5, 5, 10));
        }

        [TestMethod]
        public void CircleSquare_0_notExist()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Figure(0));
        }


        [TestMethod]
        public void Triange_2and4and5_TrueReturned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            Triangle t = new Triangle(a, b, c);
            bool actual = t.Is_Rectangular;
            Assert.AreEqual(expected, actual);

        }
    }
}