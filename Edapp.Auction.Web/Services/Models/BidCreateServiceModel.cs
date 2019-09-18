using System;

namespace Edapp.Auction.Web.Services.Models
{
    public class BidCreateServiceModel
    {
        public decimal Amount { get; set; }

        public string UserId { get; set; }

        public string ItemId { get; set; }

        public DateTime MadeOn { get; set; }
    }
}