using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCase
    {
        #region Inequilateral //неравносторонний
        [TestMethod]
        public void Positive_Inequilateral()
        {
            var t = new Triangle(17, 12, 13);

            Assert.AreEqual("Треугольник неравносторонний", t.Type);
        }
        [TestMethod]
        public void Positive_NonInequilateral()
        {
            var t = new Triangle(1, 1, 1);

            Assert.AreNotEqual("Треугольник неравносторонний", t.Type);
        }

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NonexistentInequilateral1()
        {
            var t = new Triangle(1, 2, 3);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NonexistentInequilateral2()
        {
            var t = new Triangle(1, 2, 3);

            Assert.AreEqual(false, t.Exist);
        }
        [TestMethod]
        public void Positive_ExistentInequilateral()
        {
            var t = new Triangle(2, 2, 3);

            Assert.AreNotEqual(false, t.Exist);
        }
        #endregion 

        #region Equilateral //равносторонний
        [TestMethod]
        public void Positive_Equilateral()
        {
            var t = new Triangle(1, 1, 1);

            Assert.AreEqual("Треугольник равносторонний", t.Type);
        }
        [TestMethod]
        public void Positive_NonEquilateral()
        {
            var t = new Triangle(17, 12, 13);

            Assert.AreNotEqual("Треугольник равносторонний", t.Type);
        }
        #endregion 

        #region Isosceles //равнобедренный
        [TestMethod]
        public void Positive_Isosceles()
        {
            var t = new Triangle(2, 2, 3);

            Assert.AreEqual("Треугольник равнобедренный", t.Type);
        }
        [TestMethod]
        public void Positive_NonIsosceles()
        {
            var t = new Triangle(1, 1, 1);

            Assert.AreNotEqual("Треугольник равнобедренный", t.Type);
        }

        [TestMethod]
        public void Positive_CorrectIsosceles1()
        {
            var t = new Triangle(2, 2, 3);

            Assert.AreEqual("Треугольник равнобедренный", t.Type);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_CorrectIsosceles1()
        {
            var t = new Triangle(2, 2, 4);
        }
        [TestMethod]
        public void Positive_CorrectIsosceles2()
        {
            var t = new Triangle(2, 3, 2);

            Assert.AreEqual("Треугольник равнобедренный", t.Type);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_CorrectIsosceles2()
        {
            var t = new Triangle(2, 4, 2);
        }
        [TestMethod]
        public void Positive_CorrectIsosceles3()
        {
            var t = new Triangle(3, 2, 2);

            Assert.AreEqual("Треугольник равнобедренный", t.Type);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_CorrectIsosceles3()
        {
            var t = new Triangle(4, 2, 2);
        }
        #endregion

        #region Sides
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_SumOfTwo()
        {
            var t = new Triangle(2, 2, 4);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_SumOfTwoLessThenThird()
        {
            var t = new Triangle(1, 2, 4);
        }

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_FirstEqualOthers1()
        {
            var t = new Triangle(1, 2, 3);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_FirstEqualOthers2()
        {
            var t = new Triangle(1, 3, 2);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_FirstEqualOthers3()
        {
            var t = new Triangle(3, 1, 2);
        }   

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_ThreeTranspositions1()
        {
            var t = new Triangle(1, 2, 4);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_ThreeTranspositions2()
        {
            var t = new Triangle(1, 4, 2);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_ThreeTranspositions3()
        {
            var t = new Triangle(4, 1, 2);
        }
        #endregion

        #region Values
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NullValue()
        {
            var t = new Triangle(2, 2, 0);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NullValues()
        {
            var t = new Triangle(0, 0, 0);
        }

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NegativeValue()
        {
            var t = new Triangle(2, 2, -3);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NegativeValues()
        {
            var t = new Triangle(-2, -2, -3);
        }

        [TestMethod]
        public void Positive_DoubleValue()
        {
            var t = new Triangle(2, 2, 3.1);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_DoubleValue()
        {
            var t = new Triangle(1, 2, 3.1);
        }
        [TestMethod]
        public void Positive_DoubleValues()
        {
            var t = new Triangle(2.1, 2.1, 3.1);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_DoubleValues()
        {
            var t = new Triangle(1.1, 2.1, 3.2);
        }

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NotAllValues1()
        {
            var t = new Triangle(1,2);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NotAllValues2()
        {
            var t = new Triangle(1);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NotAllValues3()
        {
            var t = new Triangle(1, 2, 3, 4);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_NotAllValues4()
        {
            var t = new Triangle();
        }
        [TestMethod]
        public void Positive_NotAllValues()
        {
            var t = new Triangle(2, 2, 3);
        }
        #endregion

        #region Borders
        [TestMethod]
        public void Positive_MaxBorder()
        {
            var t = new Triangle(10000000000000000000, 5000000000000000000, 6000000000000000000);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_MaxBorder()
        {
            var t = new Triangle(Double.MaxValue + 1, Double.MaxValue / 2 + 1, Double.MaxValue / 2 + 1);
        }
        
        [TestMethod]
        public void Positive_MinBorder()
        {
            var t = new Triangle(1, 1, 1);
        }
        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Negative_MinBorder()
        {
            var t = new Triangle(0, 1, 2);
        }
        #endregion

        #region Separator
        [TestMethod]
        public void o_____________________________________o() { }
        #endregion
    }
}
