using Edapp.Auction.Web.Data;
using Edapp.Auction.Web.Services.Interfaces;
using Edapp.Auction.Web.Services.Models;
using System;
using System.Linq;

namespace Edapp.Auction.Web.Services.Implementations
{
    public class BidService : IBidService
    {
        private readonly IDataStore _dataStore;

        public BidService(IDataStore dataStore)
        {
            _dataStore = dataStore ?? throw new ArgumentNullException(nameof(_dataStore));
        }

        public bool CreateBid(BidCreateServiceModel model)
        {
            var item = _dataStore.Items.FirstOrDefault(i => i.Id == model.ItemId);

            if (item == null)
            {
                return false;
            }

            item.Price = model.Amount;
            item.UserId = model.UserId;

            return true;
        }
    }
}