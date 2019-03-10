using JenkinsWebApp.Lib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsWebApp.Nunit
{
    [TestFixture]
    public class EvenOddTest
    {
        [Test]
        public void OddTest([Values(1,3)]int input)
        {
           EvenOdd ob = new EvenOdd();
           string res =  ob.GetNumberType(input);
           Assert.AreEqual("Odd", res);
        }

        [Test]
        public void EvenTest([Values(2,4)]int input)
        {
            EvenOdd ob = new EvenOdd();
            string res = ob.GetNumberType(input);
            Assert.AreEqual("Even", res);
        }
    }
}

