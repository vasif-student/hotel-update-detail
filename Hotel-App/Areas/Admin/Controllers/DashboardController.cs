using Hotel_App.Areas.Admin.Constants;
using Hotel_App.Areas.Admin.Models.ViewModels;
using Hotel_App.Areas.Admin.Utilis;
using Hotel_App.Data;
using Hotel_App.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class DashboardController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private AppDbContext _dbContext;
        public DashboardController(UserManager<IdentityUser> userManager, AppDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            var hotels = await _dbContext.Hotels.Where(h => h.OwnerId == user.Id).ToListAsync();
            return View(new DashboardIndexViewModel { 
                User = user,
                Hotels = hotels
            });
        }

        //***** Detail *****//
        public async Task<IActionResult> Detail(int id)
        {
            var hotel = await _dbContext.Hotels.Include(h => h.Rooms).FirstOrDefaultAsync(h => h.Id == id);
            var rooms = await _dbContext.Rooms.Include(r => r.RoomImages).Where(r => r.Hotel.Id == hotel.Id).ToListAsync();
            return View(new HotelViewModel
            {
                Hotel = hotel,
                Rooms = rooms
            });
        }

        //***** Update *****//
        public async Task<IActionResult> Update(int id)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);
            return View(new HotelUpdateViewModel { 
                Name = hotel.Name,
                Description = hotel.Description,
                Image = hotel.Image
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, HotelUpdateViewModel model)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isExist = await _dbContext.Hotels.AnyAsync(h => h.Id == id);

            if (!isExist)
            {
                return NotFound();
            }

            FileUtil.DeleteFile(Path.Combine(FileConstants.ImagePath, hotel.Image));
            hotel.Name = model.Name;
            hotel.Description = model.Description;
            hotel.Image = FileUtil.CreatedFile(Path.Combine(FileConstants.ImagePath,"HOTEL"), model.File);

            _dbContext.Update(hotel);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
