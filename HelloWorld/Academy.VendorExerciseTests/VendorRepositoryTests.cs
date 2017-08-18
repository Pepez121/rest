using Microsoft.VisualStudio.TestTools.UnitTesting;
using Academy.VendorExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.VendorExercise.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor() { VendorID = 5, CompanyName =  "ABC Group", Email = "abc@abc.com"} },
                { "XYZ Inc", new Vendor() { VendorID = 8, CompanyName =  "XYZ Inc", Email = "xyz@xyz.com"} }
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}