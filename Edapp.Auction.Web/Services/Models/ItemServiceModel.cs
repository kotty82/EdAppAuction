using System;

namespace Edapp.Auction.Web.Services.Models
{
    public class ItemServiceModel
    {
        public string Description { get; set; }

        public DateTime EndTime { get; set; }

        public string Id { get; set; }
        
        public decimal Price { get; set; }

        public string PicturePath { get; set; }

        public DateTime StartTime { get; set; }

        public string Title { get; set; }
    }
}