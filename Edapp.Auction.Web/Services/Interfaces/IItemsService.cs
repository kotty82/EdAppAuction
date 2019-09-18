using Edapp.Auction.Web.Services.Models;
using System.Collections.Generic;

namespace Edapp.Auction.Web.Services.Interfaces
{
    public interface IItemsService
    {
        IEnumerable<ItemServiceModel> GetAllItems();

        ItemServiceModel GetById(string id);
    }
}