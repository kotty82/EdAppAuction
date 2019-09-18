using Edapp.Auction.Web.Services.Models;

namespace Edapp.Auction.Web.Services.Interfaces
{
    public interface IBidService
    {
        bool CreateBid(BidCreateServiceModel model);
    }
}