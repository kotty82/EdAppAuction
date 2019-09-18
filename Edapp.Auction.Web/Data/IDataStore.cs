using System.Collections.Generic;

namespace Edapp.Auction.Web.Data
{
    public interface IDataStore
    {
        IList<Item> Items { get; set; }
    }
}