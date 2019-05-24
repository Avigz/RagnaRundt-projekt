
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
            Element TestElement = new Element("TestElementNavn", "TestDescription", "Http://google.dk",
                new Area("TestNameArea", "TestDescriptionArea", 1, 2, "path", 1));
            Element TestElement1 = new Element("TestElementNavn1", "TestDescription1", "Http://google.dk1",
                new Area("TestNameArea1", "TestDescriptionArea1", 1, 2, "Path", 1));
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
            Element UdstillingsElement = new Element("TestElementNavn", "TestDescription", "Http://google.dk",
            new Area("TestNameArea", "TestDescriptionArea", 1, 2, "path", 1));

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
        public void GetFromElementCatalogSingleton()
        {
            // I denne test vurdere vi om vu korrekt kan ekstrahere oplysninger fra vores ElementCatalogSingleton
            //Arrange

            Element TestElement = ElementCatalog.Instance.Elements[1];

            //Act
            string ExpectedName = TestElement.Name;
   
            string ActualName = ElementCatalog.Instance.Elements[1].Name;


            //Assert

            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreSame(ElementCatalog.Instance.Elements[1], TestElement);
        }


        [TestMethod]
        public void AreaPropertyTest()
        {
            //Arrange
            Area TestArea = new Area("TestName", "TestDescription", 1, 2, "Path", 1);

            //Act
            string ExpectedName = "TestName";
            string ExpectedDesc = "TestDescription";
            int ExpectedMapX = 1;
            int ExpectedMapY = 2;

            string ActualName = TestArea.Name;
            string ActualDesc = TestArea.Desciption;
            int ActualMapX = TestArea.MapLeft;
            int ActualMapY = TestArea.MapTop;
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
            Area TestArea = new Area("TestName", "TestDescription", 1, 2, "path", 1);


            //Act
            int CountPreAdd = AreaCatalog.Instance.Areas.Count;
            AreaCatalog.Instance.Areas.Add("Lydvæggen", TestArea);
            int CountAfterAdd = AreaCatalog.Instance.Areas.Count;

            //Assert
            Assert.AreNotEqual(CountPreAdd, CountAfterAdd);
            Assert.AreEqual(CountPreAdd, CountAfterAdd - 1);
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
            Assert.AreEqual(ExpectedIdDifference, ActualIdDifference);
        }

        [TestMethod]
        public void TagCatalogSingletonTest()
        {
            //I dette testscenarie vil vi vurdere vores tagcatalogSingleton fungerer optimalt, 
            //Altsaa at vi kan ekstrahere de hardcodede tags det indeholder
           

            //Arrange
            TagCatalog TestTagCatalog = TagCatalog.Instance;

            Tag TestTag = TestTagCatalog.Tags["Johnson"];

            //Act
      

            //Assert
          
            Assert.AreSame(TestTag, TestTagCatalog.Tags["Johnson"]);
        }

        [TestMethod]
        public void TourTest()
        {
            //I dette testscenarie vil vi vurdere hvor vidt vores tour klasse kan indeholde Element objekter,
            //Samt om vi kan ekstrahere properties fra en tour, samt underelementet/ underelementerne.

            //Arrange
            Tour TourTestTour = new Tour("TheTestTour", "Den bedste tour");
            Element Test = new Element("TestElementNavn", "TestDescription", "Http://google.dk", new Area("TestNameArea", "TestDescriptionArea", 1, 2, "Path", 1));
            
            //Act
            int CountPreAdd = TourTestTour.Elements.Count;
            TourTestTour.AddElement(Test);
            int CountAfterAdd = TourTestTour.Elements.Count;
            int ExpectedCount = 1;
            
            string ExpectedName = "TheTestTour";
            string ActualName = TourTestTour.Name;

            string ExpectedElementName = "TestElementNavn";
            string ActualElementName = Test.Name;

            //Assert
            Assert.AreEqual(ExpectedCount, TourTestTour.Elements.Count);
            Assert.AreSame(Test, TourTestTour.Elements[0]);
            Assert.AreEqual(ExpectedName, ActualName);
            Assert.AreEqual(ExpectedElementName, ActualElementName);
        }

        [TestMethod]
        public void TourTestAutoIncrement()
        {
            //I dette testscenarie vil vi vurdere hvor vidt vores tour klasses autoincrement funktion fungerer.

            //Arrange
            Tour TourTestTour = new Tour("TheTestTour", "Den bedste tour");
            Tour TourTestTour1 = new Tour("TheTestTour1", "Den bedste tour1");
            //Act


            int ExpectedId = TourTestTour.Id + 1;
            int ActualId = TourTestTour1.Id;

            //Assert

            Assert.AreEqual(ExpectedId, ActualId);

        }

        [TestMethod]
        public void TourCatalogSingletonTest()
        {
            //i nedenstaaende testscenarie vil vi undersoege hvor vidt vores TourCatalog klasse fungerer optimalt.
            //Dette goeres ved at teste om vu kan tilgaa de enkelte hardcodede tours igennem Dictionaryet.

            //Arrange
            Tour testTour = TourCatalog.Instance.Tours[1];
            //Act
       
            

            //Assert

            Assert.AreSame(TourCatalog.Instance.Tours[1], testTour);
        
        }

        [TestMethod]
        public void SearchlistTest()
        {
           

            //Arrange
           
            //Act



            //Assert

          

        }
    }

}
