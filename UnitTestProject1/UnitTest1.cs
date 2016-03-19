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
        public void Negative_Inequilateral()
        {
            var t = new Triangle(1, 1, 1);

            Assert.AreEqual("Треугольник равносторонний", t.Type);
        }

        [TestMethod][ExpectedException(typeof(TriangleException))]
        public void Positive_NonexistentInequilateral()
        {
            var t = new Triangle(1, 2, 3);
        }
        [TestMethod]
        public void Negative_NonexistentInequilateral()
        {
            var t = new Triangle(17, 12, 13);

            Assert.AreEqual("Треугольник неравносторонний", t.Type);
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
        public void Negative_Equilateral()
        {
            var t = new Triangle(17, 12, 13);

            Assert.AreEqual("Треугольник неравносторонний", t.Type);
        }
        #endregion 

        #region Isosceles //равнобедренный
        [TestMethod]
        public void Positive_Isosceles()
        {
        }
        [TestMethod]
        public void Negative_Isosceles()
        {
        }

        [TestMethod]
        public void Positive_NonexistentIsosceles()
        {
        }
        [TestMethod]
        public void Negative_NonexistentIsosceles()
        {
        }

        [TestMethod]
        public void Positive_CorrectIsosceles1()
        {
        }
        [TestMethod]
        public void Negative_CorrectIsosceles1()
        {
        }
        [TestMethod]
        public void Positive_CorrectIsosceles2()
        {
        }
        [TestMethod]
        public void Negative_CorrectIsosceles2()
        {
        }
        [TestMethod]
        public void Positive_CorrectIsosceles3()
        {
        }
        [TestMethod]
        public void Negative_CorrectIsosceles3()
        {
        }
        #endregion

        #region Sides //стороны
        [TestMethod]
        public void Positive_NullSide()
        {
        }
        [TestMethod]
        public void Negative_NullSide()
        {
        }

        [TestMethod]
        public void Positive_NegativeSide()
        {
        }
        [TestMethod]
        public void Negative_NegativeSide()
        {
        }

        [TestMethod]
        public void Positive_SumOfTwo()
        {
        }
        [TestMethod]
        public void Negative_SumOfTwo()
        {
        }

        [TestMethod]
        public void Positive_FirstEqualOthers1()
        {
        }
        [TestMethod]
        public void Negative_FirstEqualOthers1()
        {
        }
        [TestMethod]
        public void Positive_FirstEqualOthers2()
        {
        }
        [TestMethod]
        public void Negative_FirstEqualOthers2()
        {
        }
        [TestMethod]
        public void Positive_FirstEqualOthers3()
        {
        }
        [TestMethod]
        public void Negative_FirstEqualOthers3()
        {
        }

        [TestMethod]
        public void Positive_SumOfTwoLessThenThird()
        {
        }
        [TestMethod]
        public void Negative_SumOfTwoLessThenThird()
        {
        }

        [TestMethod]
        public void Positive_ThreeTranspositions1()
        {
        }
        [TestMethod]
        public void Negative_ThreeTranspositions1()
        {
        }
        [TestMethod]
        public void Positive_ThreeTranspositions2()
        {
        }
        [TestMethod]
        public void Negative_ThreeTranspositions2()
        {
        }
        [TestMethod]
        public void Positive_ThreeTranspositions3()
        {
        }
        [TestMethod]
        public void Negative_ThreeTranspositions3()
        {
        }

        [TestMethod]
        public void Positive_NullSides()
        {
        }
        [TestMethod]
        public void Negative_NullSides()
        {
        }
        #endregion

        #region Values //значения
        [TestMethod]
        public void Positive_DoubleValues()
        {
        }
        [TestMethod]
        public void Negative_DoubleValues()
        {
        }
        [TestMethod]
        public void Positive_NotAllValues()
        {
        }
        [TestMethod]
        public void Negative_NotAllValues()
        {
        }
        #endregion

        #region Borders //границы
        [TestMethod]
        public void Positive_MaxBorder()
        {
        }
        [TestMethod]
        public void Negative_MaxBorder()
        {
        }
        
        [TestMethod]
        public void Positive_MinBorder()
        {
        }
        [TestMethod]
        public void Negative_MinBorder()
        {
        }
        #endregion

        #region Separator 
        [TestMethod]
        public void o_____________________________________o() { }
        #endregion
    }
}
