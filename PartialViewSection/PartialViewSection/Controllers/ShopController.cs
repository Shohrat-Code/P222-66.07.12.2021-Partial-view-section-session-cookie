using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartialViewSection.Data;
using PartialViewSection.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewSection.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmShop model = new VmShop()
            {
                Socials = _context.Socials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "shop"),
                Products = _context.Products.ToList()
            };
            return View(model);
        }

        public IActionResult AddToCard(int id)
        {

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };

            string card = Request.Cookies["card"];
            string newCard = "";
            if (string.IsNullOrEmpty(card))
            {
                newCard = id.ToString();
            }
            else
            {
                List<string> cardIds = card.Split("-").ToList();
                bool isExist = cardIds.Any(c => c == id.ToString());
                if (!isExist)
                {
                    newCard = card + "-" + id;
                }
                else
                {
                    newCard = card;
                }
            }

            Response.Cookies.Append("card", newCard, options);


            return RedirectToAction("Index");
        }
    }
}
