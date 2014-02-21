using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erm.TestRig.Tests
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Test()
        {
            Assert.AreEqual("Hello World", "Hello World");
        }
    }
}
