
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
            string ExpectedAreaName = "TestNameArea";

            string ActualName = UdstillingsElement.Name;
            string ActualDesc = UdstillingsElement.description;
            string ActualUrl = UdstillingsElement.videoURL;
            string ActualAreaName = UdstillingsElement.Area.Name;

            //Assert
            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreEqual(ExpectedDesc, ActualDesc);
            Assert.AreEqual(ExpectedUrl, ExpectedUrl);
            Assert.AreEqual(ExpectedAreaName,ActualAreaName);
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
        public void AreaPropertyTest()
        {
            //Arrange
           Area TestArea = new Area("TestName", "TestDescription", 1,2);
           
            //Act
            string ExpectedName = "TestName";
            string ExpectedDesc = "TestDescription";
            int ExpectedMapX = 1;
            int ExpectedMapY = 2;

            string ActualName = TestArea.Name;
            string ActualDesc = TestArea.Desciption;
            int ActualMapX = TestArea.MapX;
            int ActualMapY = TestArea.MapY;
            //Assert
            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreEqual(ExpectedDesc, ActualDesc);
            Assert.AreEqual(ExpectedMapX, ActualMapX);
            Assert.AreEqual(ExpectedMapY, ActualMapY);
        }

        [TestMethod]
        public void AreaCatalogTest()
        {
            //Arrange
            Area TestArea = new Area("TestName", "TestDescription", 1, 2);


            //Act
            int CountPreAdd = AreaCatalog.Instance.Areas.Count;
            AreaCatalog.Instance.Areas.Add("Lydvæggen", TestArea);
            int CountAfterAdd = AreaCatalog.Instance.Areas.Count;

            //Assert
            Assert.AreNotEqual(CountPreAdd, CountAfterAdd);
            Assert.AreEqual(CountPreAdd, CountAfterAdd -1);
            Assert.AreSame(TestArea, AreaCatalog.Instance.Areas["Lydvæggen"]);
        }

    }
}
