using Edapp.Auction.Web.Data;
using Edapp.Auction.Web.Services.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Randomizer;
using Randomizer.Types;
using System;
using System.Collections.Generic;

namespace Edapp.Auction.Tests.Services
{
    [TestClass]
    public class ItemsServiceTests_GetById_Should
    {
        private RandomDecimalGenerator _randomDecimal;
        private RandomIntegerGenerator _randomInteger;
        private RandomStringGenerator _randomString;

        [TestInitialize]
        public void Setup()
        {
            _randomDecimal = new RandomDecimalGenerator();
            _randomInteger = new RandomIntegerGenerator();
            _randomString = new RandomStringGenerator();
        }

        [TestMethod]
        public void ItemNotFound_NullReturned()
        {
            // Arrange
            var dataStoreMock = new Mock<IDataStore>(MockBehavior.Strict);
            dataStoreMock.SetupProperty(p => p.Items, new List<Item>());

            var itemsService = new ItemsService(dataStoreMock.Object);

            var unknownId = _randomInteger.GeneratePositiveValue().ToString();

            // Act
            var result = itemsService.GetById(unknownId);

            // Assert
            Assert.IsNull(result, "result == null");
        }

        [TestMethod]
        public void ItemAvailable_ItemReturned()
        {
            // Arrange
            var description1 = _randomString.GenerateValue(50);
            var description2 = _randomString.GenerateValue(50);
            var endTime1 = DateTime.Now.AddHours(3);
            var endTime2 = DateTime.Now.AddHours(4);
            var id1 = _randomInteger.GeneratePositiveValue();
            var id2 = _randomInteger.GeneratePositiveValue();
            const string picturePath1 = "ABC";
            const string picturePath2 = "XYZ";
            var price1 = _randomDecimal.GeneratePositiveValue();
            var price2 = _randomDecimal.GeneratePositiveValue();
            var startTime1 = DateTime.Now.AddHours(-13);
            var startTime2 = DateTime.Now.AddHours(-20);
            var title1 = _randomString.GenerateValue(10);
            var title2 = _randomString.GenerateValue(10);
            var userId1 = _randomString.GenerateValue(8);
            var userId2 = _randomString.GenerateValue(8);

            var dataStoreMock = new Mock<IDataStore>(MockBehavior.Strict);
            dataStoreMock.SetupProperty(p => p.Items, new List<Item>
            {
                new Item
                {
                    Description = description1,
                    EndTime = endTime1,
                    Id = id1.ToString(),
                    PicturePath = picturePath1,
                    Price = price1,
                    StartTime = startTime1,
                    Title = title1,
                    UserId = userId1
                },
                new Item
                {
                    Description = description2,
                    EndTime = endTime2,
                    Id = id2.ToString(),
                    PicturePath = picturePath2,
                    Price = price2,
                    StartTime = startTime2,
                    Title = title2,
                    UserId = userId2
                }
            });

            var itemsService = new ItemsService(dataStoreMock.Object);

            // Act
            var result = itemsService.GetById(id2.ToString());

            // Assert
            Assert.IsNotNull(result, "result != null");
            Assert.AreEqual(description2, result.Description, "Incorrect Description returned");
            Assert.AreEqual(endTime2, result.EndTime, "Incorrect EndTime returned");
            Assert.AreEqual(id2.ToString(), result.Id, "Incorrect Id returned");
            Assert.AreEqual(price2, result.Price, "Incorrect Price returned");
            Assert.AreEqual(picturePath2, result.PicturePath, "Incorrect PicturePath returned");
            Assert.AreEqual(startTime2, result.StartTime, "Incorrect StartTime returned");
            Assert.AreEqual(title2, result.Title, "Incorrect Title returned");
        }
    }
}