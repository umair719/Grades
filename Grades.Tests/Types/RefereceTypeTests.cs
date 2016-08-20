using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class RefereceTypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "umair";
            name = name.ToUpper();

            

            Assert.AreEqual("UMAIR", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2016, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);        
        }


        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }
        
        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(ref book2);

            Assert.AreEqual("A Gradebook", book2.Name);

        }

        private void GiveBookName(ref GradeBook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisions()
        {
            string name1 = "Umair";
            string name2 = "umair";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }

        
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            //x1 = 4;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Umair's Grade Book";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
