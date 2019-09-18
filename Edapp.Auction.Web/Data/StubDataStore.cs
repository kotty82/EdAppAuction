using System;
using System.Collections.Generic;

namespace Edapp.Auction.Web.Data
{
    public class StubDataStore : IDataStore
    {
        public StubDataStore()
        {
            Items = new List<Item>
            {
                new Item
                {
                    Id = "1",
                    Title = "Road Bike",
                    Description = "A colourful road bike",
                    EndTime = DateTime.UtcNow.AddHours(1),
                    PicturePath = "\\images\\bike-1.jpg",
                    Price = 29.99M,
                    StartTime = DateTime.UtcNow.AddHours(-4)
                },
                new Item
                {
                    Id = "2",
                    Title = "Motor Bike",
                    Description = "A cool motor bike",
                    EndTime = DateTime.UtcNow.AddHours(24),
                    PicturePath = "\\images\\bike-2.jpg",
                    Price = 0.00M,
                    StartTime = DateTime.UtcNow.AddHours(-2)
                },
                new Item
                {
                    Id = "3",
                    Title = "Car",
                    Description = "A vintage car",
                    EndTime = DateTime.UtcNow.AddHours(-3),
                    PicturePath = "\\images\\car.jpg",
                    Price = 3000.00M,
                    StartTime = DateTime.UtcNow.AddHours(-16)
                },new Item
                {
                    Id = "4",
                    Title = "Computer",
                    Description = "A laptop computer",
                    EndTime = DateTime.UtcNow.AddHours(16),
                    PicturePath = "\\images\\computer.jpg",
                    Price = 100.00M,
                    StartTime = DateTime.UtcNow.AddHours(-1)
                },
                new Item
                {
                    Id = "5",
                    Title = "Golf Clubs",
                    Description = "An old set of golf clubs",
                    EndTime = DateTime.UtcNow.AddHours(-1),
                    PicturePath = "\\images\\golf-clubs.jpg",
                    Price = 0.00M,
                    StartTime = DateTime.UtcNow.AddHours(-8)
                }
            };
        }

        public IList<Item> Items { get; set; }
    }
}