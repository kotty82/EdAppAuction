using Edapp.Auction.Web.Models;
using Edapp.Auction.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace Edapp.Auction.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemsService _itemsService;

        public HomeController(IItemsService itemsService)
        {
            _itemsService = itemsService ?? throw new ArgumentNullException(nameof(_itemsService));
        }

        public IActionResult Index()
        {
            var serviceModel = _itemsService.GetAllItems();

            var viewModel = new ItemListViewModel
            {
                Items = serviceModel.Select(i => new ItemDto
                {
                    Id = i.Id,
                    PicturePath = i.PicturePath,
                    Price = i.Price,
                    Title = i.Title
                }).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Details(string id)
        {
            var serviceModel = _itemsService.GetById(id);

            var viewModel = new ItemDetailsViewModel
            {
                Description = serviceModel.Description,
                EndTime = serviceModel.EndTime,
                Id = serviceModel.Id,
                Price = serviceModel.Price,
                StartTime = serviceModel.StartTime,
                PicturePath = string.Concat("../../", serviceModel.PicturePath),
                ReturnUrl = HttpContext.Request.Path.ToString(),
                Title = serviceModel.Title
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}