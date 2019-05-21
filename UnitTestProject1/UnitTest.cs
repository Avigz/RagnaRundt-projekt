
using System;
using Ragna_Rundt.Model;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddElementToElementCatalog()
        {
            //Arrange
            ElementCatalog Catalog = new ElementCatalog();

            //Act

           //Assert
           
        }


        [TestMethod]
        public void ElementPropertyTest()
        {
            //Arrange
            Element UdstillingsElement = new Element("TestElementNavn", "TestDescription","Http://google.dk", new Area("TestNameArea","TestDescriptionArea", 1,2));

            //Act
            string ExpectedName = "TestElementNavn";
            string ExpectedDesc = "TestDescription";
            string ExpectedUrl = "Http://google.dk";

            string ActualName = UdstillingsElement.Name;
            string ActualDesc = UdstillingsElement.description;
            string ActualUrl = UdstillingsElement.videoURL;
            //Assert
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            ElementCatalog Catalog = new ElementCatalog();

            //Act

            //Assert
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            ElementCatalog Catalog = new ElementCatalog();

            //Act

            //Assert
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            ElementCatalog Catalog = new ElementCatalog();

            //Act

            //Assert
        }

    }
}
