
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
        public void ElementAutoincrementTest()
        {
            //I denne test vil vi vurdere hvor vidt vores autoincrement funktion ved oprettelse af et Element objekt
            // fungerer optimalt.
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
        public void ElementPropertyTest()
        {
            // I denne test undersoeger vi hvor vidt vi kan tilgaa properties paa vores Element objekt
            //Arrange
            Element UdstillingsElement = new Element("TestElementNavn", "TestDescription", "Http://google.dk", new Area("TestNameArea", "TestDescriptionArea", 1, 2));

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
            Assert.AreEqual(ExpectedAreaName, ActualAreaName);
        }

        [TestMethod]
        public void AddElementToElementCatalog()
        {
            // I denne test vurdere vi hvor vidt vi kan tilfoeje elementer til elementCatalog
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
        public void GetFromElementCatalogSingleton()
        {
            // I denne test vurdere vi om vu korrekt kan ekstrahere oplysninger fra vores ElementCatalogSingleton
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
        public void AreaCatalogSingletonTest()
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

        [TestMethod]
        public void TagTest()
        {
            //I denne test vurdere vi om vi kan ekstrahere name propertien fra tag objektet, samt tester
            //Autoincrement featuren.
            //Arrange
            Tag TestTag = new Tag("TestTag");
            Tag TestTag1 = new Tag("TestTag1");

            //Act
            string ExpectedTag = "TestTag";
            int ExpectedIdDifference = 1;
            int ActualIdDifference = TestTag1.Id - TestTag.Id;
            //Assert
            Assert.AreEqual(ExpectedTag, TestTag.Name);
            Assert.AreEqual(ExpectedIdDifference, ActualIdDifference );
        }

        public void TagCatalogSingletonTest()
        {
            //I dette testscenarie vil vi vurdere vores tagcatalogSingletons Add funktion, samt om objektet
            //der tilfoejes er magen til det der bliver lagt i Dictionariet.

            //Arrange
            TagCatalog TestTagCatalog = TagCatalog.Instance;
            Tag TestTag = new Tag("TestTag");
            Tag TestTag1 = new Tag("TestTag1");

            //Act
            int CountPreAdd = TestTagCatalog.Tags.Count;
            TestTagCatalog.Tags.Add("TestTagKey",TestTag);
            TestTagCatalog.Tags.Add("TestTagKey1", TestTag1);
            int CountAfterAdd = TestTagCatalog.Tags.Count;
            int ExpectedCountDifference = 2;

            
            //Assert
            Assert.AreNotEqual(CountPreAdd, CountAfterAdd);
            Assert.AreEqual(ExpectedCountDifference, CountAfterAdd - CountPreAdd);
            Assert.AreSame(TestTag, TestTagCatalog.Tags["TestTagKey"]);
        }
    }
}
