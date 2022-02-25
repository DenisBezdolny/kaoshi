using Laba1.Extensions;
using Laba1.Models;
using Laba1Dall.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba1.Controllers
{
    public class CartController : Controller
    {

        private Cart _cart;
        private ApplicationDbContext _context;
        private string cartKey = "cart";
        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;

        }
        public IActionResult Index()
        {
            //_cart = HttpContext.Session.Get<Cart>(cartKey);
            return View(_cart.Items.Values);
        }
        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            var item = _context.Dishes.Find(id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }
            return Redirect(returnUrl);
        }
        public IActionResult Delete(int id)
        {
            _cart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }


}

