using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HodelManagement.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HodelManagement.Controllers
{
    public class BookingManagerController : Controller
    {
        private readonly HotelContext _context;

        public BookingManagerController(HotelContext context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rooms.ToListAsync());
        }
    }
}