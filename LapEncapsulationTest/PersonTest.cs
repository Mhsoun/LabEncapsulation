using System;
using SortPerson;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LapEncapsulationTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            // arrange
            var p = new Person("Ahamad", "Mahsoun", 34);
            var expected = "Ahamad Mahsoun is 34 years old";

            //act
            var actual = p.ToString();

            // assert
            Assert.AreEqual(expected , actual);
        }
    }
}
