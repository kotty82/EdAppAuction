using System;

namespace Edapp.Auction.Web.Data
{
    public class Item
    {
        public string Description { get; set; }

        public DateTime EndTime { get; set; }

        public string Id { get; set; }

        public string PicturePath { get; set; }

        public decimal Price { get; set; }

        public DateTime StartTime { get; set; }

        public string Title { get; set; }

        public string UserId { get; set; }
    }
}