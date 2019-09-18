using Edapp.Auction.Web.Services.Interfaces;
using Edapp.Auction.Web.Services.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Edapp.Auction.Web.Hubs
{
    public class BidHub : Hub
    {
        private readonly IBidService _bidService;
        private readonly IItemsService _itemsService;

        public BidHub(IBidService bidService, IItemsService itemsService)
        {
            _bidService = bidService ?? throw new ArgumentNullException(nameof(bidService));
            this._itemsService = itemsService ?? throw new ArgumentNullException(nameof(itemsService));
        }

        public async Task Setup(string consoleId)
        {
            if (consoleId == null)
            {
                return;
            }

            await Groups.AddToGroupAsync(this.Context.ConnectionId, consoleId);
        }

        [Authorize]
        public async Task CreateBidAsync(string bidAmount, string consoleId)
        {
            if (bidAmount == null || consoleId == null)
            {
                return;
            }

            var isParsed = decimal.TryParse(bidAmount, out var parsedBidAmount);

            if (!isParsed)
            {
                return;
            }

            var item = _itemsService.GetById(consoleId);

            if (item == null)
            {
                return;
            }

            if (item.Price >= parsedBidAmount)
            {
                return;
            }

            var userId = Context.UserIdentifier;
            var serviceModel = new BidCreateServiceModel
            {
                Amount = parsedBidAmount,
                MadeOn = DateTime.UtcNow,
                ItemId = item.Id,
                UserId = userId
            };

            var succeeded = _bidService.CreateBid(serviceModel);

            if (!succeeded)
            {
                return;
            }

            await Clients.Groups(consoleId).SendAsync("ReceivedMessage", parsedBidAmount, userId);
        }
    }
}