using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzGenerator _fizzBuzzGenerator;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [TestMethod]
        public void TestBuzz()
        {

            var result = _fizzBuzzGenerator.GetFizzBuzz(5);
            Assert.AreEqual("Buzz", result);
        }

    }
}
