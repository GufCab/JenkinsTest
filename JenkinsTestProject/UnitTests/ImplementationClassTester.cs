using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JenkinsTestProject;

namespace UnitTests
{
    [TestFixture]
    public class ImplementationClassTester
    {
        [Test]
        public void AddFunctionShouldPass()
        {
            int a = 10;
            int b = 10;

            IImplementationClass uut = new ImplementationClass();

            Assert.AreEqual(uut.AddTwoNumbers(a,b), 20);
        }

    }
}
