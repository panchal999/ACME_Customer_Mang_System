using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public   void InsertSpacesTestValid()
        {
            var source = "Sonic ScrewDriver";
            var expected = "Sonic Screw Driver";

           
            var actual = source.InsertSpaces();

            Assert.AreEqual(actual, expected);
        }
    }
}
