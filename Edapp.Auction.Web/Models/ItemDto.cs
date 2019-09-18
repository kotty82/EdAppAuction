namespace Edapp.Auction.Web.Models
{
    public class ItemDto
    {
        public string Id { get; set; }

        public string PicturePath { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public string Url => $"/home/details/{Id}";
    }
}