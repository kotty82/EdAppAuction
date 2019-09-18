using Edapp.Auction.Web.Data;
using Edapp.Auction.Web.Services.Interfaces;
using Edapp.Auction.Web.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Edapp.Auction.Web.Services.Implementations
{
    public class ItemsService : IItemsService
    {
        private readonly IDataStore _dataStore;

        public ItemsService(IDataStore dataStore)
        {
            _dataStore = dataStore ?? throw new ArgumentNullException(nameof(_dataStore));
        }

        public IEnumerable<ItemServiceModel> GetAllItems()
        {
            return _dataStore.Items.Select(i => new ItemServiceModel
            {
                Id = i.Id,
                PicturePath = i.PicturePath,
                Price = i.Price,
                Title = i.Title
            }).ToList();
        }

        public ItemServiceModel GetById(string id)
        {
            return _dataStore.Items
                .Where(i => i.Id == id)
                .Select(i => new ItemServiceModel
                {
                    Description = i.Description,
                    EndTime = i.EndTime,
                    Id = i.Id,
                    Price = i.Price,
                    PicturePath = i.PicturePath,
                    StartTime = i.StartTime,
                    Title = i.Title
                })
                .FirstOrDefault();
        }
    }
}