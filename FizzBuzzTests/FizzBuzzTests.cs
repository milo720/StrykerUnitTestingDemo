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
        public void TestFizz()
        {

            var result = _fizzBuzzGenerator.GetFizzBuzz(3);
            Assert.AreEqual("Fizz", result); 
        }

        [TestMethod]
        public void TestNotFizzOrBuzz()
        {
            var result = _fizzBuzzGenerator.GetFizzBuzz(14);
            Assert.AreEqual("14", result); 
        }
    }
}
