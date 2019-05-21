
using System;
using System.Collections.Generic;
using Ragna_Rundt.Model;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void GetFromElementCatalogSingleton()
        {
            //Arrange
            ElementCatalog TestElementCatalog = ElementCatalog.Instance;
            Element Test = new Element("TestElementNavn", "TestDescription", "Http://google.dk", new Area("TestNameArea", "TestDescriptionArea", 1, 2));

            TestElementCatalog.Elements.Add(Test.Id,Test);
            //Act
            string ExpectedName = "TestElementNavn";
            string ExpectedDesc = "TestDescription";
            string ExpectedUrl = "Http://google.dk";

            string ActualName = TestElementCatalog.Elements[Test.Id].Name;
            string ActualDesc = TestElementCatalog.Elements[Test.Id].description;
            string ActualUrl = TestElementCatalog.Elements[Test.Id].videoURL;

            //Assert

            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreEqual(ExpectedDesc, ActualDesc);
            Assert.AreEqual(ExpectedUrl, ExpectedUrl);

            Assert.AreSame(TestElementCatalog.Elements[Test.Id], Test);
        }

        [TestMethod]
        public void AddElementToElementCatalog()
        {
            //Arrange
            int amountOfElements = ElementCatalog.Instance.Elements.Count;
            Element Test = new Element("TestElementNavn", "TestDescription", "Http://google.dk", new Area("TestNameArea", "TestDescriptionArea", 1, 2));

       
            //Act
            int countPreAdd = ElementCatalog.Instance.Elements.Count;

            ElementCatalog.Instance.Elements.Add(Test.Id, Test);

            int countAfterAdd = ElementCatalog.Instance.Elements.Count;

            //Assert
            Assert.AreNotEqual(countPreAdd, countAfterAdd);
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
            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreEqual(ExpectedDesc, ActualDesc);
            Assert.AreEqual(ExpectedUrl, ExpectedUrl);
        }

        [TestMethod]
        public void ElementAutoincrementTest()
        {
            //Arrange
            Element TestElement = new Element("TestElementNavn", "TestDescription", "Http://google.dk", new Area("TestNameArea", "TestDescriptionArea", 1, 2));
            Element TestElement1 = new Element("TestElementNavn1", "TestDescription1", "Http://google.dk1", new Area("TestNameArea1", "TestDescriptionArea1", 1, 2));
            //Act
            int ExpectedIncrement = 1;
            int ActualIncrement = TestElement1.Id - TestElement.Id;
            //Assert
            Assert.AreEqual(ExpectedIncrement, ActualIncrement);
            Assert.AreNotEqual(TestElement.Id, TestElement1.Id);
        }   

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
           

            //Act

            //Assert
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            

            //Act

            //Assert
        }

    }
}
